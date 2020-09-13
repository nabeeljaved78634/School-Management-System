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
    public partial class DeleteFacultyRecord : Form
    {
        public DeleteFacultyRecord()
        {
            InitializeComponent();
        }
        String NIC, NAME, MOBILE, EMAIL, EXPERIENCE, DISTRICT;
        Boolean flag = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        private void delete_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM FacultyRecord  WHERE  nic='" + nic.Text + "' ", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Faculty information Succesfully deleted ", "deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            name.Clear();
            nic.Clear();

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

        private void search_Click(object sender, EventArgs e)
        {
            //search
            cmd = new SqlCommand("Select * from facultyRecord ", con);

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
                if (NIC == nic.Text && NAME == name.Text)
                {
                    flag = false;

                    MessageBox.Show(" NIC #: " + NIC + '\n' + "NAME  #: " + NAME + '\n' + "MOBILE  #" + MOBILE + '\n' + "EMAIL  #" + EMAIL + '\n' + " EXPERIENCE  #" + EXPERIENCE + '\n' + "DISTRICT  #" + DISTRICT + '\n', "FACULTY Details ");
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

           


            sdr.Close();

            con.Close();


        }
    }
}
