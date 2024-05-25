namespace FINALPROJECT
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            btnInfo = new Button();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(360, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1192, 139);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(675, 309);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(982, 626);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DodgerBlue;
            label3.Location = new Point(204, 456);
            label3.Name = "label3";
            label3.Size = new Size(530, 55);
            label3.TabIndex = 3;
            label3.Text = "STUDENT WELLNESS,";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(204, 511);
            label2.Name = "label2";
            label2.Size = new Size(419, 55);
            label2.TabIndex = 4;
            label2.Text = "OUR EXPERTISE!";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(210, 583);
            label4.Name = "label4";
            label4.Size = new Size(510, 35);
            label4.TabIndex = 5;
            label4.Text = "empowering healthy campus living";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.DarkGray;
            label5.Location = new Point(1055, 205);
            label5.Name = "label5";
            label5.Size = new Size(75, 27);
            label5.TabIndex = 20;
            label5.Text = "Home";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(1055, 227);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(72, 10);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // btnInfo
            // 
            btnInfo.BackColor = Color.Navy;
            btnInfo.FlatStyle = FlatStyle.Flat;
            btnInfo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnInfo.ForeColor = Color.White;
            btnInfo.Location = new Point(215, 681);
            btnInfo.Name = "btnInfo";
            btnInfo.Size = new Size(168, 48);
            btnInfo.TabIndex = 22;
            btnInfo.Text = "Project By";
            btnInfo.UseVisualStyleBackColor = false;
            btnInfo.Click += btnInfo_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(215, 205);
            label6.Name = "label6";
            label6.Size = new Size(333, 27);
            label6.TabIndex = 23;
            label6.Text = "LSPU Clinic Record Manager";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkGray;
            label7.Location = new Point(1210, 206);
            label7.Name = "label7";
            label7.Size = new Size(114, 27);
            label7.TabIndex = 24;
            label7.Text = "About us";
            label7.Click += label7_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1886, 1055);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnInfo);
            Controls.Add(pictureBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label lblAbooutUs;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
        private Button btnInfo;
        private Label label6;
        private Label label7;
    }
}