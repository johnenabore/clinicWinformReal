using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECT
{
    public partial class PrintDetails : Form
    {
        PrintRESETA printRESETA;
        public PrintDetails()
        {
            InitializeComponent();
        }




        private void btnPrint_Click(object sender, EventArgs e)
        {
            printRESETA = new PrintRESETA();

            if (txtBoxFname.Text == "" || txtBoxGender.Text == "" || txtbxAge.Text == "" || txtBoxAddress.Text == "" || Year.SelectedIndex < 0 || Month.SelectedIndex < 0 || Day.SelectedIndex < 0 || txtBoxGender.SelectedIndex < 0)
            {
                MessageBox.Show("You must fill out all the credentials", "Opps!");
                txtBoxFname.Focus();
            }
            else
            {
                int yearss = Convert.ToInt32(Year.SelectedItem.ToString());
                int month = Convert.ToInt32(Month.SelectedItem.ToString());
                int day = Convert.ToInt32(Day.SelectedItem.ToString());
                string gend = txtBoxGender.SelectedItem.ToString();

                printRESETA.receiver(txtBoxFname.Text, textBoxMname.Text, textBoxLname.Text, labelsex.Text, yearss, month, day, date.Text, txtBoxAddress.Text, txtbxAge.Text, gend, txtLabel1.Text, txtBrandName1.Text, txtSigna1.Text, txtLabel2.Text, txtBrandName2.Text, txtSigna2.Text, txtLabel3.Text, txtBrandNm3.Text, txtSgna3.Text);
                printna.Enabled = false;
                backna.Enabled = false;
                printRESETA.ShowDialog();
            }
        }

        private void PrintDetails_Load(object sender, EventArgs e)
        {

        }
        public void receiver(string f, string m, string l, string add, string age, string sex, string doa)
        {
            txtBoxFname.Text = f;
            textBoxMname.Text = m;
            textBoxLname.Text = l;
            date.Text = doa;
            txtBoxAddress.Text = add;
            labelsex.Text = sex;
            txtbxAge.Text = age;
            printna.Enabled = true;
            backna.Enabled = true;
            btnPrint.Enabled = false;
            able.Text = "Disabled";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            printRESETA = new PrintRESETA();

            if (txtBoxFname.Text == "" || txtBoxGender.Text == "" || txtbxAge.Text == "" || txtBoxAddress.Text == "")
            {
                MessageBox.Show("You must fill out all the credentials", "Opps!");
                txtBoxFname.Focus();
            }
            else
            {
                printRESETA.receiver2(txtBoxFname.Text, textBoxMname.Text, textBoxLname.Text, txtBoxAddress.Text, txtbxAge.Text, labelsex.Text, date.Text, txtLabel1.Text, txtBrandName1.Text, txtSigna1.Text, txtLabel2.Text, txtBrandName2.Text, txtSigna2.Text, txtLabel3.Text, txtBrandNm3.Text, txtSgna3.Text);
                printRESETA.ShowDialog();
            }

        }
    }
}
