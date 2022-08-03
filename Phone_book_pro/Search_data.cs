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
    public partial class Search_data : Form
    {
        public Search_data()
        {
            InitializeComponent();
        }

        private void Search_data_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter ID! ");
                return;
            }


            //------------ID------------------------------
            string t;          
            t = System.IO.File.ReadAllText("C:\\Users\\Fred Chuks\\Documents\\How\\information.txt", Encoding.UTF8);
            this.id_textBox.Text = t;
            
            //--------------------------------------------

            //------------First Name----------------------
            
            string u;
            u = System.IO.File.ReadAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info.txt", Encoding.UTF8);
            this.firstname_textBox.Text = u;
            //if (System.IO.File.Exists(u) == true)
            //{
            //    MessageBox.Show(" found!");
            //    this.firstname_textBox.Text = u;

            //}
            //else
            //{
            //    //MessageBox.Show("Not found!");
            //    this.firstname_textBox.Text = "";
            //}

            //--------------------------------------------

            //-----------------Last Name------------------
            //string v;
            //v = System.IO.File.ReadAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info2.txt", Encoding.UTF8);
            //this.lastname_textBox.Text = v;

            string v;
            v = System.IO.File.ReadAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info2.txt", Encoding.UTF8);
            if (System.IO.File.Exists(v) == true)
            {

                this.lastname_textBox.Text = v;
            }
            else
            {
                this.lastname_textBox.Text = "";
            }
        }
    }
}
