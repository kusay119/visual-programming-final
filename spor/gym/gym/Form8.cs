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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if(txtusername.Text == "admin"&& txtpassword.Text == "admin")
            {
                Form1 form1=new Form1();
                form1.Show();
                this.Hide();
            }
        }
    }
}
