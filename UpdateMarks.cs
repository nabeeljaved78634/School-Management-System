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
    public partial class UpdateMarks : Form
    {
        public UpdateMarks()
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
            Form6 jd = new Form6();
            jd.Show();
            Visible = false;
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        private void search_Click(object sender, EventArgs e)
        {
            //search marks

            if (classtxt.Text == "one" || classtxt.Text == "1")
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

                    if (CMS == cmstxt.Text )
                    {
                        flag = false;

                        MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "CLASS  #" + Tclass + '\n' + "ENGLISH  #" + ENGLISH + '\n' + " URDU  #" + URDU + '\n' + "MATH  #" + TMath + '\n' + "ISLAMIAT  #" + ISLAMIAT + '\n' + "COMPUTER  #" + COMPUTER + '\n', "STUDENT MARKS Details ");

                        cms.Text = "" + CMS;
                        name.Text = "" + NAME;
                        textclass.Text = "" + Tclass;
                        english.Text = "" + ENGLISH;
                        urdu.Text = "" + URDU;
                        math.Text = "" + TMath;
                        islamiat.Text = "" + ISLAMIAT;
                        computer.Text = "" + COMPUTER;

                    }

                }


                if (flag == true)
                {
                    if (cmstxt.Text.Equals("") || classtxt.Text.Equals(""))
                    {
                        MessageBox.Show("PLEASE ENTERED BOTH CMS AND CLASS ");
                    }

                    else
                        MessageBox.Show("DOES NOT EXIST");
                }

                cmstxt.Clear();

                classtxt.Clear();


                sdr.Close();

                con.Close();

            }





            else if (classtxt.Text == "two" || classtxt.Text == "2")
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

                    if (CMS == cmstxt.Text )
                    {
                        flag = false;

                        MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "CLASS  #" + Tclass + '\n' + "ENGLISH  #" + ENGLISH + '\n' + " URDU  #" + URDU + '\n' + "MATH  #" + TMath + '\n' + "ISLAMIAT  #" + ISLAMIAT + '\n' + "COMPUTER  #" + COMPUTER + '\n', "STUDENT MARKS Details ");

                        cms.Text = "" + CMS;
                        name.Text = "" + NAME;
                        textclass.Text = "" + Tclass;
                        english.Text = "" + ENGLISH;
                        urdu.Text = "" + URDU;
                        math.Text = "" + TMath;
                        islamiat.Text = "" + ISLAMIAT;
                        computer.Text = "" + COMPUTER;

                    }

                }


                if (flag == true)
                {
                    if (cmstxt.Text.Equals("") || classtxt.Text.Equals(""))
                    {
                        MessageBox.Show("PLEASE ENTERED BOTH CMS AND CLASS ");
                    }

                    else
                        MessageBox.Show("DOES NOT EXIST");
                }

                cmstxt.Clear();

                classtxt.Clear();


                sdr.Close();

                con.Close();

            }


            else if (classtxt.Text == "three" || classtxt.Text == "3")
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

                    if (CMS == cmstxt.Text )
                    {
                        flag = false;

                        MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "CLASS  #" + Tclass + '\n' + "ENGLISH  #" + ENGLISH + '\n' + " URDU  #" + URDU + '\n' + "MATH  #" + TMath + '\n' + "ISLAMIAT  #" + ISLAMIAT + '\n' + "COMPUTER  #" + COMPUTER + '\n', "STUDENT MARKS Details ");

                        cms.Text = "" + CMS;
                        name.Text = "" + NAME;
                        textclass.Text = "" + Tclass;
                        english.Text = "" + ENGLISH;
                        urdu.Text = "" + URDU;
                        math.Text = "" + TMath;
                        islamiat.Text = "" + ISLAMIAT;
                        computer.Text = "" + COMPUTER;

                    }

                }


                if (flag == true)
                {
                    if (cmstxt.Text.Equals("") || classtxt.Text.Equals(""))
                    {
                        MessageBox.Show("PLEASE ENTERED BOTH CMS AND CLASS ");
                    }

                    else
                        MessageBox.Show("DOES NOT EXIST");
                }

                cmstxt.Clear();

                classtxt.Clear();


                sdr.Close();

                con.Close();

            }



            else
            {
                MessageBox.Show("you entered wrong class");
            }

        }










        private void update_Click(object sender, EventArgs e)
        {
            if (textclass.Text == "one" || textclass.Text == "1")
            {
                SqlCommand cmd = new SqlCommand("UPDATE one SET cms=@cms, name=@name,class=@class,english=@english,urdu=@urdu,math=@math,islamiat=@islamiat,computer=@computer WHERE  cms=@cms", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cms", cms.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@class", textclass.Text);
                cmd.Parameters.AddWithValue("@english", english.Text);
                cmd.Parameters.AddWithValue("@urdu", urdu.Text);
                cmd.Parameters.AddWithValue("@math", math.Text);

                cmd.Parameters.AddWithValue("@islamiat", islamiat.Text);
                cmd.Parameters.AddWithValue("@computer", computer.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Student Marks Succesfully updated ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cms.Text = "";
                name.Text = "";
                textclass.Text = "";
                english.Text = "";
                urdu.Text = "";
                computer.Text = "";
                islamiat.Text = "";
                math.Text = "";
            }




           else if (textclass.Text == "two" || textclass.Text == "2")
            {
                SqlCommand cmd = new SqlCommand("UPDATE two SET cms=@cms, name=@name,class=@class,english=@english,urdu=@urdu,math=@math,islamiat=@islamiat,computer=@computer WHERE  cms=@cms", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cms", cms.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@class", textclass.Text);
                cmd.Parameters.AddWithValue("@english", english.Text);
                cmd.Parameters.AddWithValue("@urdu", urdu.Text);
                cmd.Parameters.AddWithValue("@math", math.Text);

                cmd.Parameters.AddWithValue("@islamiat", islamiat.Text);
                cmd.Parameters.AddWithValue("@computer", computer.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Student Marks Succesfully updated ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cms.Text = "";
                name.Text = "";
                textclass.Text = "";
                english.Text = "";
                urdu.Text = "";
                computer.Text = "";
                islamiat.Text = "";
                math.Text = "";
            }



            else if (textclass.Text == "three" || textclass.Text == "3")
            {
                SqlCommand cmd = new SqlCommand("UPDATE three SET cms=@cms, name=@name,class=@class,english=@english,urdu=@urdu,math=@math,islamiat=@islamiat,computer=@computer WHERE  cms=@cms", con);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@cms", cms.Text);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@class", textclass.Text);
                cmd.Parameters.AddWithValue("@english", english.Text);
                cmd.Parameters.AddWithValue("@urdu", urdu.Text);
                cmd.Parameters.AddWithValue("@math", math.Text);

                cmd.Parameters.AddWithValue("@islamiat", islamiat.Text);
                cmd.Parameters.AddWithValue("@computer", computer.Text);


                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show(" Student Marks Succesfully updated ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cms.Text = "";
                name.Text = "";
                textclass.Text = "";
                english.Text = "";
                urdu.Text = "";
                computer.Text = "";
                islamiat.Text = "";
                math.Text = "";
            }



        }
    }
}
