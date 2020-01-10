namespace Forms_MyAccessPort
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.快速连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外观ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字符编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fileCheck = new System.Windows.Forms.CheckBox();
            this.stringCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textString = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusCOM = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusBaud = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusRx = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusTx = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnClosed = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.checkChangeLine = new System.Windows.Forms.CheckBox();
            this.buttonLogFile = new System.Windows.Forms.Button();
            this.checkClearRcv = new System.Windows.Forms.CheckBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip,
            this.选项ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(470, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStrip
            // 
            this.toolStrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.快速连接ToolStripMenuItem});
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(44, 21);
            this.toolStrip.Text = "连接";
            // 
            // 快速连接ToolStripMenuItem
            // 
            this.快速连接ToolStripMenuItem.Name = "快速连接ToolStripMenuItem";
            this.快速连接ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.快速连接ToolStripMenuItem.Text = "快速连接";
            this.快速连接ToolStripMenuItem.Click += new System.EventHandler(this.快速连接ToolStripMenuItem_Click);
            // 
            // 选项ToolStripMenuItem
            // 
            this.选项ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.外观ToolStripMenuItem,
            this.字符编码ToolStripMenuItem});
            this.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem";
            this.选项ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.选项ToolStripMenuItem.Text = "选项";
            // 
            // 外观ToolStripMenuItem
            // 
            this.外观ToolStripMenuItem.Name = "外观ToolStripMenuItem";
            this.外观ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.外观ToolStripMenuItem.Text = "外观";
            // 
            // 字符编码ToolStripMenuItem
            // 
            this.字符编码ToolStripMenuItem.Name = "字符编码ToolStripMenuItem";
            this.字符编码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.字符编码ToolStripMenuItem.Text = "字符编码";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(448, 212);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // fileCheck
            // 
            this.fileCheck.AutoSize = true;
            this.fileCheck.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.fileCheck.Location = new System.Drawing.Point(390, 247);
            this.fileCheck.Name = "fileCheck";
            this.fileCheck.Size = new System.Drawing.Size(78, 17);
            this.fileCheck.TabIndex = 7;
            this.fileCheck.Text = "HEX Show";
            this.fileCheck.UseVisualStyleBackColor = true;
            this.fileCheck.CheckedChanged += new System.EventHandler(this.fileCheck_CheckedChanged);
            // 
            // stringCheck
            // 
            this.stringCheck.AutoSize = true;
            this.stringCheck.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.stringCheck.Location = new System.Drawing.Point(308, 247);
            this.stringCheck.Name = "stringCheck";
            this.stringCheck.Size = new System.Drawing.Size(76, 17);
            this.stringCheck.TabIndex = 8;
            this.stringCheck.Text = "HEX Send";
            this.stringCheck.UseVisualStyleBackColor = true;
            this.stringCheck.CheckedChanged += new System.EventHandler(this.stringCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(9, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "string:";
            // 
            // textString
            // 
            this.textString.Location = new System.Drawing.Point(50, 268);
            this.textString.Name = "textString";
            this.textString.Size = new System.Drawing.Size(230, 21);
            this.textString.TabIndex = 10;
            this.textString.TextChanged += new System.EventHandler(this.textString_TextChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(285, 267);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(74, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "SendString";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusCOM,
            this.StatusBaud,
            this.StatusRx,
            this.StatusTx});
            this.statusStrip1.Location = new System.Drawing.Point(0, 295);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusCOM
            // 
            this.StatusCOM.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.StatusCOM.Name = "StatusCOM";
            this.StatusCOM.Size = new System.Drawing.Size(60, 17);
            this.StatusCOM.Text = "STATUS: ";
            // 
            // StatusBaud
            // 
            this.StatusBaud.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.StatusBaud.Name = "StatusBaud";
            this.StatusBaud.Size = new System.Drawing.Size(67, 17);
            this.StatusBaud.Text = "BaudRate:";
            // 
            // StatusRx
            // 
            this.StatusRx.Margin = new System.Windows.Forms.Padding(0, 3, 10, 2);
            this.StatusRx.Name = "StatusRx";
            this.StatusRx.Size = new System.Drawing.Size(27, 17);
            this.StatusRx.Text = "RX:";
            // 
            // StatusTx
            // 
            this.StatusTx.Margin = new System.Windows.Forms.Padding(0, 3, 20, 2);
            this.StatusTx.Name = "StatusTx";
            this.StatusTx.Size = new System.Drawing.Size(26, 17);
            this.StatusTx.Text = "TX:";
            // 
            // btnClosed
            // 
            this.btnClosed.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClosed.Location = new System.Drawing.Point(376, 2);
            this.btnClosed.Name = "btnClosed";
            this.btnClosed.Size = new System.Drawing.Size(75, 23);
            this.btnClosed.TabIndex = 13;
            this.btnClosed.Text = "Closed";
            this.btnClosed.UseVisualStyleBackColor = true;
            this.btnClosed.Click += new System.EventHandler(this.btnClosed_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(284, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // checkChangeLine
            // 
            this.checkChangeLine.AutoSize = true;
            this.checkChangeLine.Location = new System.Drawing.Point(376, 271);
            this.checkChangeLine.Name = "checkChangeLine";
            this.checkChangeLine.Size = new System.Drawing.Size(48, 16);
            this.checkChangeLine.TabIndex = 15;
            this.checkChangeLine.Text = "\\r\\n";
            this.checkChangeLine.UseVisualStyleBackColor = true;
            // 
            // buttonLogFile
            // 
            this.buttonLogFile.Font = new System.Drawing.Font("等线", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonLogFile.Location = new System.Drawing.Point(37, 243);
            this.buttonLogFile.Name = "buttonLogFile";
            this.buttonLogFile.Size = new System.Drawing.Size(146, 23);
            this.buttonLogFile.TabIndex = 16;
            this.buttonLogFile.Text = "ViewLogFile";
            this.buttonLogFile.UseVisualStyleBackColor = true;
            this.buttonLogFile.Click += new System.EventHandler(this.buttonLogFile_Click);
            // 
            // checkClearRcv
            // 
            this.checkClearRcv.AutoSize = true;
            this.checkClearRcv.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkClearRcv.Location = new System.Drawing.Point(226, 246);
            this.checkClearRcv.Name = "checkClearRcv";
            this.checkClearRcv.Size = new System.Drawing.Size(71, 18);
            this.checkClearRcv.TabIndex = 17;
            this.checkClearRcv.Text = "ClearRcv";
            this.checkClearRcv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 317);
            this.Controls.Add(this.checkClearRcv);
            this.Controls.Add(this.buttonLogFile);
            this.Controls.Add(this.checkChangeLine);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnClosed);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textString);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stringCheck);
            this.Controls.Add(this.fileCheck);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "MyAccessPort";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStrip;
        private System.Windows.Forms.ToolStripMenuItem 选项ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外观ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字符编码ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快速连接ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox fileCheck;
        private System.Windows.Forms.CheckBox stringCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textString;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusCOM;
        private System.Windows.Forms.ToolStripStatusLabel StatusBaud;
        private System.Windows.Forms.ToolStripStatusLabel StatusRx;
        private System.Windows.Forms.ToolStripStatusLabel StatusTx;
        private System.Windows.Forms.Button btnClosed;
        private System.Windows.Forms.Button btnStart;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox checkChangeLine;
        private System.Windows.Forms.Button buttonLogFile;
        private System.Windows.Forms.CheckBox checkClearRcv;
    }
}

