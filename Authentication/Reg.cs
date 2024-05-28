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

namespace Authentication
{
    public partial class Reg : Form
    {
        private static string connectionString = @"Data Source=(localdb)\Local;Initial Catalog=employeedb;Integrated Security=True;";
        public Reg()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Username.Text = string.Empty;
            Password.Text = string.Empty;
            ConfirmPassword.Text = string.Empty;
        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                Password.PasswordChar = '\0';
                ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
                ConfirmPassword.PasswordChar = '*';
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(ConfirmPassword.Text))
            {
                MessageBox.Show("Fill in all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Password.Text == ConfirmPassword.Text)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        // Check if the username already exists
                        string checkQuery = "SELECT COUNT(*) FROM reg WHERE username = @username";
                        SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                        checkCmd.Parameters.AddWithValue("@username", Username.Text);
                        int userCount = (int)checkCmd.ExecuteScalar();

                        if (userCount > 0)
                        {
                            MessageBox.Show("Username is already taken. Please choose a different username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            // Proceed with registration
                            string query = "INSERT INTO reg (username, password) VALUES (@username, @password)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@username", Username.Text);
                            cmd.Parameters.AddWithValue("@password", Password.Text);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Registered Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Navigate back to the login screen after registering successfully
                                Form1 form1 = new Form1();
                                form1.ShowDialog();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password and confirm password don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}