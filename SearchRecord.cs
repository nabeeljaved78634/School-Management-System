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
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
        }
        String CMS, NAME, MOBILE, FATHER, DISTRICT, ADDRESS, RELEGION;
        Boolean flag = true;
        private void back_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            Visible = false;

        }

        private void clear_Click(object sender, EventArgs e)
         {
            Application.Exit();



        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd ;
        SqlDataReader sdr;

        private void SearchRecord_Load(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            //search
            cmd = new SqlCommand("Select * from StudentRecord ", con);
         
            con.Open();
            sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                CMS = (string)sdr[0];
                NAME = (string)sdr[1];
                FATHER = (string)sdr[2];
                MOBILE = (string)sdr[3];
                DISTRICT = (string)sdr[4];
                RELEGION = (string)sdr[5];
                ADDRESS = (string)sdr[6];
                if (CMS == cms.Text && NAME == name.Text)
                {
                    flag = false;

                    MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "FATHER  #" + FATHER + '\n' + "MOBILE  #" + MOBILE + '\n' + " DISTRICT  #" + DISTRICT + '\n' + "RELIGION  #" + RELEGION + '\n' + "ADDRESS  #" + ADDRESS + '\n' + "DOB  #" + sdr[7] + '\n', "STUDENT Details ");
                }

            }

           
            if (flag == true)
             {
                if (cms.Text.Equals("") || name.Text.Equals(""))
                {
                    MessageBox.Show("PLEASE ENTERED BOTH CMS AND NAME ");
                }
                else
                MessageBox.Show("DOES NOT EXIST");
             }

            name.Clear();
            cms.Clear();



            sdr.Close();

                con.Close();
           
            }


            private void cms_TextChanged(object sender, EventArgs e)
         {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
