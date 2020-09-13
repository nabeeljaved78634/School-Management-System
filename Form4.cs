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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void insertrecord_Click(object sender, EventArgs e)
        {
            InsertFacultyRecord ins = new InsertFacultyRecord();
            ins.Show();
            Visible = false;
        }

        private void searchrecord_Click(object sender, EventArgs e)
        {
            SearchFacultyRecord abc = new SearchFacultyRecord();
            abc.Show();
            Visible = false;
        }

        private void updaterecord_Click(object sender, EventArgs e)
        {
            UpdateFaculty up = new UpdateFaculty();
            up.Show();
            Visible = false;
        }

        private void deleterecord_Click(object sender, EventArgs e)
        {
            DeleteFacultyRecord ing = new DeleteFacultyRecord();
            ing.Show();
            Visible = false;
        }
    }
}
