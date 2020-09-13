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


namespace SchoolManagementSystem
{
    public partial class UpdateFaculty : Form
    {
        public UpdateFaculty()
        {
            InitializeComponent();
        }
        String NIC, NAME, MOBILE, EMAIL, EXPERIENCE, DISTRICT;
        Boolean flag = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        private void UpdateFaculty_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //back
            Form4 nb = new Form4();
            nb.Show();
            Visible = false;
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            //exit
            Application.Exit();

        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE FacultyRecord SET nic=@nic, name=@name,mobile=@mobile,email=@email,experience=@experience,district=@district WHERE  nic=@nic", con);
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

            MessageBox.Show(" Student information Succesfully updated ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            nic.Text = "";
            name.Text = "";
            email.Text = "";
            mobile.Text = "";
            district.Text = "";
            experience.Text = "";
        }

        private void del_Click(object sender, EventArgs e)
        {
            //search button

            cmd = new SqlCommand("Select * from FacultyRecord ", con);

            con.Open();
            sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                NIC = (string)sdr[0];
                NAME = (string)sdr[1];
                MOBILE = (string)sdr[2];
                EMAIL = (string)sdr[3];
                EXPERIENCE = (string)sdr[4];
                DISTRICT = (string)sdr[5];
                if (NIC == nictxt.Text && NAME == nametxt.Text)
                {
                    flag = false;

                    MessageBox.Show(" NIC #: " + NIC + '\n' + "NAME  #: " + NAME + '\n' + "MOBILE  #" + MOBILE + '\n' + "EMAIL  #" + EMAIL + '\n' + " EXPERIENCE  #" + EXPERIENCE + '\n' + "DISTRICT  #" + DISTRICT + '\n', "FACULTY Details ");
                    nic.Text = "" + NIC;
                    name.Text = "" + NAME;
                    mobile.Text = "" + MOBILE;
                    email.Text = "" + EMAIL;
                    district.Text = "" + DISTRICT;
                    experience.Text = "" + EXPERIENCE;
                    district.Text = "" + DISTRICT;
                  

                }

            }


            if (flag == true)
            {
                if (nic.Text.Equals("") || name.Text.Equals(""))
                {
                    MessageBox.Show("PLEASE ENTERED BOTH NIC AND NAME ");
                }
                else
                    MessageBox.Show("DOES NOT EXIST");
            }

            nametxt.Clear();
            nictxt.Clear();



            sdr.Close();

            con.Close();



        }
    }
}
