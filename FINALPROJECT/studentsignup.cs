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
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Imaging;
using System.Windows.Forms.VisualStyles;
using MySql;

namespace FINALPROJECT
{
    public partial class studentsignup : Form
    {

        public studentsignup()
        {
            InitializeComponent();
        }

        private void stidentsignup_load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtLname.Height = 50;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                imagelocation = dialog.FileName;

                pictureBox1.ImageLocation = imagelocation;
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbfemale.Checked = false)
            {
                rbMale.Checked = true;
            }
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked = false)
            {
                rbfemale.Checked = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int user;
            bool validage = false;
            bool validID = false;
            validage = int.TryParse(txtAge.Text, out user);
            validID = int.TryParse(txtStudentID.Text, out user);


            if (!validage)
            {
                MessageBox.Show("The age must be an integer", "Oppss!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!validID && !txtStudentID.Text.Contains("-"))
            {
                MessageBox.Show("The student ID must be in the correct format", "Oppss!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtAddress.Text == "" || txtAge.Text == "" || txtbxEmail.Text == "" || txtComplaint.Text == "" || txtFname.Text == "" || txtLname.Text == "" || txtMname.Text == "" || txtStudentID.Text == "" || cbYEar.SelectedIndex < 0 || cbMonth.SelectedIndex < 0 || cbDay.SelectedIndex < 0)
            {
                MessageBox.Show("You must fill out all of the credentials", "Oppss!");
                txtFname.Focus();
            }
            else if (rbfemale.Checked == false && rbMale.Checked == false)
            {
                MessageBox.Show("You must fill out all of the credentials", "Oppss!");
                txtFname.Focus();
            }
            else
            {
                byte[] imageData;
                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                    imageData = ms.ToArray();
                }
                string server = "localhost";
                string uid = "root";
                string password = "johnenabore0312";
                string database = "lspudb";

                string constring = "server=" + server + ";uid=" + uid + ";pwd=" + password + ";database=" + database;
                MySqlConnection con = new MySqlConnection(constring);
                con.Open();

                string gender = rbfemale.Checked ? "Male" : "Female";
                string query = "INSERT INTO tblstudents (Image, Email, FirstName, LastName, StudentID, dateofAdmit, gender, MiddleName, Age, Address, Complaint) VALUES (@Image, @Email, @FirstName, @LastName, @StudentID, @dateofAdmit, @Gender, @MiddleName, @Age, @Address, @Complaint)";

                MySqlCommand cmd = new MySqlCommand(query, con);
                int year = Convert.ToInt32(cbYEar.SelectedItem.ToString());
                int month = Convert.ToInt32(cbMonth.SelectedItem.ToString());
                int day = Convert.ToInt32(cbDay.SelectedItem.ToString());

                string doa = year + "/" + month + "/" + day;

                cmd.Parameters.AddWithValue("@Image", imageData);
                cmd.Parameters.AddWithValue("@Email", txtbxEmail.Text);
                cmd.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txtMname.Text);
                cmd.Parameters.AddWithValue("@StudentID", txtStudentID.Text);
                cmd.Parameters.AddWithValue("@dateofAdmit", doa);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@Complaint", txtComplaint.Text);

                int i = cmd.ExecuteNonQuery();

                if (i > 0)
                {
                    MessageBox.Show("Data Successfully Inserted");
                }
                else
                {
                    MessageBox.Show("Failed to Insert Data");
                }

                con.Close();

            }
        }

    }
}
