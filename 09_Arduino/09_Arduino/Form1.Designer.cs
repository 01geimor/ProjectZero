namespace _09_Arduino
{
    partial class Arduino
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.sP1 = new System.IO.Ports.SerialPort(this.components);
            this.cmb_Baud = new System.Windows.Forms.ComboBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.gpb_Arduino = new System.Windows.Forms.GroupBox();
            this.ltb_Ausgabe = new System.Windows.Forms.ListBox();
            this.txt_Eingabe = new System.Windows.Forms.TextBox();
            this.cmb_COM = new System.Windows.Forms.ComboBox();
            this.lbl_Baud = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.tc_Interface = new System.Windows.Forms.TabControl();
            this.tp_Graphic = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ValueTimer = new System.Windows.Forms.TrackBar();
            this.cmb_Ganalogpins = new System.Windows.Forms.ComboBox();
            this.btn_GCreate = new System.Windows.Forms.Button();
            this.pb_GGraphic = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gpb_Arduino.SuspendLayout();
            this.tc_Interface.SuspendLayout();
            this.tp_Graphic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ValueTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // sP1
            // 
            this.sP1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sP1_DataReceived);
            // 
            // cmb_Baud
            // 
            this.cmb_Baud.AutoCompleteCustomSource.AddRange(new string[] {
            "9600"});
            this.cmb_Baud.FormattingEnabled = true;
            this.cmb_Baud.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "74880",
            "115200",
            "230400"});
            this.cmb_Baud.Location = new System.Drawing.Point(246, 13);
            this.cmb_Baud.Name = "cmb_Baud";
            this.cmb_Baud.Size = new System.Drawing.Size(121, 21);
            this.cmb_Baud.TabIndex = 0;
            this.cmb_Baud.Text = "9600";
            // 
            // btn_Send
            // 
            this.btn_Send.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Send.Location = new System.Drawing.Point(563, 113);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(70, 23);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // gpb_Arduino
            // 
            this.gpb_Arduino.Controls.Add(this.ltb_Ausgabe);
            this.gpb_Arduino.Controls.Add(this.txt_Eingabe);
            this.gpb_Arduino.Controls.Add(this.btn_Send);
            this.gpb_Arduino.Enabled = false;
            this.gpb_Arduino.Location = new System.Drawing.Point(36, 40);
            this.gpb_Arduino.Name = "gpb_Arduino";
            this.gpb_Arduino.Size = new System.Drawing.Size(644, 142);
            this.gpb_Arduino.TabIndex = 2;
            this.gpb_Arduino.TabStop = false;
            this.gpb_Arduino.Text = "Arduino";
            // 
            // ltb_Ausgabe
            // 
            this.ltb_Ausgabe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ltb_Ausgabe.FormattingEnabled = true;
            this.ltb_Ausgabe.Location = new System.Drawing.Point(6, 27);
            this.ltb_Ausgabe.Name = "ltb_Ausgabe";
            this.ltb_Ausgabe.Size = new System.Drawing.Size(627, 82);
            this.ltb_Ausgabe.TabIndex = 4;
            // 
            // txt_Eingabe
            // 
            this.txt_Eingabe.Location = new System.Drawing.Point(6, 115);
            this.txt_Eingabe.Name = "txt_Eingabe";
            this.txt_Eingabe.Size = new System.Drawing.Size(551, 20);
            this.txt_Eingabe.TabIndex = 3;
            // 
            // cmb_COM
            // 
            this.cmb_COM.FormattingEnabled = true;
            this.cmb_COM.Location = new System.Drawing.Point(69, 13);
            this.cmb_COM.Name = "cmb_COM";
            this.cmb_COM.Size = new System.Drawing.Size(121, 21);
            this.cmb_COM.TabIndex = 3;
            // 
            // lbl_Baud
            // 
            this.lbl_Baud.AutoSize = true;
            this.lbl_Baud.Location = new System.Drawing.Point(208, 16);
            this.lbl_Baud.Name = "lbl_Baud";
            this.lbl_Baud.Size = new System.Drawing.Size(32, 13);
            this.lbl_Baud.TabIndex = 4;
            this.lbl_Baud.Text = "Baud";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "COM";
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(371, 11);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(75, 23);
            this.btn_Connect.TabIndex = 6;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Location = new System.Drawing.Point(452, 11);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(75, 23);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // tc_Interface
            // 
            this.tc_Interface.Controls.Add(this.tp_Graphic);
            this.tc_Interface.Controls.Add(this.tabPage2);
            this.tc_Interface.Enabled = false;
            this.tc_Interface.Location = new System.Drawing.Point(36, 188);
            this.tc_Interface.Name = "tc_Interface";
            this.tc_Interface.SelectedIndex = 0;
            this.tc_Interface.Size = new System.Drawing.Size(648, 361);
            this.tc_Interface.TabIndex = 8;
            // 
            // tp_Graphic
            // 
            this.tp_Graphic.Controls.Add(this.label2);
            this.tp_Graphic.Controls.Add(this.label4);
            this.tp_Graphic.Controls.Add(this.tb_ValueTimer);
            this.tp_Graphic.Controls.Add(this.cmb_Ganalogpins);
            this.tp_Graphic.Controls.Add(this.btn_GCreate);
            this.tp_Graphic.Controls.Add(this.pb_GGraphic);
            this.tp_Graphic.Location = new System.Drawing.Point(4, 22);
            this.tp_Graphic.Name = "tp_Graphic";
            this.tp_Graphic.Padding = new System.Windows.Forms.Padding(3);
            this.tp_Graphic.Size = new System.Drawing.Size(640, 335);
            this.tp_Graphic.TabIndex = 0;
            this.tp_Graphic.Text = "Graphic";
            this.tp_Graphic.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "AnalogPin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(559, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Refresh Time";
            // 
            // tb_ValueTimer
            // 
            this.tb_ValueTimer.Location = new System.Drawing.Point(574, 105);
            this.tb_ValueTimer.Maximum = 300;
            this.tb_ValueTimer.Minimum = 1;
            this.tb_ValueTimer.Name = "tb_ValueTimer";
            this.tb_ValueTimer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tb_ValueTimer.Size = new System.Drawing.Size(45, 224);
            this.tb_ValueTimer.TabIndex = 9;
            this.tb_ValueTimer.TickFrequency = 10;
            this.tb_ValueTimer.Value = 50;
            this.tb_ValueTimer.Scroll += new System.EventHandler(this.tb_ValueTimer_Scroll);
            // 
            // cmb_Ganalogpins
            // 
            this.cmb_Ganalogpins.FormattingEnabled = true;
            this.cmb_Ganalogpins.Items.AddRange(new object[] {
            "A0"});
            this.cmb_Ganalogpins.Location = new System.Drawing.Point(559, 22);
            this.cmb_Ganalogpins.Name = "cmb_Ganalogpins";
            this.cmb_Ganalogpins.Size = new System.Drawing.Size(75, 21);
            this.cmb_Ganalogpins.TabIndex = 2;
            this.cmb_Ganalogpins.Text = "A0";
            // 
            // btn_GCreate
            // 
            this.btn_GCreate.Location = new System.Drawing.Point(559, 49);
            this.btn_GCreate.Name = "btn_GCreate";
            this.btn_GCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_GCreate.TabIndex = 1;
            this.btn_GCreate.Text = "Create";
            this.btn_GCreate.UseVisualStyleBackColor = true;
            this.btn_GCreate.Click += new System.EventHandler(this.btn_GCreate_Click);
            // 
            // pb_GGraphic
            // 
            this.pb_GGraphic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_GGraphic.Location = new System.Drawing.Point(6, 6);
            this.pb_GGraphic.Name = "pb_GGraphic";
            this.pb_GGraphic.Size = new System.Drawing.Size(547, 323);
            this.pb_GGraphic.TabIndex = 0;
            this.pb_GGraphic.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(640, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Arduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.tc_Interface);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_COM);
            this.Controls.Add(this.lbl_Baud);
            this.Controls.Add(this.gpb_Arduino);
            this.Controls.Add(this.cmb_Baud);
            this.Name = "Arduino";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdruinoConnect";
            this.Load += new System.EventHandler(this.Arduino_Load);
            this.gpb_Arduino.ResumeLayout(false);
            this.gpb_Arduino.PerformLayout();
            this.tc_Interface.ResumeLayout(false);
            this.tp_Graphic.ResumeLayout(false);
            this.tp_Graphic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_ValueTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_GGraphic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort sP1;
        private System.Windows.Forms.ComboBox cmb_Baud;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.GroupBox gpb_Arduino;
        private System.Windows.Forms.TextBox txt_Eingabe;
        private System.Windows.Forms.ComboBox cmb_COM;
        private System.Windows.Forms.Label lbl_Baud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.ListBox ltb_Ausgabe;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.TabControl tc_Interface;
        private System.Windows.Forms.TabPage tp_Graphic;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmb_Ganalogpins;
        private System.Windows.Forms.Button btn_GCreate;
        private System.Windows.Forms.PictureBox pb_GGraphic;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar tb_ValueTimer;
    }
}

