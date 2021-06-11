namespace CoffeeShop
{
    partial class CoffeShop
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
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btnTable1 = new System.Windows.Forms.Button();
            this.BtnTable2 = new System.Windows.Forms.Button();
            this.btnTable3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbRezervations = new System.Windows.Forms.ListBox();
            this.tbActiveTables = new System.Windows.Forms.TextBox();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnTb10 = new System.Windows.Forms.Button();
            this.btnTb9 = new System.Windows.Forms.Button();
            this.btnTb8 = new System.Windows.Forms.Button();
            this.btnTb11 = new System.Windows.Forms.Button();
            this.btnTb12 = new System.Windows.Forms.Button();
            this.lbCred = new System.Windows.Forms.Label();
            this.btnTb13 = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLogin
            // 
            this.gbLogin.BackgroundImage = global::CoffeeShop.Properties.Resources.Capture;
            this.gbLogin.Controls.Add(this.btnLogin);
            this.gbLogin.Controls.Add(this.label2);
            this.gbLogin.Controls.Add(this.label1);
            this.gbLogin.Controls.Add(this.lblError);
            this.gbLogin.Controls.Add(this.tbPassword);
            this.gbLogin.Controls.Add(this.tbUsername);
            this.gbLogin.Location = new System.Drawing.Point(300, 356);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(304, 132);
            this.gbLogin.TabIndex = 0;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "LOGIN";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(164, 100);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Salmon;
            this.label2.Location = new System.Drawing.Point(29, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passowrd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Salmon;
            this.lblError.Location = new System.Drawing.Point(127, 16);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(150, 13);
            this.lblError.TabIndex = 2;
            this.lblError.Text = "Invalid Username or Password";
            this.lblError.Visible = false;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(124, 74);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(153, 20);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(124, 38);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(153, 20);
            this.tbUsername.TabIndex = 0;
            this.tbUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUsername_KeyDown);
            // 
            // btnTable1
            // 
            this.btnTable1.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTable1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable1.Location = new System.Drawing.Point(65, 57);
            this.btnTable1.Name = "btnTable1";
            this.btnTable1.Size = new System.Drawing.Size(137, 112);
            this.btnTable1.TabIndex = 1;
            this.btnTable1.Text = "Table 1";
            this.btnTable1.UseVisualStyleBackColor = true;
            this.btnTable1.Visible = false;
            this.btnTable1.Click += new System.EventHandler(this.btnTable1_Click);
            // 
            // BtnTable2
            // 
            this.BtnTable2.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.BtnTable2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnTable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTable2.Location = new System.Drawing.Point(277, 57);
            this.BtnTable2.Name = "BtnTable2";
            this.BtnTable2.Size = new System.Drawing.Size(135, 112);
            this.BtnTable2.TabIndex = 2;
            this.BtnTable2.Text = "Table 2";
            this.BtnTable2.UseVisualStyleBackColor = true;
            this.BtnTable2.Visible = false;
            this.BtnTable2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTable3
            // 
            this.btnTable3.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTable3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable3.Location = new System.Drawing.Point(493, 57);
            this.btnTable3.Name = "btnTable3";
            this.btnTable3.Size = new System.Drawing.Size(133, 112);
            this.btnTable3.TabIndex = 3;
            this.btnTable3.Text = "Table 3";
            this.btnTable3.UseVisualStyleBackColor = true;
            this.btnTable3.Visible = false;
            this.btnTable3.Click += new System.EventHandler(this.btnTable3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(707, 57);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(134, 112);
            this.button4.TabIndex = 4;
            this.button4.Text = "Table 4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(707, 226);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(134, 106);
            this.button5.TabIndex = 5;
            this.button5.Text = "Table 5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(704, 382);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 106);
            this.button6.TabIndex = 5;
            this.button6.Text = "Table 6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // gbInfo
            // 
            this.gbInfo.BackgroundImage = global::CoffeeShop.Properties.Resources.Capture;
            this.gbInfo.Controls.Add(this.label4);
            this.gbInfo.Controls.Add(this.label3);
            this.gbInfo.Controls.Add(this.lbRezervations);
            this.gbInfo.Controls.Add(this.tbActiveTables);
            this.gbInfo.Controls.Add(this.tbProfit);
            this.gbInfo.Location = new System.Drawing.Point(277, 362);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Size = new System.Drawing.Size(349, 126);
            this.gbInfo.TabIndex = 6;
            this.gbInfo.TabStop = false;
            this.gbInfo.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "UnPaid Profit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Active Tables";
            // 
            // lbRezervations
            // 
            this.lbRezervations.FormattingEnabled = true;
            this.lbRezervations.Location = new System.Drawing.Point(23, 20);
            this.lbRezervations.Name = "lbRezervations";
            this.lbRezervations.Size = new System.Drawing.Size(170, 82);
            this.lbRezervations.TabIndex = 2;
            this.lbRezervations.DoubleClick += new System.EventHandler(this.lbRezervations_DoubleClick);
            // 
            // tbActiveTables
            // 
            this.tbActiveTables.Enabled = false;
            this.tbActiveTables.Location = new System.Drawing.Point(305, 20);
            this.tbActiveTables.Name = "tbActiveTables";
            this.tbActiveTables.Size = new System.Drawing.Size(37, 20);
            this.tbActiveTables.TabIndex = 1;
            // 
            // tbProfit
            // 
            this.tbProfit.Enabled = false;
            this.tbProfit.Location = new System.Drawing.Point(225, 82);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(102, 20);
            this.tbProfit.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "First Flour",
            "Second Flour"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "First Flour",
            "Second Flour"});
            this.comboBox1.Location = new System.Drawing.Point(374, 226);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnTb10
            // 
            this.btnTb10.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTb10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb10.Location = new System.Drawing.Point(65, 376);
            this.btnTb10.Name = "btnTb10";
            this.btnTb10.Size = new System.Drawing.Size(137, 112);
            this.btnTb10.TabIndex = 7;
            this.btnTb10.Text = "Table 9";
            this.btnTb10.UseVisualStyleBackColor = true;
            this.btnTb10.Visible = false;
            this.btnTb10.Click += new System.EventHandler(this.btnTb10_Click);
            // 
            // btnTb9
            // 
            this.btnTb9.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTb9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTb9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb9.Location = new System.Drawing.Point(65, 220);
            this.btnTb9.Name = "btnTb9";
            this.btnTb9.Size = new System.Drawing.Size(137, 112);
            this.btnTb9.TabIndex = 8;
            this.btnTb9.Text = "Table 8";
            this.btnTb9.UseVisualStyleBackColor = true;
            this.btnTb9.Visible = false;
            this.btnTb9.Click += new System.EventHandler(this.btnTb9_Click);
            // 
            // btnTb8
            // 
            this.btnTb8.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTb8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTb8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb8.Location = new System.Drawing.Point(65, 57);
            this.btnTb8.Name = "btnTb8";
            this.btnTb8.Size = new System.Drawing.Size(137, 112);
            this.btnTb8.TabIndex = 9;
            this.btnTb8.Text = "Table 7";
            this.btnTb8.UseVisualStyleBackColor = true;
            this.btnTb8.Visible = false;
            this.btnTb8.Click += new System.EventHandler(this.btnTb8_Click);
            // 
            // btnTb11
            // 
            this.btnTb11.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTb11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTb11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb11.Location = new System.Drawing.Point(707, 57);
            this.btnTb11.Name = "btnTb11";
            this.btnTb11.Size = new System.Drawing.Size(137, 112);
            this.btnTb11.TabIndex = 10;
            this.btnTb11.Text = "Table 10";
            this.btnTb11.UseVisualStyleBackColor = true;
            this.btnTb11.Visible = false;
            this.btnTb11.Click += new System.EventHandler(this.btnTb11_Click);
            // 
            // btnTb12
            // 
            this.btnTb12.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTb12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTb12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb12.Location = new System.Drawing.Point(707, 220);
            this.btnTb12.Name = "btnTb12";
            this.btnTb12.Size = new System.Drawing.Size(137, 112);
            this.btnTb12.TabIndex = 11;
            this.btnTb12.Text = "Table 11";
            this.btnTb12.UseVisualStyleBackColor = true;
            this.btnTb12.Visible = false;
            this.btnTb12.Click += new System.EventHandler(this.btnTb12_Click);
            // 
            // lbCred
            // 
            this.lbCred.AutoSize = true;
            this.lbCred.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbCred.Location = new System.Drawing.Point(339, 340);
            this.lbCred.Name = "lbCred";
            this.lbCred.Size = new System.Drawing.Size(223, 13);
            this.lbCred.TabIndex = 12;
            this.lbCred.Text = "Username: Coffee123    Password: admin123 ";
            // 
            // btnTb13
            // 
            this.btnTb13.BackgroundImage = global::CoffeeShop.Properties.Resources.s;
            this.btnTb13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTb13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTb13.Location = new System.Drawing.Point(704, 376);
            this.btnTb13.Name = "btnTb13";
            this.btnTb13.Size = new System.Drawing.Size(137, 112);
            this.btnTb13.TabIndex = 13;
            this.btnTb13.Text = "Table 12";
            this.btnTb13.UseVisualStyleBackColor = true;
            this.btnTb13.Visible = false;
            this.btnTb13.Click += new System.EventHandler(this.btnTb13_Click);
            // 
            // CoffeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CoffeeShop.Properties.Resources.Capture;
            this.ClientSize = new System.Drawing.Size(934, 541);
            this.Controls.Add(this.btnTb13);
            this.Controls.Add(this.lbCred);
            this.Controls.Add(this.btnTb12);
            this.Controls.Add(this.btnTb11);
            this.Controls.Add(this.btnTb8);
            this.Controls.Add(this.btnTb9);
            this.Controls.Add(this.btnTb10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTable3);
            this.Controls.Add(this.BtnTable2);
            this.Controls.Add(this.btnTable1);
            this.Controls.Add(this.gbLogin);
            this.Name = "CoffeShop";
            this.Text = "CoffeeShop";
            this.Load += new System.EventHandler(this.CoffeShop_Load);
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btnTable1;
        private System.Windows.Forms.Button BtnTable2;
        private System.Windows.Forms.Button btnTable3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox gbInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbRezervations;
        private System.Windows.Forms.TextBox tbActiveTables;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnTb10;
        private System.Windows.Forms.Button btnTb9;
        private System.Windows.Forms.Button btnTb8;
        private System.Windows.Forms.Button btnTb11;
        private System.Windows.Forms.Button btnTb12;
        private System.Windows.Forms.Label lbCred;
        private System.Windows.Forms.Button btnTb13;
    }
}

