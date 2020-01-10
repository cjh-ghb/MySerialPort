using Microsoft.Win32;
using System;
using static System.Convert;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Forms_MyAccessPort
{
    public partial class accessPort : Form
    {
        public static bool serialConnect { get; set; }
        public static string NewPort = "";
        public static Int32 NewBaudRate = 0;
        bool isOpened = false;
        public accessPort()
        {
            InitializeComponent();
        }

        //窗体加载，扫描识别存在的串口
        private void serialPort_Load(object sender, EventArgs e)
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey("Hardware\\DeviceMap\\SerialComm");
            if (keyCom != null)
            {
                string[] sSubKeys = keyCom.GetValueNames();
                //把COM口的名字显示在Items里去
                comboPort.Items.Clear();
                foreach(string name in sSubKeys)
                {
                    string value = (string)keyCom.GetValue(name);
                    comboPort.Items.Add(value);
                }
                if(comboPort.Items.Count > 0)
                {
                    comboPort.SelectedIndex = 0;
                }
            }
            comboBaud.Text = "115200";
            comboData.Text = "8";
            comboStop.Text = "1";
            comboParity.Text = "None";
            comboFlow.Text = "None";
            comboProtocal.SelectedIndex = 0;
        }

        private void buttonNot_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(!isOpened)
            {
                serialPort1.PortName = comboPort.Text;
                NewPort = comboPort.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBaud.Text);
                NewBaudRate = Convert.ToInt32(comboBaud.Text);
               
                    /*serialPort1.Open();
                    comboPort.Enabled = false;
                    comboFlow.Enabled = false;
                    comboBaud.Enabled = false;
                    comboData.Enabled = false;
                    comboParity.Enabled = false;
                    comboProtocal.Enabled = false;
                    comboStop.Enabled = false;
                    isOpened = true;*/
                    //串口接收处理函数，转到主窗口运行
                    /*serialPort1.DataReceived += new
                        SerialDataReceivedEventHandler(DataReceived);*/
                    serialConnect = true;
                
            }

        }
    }
}
