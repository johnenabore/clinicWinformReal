using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINALPROJECT
{
    public partial class EMail : Form
    {
        public EMail()
        {
            InitializeComponent();
        }


        private void SendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string to = txtTo.Text;
                string subject = txtSubject.Text;
                string body = txtbodyy.Text;

                string Email = "johnenabore0312@gmail.com";
                string password = "john0312gabrielle";
                string Host = "smtp-mail.outlook.com";
                int port = 587;

                using (MailMessage mail = new MailMessage(Email, to, subject, body))
                {
                    using (SmtpClient smtp = new SmtpClient(Host, port))
                    {
                        foreach (var filename in openFileDialog2.FileNames)
                            if (File.Exists(filename))
                                mail.Attachments.Add(new Attachment(filename));
                        smtp.UseDefaultCredentials = false;
                        smtp.EnableSsl = true;
                        smtp.Credentials = new NetworkCredential(Email, password);
                        smtp.Send(mail);
                        MessageBox.Show("Email Sent Successfully", "Success");
                        txtTo.Text = "";
                        txtSubject.Text = "";
                        txtlabel.Text = "";
                        txtbodyy.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex}", "Error!");
            }
        }

        private void Attachments_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            foreach (var filename in openFileDialog2.FileNames)
            {
                txtlabel.Text = filename;
            }

        }
    }
}
