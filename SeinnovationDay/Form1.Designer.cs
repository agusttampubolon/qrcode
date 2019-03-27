namespace SeinnovationDay
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUniqueCode = new System.Windows.Forms.Label();
            this.lblPleaseWait = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnCloseKeyboard = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.webprint = new System.Windows.Forms.WebBrowser();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.textBox2.Location = new System.Drawing.Point(271, 614);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 31);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(34, 147);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.ScrollBarsEnabled = false;
            this.webBrowser1.Size = new System.Drawing.Size(492, 443);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblUniqueCode);
            this.panel1.Controls.Add(this.btnCloseKeyboard);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 759);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 744);
            this.panel1.TabIndex = 3;
            // 
            // lblUniqueCode
            // 
            this.lblUniqueCode.AutoSize = true;
            this.lblUniqueCode.Location = new System.Drawing.Point(32, 33);
            this.lblUniqueCode.Name = "lblUniqueCode";
            this.lblUniqueCode.Size = new System.Drawing.Size(70, 25);
            this.lblUniqueCode.TabIndex = 15;
            this.lblUniqueCode.Text = "label2";
            this.lblUniqueCode.Visible = false;
            // 
            // lblPleaseWait
            // 
            this.lblPleaseWait.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPleaseWait.BackColor = System.Drawing.Color.White;
            this.lblPleaseWait.Font = new System.Drawing.Font("Calibri", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPleaseWait.ForeColor = System.Drawing.Color.Black;
            this.lblPleaseWait.Location = new System.Drawing.Point(34, 345);
            this.lblPleaseWait.Name = "lblPleaseWait";
            this.lblPleaseWait.Size = new System.Drawing.Size(489, 53);
            this.lblPleaseWait.TabIndex = 14;
            this.lblPleaseWait.Text = "please wait...";
            this.lblPleaseWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lblInput);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btn0);
            this.panel2.Controls.Add(this.btn9);
            this.panel2.Controls.Add(this.btnOK);
            this.panel2.Controls.Add(this.btn5);
            this.panel2.Controls.Add(this.btn6);
            this.panel2.Controls.Add(this.btn4);
            this.panel2.Controls.Add(this.btn3);
            this.panel2.Controls.Add(this.btn8);
            this.panel2.Controls.Add(this.btn2);
            this.panel2.Controls.Add(this.btn1);
            this.panel2.Controls.Add(this.btn7);
            this.panel2.Location = new System.Drawing.Point(34, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 588);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // lblInput
            // 
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.ForeColor = System.Drawing.Color.White;
            this.lblInput.Location = new System.Drawing.Point(115, 27);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(367, 53);
            this.lblInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 55);
            this.label1.TabIndex = 12;
            this.label1.Text = "JKT";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LimeGreen;
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(8, 464);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 121);
            this.btnClear.TabIndex = 11;
            this.btnClear.TabStop = false;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.LimeGreen;
            this.btn0.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(168, 464);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(154, 121);
            this.btn0.TabIndex = 10;
            this.btn0.TabStop = false;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.LimeGreen;
            this.btn9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(328, 89);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(154, 121);
            this.btn9.TabIndex = 9;
            this.btn9.TabStop = false;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOK.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(328, 464);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(154, 121);
            this.btnOK.TabIndex = 0;
            this.btnOK.TabStop = false;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.LimeGreen;
            this.btn5.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(168, 215);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(154, 121);
            this.btn5.TabIndex = 5;
            this.btn5.TabStop = false;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.LimeGreen;
            this.btn6.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(328, 214);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(154, 121);
            this.btn6.TabIndex = 6;
            this.btn6.TabStop = false;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.LimeGreen;
            this.btn4.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(8, 215);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(154, 121);
            this.btn4.TabIndex = 4;
            this.btn4.TabStop = false;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.LimeGreen;
            this.btn3.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(328, 339);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(154, 121);
            this.btn3.TabIndex = 3;
            this.btn3.TabStop = false;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.LimeGreen;
            this.btn8.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(168, 89);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(154, 122);
            this.btn8.TabIndex = 8;
            this.btn8.TabStop = false;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LimeGreen;
            this.btn2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(168, 341);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(154, 121);
            this.btn2.TabIndex = 2;
            this.btn2.TabStop = false;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.LimeGreen;
            this.btn1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(8, 340);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(154, 121);
            this.btn1.TabIndex = 1;
            this.btn1.TabStop = false;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.LimeGreen;
            this.btn7.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(8, 89);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(154, 122);
            this.btn7.TabIndex = 7;
            this.btn7.TabStop = false;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(406, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 53);
            this.button3.TabIndex = 13;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCloseKeyboard
            // 
            this.btnCloseKeyboard.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCloseKeyboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCloseKeyboard.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btnCloseKeyboard.FlatAppearance.BorderSize = 0;
            this.btnCloseKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseKeyboard.ForeColor = System.Drawing.Color.White;
            this.btnCloseKeyboard.Location = new System.Drawing.Point(214, 661);
            this.btnCloseKeyboard.Name = "btnCloseKeyboard";
            this.btnCloseKeyboard.Size = new System.Drawing.Size(417, 83);
            this.btnCloseKeyboard.TabIndex = 5;
            this.btnCloseKeyboard.TabStop = false;
            this.btnCloseKeyboard.Text = "Close Keyboard";
            this.btnCloseKeyboard.UseVisualStyleBackColor = false;
            this.btnCloseKeyboard.Click += new System.EventHandler(this.btnCloseKeyboard_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(214, 658);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(417, 83);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Keyboard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(214, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(417, 83);
            this.button1.TabIndex = 3;
            this.button1.Text = "Check In";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // webprint
            // 
            this.webprint.Location = new System.Drawing.Point(28, 4);
            this.webprint.MinimumSize = new System.Drawing.Size(20, 20);
            this.webprint.Name = "webprint";
            this.webprint.ScrollBarsEnabled = false;
            this.webprint.Size = new System.Drawing.Size(763, 992);
            this.webprint.TabIndex = 14;
            this.webprint.Url = new System.Uri("", System.UriKind.Relative);
            this.webprint.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPleaseWait);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.webBrowser1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(146, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(551, 626);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Scan your QR Code";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SeinnovationDay.Properties.Resources.bg_app;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 1541);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.webprint);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnCloseKeyboard;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser webprint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblPleaseWait;
        private System.Windows.Forms.Label lblUniqueCode;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

