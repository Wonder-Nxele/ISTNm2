namespace ISTNM2
{
    partial class AddNewEmployee
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
            this.submitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.kitchenStaff = new System.Windows.Forms.RadioButton();
            this.manager = new System.Windows.Forms.RadioButton();
            this.cashier = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkGray;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Blue;
            this.submitButton.Location = new System.Drawing.Point(224, 311);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 30);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.Blue;
            this.clearButton.Location = new System.Drawing.Point(369, 311);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 30);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Blue;
            this.name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.name.Location = new System.Drawing.Point(338, 76);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(106, 20);
            this.name.TabIndex = 2;
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.Blue;
            this.surname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surname.Location = new System.Drawing.Point(338, 104);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(106, 20);
            this.surname.TabIndex = 3;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Blue;
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(338, 132);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(106, 20);
            this.email.TabIndex = 4;
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Blue;
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(338, 164);
            this.password.Name = "password";
            this.password.PasswordChar = '_';
            this.password.Size = new System.Drawing.Size(106, 20);
            this.password.TabIndex = 5;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.Blue;
            this.phone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.phone.Location = new System.Drawing.Point(339, 200);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(105, 20);
            this.phone.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(225, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(225, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(225, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(225, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(227, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "CellPhone No:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(138, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(398, 57);
            this.label6.TabIndex = 12;
            this.label6.Text = "Add A New Staff Member";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label7.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(160, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Type:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kitchenStaff
            // 
            this.kitchenStaff.AutoSize = true;
            this.kitchenStaff.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitchenStaff.ForeColor = System.Drawing.Color.Blue;
            this.kitchenStaff.Location = new System.Drawing.Point(235, 259);
            this.kitchenStaff.Name = "kitchenStaff";
            this.kitchenStaff.Size = new System.Drawing.Size(106, 29);
            this.kitchenStaff.TabIndex = 14;
            this.kitchenStaff.TabStop = true;
            this.kitchenStaff.Text = "Kitchen Staff";
            this.kitchenStaff.UseVisualStyleBackColor = true;
            // 
            // manager
            // 
            this.manager.AutoSize = true;
            this.manager.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manager.ForeColor = System.Drawing.Color.Blue;
            this.manager.Location = new System.Drawing.Point(456, 259);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(81, 29);
            this.manager.TabIndex = 15;
            this.manager.TabStop = true;
            this.manager.Text = "Manager";
            this.manager.UseVisualStyleBackColor = true;
            // 
            // cashier
            // 
            this.cashier.AutoSize = true;
            this.cashier.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashier.ForeColor = System.Drawing.Color.Blue;
            this.cashier.Location = new System.Drawing.Point(355, 259);
            this.cashier.Name = "cashier";
            this.cashier.Size = new System.Drawing.Size(73, 29);
            this.cashier.TabIndex = 16;
            this.cashier.TabStop = true;
            this.cashier.Text = "Cashier";
            this.cashier.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label8.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(194, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Date Of Birth:";
            // 
            // birthDate
            // 
            this.birthDate.CalendarFont = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDate.CalendarForeColor = System.Drawing.Color.Blue;
            this.birthDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.birthDate.CalendarTitleBackColor = System.Drawing.Color.Blue;
            this.birthDate.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.birthDate.Location = new System.Drawing.Point(303, 233);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(200, 20);
            this.birthDate.TabIndex = 19;
            this.birthDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddNewEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(724, 406);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cashier);
            this.Controls.Add(this.manager);
            this.Controls.Add(this.kitchenStaff);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.submitButton);
            this.Name = "AddNewEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton kitchenStaff;
        private System.Windows.Forms.RadioButton manager;
        private System.Windows.Forms.RadioButton cashier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker birthDate;
    }
}

