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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eq = txteq.Text;
            string descripion = richTextBoxds.Text;
            string used = txtused.Text;
            string date = dateTimePickerdl.Text;
            Int64 cost = Int64.Parse(txtcost.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txteq.Clear();
            richTextBoxds.Clear();
            txtused.Clear();
            txtcost.Clear();
            dateTimePickerdl.Value= DateTime.Now;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
