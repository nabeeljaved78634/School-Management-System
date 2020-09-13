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
    public partial class InsertFacultyRecord : Form
    {
        public InsertFacultyRecord()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        private void InsertFacultyRecord_Load(object sender, EventArgs e)
        {
            GetStudentsRecord();
        }

        public void GetStudentsRecord()
        {
            SqlCommand cmd = new SqlCommand("Select * from FacultyRecord ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView2.DataSource = dt;

        }
        private void back_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
            Visible = false;
        }

      

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (ValidCNIC(nic.Text) == true && ValidMOBILE(mobile.Text) == true && ValidEmail(email.Text)==true)
            {
                if (IsValid())
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO FacultyRecord VALUES(@nic,@name,@mobile,@email,@experience,@district)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@nic", nic.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);
                    cmd.Parameters.AddWithValue("@mobile", mobile.Text);


                    cmd.Parameters.AddWithValue("@email", email.Text);
                    cmd.Parameters.AddWithValue("@experience", experience.Text);

                    cmd.Parameters.AddWithValue("@district", district.Text);



                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New Student is Succesfully save in the Database", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetStudentsRecord();

                    name.Clear();
                    nic.Clear();
                    mobile.Clear();
                    email.Clear();
                    experience.Clear();
                    district.Clear();
                }

            }
            else
            {
                MessageBox.Show("Either nic or mobile or  email  is not in correct format.");
            }

        }
        private bool ValidMOBILE(string MOBILE)
        {
            Regex check = new Regex(@"^[0-9]{4}-[0-9]{7}$");
            bool valid = false;
            valid = check.IsMatch(MOBILE);
            return valid;
        }

        private bool ValidCNIC(string CNIC)
        {
            Regex checkit = new Regex(@"^[0-9]{5}-[0-9]{7}-[0-9]{1}$");
            bool valid = false;
            valid = checkit.IsMatch(CNIC);
            return valid;
        }

        private bool ValidEmail(string email)
        {
            Regex checkit = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool valid = false;
            valid = checkit.IsMatch(email);
            return valid;
        }

        private bool IsValid()
        {
            if (name.Text == string.Empty)
            {
                MessageBox.Show("Student Name is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (nic.Text == string.Empty)
            {
                MessageBox.Show("NIC is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (email.Text == string.Empty)
            {
                MessageBox.Show("EMAIL is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }



            if (experience.Text == string.Empty)
            {
                MessageBox.Show("Experience is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (district.Text == string.Empty)
            {
                MessageBox.Show("District is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (mobile.Text == string.Empty)
            {
                MessageBox.Show("Mobile Number is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ValidCMS(string CMS)
        {
            Regex checkit = new Regex(@"^[0-9]{3}-[0-9]{2}-[0-9]{4}$");
            bool valid = false;
            valid = checkit.IsMatch(CMS);
            return valid;
        }
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nic.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            mobile.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            email.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            experience.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
            district.Text = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();

        }
    }
}
