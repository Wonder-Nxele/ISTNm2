using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Runtime.InteropServices;

namespace ISTNM2
{
    public partial class AddNewEmployee: Form
    {
        string connectionString = @"";
        [DllImport("kernel32.dll")]
        static extern bool AllocConsole();
        public AddNewEmployee()
        {
            InitializeComponent();
            AllocConsole();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // Get values from form controls
            string e_name = name.Text.Trim();
            string e_surname = surname.Text.Trim();
            string e_email = email.Text.Trim();
            string e_phone = phone.Text.Trim();
            string e_password = password.Text;
            DateTime dob = birthDate.Value;
            String e_type = "";

            if (kitchenStaff.Checked) { e_type = "KitchenStaff"; } 
            
            if(cashier.Checked){ e_type = "Cashier"; }

            if (manager.Checked) { e_type = "Manager"; }

            // Empty field check
            if (string.IsNullOrWhiteSpace(e_name) ||
                string.IsNullOrWhiteSpace(e_surname) ||
                string.IsNullOrWhiteSpace(e_email) ||
                string.IsNullOrWhiteSpace(e_phone) ||
                string.IsNullOrWhiteSpace(e_password))
            {
                MessageBox.Show("Make sure all the fields are filled.");
                return;
            }

            // Name & Surname: only letters
            if (!e_name.All(char.IsLetter))
            {
                MessageBox.Show("Name must only contain letters.");
                return;
            }

            if (!e_surname.All(char.IsLetter))
            {
                MessageBox.Show("Surname must only contain letters.");
                return;
            }

            // Email format check
            if (!e_email.Contains("@") || !e_email.Contains("."))
            {
                MessageBox.Show("Incorrect email format.");
                return;
            }

            // Phone number: must be digits only, at least 10 digits
            if (!e_phone.All(char.IsDigit) || e_phone.Length < 10)
            {
                MessageBox.Show("Phone number must be at least 10 digits and contain digits only.");
                return;
            }

            if (e_password.Length < 6 ||
            !e_password.Any(char.IsDigit) ||
            !e_password.Any(c => "!@#$%^&*()_+-=[]{}|;:',.<>/?`~".Contains(c)))
            {
                MessageBox.Show("Password must be at least 6 characters long, contain at least one digit, and one special character.");
                return;
            }


            using (SqlConnection conn = new SqlConnection(this.connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"INSERT INTO Employee 
                             (name, surname, email, password, phone, employee_type, employee_status, created_at, date_of_birth)
                             VALUES 
                             (@name, @surname, @email, @password, @phone, @type, @status, @created_at, @dob)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", e_name);
                        cmd.Parameters.AddWithValue("@surname", e_surname);
                        cmd.Parameters.AddWithValue("@email", e_email);
                        cmd.Parameters.AddWithValue("@password", HashPassword(e_password));
                        cmd.Parameters.AddWithValue("@phone", e_phone);
                        cmd.Parameters.AddWithValue("@type",e_type);
                        cmd.Parameters.AddWithValue("@status", "Active");
                        cmd.Parameters.AddWithValue("@created_at", DateTime.Now);
                        cmd.Parameters.AddWithValue("@dob", dob);

                        int result = cmd.ExecuteNonQuery();
                        if (result > 0)
                        {
                            new LoggedInForm().Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add employee.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
