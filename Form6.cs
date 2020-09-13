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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 dd = new Form2();
            dd.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void insertmarks_Click(object sender, EventArgs e)
        {
            InsertMarks kf = new InsertMarks();
            kf.Show();
            Visible = false;
        }

        private void searchmarks_Click(object sender, EventArgs e)
        {
            SearchMarks jnfj = new SearchMarks();
            jnfj.Show();
            Visible = false;
        }

        private void updatemarks_Click(object sender, EventArgs e)
        {
            UpdateMarks bdj = new UpdateMarks();
            bdj.Show();
            Visible = false;
        }
    }
}
