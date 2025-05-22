namespace ISTNM2
{
    partial class LoginForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.showPassword = new System.Windows.Forms.Label();
            this.showPasswordCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(219, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(219, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Password:";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.Blue;
            this.password.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.password.Location = new System.Drawing.Point(320, 156);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(155, 20);
            this.password.TabIndex = 12;
            this.password.UseSystemPasswordChar = true;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Blue;
            this.email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.email.Location = new System.Drawing.Point(320, 116);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(155, 20);
            this.email.TabIndex = 13;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.DarkGray;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Blue;
            this.loginButton.Location = new System.Drawing.Point(312, 213);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 30);
            this.loginButton.TabIndex = 14;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // showPassword
            // 
            this.showPassword.AutoSize = true;
            this.showPassword.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.showPassword.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.Blue;
            this.showPassword.Location = new System.Drawing.Point(282, 185);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(103, 25);
            this.showPassword.TabIndex = 16;
            this.showPassword.Text = "Show Password:";
            // 
            // showPasswordCheck
            // 
            this.showPasswordCheck.AutoSize = true;
            this.showPasswordCheck.BackColor = System.Drawing.Color.Blue;
            this.showPasswordCheck.Location = new System.Drawing.Point(392, 190);
            this.showPasswordCheck.Name = "showPasswordCheck";
            this.showPasswordCheck.Size = new System.Drawing.Size(15, 14);
            this.showPasswordCheck.TabIndex = 17;
            this.showPasswordCheck.UseVisualStyleBackColor = false;
            this.showPasswordCheck.CheckedChanged += new System.EventHandler(this.showPasswordCheck_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(125, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(452, 57);
            this.label2.TabIndex = 18;
            this.label2.Text = "Welcome to Sbo\'s Kota House";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(718, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showPasswordCheck);
            this.Controls.Add(this.showPassword);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label showPassword;
        private System.Windows.Forms.CheckBox showPasswordCheck;
        private System.Windows.Forms.Label label2;
    }
}