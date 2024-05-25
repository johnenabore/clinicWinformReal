namespace FINALPROJECT
{
    partial class Contents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contents));
            label1 = new Label();
            pictureBox4 = new PictureBox();
            panel1 = new Panel();
            btnPrint = new Button();
            btnSearchbtn = new Button();
            textBox1 = new TextBox();
            labelmo = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            btnDelete = new Button();
            btnREFRESH = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(327, -80);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 9;
            label1.Text = "Patient Details";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(200, -112);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Padding = new Padding(50, 0, 0, 0);
            pictureBox4.Size = new Size(88, 82);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnPrint);
            panel1.Controls.Add(btnSearchbtn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(labelmo);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnREFRESH);
            panel1.Location = new Point(227, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(1430, 979);
            panel1.TabIndex = 7;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = SystemColors.InactiveBorder;
            btnPrint.BackgroundImageLayout = ImageLayout.None;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.Navy;
            btnPrint.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrint.Location = new Point(820, 805);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(125, 32);
            btnPrint.TabIndex = 34;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = false;
            btnPrint.Click += btnPrint_Click_1;
            // 
            // btnSearchbtn
            // 
            btnSearchbtn.BackColor = SystemColors.GradientActiveCaption;
            btnSearchbtn.BackgroundImageLayout = ImageLayout.None;
            btnSearchbtn.FlatStyle = FlatStyle.Flat;
            btnSearchbtn.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearchbtn.ForeColor = Color.Navy;
            btnSearchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearchbtn.Location = new Point(266, 805);
            btnSearchbtn.Name = "btnSearchbtn";
            btnSearchbtn.Size = new Size(79, 32);
            btnSearchbtn.TabIndex = 33;
            btnSearchbtn.Text = "Search";
            btnSearchbtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.ControlDark;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(85, 805);
            textBox1.Margin = new Padding(3, 103, 3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 32);
            textBox1.TabIndex = 32;
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelmo
            // 
            labelmo.AutoSize = true;
            labelmo.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelmo.Location = new Point(12, 812);
            labelmo.Name = "labelmo";
            labelmo.Size = new Size(67, 19);
            labelmo.TabIndex = 31;
            labelmo.Text = "Search:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(628, 764);
            label3.Name = "label3";
            label3.Size = new Size(252, 20);
            label3.TabIndex = 30;
            label3.Text = "Edit the info of the patient in the cell";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 134);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1429, 627);
            dataGridView1.TabIndex = 29;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-12, 897);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1588, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(590, 75);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(232, 24);
            label2.TabIndex = 27;
            label2.Text = "Student's Clinic Record";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.InactiveBorder;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.Navy;
            btnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            btnDelete.Location = new Point(659, 805);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 32);
            btnDelete.TabIndex = 24;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnREFRESH
            // 
            btnREFRESH.BackColor = SystemColors.InactiveBorder;
            btnREFRESH.BackgroundImageLayout = ImageLayout.None;
            btnREFRESH.FlatStyle = FlatStyle.Flat;
            btnREFRESH.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnREFRESH.ForeColor = Color.Navy;
            btnREFRESH.ImageAlign = ContentAlignment.MiddleLeft;
            btnREFRESH.Location = new Point(504, 805);
            btnREFRESH.Name = "btnREFRESH";
            btnREFRESH.Size = new Size(125, 32);
            btnREFRESH.TabIndex = 23;
            btnREFRESH.Text = "Refresh";
            btnREFRESH.UseVisualStyleBackColor = false;
            btnREFRESH.Click += btnREFRESH_Click_1;
            // 
            // Contents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1747, 1102);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.Off;
            Name = "Contents";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Contents";
            Load += Contents_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpload;
        private Label label1;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Button btnDelete;
        private Button btnSearch;
        private Button btnREFRESH;
        private Label label2;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Label label3;
        private Label labelmo;
        private Button btnSearchbtn;
        private TextBox textBox1;
        private Button btnPrint;
    }
}