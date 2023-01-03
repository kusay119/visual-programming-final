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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form2 nm = new Form2();
            nm.Show();
        }
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           
        }
        Boolean b = true;
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(b==true)
            {
                menuStrip1.Dock= DockStyle.Left;
                b = false;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\reeto\OneDrive\Desktop\spor\gym icons and images\Name-48-50px\img3.jpg");
            }
            else
            {
                menuStrip1.Dock = DockStyle.Top;
                b = true;
                toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\reeto\OneDrive\Desktop\spor\gym icons and images\Name-48-50px\img2.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripMenuItem1.Image = Image.FromFile(@"C:\Users\reeto\OneDrive\Desktop\spor\gym icons and images\Name-48-50px\img3.jpg");
        }

        private void newStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 ns= new Form3();
            ns.Show();
        }

        private void equToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4frm = new Form4();
            form4frm.Show();
        }

        private void searchMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7form7 = new Form7();
            form7form7.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("close","close",MessageBoxButtons.YesNo,MessageBoxIcon.Error) == DialogResult.Yes) 
                {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("welcome back","welcome",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
