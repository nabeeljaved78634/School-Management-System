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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void insertfee_Click(object sender, EventArgs e)
        {
            InsertFiance ab = new InsertFiance();
            ab.Show();
            Visible = false;
        }

        private void searchfee_Click(object sender, EventArgs e)
        {
            SearchFiance ss = new SearchFiance();
            ss.Show();
            Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 dhhd = new Form2();
            dhhd.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updatefee_Click(object sender, EventArgs e)
        {
            UpdateFiance dnk = new UpdateFiance();
            dnk.Show();
            Visible = false;

        }
    }
}
