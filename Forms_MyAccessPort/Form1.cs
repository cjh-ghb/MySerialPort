using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Forms_MyAccessPort
{
    public partial class Form1 : Form
    {
        private string MainPort = "";
        private int MainBaudRate = 0;
        private bool MainserialConnect = false;
        private int LogNum = 0;
        private int rxNum = 0;
        private int txNum = 0;
        private string HexOutput = "";
        private string filePath = Environment.CurrentDirectory + "\\Log.txt";
        public Form1()
        {
            InitializeComponent();
            //多线程调用时，线程能安全的访问窗体控件
            Control.CheckForIllegalCrossThreadCalls = false;
            //Control.Invoke;
        }

        private void 快速连接ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accessPort accessPort = new accessPort();
            if(accessPort.ShowDialog() == DialogResult.OK)
            {
                MainPort = accessPort.NewPort;
                MainBaudRate = accessPort.NewBaudRate;
                MainserialConnect = accessPort.serialConnect;
                MessageBox.Show(MainPort + " + " + MainBaudRate
                    + " + " + MainserialConnect);
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //端口和波特率从自定义窗口传回来
                serialPort1.PortName = MainPort;
                serialPort1.BaudRate = MainBaudRate;
            }
            catch (Exception)
            {
                MessageBox.Show("请选择串口重新连接");
            }
            
            //这里得到自定义串口窗体的属性数据 serialPort.MyProperty
            try
            {
                serialPort1.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("串口连接成功！");
            try     //数据接收
            {
                serialPort1.DataReceived += new
                    SerialDataReceivedEventHandler(DataReceived);
            }
            catch
            {
                MessageBox.Show("数据接收失败！");
            }
            StatusCOM.Text = "STATUS: " + serialPort1.PortName;
            StatusBaud.Text = "BaudRate: " + serialPort1.BaudRate;
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
            }
            catch
            {
                MessageBox.Show("串口关闭失败！");
            }
            richTextBox1.Clear();
        }

        //数据接收并实时存入log文件中
        private void DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string str = serialPort1.ReadExisting();
            if (!File.Exists(filePath))
            {
                FileStream fileStream = new FileStream(filePath,
                    FileMode.Create, FileAccess.Write); //向新建文件中写入

                SendToLog(fileStream, str);
            }
            else
            {
                FileStream fileStream = new FileStream(filePath,
                    FileMode.Open, FileAccess.Write);   //已经有文件，进行写入
                SendToLog(fileStream, str);
            }
            if (checkClearRcv.CheckState == CheckState.Checked)
            {
                richTextBox1.Text = "";
                rxNum = 0;
                txNum = 0;
            }
            richTextBox1.Text += str;
            //统计接收数据大小
            rxNum += richTextBox1.Text.Count();
            StatusRx.Text = "RX: " + rxNum;
        }
        public void SendToLog(FileStream fileStream, string str)
        {
            fileStream.Seek(0, SeekOrigin.End);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine("Information " + LogNum + "  "
                + DateTime.Now.ToString() + ":");
            LogNum++;
            streamWriter.Write(str);
            streamWriter.WriteLine();
            streamWriter.Close();
            fileStream.Close();
        }

        //string send
        private void button4_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                if (textString.Text.Trim() != "")
                {
                    //如果check选上"\r\n"，每条命令带回车
                    if (checkChangeLine.CheckState == CheckState.Checked)
                    {
                        textString.Text += "\r\n";
                    }
                    serialPort1.Write(textString.Text);
                    txNum += textString.Text.Count();
                    StatusTx.Text = "TX: " + txNum;
                }
                else
                {
                    MessageBox.Show("没有发送消息");
                }
            }
            else
            {
                MessageBox.Show("串口没有打开");
            }
        }

        private void buttonLogFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("没有通信信息!");
            }
            else
            {
                System.Diagnostics.Process.Start(filePath);
            }
        }

        private void textString_TextChanged(object sender, EventArgs e)
        {
            
        }

        //把输入字符串转HEX
        private void stringCheck_CheckedChanged(object sender, EventArgs e)
        {
            if ((stringCheck.CheckState == CheckState.Checked)
                && (textString.Text.Trim() != "")
                && (textString.Text.Substring(0,2) != "0x"))
            {
                char[] texts = textString.Text.ToCharArray();
                foreach (char letter in texts)
                {
                    int text = Convert.ToInt32(letter);
                    HexOutput += string.Format("{0:X} ", text);
                }
                textString.Text = HexOutput;
                HexOutput = "";
            }
        }

        //把得到的信息从HEX转字符串
        private void fileCheck_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;  //代表它是第几行
            int index = richTextBox1.Text.IndexOf("\r\n");
            var hexSplit = richTextBox1.Text.Split(' ');
            string endStr = "";
            if (fileCheck.CheckState == CheckState.Checked
                && richTextBox1.Text.Trim() != "")
            {
                //再判断文本内容是否为HEX，和对哪部分文本内容转换
                while (i < hexSplit.Length) //小于数组大小
                {
                    if (hexSplit[i].Length == 2)    //两个字节就是分割出来的hex
                    {
                        int value = Convert.ToInt32(hexSplit[i], 16);
                        string stringValue = Char.ConvertFromUtf32(value);
                        char charValue = (char)value;
                        endStr += charValue;
                    }
                    else
                    {
                        endStr += hexSplit[i] + " ";
                    }
                    i++;
                }
                richTextBox1.Text = endStr;
            }
        }

        //判断字符串是十六进制返回TRUE
        public bool IsHexadecimal(string str)
        {
            const string PATTERN = @"[A-Fa-f0-9]+$";
            return Regex.IsMatch(str, PATTERN);
        }
    }
}
