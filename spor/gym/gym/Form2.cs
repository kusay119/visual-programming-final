using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gym
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string fname = txtfirst.Text;
            string lname = txtlast.Text;
            string gender = "";
            bool isChacked = radioButton1.Checked;
            if (isChacked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            string dob = dateTimePickerdob.Text;
            Int64 mobile = Int64.Parse(txtmobile.Text);
            string emaile = txtmaile.Text;
            string joindate = dateTimePickerjoin.Text;
            string gymtime = comboBoxtime.Text;
            string addres  = richTextBoxaddres.Text;
            string member = comboBoxship.Text;
            MessageBox.Show("confrom");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfirst.Clear();
            txtlast.Clear();
            radioButton1.Checked=false;
            radioButton2.Checked=false;
            txtmobile.Clear();
            txtmaile.Clear();
            comboBoxtime.ResetText();
            comboBoxship.ResetText();
            richTextBoxaddres.Clear();
            dateTimePickerdob.Value= DateTime.Now;
            dateTimePickerjoin.Value= DateTime.Now;
        }
    }
}
