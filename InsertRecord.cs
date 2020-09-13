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
    public partial class InsertRecord : Form
    {
        public InsertRecord()
        {
            InitializeComponent();
        }

    SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        private void InsertRecord_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        public void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentRecord ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView.DataSource = dt;

        }
        private void insert_Click(object sender, EventArgs e)
        {
            //insert
            if (ValidCMS(cms.Text) == true && ValidMOBILE(mobile.Text)==true)
            {
                if (IsValid())
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO StudentRecord VALUES(@cms,@name,@father,@mobile,@district,@religion,@address,@date)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@cms", cms.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);

                    cmd.Parameters.AddWithValue("@father", father.Text);
                    cmd.Parameters.AddWithValue("@mobile", mobile.Text);
                    cmd.Parameters.AddWithValue("@district", district.Text);
                    cmd.Parameters.AddWithValue("@religion", religion.Text);

                    cmd.Parameters.AddWithValue("@Address", address.Text);
                    cmd.Parameters.AddWithValue("@date", date.Text);


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Student is Succesfully save in the Database", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStudentsRecord();

                    name.Clear();
                    religion.Clear();
                    address.Clear();
                    father.Clear();
                    mobile.Clear();
                    district.Clear();
                    cms.Clear();
                }

            }
            else
            {
                MessageBox.Show("CMS or mobile is not in correct format.");
            }
            
        }

        private bool IsValid()
        {
            if (name.Text == string.Empty )
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
                MessageBox.Show("Fataher Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (district.Text == string.Empty)
            {
                MessageBox.Show("District is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (religion.Text == string.Empty)
            {
                MessageBox.Show("Religion is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (date.Text == string.Empty)
            {
                MessageBox.Show("DOB is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (address.Text == string.Empty)
            {
                MessageBox.Show("Address is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

           

            return true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            //clearButton
            Application.Exit();
          
       
        }
        
       
        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cms.Text = dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            father.Text = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            mobile.Text = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            district.Text = dataGridView.SelectedRows[0].Cells[4].Value.ToString();
            religion.Text = dataGridView.SelectedRows[0].Cells[5].Value.ToString();
            address.Text = dataGridView.SelectedRows[0].Cells[6].Value.ToString();


            date.Text = dataGridView.SelectedRows[0].Cells[7].Value.ToString();
          
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            Visible = false;
        }
        private bool ValidCMS(string CMS)
        {
            Regex checkit = new Regex(@"^[0-9]{3}-[0-9]{2}-[0-9]{4}$");
            bool valid = false;
            valid = checkit.IsMatch(CMS);
            return valid;
        }

        private bool ValidMOBILE(string MOBILE)
        {
            Regex check = new Regex(@"^[0-9]{4}-[0-9]{7}$");
            bool valid = false;
            valid = check.IsMatch(MOBILE);
            return valid;
        }
    }
}
