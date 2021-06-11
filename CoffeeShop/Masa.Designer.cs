namespace CoffeeShop
{
    partial class Masa
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
            this.labelName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tbRezName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReserve = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.gbDrinks = new System.Windows.Forms.GroupBox();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCaffee = new System.Windows.Forms.ListBox();
            this.lbSaur = new System.Windows.Forms.ListBox();
            this.lbCoctails = new System.Windows.Forms.ListBox();
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.gbDrinks.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(34, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Table";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(245, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESERVE";
            // 
            // tbRezName
            // 
            this.tbRezName.Location = new System.Drawing.Point(94, 50);
            this.tbRezName.Name = "tbRezName";
            this.tbRezName.Size = new System.Drawing.Size(116, 20);
            this.tbRezName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "date/time";
            // 
            // btnReserve
            // 
            this.btnReserve.BackColor = System.Drawing.Color.LightGreen;
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.Location = new System.Drawing.Point(469, 48);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Size = new System.Drawing.Size(88, 23);
            this.btnReserve.TabIndex = 6;
            this.btnReserve.Text = "Reserve Table";
            this.btnReserve.UseVisualStyleBackColor = false;
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Yellow;
            this.btnNew.Location = new System.Drawing.Point(231, 115);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(121, 23);
            this.btnNew.TabIndex = 7;
            this.btnNew.Text = "New Client Check";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // gbDrinks
            // 
            this.gbDrinks.Controls.Add(this.btnAddDrink);
            this.gbDrinks.Controls.Add(this.comboBox1);
            this.gbDrinks.Controls.Add(this.label6);
            this.gbDrinks.Controls.Add(this.label5);
            this.gbDrinks.Controls.Add(this.label4);
            this.gbDrinks.Controls.Add(this.lbCaffee);
            this.gbDrinks.Controls.Add(this.lbSaur);
            this.gbDrinks.Controls.Add(this.lbCoctails);
            this.gbDrinks.Location = new System.Drawing.Point(16, 144);
            this.gbDrinks.Name = "gbDrinks";
            this.gbDrinks.Size = new System.Drawing.Size(541, 154);
            this.gbDrinks.TabIndex = 8;
            this.gbDrinks.TabStop = false;
            this.gbDrinks.Text = "Drinks";
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Location = new System.Drawing.Point(21, 95);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(80, 36);
            this.btnAddDrink.TabIndex = 7;
            this.btnAddDrink.Text = "Add Drink";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Coctails",
            "Soft Drinks",
            "Caffee"});
            this.comboBox1.Location = new System.Drawing.Point(21, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Caffee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Soft Drinks";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(150, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coctails";
            // 
            // lbCaffee
            // 
            this.lbCaffee.Enabled = false;
            this.lbCaffee.FormattingEnabled = true;
            this.lbCaffee.Location = new System.Drawing.Point(399, 36);
            this.lbCaffee.Name = "lbCaffee";
            this.lbCaffee.Size = new System.Drawing.Size(120, 95);
            this.lbCaffee.TabIndex = 2;
            // 
            // lbSaur
            // 
            this.lbSaur.Enabled = false;
            this.lbSaur.FormattingEnabled = true;
            this.lbSaur.Location = new System.Drawing.Point(258, 36);
            this.lbSaur.Name = "lbSaur";
            this.lbSaur.Size = new System.Drawing.Size(120, 95);
            this.lbSaur.TabIndex = 1;
            // 
            // lbCoctails
            // 
            this.lbCoctails.Enabled = false;
            this.lbCoctails.FormattingEnabled = true;
            this.lbCoctails.Location = new System.Drawing.Point(118, 36);
            this.lbCoctails.Name = "lbCoctails";
            this.lbCoctails.Size = new System.Drawing.Size(120, 95);
            this.lbCoctails.TabIndex = 0;
            // 
            // tbMoney
            // 
            this.tbMoney.Enabled = false;
            this.tbMoney.Location = new System.Drawing.Point(16, 317);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(100, 20);
            this.tbMoney.TabIndex = 9;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(482, 315);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Pay Check";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Check";
            // 
            // Masa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(583, 349);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.tbMoney);
            this.Controls.Add(this.gbDrinks);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnReserve);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbRezName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelName);
            this.Name = "Masa";
            this.Text = "Masa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Masa_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Masa_FormClosed);
            this.Load += new System.EventHandler(this.Masa_Load);
            this.gbDrinks.ResumeLayout(false);
            this.gbDrinks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRezName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.GroupBox gbDrinks;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbCaffee;
        private System.Windows.Forms.ListBox lbSaur;
        private System.Windows.Forms.ListBox lbCoctails;
        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label label7;
    }
}