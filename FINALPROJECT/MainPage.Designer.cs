namespace FINALPROJECT
{
    partial class ConfirmPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPage));
            panel2 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(139, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 575);
            panel2.TabIndex = 1;
            // 
            // button2
            // 
            button2.BackColor = Color.Gray;
            button2.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(36, 464);
            button2.Name = "button2";
            button2.Size = new Size(429, 39);
            button2.TabIndex = 11;
            button2.Text = "I am not authorized - Exit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(36, 406);
            button1.Name = "button1";
            button1.Size = new Size(429, 39);
            button1.TabIndex = 10;
            button1.Text = "I am authorized - Enter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(36, 346);
            label6.Name = "label6";
            label6.Size = new Size(429, 28);
            label6.TabIndex = 9;
            label6.Text = "affirm that you are authorized personnel to use this application";
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 306);
            label5.Name = "label5";
            label5.Size = new Size(453, 28);
            label5.TabIndex = 8;
            label5.Text = "student's credentials and informations. By entering, you";
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 269);
            label4.Name = "label4";
            label4.Size = new Size(453, 28);
            label4.TabIndex = 7;
            label4.Text = "This application contains confidential records including";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 253);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(190, 182);
            label2.Name = "label2";
            label2.Size = new Size(107, 32);
            label2.TabIndex = 5;
            label2.Text = "System";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(33, 137);
            label1.Name = "label1";
            label1.Size = new Size(432, 32);
            label1.TabIndex = 4;
            label1.Text = "LSPU Clinic Record Management";
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(208, 16);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(89, 89);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // ConfirmPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(774, 587);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ConfirmPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainPage";
            Load += MainPage_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}