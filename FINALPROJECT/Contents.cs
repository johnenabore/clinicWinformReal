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
using System.Xml.Linq;
using MySqlX.XDevAPI.Relational;

namespace FINALPROJECT
{
    public partial class Contents : Form
    {
        private DataTable stdDataTable = new DataTable();
        public Contents()
        {
            InitializeComponent();
        }

        private void FillDGV()
        {
            MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=johnenabore0312;database=lspudb");
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM tblstudents", con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            con.Open();
            da.Fill(dt);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        private void Contents_Load_1(object sender, EventArgs e)
        {
            FillDGV();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.SelectedRows.Count - 1; i >= 0; i--)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[i];
                string id = row.Cells["studentID"].Value.ToString();

                string deleteQuery = "DELETE FROM tblstudents WHERE studentID = @studentID";
                using (MySqlConnection con = new MySqlConnection("server=localhost;uid=root;pwd=johnenabore0312;database=lspudb"))
                {
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@studentID", id);
                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                DialogResult delete = MessageBox.Show("Are you sure you want to delete this section?", "Warning!", MessageBoxButtons.YesNoCancel);

                if (delete == DialogResult.Yes)
                {
                    dataGridView1.Rows.Remove(row);
                }
                else
                {
                    delete = DialogResult.Cancel;
                }
            }
        }


        private void btnREFRESH_Click_1(object sender, EventArgs e)
        {
            FillDGV();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;

                dv.RowFilter = "Convert(StudentID, 'System.String') Like '%" + textBox1.Text + "%'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0) // Check if any rows are selected
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];

                string fname = row.Cells["FirstName"].Value.ToString();
                string Lname = row.Cells["LastName"].Value.ToString(); // Change "studentID" to the actual name of your column
                string Mname = row.Cells["MiddleName"].Value.ToString(); // Change "studentID" to the actual name of your column
                string Address = row.Cells["Address"].Value.ToString(); // Change "studentID" to the actual name of your column
                string Age = row.Cells["Age"].Value.ToString(); // Change "studentID" to the actual name of your column
                string Sex = row.Cells["gender"].Value.ToString(); // Change "studentID" to the actual name of your column
                string doa = row.Cells["dateofAdmit"].Value.ToString(); // Change "studentID" to the actual name of your column

                


                PrintDetails pd = new PrintDetails();
                pd.receiver(fname, Mname, Lname, Address, Age, Sex, doa);
                pd.ShowDialog();

            }

        }
    }
}

