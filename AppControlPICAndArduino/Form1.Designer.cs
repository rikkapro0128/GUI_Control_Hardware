namespace AppControlPICAndArduino
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.statusConnect = new System.Windows.Forms.TextBox();
            this.selectBraudrate = new System.Windows.Forms.ComboBox();
            this.selectCOM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numReceived = new System.Windows.Forms.TextBox();
            this.exitApp = new System.Windows.Forms.Button();
            this.sendData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.contentSend = new System.Windows.Forms.TextBox();
            this.permitData = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.offLed = new System.Windows.Forms.Button();
            this.onLed = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.console = new System.Windows.Forms.RichTextBox();
            this.typeBoard = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "RS232 (COM) Communication Lab";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.statusConnect);
            this.groupBox1.Controls.Add(this.selectBraudrate);
            this.groupBox1.Controls.Add(this.selectCOM);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(200, 162);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Communication Setup";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDisconnect.BackColor = System.Drawing.Color.Black;
            this.btnDisconnect.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDisconnect.ForeColor = System.Drawing.Color.White;
            this.btnDisconnect.Location = new System.Drawing.Point(90, 125);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDisconnect.Size = new System.Drawing.Size(105, 31);
            this.btnDisconnect.TabIndex = 10;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConnect.BackColor = System.Drawing.Color.Black;
            this.btnConnect.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(8, 125);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Size = new System.Drawing.Size(75, 31);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // statusConnect
            // 
            this.statusConnect.BackColor = System.Drawing.Color.LightCoral;
            this.statusConnect.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusConnect.Cursor = System.Windows.Forms.Cursors.Default;
            this.statusConnect.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.statusConnect.ForeColor = System.Drawing.Color.Firebrick;
            this.statusConnect.Location = new System.Drawing.Point(9, 95);
            this.statusConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statusConnect.Name = "statusConnect";
            this.statusConnect.ReadOnly = true;
            this.statusConnect.Size = new System.Drawing.Size(186, 16);
            this.statusConnect.TabIndex = 9;
            this.statusConnect.Text = "Disconnected!";
            this.statusConnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statusConnect.TextChanged += new System.EventHandler(this.statusConnect_TextChanged);
            // 
            // selectBraudrate
            // 
            this.selectBraudrate.BackColor = System.Drawing.Color.White;
            this.selectBraudrate.FormattingEnabled = true;
            this.selectBraudrate.Location = new System.Drawing.Point(89, 57);
            this.selectBraudrate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectBraudrate.Name = "selectBraudrate";
            this.selectBraudrate.Size = new System.Drawing.Size(106, 24);
            this.selectBraudrate.TabIndex = 8;
            this.selectBraudrate.Text = "Choose";
            // 
            // selectCOM
            // 
            this.selectCOM.BackColor = System.Drawing.Color.White;
            this.selectCOM.FormattingEnabled = true;
            this.selectCOM.Location = new System.Drawing.Point(89, 27);
            this.selectCOM.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectCOM.Name = "selectCOM";
            this.selectCOM.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectCOM.Size = new System.Drawing.Size(106, 24);
            this.selectCOM.TabIndex = 0;
            this.selectCOM.Tag = "Choose";
            this.selectCOM.Text = "Choose";
            this.selectCOM.SelectedIndexChanged += new System.EventHandler(this.selectCOM_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Braud Rate";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "COM Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(227, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(200, 63);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Switch Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Counter (SW)";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGreen;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox2.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(103, 30);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(91, 16);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "0";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.numReceived);
            this.groupBox3.Controls.Add(this.exitApp);
            this.groupBox3.Controls.Add(this.sendData);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.contentSend);
            this.groupBox3.Controls.Add(this.permitData);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(443, 35);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(212, 162);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Send / Receive";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // numReceived
            // 
            this.numReceived.BackColor = System.Drawing.Color.LightGreen;
            this.numReceived.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numReceived.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numReceived.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numReceived.ForeColor = System.Drawing.Color.Black;
            this.numReceived.Location = new System.Drawing.Point(68, 60);
            this.numReceived.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numReceived.Name = "numReceived";
            this.numReceived.ReadOnly = true;
            this.numReceived.Size = new System.Drawing.Size(137, 16);
            this.numReceived.TabIndex = 17;
            this.numReceived.Text = "0";
            this.numReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // exitApp
            // 
            this.exitApp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exitApp.BackColor = System.Drawing.Color.Black;
            this.exitApp.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitApp.ForeColor = System.Drawing.Color.White;
            this.exitApp.Location = new System.Drawing.Point(6, 125);
            this.exitApp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitApp.Name = "exitApp";
            this.exitApp.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.exitApp.Size = new System.Drawing.Size(200, 31);
            this.exitApp.TabIndex = 16;
            this.exitApp.Text = "Exit Program";
            this.exitApp.UseVisualStyleBackColor = false;
            this.exitApp.Click += new System.EventHandler(this.exitApp_Click);
            // 
            // sendData
            // 
            this.sendData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendData.BackColor = System.Drawing.Color.Black;
            this.sendData.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sendData.ForeColor = System.Drawing.Color.White;
            this.sendData.Location = new System.Drawing.Point(6, 88);
            this.sendData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendData.Name = "sendData";
            this.sendData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendData.Size = new System.Drawing.Size(200, 31);
            this.sendData.TabIndex = 15;
            this.sendData.Text = "Send Data";
            this.sendData.UseVisualStyleBackColor = false;
            this.sendData.Click += new System.EventHandler(this.sendData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 60);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Receive";
            // 
            // contentSend
            // 
            this.contentSend.BackColor = System.Drawing.Color.White;
            this.contentSend.ForeColor = System.Drawing.Color.Black;
            this.contentSend.Location = new System.Drawing.Point(68, 27);
            this.contentSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contentSend.Name = "contentSend";
            this.contentSend.PlaceholderText = "Write here...";
            this.contentSend.Size = new System.Drawing.Size(138, 23);
            this.contentSend.TabIndex = 11;
            this.contentSend.TextChanged += new System.EventHandler(this.contentSend_textChanged);
            // 
            // permitData
            // 
            this.permitData.AutoSize = true;
            this.permitData.Location = new System.Drawing.Point(37, 27);
            this.permitData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.permitData.Name = "permitData";
            this.permitData.Padding = new System.Windows.Forms.Padding(5);
            this.permitData.Size = new System.Drawing.Size(25, 24);
            this.permitData.TabIndex = 6;
            this.permitData.UseVisualStyleBackColor = true;
            this.permitData.CheckedChanged += new System.EventHandler(this.permitData_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Send";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.typeBoard);
            this.groupBox4.Controls.Add(this.offLed);
            this.groupBox4.Controls.Add(this.onLed);
            this.groupBox4.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(227, 105);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(200, 92);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Led Control";
            // 
            // offLed
            // 
            this.offLed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.offLed.BackColor = System.Drawing.Color.Black;
            this.offLed.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.offLed.ForeColor = System.Drawing.Color.White;
            this.offLed.Location = new System.Drawing.Point(103, 52);
            this.offLed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.offLed.Name = "offLed";
            this.offLed.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.offLed.Size = new System.Drawing.Size(89, 31);
            this.offLed.TabIndex = 7;
            this.offLed.Text = "OFF";
            this.offLed.UseVisualStyleBackColor = false;
            this.offLed.Click += new System.EventHandler(this.offLed_Click);
            // 
            // onLed
            // 
            this.onLed.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.onLed.BackColor = System.Drawing.Color.Black;
            this.onLed.Font = new System.Drawing.Font("JetBrains Mono", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.onLed.ForeColor = System.Drawing.Color.White;
            this.onLed.Location = new System.Drawing.Point(8, 52);
            this.onLed.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.onLed.Name = "onLed";
            this.onLed.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.onLed.Size = new System.Drawing.Size(89, 31);
            this.onLed.TabIndex = 7;
            this.onLed.Text = "ON";
            this.onLed.UseVisualStyleBackColor = false;
            this.onLed.Click += new System.EventHandler(this.onLed_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.console);
            this.groupBox5.Font = new System.Drawing.Font("JetBrains Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox5.Location = new System.Drawing.Point(12, 213);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox5.Size = new System.Drawing.Size(643, 198);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Data Send / Receive";
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(9, 22);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(627, 170);
            this.console.TabIndex = 8;
            this.console.Text = "";
            this.console.TextChanged += new System.EventHandler(this.console_TextChanged);
            // 
            // typeBoard
            // 
            this.typeBoard.BackColor = System.Drawing.Color.White;
            this.typeBoard.FormattingEnabled = true;
            this.typeBoard.Location = new System.Drawing.Point(8, 22);
            this.typeBoard.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.typeBoard.Name = "typeBoard";
            this.typeBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.typeBoard.Size = new System.Drawing.Size(184, 24);
            this.typeBoard.TabIndex = 8;
            this.typeBoard.Tag = "Choose";
            this.typeBoard.Text = "Choose";
            this.typeBoard.SelectedIndexChanged += new System.EventHandler(this.typeBoard_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 423);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "GUI Control Device";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private ComboBox selectBraudrate;
        private ComboBox selectCOM;
        private Label label3;
        private Label label2;
        private TextBox statusConnect;
        private Button btnConnect;
        private Button btnDisconnect;
        private Label label4;
        private TextBox textBox2;
        private Button offLed;
        private Button onLed;
        private CheckBox permitData;
        private Label label5;
        private TextBox contentSend;
        private Button exitApp;
        private Button sendData;
        private Label label6;
        private FolderBrowserDialog folderBrowserDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private GroupBox groupBox5;
        private RichTextBox console;
        private TextBox numReceived;
        private ComboBox typeBoard;
    }
}