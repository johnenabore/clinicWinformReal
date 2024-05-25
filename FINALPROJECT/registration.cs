using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECT
{
    public partial class registration : Form
    {
        public string UserInput { get; set; }
        string[] Lowercase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z".ToLower() };
        string[] Uppercase = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        string[] SpecialCharacters = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "[", "]", "{", "}", "|", ";", ":", "'", "\"", "<", ">", ",", ".", "?", "/", "\\" };
        string[] Numbers = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string PasswordPrompt { get; set; }
        public registration()
        {
            InitializeComponent();
        }
        private void showPasswordRegister_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordRegister.Checked)
            {
                txtPasswordregister.UseSystemPasswordChar = true;
                txtConfirmPassword.UseSystemPasswordChar = true;
                txtcurrent.UseSystemPasswordChar=true;
            }
            else
            {
                txtPasswordregister.UseSystemPasswordChar = false;
                txtConfirmPassword.UseSystemPasswordChar = false;
                txtcurrent.UseSystemPasswordChar=false;
            }
        }



        public void btnLogin_Click_1(object sender, EventArgs e)
        {
            bool loop = false;
            bool loop2 = false;
            bool loop3 = false;
            bool loop4 = false;


            if (txtPasswordregister.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password and confirm password is not the same", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            if (txtConfirmPassword.Text == txtPasswordregister.Text)
            {
                foreach (var a in Lowercase)
                {
                    if (txtConfirmPassword.Text.Contains(a))
                    {
                        loop = true;
                        break;
                    }
                }
                foreach (var b in Uppercase)
                {
                    if (txtConfirmPassword.Text.Contains(b))
                    {
                        loop2 = true;
                        break;
                    }
                }
                foreach (var c in SpecialCharacters)
                {
                    if (txtConfirmPassword.Text.Contains(c))
                    {
                        loop3 = true;
                        break;
                    }
                }
                foreach (var d in Numbers)
                {
                    if (txtConfirmPassword.Text.Contains(d))
                    {
                        loop4 = true;
                        break;
                    }
                }
                if (!loop || !loop2 || !loop3 || !loop4)
                {
                    MessageBox.Show("The password must contain at least one uppercase, lowercase, special character and a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtConfirmPassword.Focus();
                }
                else
                {
                    string server = "localhost";
                    string uid = "root";
                    string password = "johnenabore0312";
                    string database = "passworddtbs";

                    string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;

                        using (MySqlConnection con = new MySqlConnection(constring))
                        {
                            string query = "SELECT password FROM tblpassword";
                            MySqlCommand cmd = new MySqlCommand(query, con);
                            con.Open();
                            string storedPassword = cmd.ExecuteScalar()?.ToString();



                        // Check if the entered password already exists in the table
                        string checkQuery = "SELECT COUNT(*) FROM tblpassword WHERE password = @password";
                        MySqlCommand checkCmd = new MySqlCommand(checkQuery, con);
                        checkCmd.Parameters.AddWithValue("@password", txtConfirmPassword.Text);
                        int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                        if (storedPassword != null && storedPassword != txtcurrent.Text)
                        {
                            MessageBox.Show("The entered password does not match in the current password", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            if (count == 0) // Password does not exist, so insert the new password
                            {
                                // Delete the previous password, if it exists
                                string deleteQuery = "DELETE FROM tblpassword";
                                MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, con);
                                int deletedRows = deleteCmd.ExecuteNonQuery();

                                // Insert the new password
                                string insertQuery = "INSERT INTO tblpassword (password) VALUES (@password)";
                                MySqlCommand insertCmd = new MySqlCommand(insertQuery, con);
                                insertCmd.Parameters.AddWithValue("@password", txtConfirmPassword.Text);

                                int i = insertCmd.ExecuteNonQuery();

                                if (i > 0)
                                {
                                    MessageBox.Show("The application needs a restart, Press okay to Continue", "Password Successfully Changed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Application.Exit();
                                }
                                else
                                {
                                    MessageBox.Show("Failed to Insert Data");
                                }
                            }
                            else // Password already exists
                            {
                                MessageBox.Show("The entered password already exists in the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }

            }
        }
    }
}

