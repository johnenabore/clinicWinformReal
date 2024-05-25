namespace FINALPROJECT
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel3 = new Panel();
            btnPatient = new Button();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            patient = new Button();
            panel1 = new Panel();
            pictureContents = new PictureBox();
            Contens = new Button();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            AccountCenter = new Button();
            sideBar = new FlowLayoutPanel();
            panel5 = new Panel();
            btnHum = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox7 = new PictureBox();
            panel6 = new Panel();
            pictureBox6 = new PictureBox();
            Print = new Button();
            panel8 = new Panel();
            pictureBox8 = new PictureBox();
            button3 = new Button();
            panel9 = new Panel();
            pictureBox9 = new PictureBox();
            button4 = new Button();
            panel7 = new Panel();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            SideBarTransition = new System.Windows.Forms.Timer(components);
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureContents).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            sideBar.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.Controls.Add(btnPatient);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(0, 50);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 124);
            panel3.TabIndex = 3;
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.DodgerBlue;
            btnPatient.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatient.Image = (Image)resources.GetObject("btnPatient.Image");
            btnPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatient.Location = new Point(0, 267);
            btnPatient.Margin = new Padding(0);
            btnPatient.Name = "btnPatient";
            btnPatient.Padding = new Padding(15, 0, 0, 0);
            btnPatient.Size = new Size(298, 131);
            btnPatient.TabIndex = 2;
            btnPatient.Text = "                     Patient";
            btnPatient.TextAlign = ContentAlignment.MiddleLeft;
            btnPatient.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.InactiveBorder;
            label1.Location = new Point(-8, 93);
            label1.Name = "label1";
            label1.Padding = new Padding(75, 0, 0, 0);
            label1.Size = new Size(197, 20);
            label1.TabIndex = 3;
            label1.Text = "Welcome, Admin";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(50, 0, 0, 0);
            pictureBox4.Size = new Size(247, 87);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 2;
            pictureBox4.TabStop = false;
            // 
            // patient
            // 
            patient.BackColor = Color.Navy;
            patient.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            patient.ForeColor = SystemColors.InactiveBorder;
            patient.ImageAlign = ContentAlignment.MiddleLeft;
            patient.Location = new Point(-9, -6);
            patient.Margin = new Padding(0);
            patient.Name = "patient";
            patient.Padding = new Padding(15, 0, 0, 0);
            patient.Size = new Size(353, 146);
            patient.TabIndex = 2;
            patient.Text = "                 Patient";
            patient.TextAlign = ContentAlignment.MiddleLeft;
            patient.UseVisualStyleBackColor = false;
            patient.Click += patient_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureContents);
            panel1.Controls.Add(Contens);
            panel1.Location = new Point(3, 294);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 125);
            panel1.TabIndex = 6;
            // 
            // pictureContents
            // 
            pictureContents.Image = (Image)resources.GetObject("pictureContents.Image");
            pictureContents.Location = new Point(7, 47);
            pictureContents.Name = "pictureContents";
            pictureContents.Size = new Size(37, 36);
            pictureContents.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureContents.TabIndex = 6;
            pictureContents.TabStop = false;
            // 
            // Contens
            // 
            Contens.BackColor = Color.Navy;
            Contens.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Contens.ForeColor = SystemColors.InactiveBorder;
            Contens.ImageAlign = ContentAlignment.MiddleLeft;
            Contens.Location = new Point(-22, -7);
            Contens.Name = "Contens";
            Contens.Size = new Size(295, 146);
            Contens.TabIndex = 7;
            Contens.Text = "  Patient Records";
            Contens.UseVisualStyleBackColor = false;
            Contens.Click += Contens_Click_1;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(AccountCenter);
            panel4.Location = new Point(3, 425);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 132);
            panel4.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Navy;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(7, 53);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DodgerBlue;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(3, 554);
            button1.Name = "button1";
            button1.Size = new Size(298, 149);
            button1.TabIndex = 3;
            button1.Text = "Account Center";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AccountCenter
            // 
            AccountCenter.BackColor = Color.Navy;
            AccountCenter.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AccountCenter.ForeColor = SystemColors.InactiveBorder;
            AccountCenter.ImageAlign = ContentAlignment.MiddleLeft;
            AccountCenter.Location = new Point(-29, -10);
            AccountCenter.Name = "AccountCenter";
            AccountCenter.Size = new Size(319, 161);
            AccountCenter.TabIndex = 8;
            AccountCenter.Text = "  Account Center";
            AccountCenter.UseVisualStyleBackColor = false;
            AccountCenter.Click += AccountCenter_Click;
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.Navy;
            sideBar.Controls.Add(panel5);
            sideBar.Controls.Add(panel3);
            sideBar.Controls.Add(panel2);
            sideBar.Controls.Add(panel1);
            sideBar.Controls.Add(panel4);
            sideBar.Controls.Add(panel6);
            sideBar.Controls.Add(panel8);
            sideBar.Controls.Add(panel9);
            sideBar.Controls.Add(panel7);
            sideBar.Dock = DockStyle.Left;
            sideBar.ForeColor = SystemColors.ActiveCaptionText;
            sideBar.Location = new Point(0, 0);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(250, 1069);
            sideBar.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnHum);
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 44);
            panel5.TabIndex = 11;
            // 
            // btnHum
            // 
            btnHum.Image = (Image)resources.GetObject("btnHum.Image");
            btnHum.Location = new Point(3, -1);
            btnHum.Name = "btnHum";
            btnHum.Size = new Size(41, 42);
            btnHum.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHum.TabIndex = 7;
            btnHum.TabStop = false;
            btnHum.Click += btnHum_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(206, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(patient);
            panel2.Location = new Point(3, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 111);
            panel2.TabIndex = 10;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(9, 43);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(37, 36);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(pictureBox6);
            panel6.Controls.Add(Print);
            panel6.Location = new Point(3, 563);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 125);
            panel6.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Navy;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(7, 43);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 37);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // Print
            // 
            Print.BackColor = Color.Navy;
            Print.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Print.ForeColor = SystemColors.InactiveBorder;
            Print.ImageAlign = ContentAlignment.MiddleLeft;
            Print.Location = new Point(-29, -18);
            Print.Name = "Print";
            Print.Size = new Size(312, 161);
            Print.TabIndex = 10;
            Print.Text = "Prescription";
            Print.UseVisualStyleBackColor = false;
            Print.Click += Print_Click;
            // 
            // panel8
            // 
            panel8.Controls.Add(pictureBox8);
            panel8.Controls.Add(button3);
            panel8.Location = new Point(3, 694);
            panel8.Name = "panel8";
            panel8.Size = new Size(250, 125);
            panel8.TabIndex = 13;
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.Navy;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(9, 36);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(37, 37);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 10;
            pictureBox8.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Navy;
            button3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.InactiveBorder;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-31, -25);
            button3.Name = "button3";
            button3.Size = new Size(312, 161);
            button3.TabIndex = 10;
            button3.Text = "Send Email";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel9
            // 
            panel9.Controls.Add(pictureBox9);
            panel9.Controls.Add(button4);
            panel9.Location = new Point(3, 825);
            panel9.Name = "panel9";
            panel9.Size = new Size(250, 125);
            panel9.TabIndex = 13;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.Navy;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(9, 34);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(37, 37);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 10;
            pictureBox9.TabStop = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.InactiveBorder;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-31, -27);
            button4.Name = "button4";
            button4.Size = new Size(312, 161);
            button4.TabIndex = 10;
            button4.Text = "About";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(button2);
            panel7.Location = new Point(3, 956);
            panel7.Name = "panel7";
            panel7.Size = new Size(250, 125);
            panel7.TabIndex = 12;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Navy;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(9, 34);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(37, 37);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.InactiveBorder;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-31, -27);
            button2.Name = "button2";
            button2.Size = new Size(312, 161);
            button2.TabIndex = 10;
            button2.Text = "Log out";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // SideBarTransition
            // 
            SideBarTransition.Interval = 10;
            SideBarTransition.Tick += SideBarTransition_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(969, 1069);
            Controls.Add(sideBar);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " LSPU CLINIC RECORD MANAGEMENT SYSTEM";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureContents).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            sideBar.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHum).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button patient;
        private Panel panel3;
        private Button btnPatient;
        private Panel panel4;
        private Button button1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Button Contens;
        private PictureBox pictureContents;
        private Button AccountCenter;
        private Label label1;
        private PictureBox pictureBox4;
        private FlowLayoutPanel sideBar;
        private System.Windows.Forms.Timer SideBarTransition;
        private PictureBox btnHum;
        private Panel panel2;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Panel panel6;
        private Button Print;
        private Panel panel7;
        private PictureBox pictureBox5;
        private Button button2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Panel panel8;
        private PictureBox pictureBox8;
        private Button button3;
        private Panel panel9;
        private PictureBox pictureBox9;
        private Button button4;
    }
}