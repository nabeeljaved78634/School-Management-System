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
    public partial class SearchMarks : Form
    {
        public SearchMarks()
        {
            InitializeComponent();
        }
        String CMS, NAME, Tclass, ENGLISH, URDU, TMath, ISLAMIAT, COMPUTER;
        Boolean flag = true;

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form6 vv = new Form6();
            vv.Show();
            Visible = false;

        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        private void del_Click(object sender, EventArgs e)
        {
            //search marks
 
            if(textclass.Text=="one" ||  textclass.Text=="1")
            { 
            
                cmd = new SqlCommand("Select * from one ", con);

            con.Open();
            sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                CMS = (string)sdr[0];
                NAME = (string)sdr[1];
                Tclass = (string)sdr[2];
                ENGLISH = (string)sdr[3];
                URDU = (string)sdr[4];
                TMath = (string)sdr[5];
                ISLAMIAT = (string)sdr[6];
                COMPUTER = (string)sdr[7];

                if (CMS == cms.Text && NAME == name.Text)
                {
                    flag = false;

                    MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "CLASS  #" + Tclass + '\n' + "ENGLISH  #" + ENGLISH + '\n' + " URDU  #" + URDU + '\n' + "MATH  #" + TMath + '\n' + "ISLAMIAT  #" + ISLAMIAT + '\n' + "COMPUTER  #" + COMPUTER + '\n', "STUDENT MARKS Details ");
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

            textclass.Clear();


            sdr.Close();

            con.Close();

        }





          else  if (textclass.Text == "two" || textclass.Text == "2")
            {

                cmd = new SqlCommand("Select * from two ", con);

                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    CMS = (string)sdr[0];
                    NAME = (string)sdr[1];
                    Tclass = (string)sdr[2];
                    ENGLISH = (string)sdr[3];
                    URDU = (string)sdr[4];
                    TMath = (string)sdr[5];
                    ISLAMIAT = (string)sdr[6];
                    COMPUTER = (string)sdr[7];

                    if (CMS == cms.Text && NAME == name.Text)
                    {
                        flag = false;

                        MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "CLASS  #" + Tclass + '\n' + "ENGLISH  #" + ENGLISH + '\n' + " URDU  #" + URDU + '\n' + "MATH  #" + TMath + '\n' + "ISLAMIAT  #" + ISLAMIAT + '\n' + "COMPUTER  #" + COMPUTER + '\n', "STUDENT MARKS Details ");
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

                textclass.Clear();


                sdr.Close();

                con.Close();

            }

            else if (textclass.Text == "three" || textclass.Text == "3")
            {

                cmd = new SqlCommand("Select * from three ", con);

                con.Open();
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    CMS = (string)sdr[0];
                    NAME = (string)sdr[1];
                    Tclass = (string)sdr[2];
                    ENGLISH = (string)sdr[3];
                    URDU = (string)sdr[4];
                    TMath = (string)sdr[5];
                    ISLAMIAT = (string)sdr[6];
                    COMPUTER = (string)sdr[7];

                    if (CMS == cms.Text && NAME == name.Text)
                    {
                        flag = false;

                        MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "CLASS  #" + Tclass + '\n' + "ENGLISH  #" + ENGLISH + '\n' + " URDU  #" + URDU + '\n' + "MATH  #" + TMath + '\n' + "ISLAMIAT  #" + ISLAMIAT + '\n' + "COMPUTER  #" + COMPUTER + '\n', "STUDENT MARKS Details ");
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

                textclass.Clear();


                sdr.Close();

                con.Close();

            }



            else
            {
                MessageBox.Show("you entered wrong class");
            }
        }

    }
}


















