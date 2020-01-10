namespace Forms_MyAccessPort
{
    partial class accessPort
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboPort = new System.Windows.Forms.ComboBox();
            this.comboParity = new System.Windows.Forms.ComboBox();
            this.comboFlow = new System.Windows.Forms.ComboBox();
            this.comboStop = new System.Windows.Forms.ComboBox();
            this.comboData = new System.Windows.Forms.ComboBox();
            this.comboBaud = new System.Windows.Forms.ComboBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.comboProtocal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonNot = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "波特率";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "数据位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(26, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "校验位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(26, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "流控制";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(26, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "串口号";
            // 
            // comboPort
            // 
            this.comboPort.FormattingEnabled = true;
            this.comboPort.Location = new System.Drawing.Point(76, 21);
            this.comboPort.Name = "comboPort";
            this.comboPort.Size = new System.Drawing.Size(98, 20);
            this.comboPort.TabIndex = 6;
            // 
            // comboParity
            // 
            this.comboParity.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboParity.FormattingEnabled = true;
            this.comboParity.Location = new System.Drawing.Point(76, 105);
            this.comboParity.Name = "comboParity";
            this.comboParity.Size = new System.Drawing.Size(98, 22);
            this.comboParity.TabIndex = 7;
            // 
            // comboFlow
            // 
            this.comboFlow.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFlow.FormattingEnabled = true;
            this.comboFlow.Location = new System.Drawing.Point(76, 126);
            this.comboFlow.Name = "comboFlow";
            this.comboFlow.Size = new System.Drawing.Size(98, 22);
            this.comboFlow.TabIndex = 8;
            // 
            // comboStop
            // 
            this.comboStop.FormattingEnabled = true;
            this.comboStop.Location = new System.Drawing.Point(76, 84);
            this.comboStop.Name = "comboStop";
            this.comboStop.Size = new System.Drawing.Size(98, 20);
            this.comboStop.TabIndex = 9;
            // 
            // comboData
            // 
            this.comboData.FormattingEnabled = true;
            this.comboData.Location = new System.Drawing.Point(76, 63);
            this.comboData.Name = "comboData";
            this.comboData.Size = new System.Drawing.Size(98, 20);
            this.comboData.TabIndex = 10;
            // 
            // comboBaud
            // 
            this.comboBaud.FormattingEnabled = true;
            this.comboBaud.Location = new System.Drawing.Point(76, 42);
            this.comboBaud.Name = "comboBaud";
            this.comboBaud.Size = new System.Drawing.Size(98, 20);
            this.comboBaud.TabIndex = 11;
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonOk.Location = new System.Drawing.Point(26, 187);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(76, 23);
            this.buttonOk.TabIndex = 12;
            this.buttonOk.Text = "确认连接";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // comboProtocal
            // 
            this.comboProtocal.AutoCompleteCustomSource.AddRange(new string[] {
            "Serial"});
            this.comboProtocal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProtocal.FormattingEnabled = true;
            this.comboProtocal.Items.AddRange(new object[] {
            "Serial",
            "Telnet",
            "SSH",
            "Ymodem"});
            this.comboProtocal.Location = new System.Drawing.Point(76, 147);
            this.comboProtocal.Name = "comboProtocal";
            this.comboProtocal.Size = new System.Drawing.Size(98, 22);
            this.comboProtocal.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(34, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "协议";
            // 
            // buttonNot
            // 
            this.buttonNot.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonNot.Location = new System.Drawing.Point(109, 187);
            this.buttonNot.Name = "buttonNot";
            this.buttonNot.Size = new System.Drawing.Size(76, 23);
            this.buttonNot.TabIndex = 15;
            this.buttonNot.Text = "取消连接";
            this.buttonNot.UseVisualStyleBackColor = true;
            this.buttonNot.Click += new System.EventHandler(this.buttonNot_Click);
            // 
            // accessPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 241);
            this.Controls.Add(this.buttonNot);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboProtocal);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.comboBaud);
            this.Controls.Add(this.comboData);
            this.Controls.Add(this.comboStop);
            this.Controls.Add(this.comboFlow);
            this.Controls.Add(this.comboParity);
            this.Controls.Add(this.comboPort);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "accessPort";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "serialPort";
            this.Load += new System.EventHandler(this.serialPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboPort;
        private System.Windows.Forms.ComboBox comboParity;
        private System.Windows.Forms.ComboBox comboFlow;
        private System.Windows.Forms.ComboBox comboStop;
        private System.Windows.Forms.ComboBox comboData;
        private System.Windows.Forms.ComboBox comboBaud;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.ComboBox comboProtocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonNot;
        private System.IO.Ports.SerialPort serialPort1;
    }
}