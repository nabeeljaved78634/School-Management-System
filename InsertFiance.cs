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
using System.Text.RegularExpressions;


namespace SchoolManagementSystem
{
    public partial class InsertFiance : Form
    {
        public InsertFiance()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        private void back_Click(object sender, EventArgs e)
        {
            Form5 hk = new Form5();
            hk.Show();
            Visible = false;
        }

        public void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from Fiance ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView3.DataSource = dt;

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void InsertFiance_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (ValidCMS(cms.Text) == true )
            {
                if (IsValid())
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO Fiance VALUES(@cms,@name,@father,@due,@month,@amount)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@cms", cms.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@father", father.Text);


                    cmd.Parameters.AddWithValue("@due", due.Text);
                    cmd.Parameters.AddWithValue("@month", month.Text);

                    cmd.Parameters.AddWithValue("@amount", amount.Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Student  Fiance is Succesfully save in the Database", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStudentsRecord();

                    name.Clear();
                    cms.Clear();
                    father.Clear();
                    month.Clear();
                    due.Clear();
                    amount.Clear();
                }

            }
            else
            {
                MessageBox.Show("cms  is not in correct format.");
            }


        }
        private bool IsValid()
        {
            if (name.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cms.Text == string.Empty)
            {
                MessageBox.Show("CMS is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (father.Text == string.Empty)
            {
                MessageBox.Show("Father Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            if (month.Text == string.Empty)
            {
                MessageBox.Show("Month is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (amount.Text == string.Empty)
            {
                MessageBox.Show("Amount is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (due.Text == string.Empty)
            {
                MessageBox.Show("Due is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private bool ValidCMS(string CMS)
        {
            Regex checkit = new Regex(@"^[0-9]{3}-[0-9]{2}-[0-9]{4}$");
            bool valid = false;
            valid = checkit.IsMatch(CMS);
            return valid;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cms.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            father.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            due.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            month.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            amount.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();




        }
    }
}
