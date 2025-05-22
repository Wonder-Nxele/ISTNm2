    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using BCrypt.Net;

    namespace ISTNM2
    {
        public partial class LoginForm: Form
        {
            string connectionString = @"Server=146.230.177.46;Database=WstGrp16;User Id=WstGrp16;Password= tdsfs;";
            public LoginForm()
            {
                InitializeComponent();
            }

            private void LoginForm_Load(object sender, EventArgs e)
            {

            }

            private void registerButton_Click(object sender, EventArgs e)
            {
                new AddNewEmployee().Show();
                this.Hide();
            }

            private void label2_Click(object sender, EventArgs e)
            {

            }

            private void loginButton_Click(object sender, EventArgs e)
            {
                String user_email = email.Text.Trim();
                String user_password = password.Text.Trim();

                if (string.IsNullOrEmpty(user_email) || string.IsNullOrEmpty(user_password)) 
                {
                    MessageBox.Show("Fill in all the details!");
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        String query = "SELECT password FROM Employee WHERE email=@Email ";

                        using (SqlCommand qry = new SqlCommand(query, conn)) 
                        {
                        qry.Parameters.AddWithValue("@Email", user_email);

                        object result = qry.ExecuteScalar();

                        if (result != null)
                        {
                            string hashedPassword = result.ToString();

                            if (BCrypt.Net.BCrypt.Verify(user_password, hashedPassword))
                            {
                                if (user_email.Equals("nkonzon123@gmail.com"))
                                {
                                    new AddNewEmployee().Show();
                                }
                                else { new AddNewEmployee().Show(); }
                                
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found.");
                        }

                    }
                }
                    catch (Exception ex) { MessageBox.Show(ex.ToString()); }
                }
            
            }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void showPasswordCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheck.Checked)
            {
                password.UseSystemPasswordChar = false;
            }
        }
    }
    }
