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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string fname = txtfn.Text;
            string lname = txtlt.Text;
            string gender = "";
            bool ischecked = radioButton1.Checked;
            if(ischecked)
            {
                gender = radioButton1.Text; 
            }
            else
            {
                gender = radioButton2.Text; 
            }
            string dob = dateTimePickerd3.Text;
            Int64 mobile = Int64.Parse(txtme.Text);
            string maile = txtmi.Text;
            string join = dateTimePickerjj.Text;
            string state = txtstate.Text;
            string city = txtcity.Text;
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtfn.Clear();
            txtlt.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtme.Clear();
            txtmi.Clear();
            txtstate.Clear();
            txtcity.Clear();


            dateTimePickerd3.Value = DateTime.Now;
            dateTimePickerjj.Value = DateTime.Now;
        }
    }
}
