using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone_book_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reg_data rgd = new Reg_data();
            rgd.MdiParent = this;
            rgd.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_data sd = new Search_data();
            sd.MdiParent = this;
            sd.Show();
        }

      
        

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            About_Us au = new About_Us();
            au.MdiParent = this;
            au.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode== Keys.F2)
            {
                toolStripButton1_Click(sender, e);
            }
            //-------------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            //-------------------------------
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton3_Click(sender, e);
            }
            //-------------------------------
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton6_Click(sender, e);
            }
            //-------------------------------
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton5_Click(sender, e);
            }

        }
    }
}
