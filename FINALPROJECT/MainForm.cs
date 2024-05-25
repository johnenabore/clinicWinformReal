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
    public partial class MainForm : Form
    {
        studentsignup student;
        Contents contents;
        Home home;
        PrintDetails printDetails;
        registration registration;
        About about;
        EMail eMail;
        public MainForm()
        {
            InitializeComponent();

        }
        private void patient_Click(object sender, EventArgs e)
        {
            if (student == null)
            {
                student = new studentsignup();
                student.FormClosed += student_FormClosed;
                student.MdiParent = this;
                student.Dock = DockStyle.Fill;
                student.Show();
            }
            else
            {
                student.Activate();
            }
        }
        private void student_FormClosed(object sender, FormClosedEventArgs e)
        {
            student = null;
        }
        private void contents_FormClosed(object sender, FormClosedEventArgs e)
        {
            home = null;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();
                home.FormClosed += student_FormClosed;
                home.MdiParent = this;
                home.Show();
            }
            else
            {
                home.Activate();
            }
        }

        private void btnPatientRecords_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registration registration = new registration();
            registration.Show();
            this.Hide();
        }


        bool sidebarExpand = true;
        public void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sideBar.Width -= 10;
                if (sideBar.Width < 62)
                {
                    sidebarExpand = false;
                    SideBarTransition.Stop();
                }
            }
            else
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 250)
                {
                    sidebarExpand = true;
                    SideBarTransition.Stop();
                }
            }
        }

        private void btnHum_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (home == null)
            {
                home = new Home();
                home.FormClosed += student_FormClosed;
                home.MdiParent = this;
                home.Show();
            }
            else
            {
                home.Activate();
            }

        }

        private void Print_Click(object sender, EventArgs e)
        {
            if (printDetails == null)
            {
                printDetails = new PrintDetails();
                printDetails.FormClosed += student_FormClosed;
                printDetails.MdiParent = this;
                printDetails.Dock = DockStyle.Fill;
                printDetails.Show();
                
            }
            else
            {
                printDetails.Activate();
            }
        }

        private void AccountCenter_Click(object sender, EventArgs e)
        {
            if (registration == null)
            {
                registration = new registration();
                registration.FormClosed += student_FormClosed;
                registration.MdiParent = this;
                registration.Dock = DockStyle.Fill;
                registration.Show();
            }
            else
            {
                registration.Activate();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void Run()
        {
            this.Close();
        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new About();
                about.FormClosed += student_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (eMail == null)
            {
                eMail = new EMail();
                eMail.FormClosed += student_FormClosed;
                eMail.MdiParent = this;
                eMail.Dock = DockStyle.Fill;
                eMail.Show();
            }
            else
            {
                eMail.Activate();
            }
        }

        private void Contens_Click_1(object sender, EventArgs e)
        {
            if (contents == null)
            {
                contents = new Contents();
                contents.FormClosed += contents_FormClosed;
                contents.MdiParent = this;
                contents.Dock = DockStyle.Fill;
                contents.Show();
            }
            else
            {
                contents.Activate();
            }


        }
    }
}



