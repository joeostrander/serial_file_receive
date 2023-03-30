
namespace serial_file_receive
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBitsPerSecond = new System.Windows.Forms.ComboBox();
            this.comboBoxComPort1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LabelBitsPerSecond = new System.Windows.Forms.Label();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.LabelDataBits = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.comboBoxParity = new System.Windows.Forms.ComboBox();
            this.comboBoxFlowControl = new System.Windows.Forms.ComboBox();
            this.LabelParity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.linkLabelFilename = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.labelBytesReceivedHeader = new System.Windows.Forms.Label();
            this.labelBytesReceived = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxBitsPerSecond);
            this.groupBox1.Controls.Add(this.comboBoxComPort1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.LabelBitsPerSecond);
            this.groupBox1.Controls.Add(this.comboBoxDataBits);
            this.groupBox1.Controls.Add(this.LabelDataBits);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.comboBoxParity);
            this.groupBox1.Controls.Add(this.comboBoxFlowControl);
            this.groupBox1.Controls.Add(this.LabelParity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxStopBits);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Settings";
            // 
            // comboBoxBitsPerSecond
            // 
            this.comboBoxBitsPerSecond.FormattingEnabled = true;
            this.comboBoxBitsPerSecond.Items.AddRange(new object[] {
            "110",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600",
            "1250000"});
            this.comboBoxBitsPerSecond.Location = new System.Drawing.Point(99, 50);
            this.comboBoxBitsPerSecond.Name = "comboBoxBitsPerSecond";
            this.comboBoxBitsPerSecond.Size = new System.Drawing.Size(104, 21);
            this.comboBoxBitsPerSecond.TabIndex = 3;
            // 
            // comboBoxComPort1
            // 
            this.comboBoxComPort1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxComPort1.FormattingEnabled = true;
            this.comboBoxComPort1.Location = new System.Drawing.Point(99, 23);
            this.comboBoxComPort1.Name = "comboBoxComPort1";
            this.comboBoxComPort1.Size = new System.Drawing.Size(272, 21);
            this.comboBoxComPort1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // LabelBitsPerSecond
            // 
            this.LabelBitsPerSecond.AutoSize = true;
            this.LabelBitsPerSecond.Location = new System.Drawing.Point(37, 53);
            this.LabelBitsPerSecond.Name = "LabelBitsPerSecond";
            this.LabelBitsPerSecond.Size = new System.Drawing.Size(56, 13);
            this.LabelBitsPerSecond.TabIndex = 2;
            this.LabelBitsPerSecond.Text = "Baud rate:";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.comboBoxDataBits.Location = new System.Drawing.Point(99, 77);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(104, 21);
            this.comboBoxDataBits.TabIndex = 5;
            // 
            // LabelDataBits
            // 
            this.LabelDataBits.AutoSize = true;
            this.LabelDataBits.Location = new System.Drawing.Point(40, 80);
            this.LabelDataBits.Name = "LabelDataBits";
            this.LabelDataBits.Size = new System.Drawing.Size(53, 13);
            this.LabelDataBits.TabIndex = 4;
            this.LabelDataBits.Text = "Data Bits:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(25, 161);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 13);
            this.Label5.TabIndex = 10;
            this.Label5.Text = "Flow Control:";
            // 
            // comboBoxParity
            // 
            this.comboBoxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParity.FormattingEnabled = true;
            this.comboBoxParity.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even",
            "Mark",
            "Space"});
            this.comboBoxParity.Location = new System.Drawing.Point(99, 104);
            this.comboBoxParity.Name = "comboBoxParity";
            this.comboBoxParity.Size = new System.Drawing.Size(104, 21);
            this.comboBoxParity.TabIndex = 7;
            // 
            // comboBoxFlowControl
            // 
            this.comboBoxFlowControl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFlowControl.FormattingEnabled = true;
            this.comboBoxFlowControl.Items.AddRange(new object[] {
            "Xon / Xoff",
            "Hardware",
            "Both",
            "None"});
            this.comboBoxFlowControl.Location = new System.Drawing.Point(99, 158);
            this.comboBoxFlowControl.Name = "comboBoxFlowControl";
            this.comboBoxFlowControl.Size = new System.Drawing.Size(104, 21);
            this.comboBoxFlowControl.TabIndex = 11;
            // 
            // LabelParity
            // 
            this.LabelParity.AutoSize = true;
            this.LabelParity.Location = new System.Drawing.Point(57, 107);
            this.LabelParity.Name = "LabelParity";
            this.LabelParity.Size = new System.Drawing.Size(36, 13);
            this.LabelParity.TabIndex = 6;
            this.LabelParity.Text = "Parity:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stop bits:";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(99, 131);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(104, 21);
            this.comboBoxStopBits.TabIndex = 9;
            // 
            // linkLabelFilename
            // 
            this.linkLabelFilename.AutoSize = true;
            this.linkLabelFilename.Location = new System.Drawing.Point(363, 256);
            this.linkLabelFilename.Name = "linkLabelFilename";
            this.linkLabelFilename.Size = new System.Drawing.Size(42, 13);
            this.linkLabelFilename.TabIndex = 3;
            this.linkLabelFilename.TabStop = true;
            this.linkLabelFilename.Text = "&Browse";
            this.linkLabelFilename.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFilename_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Destination &File Path";
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(12, 253);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(345, 20);
            this.textBoxFile.TabIndex = 2;
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(12, 296);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(393, 42);
            this.buttonReceive.TabIndex = 4;
            this.buttonReceive.Text = "&Start Receiving";
            this.buttonReceive.UseVisualStyleBackColor = true;
            this.buttonReceive.Click += new System.EventHandler(this.buttonReceive_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // labelBytesReceivedHeader
            // 
            this.labelBytesReceivedHeader.AutoSize = true;
            this.labelBytesReceivedHeader.Location = new System.Drawing.Point(12, 353);
            this.labelBytesReceivedHeader.Name = "labelBytesReceivedHeader";
            this.labelBytesReceivedHeader.Size = new System.Drawing.Size(85, 13);
            this.labelBytesReceivedHeader.TabIndex = 5;
            this.labelBytesReceivedHeader.Text = "Bytes Received:";
            // 
            // labelBytesReceived
            // 
            this.labelBytesReceived.AutoSize = true;
            this.labelBytesReceived.Location = new System.Drawing.Point(103, 353);
            this.labelBytesReceived.Name = "labelBytesReceived";
            this.labelBytesReceived.Size = new System.Drawing.Size(13, 13);
            this.labelBytesReceived.TabIndex = 6;
            this.labelBytesReceived.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 375);
            this.Controls.Add(this.labelBytesReceived);
            this.Controls.Add(this.labelBytesReceivedHeader);
            this.Controls.Add(this.buttonReceive);
            this.Controls.Add(this.textBoxFile);
            this.Controls.Add(this.linkLabelFilename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.ComboBox comboBoxBitsPerSecond;
        private System.Windows.Forms.ComboBox comboBoxComPort1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label LabelBitsPerSecond;
        internal System.Windows.Forms.ComboBox comboBoxDataBits;
        internal System.Windows.Forms.Label LabelDataBits;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.ComboBox comboBoxParity;
        internal System.Windows.Forms.ComboBox comboBoxFlowControl;
        internal System.Windows.Forms.Label LabelParity;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.LinkLabel linkLabelFilename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label labelBytesReceivedHeader;
        private System.Windows.Forms.Label labelBytesReceived;
    }
}

