using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FINALPROJECT
{
    public partial class PrintRESETA : Form
    {
        public PrintRESETA()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }
        Bitmap bitmap;
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            // Create a panel
            Panel panel = new Panel();

            // Set the size of the panel
            panel.Size = new Size(1000, 1000);

            // Adjust the location of the panel
            // For example, let's move it 50 pixels up and 100 pixels to the right from its default position
            panel.Location = new Point(panel.Location.X + 260, panel.Location.Y - 55); // Adjust the Y coordinate to move the panel upwards

            // Adjust the height of the panel to keep it at the same position but smaller
            panel.Height += 55; // Increase the height of the panel to keep it at the same position but smaller

            // Add the panel to the form's controls
            this.Controls.Add(panel);

            // Create graphics object for the panel
            Graphics graphics = panel.CreateGraphics();

            // Get the size of the form's client area
            Size size = this.ClientSize;

            // Create a bitmap to capture the screenshot
            bitmap = new Bitmap(size.Width, size.Height, graphics);

            // Create graphics object from the bitmap
            graphics = Graphics.FromImage(bitmap);

            // Get the location of the panel relative to the screen
            Point point = PointToScreen(panel.Location);

            // Copy the contents of the screen to the bitmap
            graphics.CopyFromScreen(point.X, point.Y, 0, 0, size);

            // Show print preview dialog
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        public void receiver(string f, string m, string l,string sex, int year, int month, int day, string date,string Address, string age, string gender, string brand1, string label, string signa1, string brand2, string label2, string sign2, string brand3, string label3, string signa3)
        {
            lblName.Text = f + " " + m + " " + l;
            lblSex.Text = sex;
            lblDate.Text = year.ToString() + " /" + month.ToString() + "/" + day.ToString();
            lblDate.Text = date;
            lblAddress.Text = Address;
            lblAge.Text = age;
            lblSex.Text = gender;
            lblgnrctrm1.Text = brand1;
            lblbrndnm1.Text = label.ToUpper();
            lblsig1.Text = signa1;
            lblgnrctrm2.Text = brand2;
            lblbrndnm11.Text = label2.ToUpper();
            lblsig2.Text = sign2;
            lblgnrctrm3.Text = brand3;
            lblbrndnm3.Text = label3.ToUpper();
            lblsig3.Text = signa3;
        }
        public void receiver2(string f, string m, string l, string add, string age, string sex, string doa, string brand1, string label, string signa1, string brand2, string label2, string sign2, string brand3, string label3, string signa3)
        {
            lblName.Text = f + " " + m + " " + l;
            lblSex.Text = sex;
            lblDate.Text = doa;
            lblAddress.Text = add;
            lblAge.Text = age;
            lblgnrctrm1.Text = brand1;
            lblbrndnm1.Text = label.ToUpper();
            lblsig1.Text = signa1;
            lblgnrctrm2.Text = brand2;
            lblbrndnm11.Text = label2.ToUpper();
            lblsig2.Text = sign2;
            lblgnrctrm3.Text = brand3;
            lblbrndnm3.Text = label3.ToUpper();
            lblsig3.Text = signa3;

        }

        private void lblSex_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void PrintRESETA_Load(object sender, EventArgs e)
        {

        }
    }
}