namespace FINALPROJECT
{
    partial class EMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EMail));
            label1 = new Label();
            txtTo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtSubject = new TextBox();
            SendEmail = new PictureBox();
            openFileDialog2 = new OpenFileDialog();
            txtlabel = new Label();
            panel1 = new Panel();
            label7 = new Label();
            Attachments = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            txtbodyy = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)SendEmail).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Attachments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(136, 49);
            label1.Name = "label1";
            label1.Size = new Size(136, 27);
            label1.TabIndex = 0;
            label1.Text = "Send Email";
            // 
            // txtTo
            // 
            txtTo.BackColor = Color.White;
            txtTo.BorderStyle = BorderStyle.None;
            txtTo.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtTo.Location = new Point(136, 310);
            txtTo.Multiline = true;
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(621, 34);
            txtTo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkGray;
            label2.Location = new Point(84, 314);
            label2.Name = "label2";
            label2.Size = new Size(46, 27);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkGray;
            label3.Location = new Point(26, 412);
            label3.Name = "label3";
            label3.Size = new Size(104, 27);
            label3.TabIndex = 4;
            label3.Text = "Subject:";
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.White;
            txtSubject.BorderStyle = BorderStyle.None;
            txtSubject.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubject.Location = new Point(136, 412);
            txtSubject.Multiline = true;
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(621, 34);
            txtSubject.TabIndex = 3;
            // 
            // SendEmail
            // 
            SendEmail.Image = (Image)resources.GetObject("SendEmail.Image");
            SendEmail.Location = new Point(1293, 734);
            SendEmail.Name = "SendEmail";
            SendEmail.Size = new Size(64, 54);
            SendEmail.SizeMode = PictureBoxSizeMode.StretchImage;
            SendEmail.TabIndex = 7;
            SendEmail.TabStop = false;
            SendEmail.Click += SendEmail_Click;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog1";
            // 
            // txtlabel
            // 
            txtlabel.AutoSize = true;
            txtlabel.Location = new Point(863, 420);
            txtlabel.Name = "txtlabel";
            txtlabel.Size = new Size(0, 19);
            txtlabel.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(Attachments);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(txtbodyy);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(SendEmail);
            panel1.Controls.Add(txtlabel);
            panel1.Controls.Add(txtSubject);
            panel1.Controls.Add(txtTo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            panel1.ForeColor = Color.DimGray;
            panel1.Location = new Point(237, 95);
            panel1.Name = "panel1";
            panel1.Size = new Size(1387, 913);
            panel1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.WhiteSmoke;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(922, 750);
            label7.Name = "label7";
            label7.Size = new Size(198, 27);
            label7.TabIndex = 22;
            label7.Text = "Add Attachment:";
            // 
            // Attachments
            // 
            Attachments.Image = (Image)resources.GetObject("Attachments.Image");
            Attachments.Location = new Point(1126, 734);
            Attachments.Name = "Attachments";
            Attachments.Size = new Size(65, 54);
            Attachments.SizeMode = PictureBoxSizeMode.StretchImage;
            Attachments.TabIndex = 21;
            Attachments.TabStop = false;
            Attachments.Click += Attachments_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.WhiteSmoke;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkGray;
            label6.Location = new Point(1211, 750);
            label6.Name = "label6";
            label6.Size = new Size(76, 27);
            label6.TabIndex = 20;
            label6.Text = "Send:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(55, 524);
            label5.Name = "label5";
            label5.Size = new Size(75, 27);
            label5.TabIndex = 19;
            label5.Text = "Body:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(84, 476);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(1273, 10);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(84, 372);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1273, 10);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // txtbodyy
            // 
            txtbodyy.BackColor = Color.White;
            txtbodyy.BorderStyle = BorderStyle.None;
            txtbodyy.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtbodyy.Location = new Point(136, 524);
            txtbodyy.Multiline = true;
            txtbodyy.Name = "txtbodyy";
            txtbodyy.Size = new Size(1161, 113);
            txtbodyy.TabIndex = 16;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 238);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1302, 28);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(84, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DarkGray;
            label4.Location = new Point(188, 174);
            label4.Name = "label4";
            label4.Size = new Size(293, 27);
            label4.TabIndex = 11;
            label4.Text = "LSPUClinic@lspu.edu.ph";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1387, 114);
            panel2.TabIndex = 10;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(26, 29);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(88, 65);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 23;
            pictureBox5.TabStop = false;
            // 
            // EMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1836, 982);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EMail";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "EMail";
            ((System.ComponentModel.ISupportInitialize)SendEmail).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Attachments).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTo;
        private Label label2;
        private Label label3;
        private TextBox txtSubject;
        private PictureBox SendEmail;
        private OpenFileDialog openFileDialog2;
        private Label txtlabel;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label4;
        private TextBox txtbodyy;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label5;
        private PictureBox Attachments;
        private Label label7;
        private PictureBox pictureBox5;
    }
}