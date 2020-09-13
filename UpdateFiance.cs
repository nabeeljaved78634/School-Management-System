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
    public partial class UpdateFiance : Form
    {
        public UpdateFiance()
        {
            InitializeComponent();
        }
        String CMS, NAME, DUE, FATHER, MONTH, AMOUNT;
        Boolean flag = true;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cms_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void del_Click(object sender, EventArgs e)
        {
            //search
            cmd = new SqlCommand("Select * from Fiance ", con);

            con.Open();
            sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                CMS = (string)sdr[0];
                NAME = (string)sdr[1];
                FATHER = (string)sdr[2];
                DUE = (string)sdr[3];
                MONTH = (string)sdr[4];
                AMOUNT = (string)sdr[5];
                if (CMS == cmstxt.Text && NAME == nametxt.Text)
                {
                    flag = false;

                    MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "FATHER  #" + FATHER + '\n' + "DUE  #" + DUE + '\n' + " MONTH  #" + MONTH + '\n' + "AMOUNT  #" + AMOUNT + '\n' , "FIANCE Details ");
                    cms.Text = "" + CMS;
                    name.Text = "" + NAME;
                    father.Text = "" + FATHER;
                    due.Text = "" + DUE;
                    month.Text = "" + MONTH;
                    amount.Text = "" + AMOUNT;
                
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

            nametxt.Clear();
            cmstxt.Clear();



            sdr.Close();

            con.Close();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateFiance_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form5 jdks = new Form5();
            jdks.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            //update
            SqlCommand cmd = new SqlCommand("UPDATE Fiance SET cms=@cms, name=@name,father=@father,due=@due,month=@month,amount=@amount WHERE  cms=@cms", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cms", cms.Text);
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@father", father.Text);
            cmd.Parameters.AddWithValue("@due", due.Text);
            cmd.Parameters.AddWithValue("@month", month.Text);

            cmd.Parameters.AddWithValue("@amount", amount.Text);




            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show(" Student Fiance Succesfully updated ", "updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cms.Text = "";
            name.Text = "";
            father.Text = "";
            due.Text = "";
            month.Text = "";
            amount.Text = "";

        }
    }
}
