using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SchoolManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.progressBar1.Minimum = 1;
            this.progressBar1.Maximum = 200;
            this.progressBar1.Value = 1;
            for (int i = 1; i < 200; i++)
            {
                this.progressBar1.Value++;
            }

        }

        private void login_Click(object sender, EventArgs e)
        {

           
            if (cms.Text.Equals("admin") && password.Text.Equals("12345"))
            {
                
                    Form2 frm1 = new Form2();

                    frm1.Show();
                    Visible = false;
                 }

            else if (cms.Text.Equals("") && password.Text.Equals(""))
            {
                MessageBox.Show("PLEASE ENTER ADMIN AND PASSWORD");
            }


            else
            {
                MessageBox.Show("Invlid ADMIN or PASSWORD");
            }


        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
