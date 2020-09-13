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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        String CMS, NAME,MOBILE,FATHER,DISTRICT,ADDRESS,RELEGION;

        Boolean flag = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");

        private void search_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from StudentRecord ", con);

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                CMS = (string)sdr[0];
                NAME = (string)sdr[1];
                FATHER = (string)sdr[2];
                MOBILE = (string)sdr[3];
                DISTRICT = (string)sdr[4];
                RELEGION = (string)sdr[5];
                ADDRESS = (string)sdr[6];
                if (CMS == id.Text && NAME == name.Text)
                {
                    flag = false;

                    MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "FATHER  #" + FATHER + '\n' + "MOBILE  #" + MOBILE + '\n' + " DISTRICT  #" + DISTRICT + '\n' + "RELIGION  #" + RELEGION + '\n' + "ADDRESS  #" + ADDRESS + '\n' + "DOB  #" + sdr[7] + '\n', "STUDENT Details ");
                }

            }


            if (flag == true)
            {
                if (id.Text.Equals("") || name.Text.Equals(""))
                {
                    MessageBox.Show("PLEASE ENTERED BOTH CMS AND PASSWORD ");
                }
                else
                {
                    MessageBox.Show("DOES NOT EXIST");
                }
            }
          


            sdr.Close();

            con.Close();



        }

        private void clear_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void back_Click(object sender, EventArgs e)
        {

            Form3 obj = new Form3();
            obj.Show();
            Visible = false;


        }

        private void del_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd = new SqlCommand("DELETE FROM StudentRecord  WHERE  cms='" + id.Text + "' ", con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show(" Student information Succesfully deleted ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            name.Clear();
            id.Clear();



        }

             


    }
}

