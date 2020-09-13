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
    public partial class InsertMarks : Form
    {
        public InsertMarks()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");


        private void InsertMarks_Load(object sender, EventArgs e)
        {
           

        }

        public void GetStudentsRecord1()
        {
            SqlCommand cmd = new SqlCommand("Select * from one ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        public void GetStudentsRecord2()
        {
            SqlCommand cmd = new SqlCommand("Select * from two ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

        }

        public void GetStudentsRecord3()
        {
            SqlCommand cmd = new SqlCommand("Select * from three ", con);
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            dt.Load(sdr);
            con.Close();
            dataGridView1.DataSource = dt;

        }


        private void back_Click(object sender, EventArgs e)
        {
            Form6 nck = new Form6();
            nck.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if(textclass.Text=="one" || textclass.Text == "1")
            {
                //insert
            if (ValidCMS(cms.Text) == true )
            {
                if (IsValid())
                {

                    SqlCommand cmd = new SqlCommand("INSERT INTO one VALUES(@cms,@name,@class,@english,@urdu,@math,@islamiat,@computer)", con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@cms", cms.Text);
                    cmd.Parameters.AddWithValue("@name", name.Text);

                    cmd.Parameters.AddWithValue("@class", textclass.Text);
                
                    cmd.Parameters.AddWithValue("@english", text1.Text);
                  

                    cmd.Parameters.AddWithValue("@urdu", text2.Text);
                  

                    cmd.Parameters.AddWithValue("@math", text3.Text);
                   

                    cmd.Parameters.AddWithValue("@islamiat", text4.Text);
                    

                    cmd.Parameters.AddWithValue("@computer", text5.Text);
                   
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("New MARKS is Succesfully save in the Database", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

                    name.Clear();
                    textclass.Clear();
                    cms.Clear();
                   
                 

                    text1.Clear();
                    text2.Clear(); 
                    text3.Clear();
                    text4.Clear(); 
                    text5.Clear();
                }
                    GetStudentsRecord1();

                }
                else
            {
                MessageBox.Show("CMS  is not in correct format.");
            }
            }














            //for class Two

            else if (textclass.Text == "two" || textclass.Text == "2")
            {
                //insert
                if (ValidCMS(cms.Text) == true)
                {
                    if (IsValid())
                    {

                        SqlCommand cmd = new SqlCommand("INSERT INTO two VALUES(@cms,@name,@class,@english,@urdu,@math,@islamiat,@computer)", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@cms", cms.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);

                        cmd.Parameters.AddWithValue("@class", textclass.Text);

                        cmd.Parameters.AddWithValue("@english", text1.Text);


                        cmd.Parameters.AddWithValue("@urdu", text2.Text);


                        cmd.Parameters.AddWithValue("@math", text3.Text);


                        cmd.Parameters.AddWithValue("@islamiat", text4.Text);


                        cmd.Parameters.AddWithValue("@computer", text5.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("New MARKS is Succesfully save in the Database", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        name.Clear();
                        textclass.Clear();
                        cms.Clear();



                        text1.Clear();
                        text2.Clear();
                        text3.Clear();
                        text4.Clear();
                        text5.Clear();
                    }

                    GetStudentsRecord2();

                }
                else
                {
                    MessageBox.Show("CMS  is not in correct format.");
                }
            }










            //for class three

            else if (textclass.Text == "three" || textclass.Text == "3")
            {
                //insert
                if (ValidCMS(cms.Text) == true)
                {
                    if (IsValid())
                    {

                        SqlCommand cmd = new SqlCommand("INSERT INTO three VALUES(@cms,@name,@class,@english,@urdu,@math,@islamiat,@computer)", con);
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@cms", cms.Text);
                        cmd.Parameters.AddWithValue("@name", name.Text);

                        cmd.Parameters.AddWithValue("@class", textclass.Text);

                        cmd.Parameters.AddWithValue("@english", text1.Text);
                        cmd.Parameters.AddWithValue("@urdu", text2.Text);


                        cmd.Parameters.AddWithValue("@math", text3.Text);


                        cmd.Parameters.AddWithValue("@islamiat", text4.Text);


                        cmd.Parameters.AddWithValue("@computer", text5.Text);

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        MessageBox.Show("New MARKS is Succesfully save in the Database", "saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                        name.Clear();
                        textclass.Clear();
                        cms.Clear();



                        text1.Clear();
                        text2.Clear();
                        text3.Clear();
                        text4.Clear();
                        text5.Clear();
                    }

                    GetStudentsRecord3();

                }
                else
                {
                    MessageBox.Show("CMS  is not in correct format.");
                }
            }




            else
            {
                MessageBox.Show("Please Enter correct class");
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

            if (textclass.Text == string.Empty)
            {
                MessageBox.Show("Class is required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cms.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            name.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            
            textclass.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            
            text1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            
            text2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            
            text3.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            
            text4.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            
            text5.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
          
        }
    }
}
