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
    public partial class SearchFiance : Form
    {
        public SearchFiance()
        {
            InitializeComponent();
        }
        String CMS, NAME, DUE, FATHER, MONTH, AMOUNT;
        Boolean flag = true;


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-BD343QK;Initial Catalog=SchoolManagementSystem;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader sdr;

        private void SearchFiance_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form5 njd = new Form5();
            njd.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
               
                if (CMS == cms.Text && NAME == name.Text)
                {
                    flag = false;

                    MessageBox.Show(" CMS #: " + CMS + '\n' + "NAME  #: " + NAME + '\n' + "FATHER  #" + FATHER + '\n' + "DUE  #" + DUE + '\n' + " MONTH  #" + MONTH + '\n' + "AMOUNT #" + AMOUNT + '\n' , "STUDENT Details ");
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
    }
}
