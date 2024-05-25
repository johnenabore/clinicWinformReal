using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace FINALPROJECT
{

    public partial class logInPage : Form
    {


        public logInPage()
        {
            InitializeComponent();
        }
        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void logInPage_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(140, 255, 255, 255);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ConfirmPage ConfirmPage = new ConfirmPage();

            string enteredPassword = txtPassword.Text;

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


                if (storedPassword != null && storedPassword == enteredPassword)
                {
                    ConfirmPage.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid password. Please try again.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

    }
}