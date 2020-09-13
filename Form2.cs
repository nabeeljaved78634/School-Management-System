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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
           InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            //student Record
            
            Form3 frm = new Form3();
            frm.Show();
            Visible = false;
        }

        private void fiance_Click(object sender, EventArgs e)
        {
            //fiance button
            Form5 hhs = new Form5();
            hhs.Show();
            Visible = false;

        }

      
        private void button4_Click(object sender, EventArgs e)
        {
            // Faculty record
            Form4 obk = new Form4();
            obk.Show();
            Visible = false;
        }

        private void grades_Click(object sender, EventArgs e)
        {
            //grades
            Form6 jdk = new Form6();
                jdk.Show();
            Visible = false;
        }
    }
}
