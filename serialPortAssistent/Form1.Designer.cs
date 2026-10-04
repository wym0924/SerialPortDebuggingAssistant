namespace serialPortAssistent
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            cbRts = new CheckBox();
            btnOpenAndClosePort = new Button();
            cbDtr = new CheckBox();
            stop = new ComboBox();
            label5 = new Label();
            check = new ComboBox();
            label4 = new Label();
            data = new ComboBox();
            label3 = new Label();
            bps = new ComboBox();
            label2 = new Label();
            serialPortNumber = new ComboBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtReceiveData = new TextBox();
            groupBox3 = new GroupBox();
            sendData = new TextBox();
            groupBox4 = new GroupBox();
            btnZt = new Button();
            btnSaveReceive = new Button();
            btnSelectPath = new Button();
            btnClearReceive = new Button();
            cbAutoClearReceive = new CheckBox();
            cb16HexReceive = new CheckBox();
            txtReceiveFilePath = new TextBox();
            groupBox5 = new GroupBox();
            textBox1 = new TextBox();
            label9 = new Label();
            label6 = new Label();
            btnClearSend = new Button();
            btnSendFile = new Button();
            btnOpenFile = new Button();
            btnSend = new Button();
            cbAutoSend = new CheckBox();
            cb16HexSend = new CheckBox();
            txtSendFilePath = new TextBox();
            txtAutoSendZq = new TextBox();
            label7 = new Label();
            state = new Label();
            label10 = new Label();
            txtSendCount = new TextBox();
            txtReceiveCount = new TextBox();
            label11 = new Label();
            btnClearCount = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbRts);
            groupBox1.Controls.Add(btnOpenAndClosePort);
            groupBox1.Controls.Add(cbDtr);
            groupBox1.Controls.Add(stop);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(check);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(data);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(bps);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(serialPortNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(248, 236);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "串口设置";
            // 
            // cbRts
            // 
            cbRts.AutoSize = true;
            cbRts.Location = new Point(17, 180);
            cbRts.Name = "cbRts";
            cbRts.Size = new Size(49, 21);
            cbRts.TabIndex = 5;
            cbRts.Text = "RTS";
            cbRts.UseVisualStyleBackColor = true;
            cbRts.CheckedChanged += cbRts_CheckedChanged;
            // 
            // btnOpenAndClosePort
            // 
            btnOpenAndClosePort.Location = new Point(109, 186);
            btnOpenAndClosePort.Name = "btnOpenAndClosePort";
            btnOpenAndClosePort.Size = new Size(104, 37);
            btnOpenAndClosePort.TabIndex = 1;
            btnOpenAndClosePort.Text = "打开串口";
            btnOpenAndClosePort.UseVisualStyleBackColor = true;
            btnOpenAndClosePort.Click += button1_Click;
            // 
            // cbDtr
            // 
            cbDtr.AutoSize = true;
            cbDtr.Location = new Point(17, 207);
            cbDtr.Name = "cbDtr";
            cbDtr.Size = new Size(51, 21);
            cbDtr.TabIndex = 1;
            cbDtr.Text = "DTR";
            cbDtr.UseVisualStyleBackColor = true;
            cbDtr.CheckedChanged += cbDtr_CheckedChanged;
            // 
            // stop
            // 
            stop.FormattingEnabled = true;
            stop.Items.AddRange(new object[] { "1", "1.5", "2" });
            stop.Location = new Point(93, 149);
            stop.Name = "stop";
            stop.Size = new Size(121, 25);
            stop.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 152);
            label5.Name = "label5";
            label5.Size = new Size(44, 17);
            label5.TabIndex = 3;
            label5.Text = "停止位";
            // 
            // check
            // 
            check.FormattingEnabled = true;
            check.Items.AddRange(new object[] { "None", "Odd", "Even" });
            check.Location = new Point(93, 118);
            check.Name = "check";
            check.Size = new Size(121, 25);
            check.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 121);
            label4.Name = "label4";
            label4.Size = new Size(44, 17);
            label4.TabIndex = 3;
            label4.Text = "校验位";
            // 
            // data
            // 
            data.FormattingEnabled = true;
            data.Items.AddRange(new object[] { "7", "8" });
            data.Location = new Point(93, 87);
            data.Name = "data";
            data.Size = new Size(121, 25);
            data.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 90);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "数据位";
            // 
            // bps
            // 
            bps.FormattingEnabled = true;
            bps.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            bps.Location = new Point(93, 56);
            bps.Name = "bps";
            bps.Size = new Size(121, 25);
            bps.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 3;
            label2.Text = "波特率";
            // 
            // serialPortNumber
            // 
            serialPortNumber.FormattingEnabled = true;
            serialPortNumber.Location = new Point(93, 25);
            serialPortNumber.Name = "serialPortNumber";
            serialPortNumber.Size = new Size(121, 25);
            serialPortNumber.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(44, 17);
            label1.TabIndex = 1;
            label1.Text = "串口号";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtReceiveData);
            groupBox2.Location = new Point(266, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(281, 345);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "接收区";
            // 
            // txtReceiveData
            // 
            txtReceiveData.Location = new Point(6, 22);
            txtReceiveData.Multiline = true;
            txtReceiveData.Name = "txtReceiveData";
            txtReceiveData.Size = new Size(266, 317);
            txtReceiveData.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(sendData);
            groupBox3.Location = new Point(266, 363);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 225);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "发送区";
            // 
            // sendData
            // 
            sendData.Location = new Point(6, 22);
            sendData.Multiline = true;
            sendData.Name = "sendData";
            sendData.Size = new Size(266, 191);
            sendData.TabIndex = 1;
            sendData.TextChanged += sendData_TextChanged;
            sendData.Leave += sendData_Leave;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnZt);
            groupBox4.Controls.Add(btnSaveReceive);
            groupBox4.Controls.Add(btnSelectPath);
            groupBox4.Controls.Add(btnClearReceive);
            groupBox4.Controls.Add(cbAutoClearReceive);
            groupBox4.Controls.Add(cb16HexReceive);
            groupBox4.Controls.Add(txtReceiveFilePath);
            groupBox4.Location = new Point(12, 254);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(248, 148);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "接收配置";
            // 
            // btnZt
            // 
            btnZt.Location = new Point(126, 51);
            btnZt.Name = "btnZt";
            btnZt.Size = new Size(87, 23);
            btnZt.TabIndex = 10;
            btnZt.Text = "暂停";
            btnZt.UseVisualStyleBackColor = true;
            btnZt.Click += btnZt_Click;
            // 
            // btnSaveReceive
            // 
            btnSaveReceive.Location = new Point(126, 80);
            btnSaveReceive.Name = "btnSaveReceive";
            btnSaveReceive.Size = new Size(87, 23);
            btnSaveReceive.TabIndex = 9;
            btnSaveReceive.Text = "保存数据";
            btnSaveReceive.UseVisualStyleBackColor = true;
            btnSaveReceive.Click += btnSaveReceive_Click;
            // 
            // btnSelectPath
            // 
            btnSelectPath.Location = new Point(16, 80);
            btnSelectPath.Name = "btnSelectPath";
            btnSelectPath.Size = new Size(87, 23);
            btnSelectPath.TabIndex = 8;
            btnSelectPath.Text = "选择路径";
            btnSelectPath.UseVisualStyleBackColor = true;
            btnSelectPath.Click += btnSelectPath_Click;
            // 
            // btnClearReceive
            // 
            btnClearReceive.ImageAlign = ContentAlignment.BottomCenter;
            btnClearReceive.Location = new Point(126, 22);
            btnClearReceive.Name = "btnClearReceive";
            btnClearReceive.Size = new Size(87, 23);
            btnClearReceive.TabIndex = 6;
            btnClearReceive.Text = "手动清空";
            btnClearReceive.UseVisualStyleBackColor = true;
            btnClearReceive.Click += btnClearReceive_Click;
            // 
            // cbAutoClearReceive
            // 
            cbAutoClearReceive.AutoSize = true;
            cbAutoClearReceive.Location = new Point(25, 24);
            cbAutoClearReceive.Name = "cbAutoClearReceive";
            cbAutoClearReceive.Size = new Size(75, 21);
            cbAutoClearReceive.TabIndex = 7;
            cbAutoClearReceive.Text = "自动清空";
            cbAutoClearReceive.UseVisualStyleBackColor = true;
            cbAutoClearReceive.CheckedChanged += cbAutoClearReceive_CheckedChanged;
            // 
            // cb16HexReceive
            // 
            cb16HexReceive.AutoSize = true;
            cb16HexReceive.Location = new Point(25, 51);
            cb16HexReceive.Name = "cb16HexReceive";
            cb16HexReceive.Size = new Size(75, 21);
            cb16HexReceive.TabIndex = 6;
            cb16HexReceive.Text = "十六进制";
            cb16HexReceive.UseVisualStyleBackColor = true;
            cb16HexReceive.CheckedChanged += cb16HexReceive_CheckedChanged;
            // 
            // txtReceiveFilePath
            // 
            txtReceiveFilePath.Location = new Point(6, 109);
            txtReceiveFilePath.Multiline = true;
            txtReceiveFilePath.Name = "txtReceiveFilePath";
            txtReceiveFilePath.Size = new Size(236, 26);
            txtReceiveFilePath.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBox1);
            groupBox5.Controls.Add(label9);
            groupBox5.Controls.Add(label6);
            groupBox5.Controls.Add(btnClearSend);
            groupBox5.Controls.Add(btnSendFile);
            groupBox5.Controls.Add(btnOpenFile);
            groupBox5.Controls.Add(btnSend);
            groupBox5.Controls.Add(cbAutoSend);
            groupBox5.Controls.Add(cb16HexSend);
            groupBox5.Controls.Add(txtSendFilePath);
            groupBox5.Location = new Point(12, 408);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(248, 180);
            groupBox5.TabIndex = 11;
            groupBox5.TabStop = false;
            groupBox5.Text = "发送配置";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 283);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(116, 20);
            textBox1.TabIndex = 13;
            textBox1.Text = "1000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, -123);
            label9.Name = "label9";
            label9.Size = new Size(105, 17);
            label9.TabIndex = 12;
            label9.Text = "自动发送周期(ms)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 150);
            label6.Name = "label6";
            label6.Size = new Size(105, 17);
            label6.TabIndex = 6;
            label6.Text = "自动发送周期(ms)";
            // 
            // btnClearSend
            // 
            btnClearSend.Location = new Point(126, 51);
            btnClearSend.Name = "btnClearSend";
            btnClearSend.Size = new Size(87, 23);
            btnClearSend.TabIndex = 10;
            btnClearSend.Text = "清空发送";
            btnClearSend.UseVisualStyleBackColor = true;
            btnClearSend.Click += btnClearSend_Click;
            // 
            // btnSendFile
            // 
            btnSendFile.Location = new Point(126, 80);
            btnSendFile.Name = "btnSendFile";
            btnSendFile.Size = new Size(87, 23);
            btnSendFile.TabIndex = 9;
            btnSendFile.Text = "发送文件";
            btnSendFile.UseVisualStyleBackColor = true;
            btnSendFile.Click += btnSendFile_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(16, 80);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(87, 23);
            btnOpenFile.TabIndex = 8;
            btnOpenFile.Text = "打开文件";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // btnSend
            // 
            btnSend.ImageAlign = ContentAlignment.BottomCenter;
            btnSend.Location = new Point(126, 22);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(87, 23);
            btnSend.TabIndex = 6;
            btnSend.Text = "手动发送";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cbAutoSend
            // 
            cbAutoSend.AutoSize = true;
            cbAutoSend.Location = new Point(25, 24);
            cbAutoSend.Name = "cbAutoSend";
            cbAutoSend.Size = new Size(75, 21);
            cbAutoSend.TabIndex = 7;
            cbAutoSend.Text = "自动发送";
            cbAutoSend.UseVisualStyleBackColor = true;
            cbAutoSend.CheckedChanged += cbAutoSend_CheckedChanged;
            // 
            // cb16HexSend
            // 
            cb16HexSend.AutoSize = true;
            cb16HexSend.Location = new Point(25, 51);
            cb16HexSend.Name = "cb16HexSend";
            cb16HexSend.Size = new Size(75, 21);
            cb16HexSend.TabIndex = 6;
            cb16HexSend.Text = "十六进制";
            cb16HexSend.UseVisualStyleBackColor = true;
            cb16HexSend.CheckedChanged += cb16HexSend_CheckedChanged;
            // 
            // txtSendFilePath
            // 
            txtSendFilePath.Location = new Point(6, 109);
            txtSendFilePath.Multiline = true;
            txtSendFilePath.Name = "txtSendFilePath";
            txtSendFilePath.Size = new Size(236, 26);
            txtSendFilePath.TabIndex = 0;
            // 
            // txtAutoSendZq
            // 
            txtAutoSendZq.Location = new Point(138, 556);
            txtAutoSendZq.Multiline = true;
            txtAutoSendZq.Name = "txtAutoSendZq";
            txtAutoSendZq.Size = new Size(116, 20);
            txtAutoSendZq.TabIndex = 11;
            txtAutoSendZq.Text = "1000";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 603);
            label7.Name = "label7";
            label7.Size = new Size(44, 17);
            label7.TabIndex = 11;
            label7.Text = "状态：";
            // 
            // state
            // 
            state.AutoSize = true;
            state.Location = new Point(57, 603);
            state.Name = "state";
            state.Size = new Size(68, 17);
            state.TabIndex = 11;
            state.Text = "初始化正常";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(173, 603);
            label10.Name = "label10";
            label10.Size = new Size(56, 17);
            label10.TabIndex = 14;
            label10.Text = "发送计数";
            // 
            // txtSendCount
            // 
            txtSendCount.Location = new Point(235, 600);
            txtSendCount.Multiline = true;
            txtSendCount.Name = "txtSendCount";
            txtSendCount.Size = new Size(63, 20);
            txtSendCount.TabIndex = 15;
            txtSendCount.Text = "0";
            // 
            // txtReceiveCount
            // 
            txtReceiveCount.Location = new Point(372, 600);
            txtReceiveCount.Multiline = true;
            txtReceiveCount.Name = "txtReceiveCount";
            txtReceiveCount.Size = new Size(63, 20);
            txtReceiveCount.TabIndex = 17;
            txtReceiveCount.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(310, 603);
            label11.Name = "label11";
            label11.Size = new Size(56, 17);
            label11.TabIndex = 16;
            label11.Text = "接收计数";
            // 
            // btnClearCount
            // 
            btnClearCount.Location = new Point(451, 599);
            btnClearCount.Name = "btnClearCount";
            btnClearCount.Size = new Size(87, 23);
            btnClearCount.TabIndex = 14;
            btnClearCount.Text = "清空计数";
            btnClearCount.UseVisualStyleBackColor = true;
            btnClearCount.Click += btnClearCount_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 629);
            Controls.Add(btnClearCount);
            Controls.Add(txtReceiveCount);
            Controls.Add(label11);
            Controls.Add(txtSendCount);
            Controls.Add(label10);
            Controls.Add(state);
            Controls.Add(label7);
            Controls.Add(txtAutoSendZq);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox bps;
        private Label label2;
        private ComboBox serialPortNumber;
        private Label label1;
        private ComboBox stop;
        private Label label5;
        private ComboBox check;
        private Label label4;
        private ComboBox data;
        private Label label3;
        private Button btnOpenAndClosePort;
        private CheckBox cbDtr;
        private GroupBox groupBox2;
        private TextBox txtReceiveData;
        private GroupBox groupBox3;
        private TextBox sendData;
        private CheckBox cbRts;
        private GroupBox groupBox4;
        private Button btnZt;
        private Button btnSaveReceive;
        private Button btnSelectPath;
        private Button btnClearReceive;
        private CheckBox cbAutoClearReceive;
        private CheckBox cb16HexReceive;
        private TextBox txtReceiveFilePath;
        private GroupBox groupBox5;
        private Button btnClearSend;
        private Button btnSendFile;
        private Button btnOpenFile;
        private Button btnSend;
        private CheckBox cbAutoSend;
        private CheckBox cb16HexSend;
        private TextBox txtSendFilePath;
        private TextBox textBox1;
        private Label label9;
        private Label label6;
        private TextBox txtAutoSendZq;
        private Label label7;
        private Label state;
        private Label label10;
        private TextBox txtSendCount;
        private TextBox txtReceiveCount;
        private Label label11;
        private Button btnClearCount;
        private System.Windows.Forms.Timer timer1;
    }
}
