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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void insertrecord_Click(object sender, EventArgs e)
        {
            //insertrecord
            InsertRecord obj = new InsertRecord();
            obj.Show();
            Visible = false;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
            Visible = false;
        }

        private void deleterecord_Click(object sender, EventArgs e)
        {
              DeleteRecord del = new DeleteRecord();
            del.Show();
            Visible = false;
                
        }

        private void searchrecord_Click(object sender, EventArgs e)
        {
            SearchRecord obj = new SearchRecord();
            obj.Show();
            Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void updaterecord_Click(object sender, EventArgs e)
        {
            UpdateRecord update = new UpdateRecord();
            update.Show();
            Visible = false;
         }
    }
}
