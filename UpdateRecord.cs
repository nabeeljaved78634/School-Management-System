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
    public partial class UpdateRecord : Form
    {
        public UpdateRecord()
        {
            InitializeComponent();
        }
        String CMS, NAME, MOBILE, FATHER, DISTRICT, ADDRESS, RELEGION;
        Boolean flag = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

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
                if (CMS == cmstxt.Text && NAME == nametxt.Text)
                {
                    flag = false;

                    MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "FATHER  #" + FATHER + '\n' + "MOBILE  #" + MOBILE + '\n' + " DISTRICT  #" + DISTRICT + '\n' + "RELIGION  #" + RELEGION + '\n' + "ADDRESS  #" + ADDRESS + '\n' + "DOB  #" + sdr[7] + '\n', "STUDENT Details DELETED");
                    cms.Text =""+ CMS;
                    name.Text = "" + NAME;
                    father.Text = "" + FATHER;
                    mobile.Text = "" + MOBILE;
                    district.Text = "" + DISTRICT;
                    religion.Text = "" + RELEGION;
                    address.Text = "" + ADDRESS;
                    date.Text = "" + sdr[7];

                }

            }


            if (flag == true)
            {
                if (cms.Text.Equals("") || name.Text.Equals(""))
                {
                    MessageBox.Show("PLEASE ENTERED BOTH CMS AND PASSWORD ");
                }
                else
                    MessageBox.Show("DOES NOT EXIST");
            }

            nametxt.Clear();
            cmstxt.Clear();



            sdr.Close();

            con.Close();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            Visible = false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UPDATE StudentRecord SET cms=@cms, name=@name,father=@father,mobile=@mobile,district=@district,religion=@religion,address=@address,date=@date WHERE  cms=@cms", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cms", cms.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@father", father.Text);
            cmd.Parameters.AddWithValue("@mobile", mobile.Text);
            cmd.Parameters.AddWithValue("@district", district.Text);
            cmd.Parameters.AddWithValue("@religion", religion.Text);

            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.Parameters.AddWithValue("@date", date.Text);
            

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(" Student information Succesfully updated ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cms.Text = "";
                name.Text = "";
            father.Text = "";
            mobile.Text = "";
            district.Text = "";
            religion.Text = "";
            address.Text = "";
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
