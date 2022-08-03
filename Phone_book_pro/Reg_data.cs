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
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {

        }

        private void New_butt_Click(object sender, EventArgs e)
        {
            this.Save_butt.Enabled = true;
            this.New_butt.Enabled = false;
            this.Info_gbox.Enabled = true;
        }

        private void Save_butt_Click(object sender, EventArgs e)
        {






            if (this.id_textBox.Text == "")
            {
                MessageBox.Show("Enter all details!");
                return;

            }


            this.New_butt.Enabled = true;
            this.Save_butt.Enabled = false;
            this.Info_gbox.Enabled = false;


            



            //    //---------id---------------------------
            //string fn;
            //fn = "C:\\Users\\Fred Chuks\\Documents\\How";
            //string s;
            //s = fn + this.id_textBox.Text + "_fn.txt";
            //System.IO.File.WriteAllText(fn, this.firstname_textBox.Text, Encoding.UTF8);


            //------------ID------------------------------
            string t;
            t = this.id_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\information.txt", t, Encoding.UTF8);
            //---------------------------------------------

            //--------First Name---------------------------
            string u;
            u = this.firstname_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info1.txt", u, Encoding.UTF8);
            //---------------------------------------------

            //-------Last Name-----------------------------
            string v;
            v = this.lastname_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info2.txt", v, Encoding.UTF8);
            //---------------------------------------------

            //--------Tell No------------------------------
            string w;
            w = this.tell_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info3.txt", w, Encoding.UTF8);
            //---------------------------------------------

            //-------Cell No-------------------------------
            string x;
            x = this.cell_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info4.txt", x, Encoding.UTF8);
            //---------------------------------------------

            //-------Email---------------------------------
            string y;
            y = this.email_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info5.txt", y, Encoding.UTF8);
            //---------------------------------------------

            //-------Address-------------------------------
            string z;
            z = this.address_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info6.txt", z, Encoding.UTF8);
            //---------------------------------------------

            //------Comment--------------------------------
            string z1;
            z1 = this.comment_textBox.Text;
            System.IO.File.WriteAllText("C:\\Users\\Fred Chuks\\Documents\\How\\info7.txt", z1, Encoding.UTF8);
            //---------------------------------------------


           











            //    //------------Reset text---------------

            this.id_textBox.ResetText();
            this.firstname_textBox.ResetText();
            this.lastname_textBox.ResetText();
            this.cell_textBox.ResetText();
            this.tell_textBox.ResetText();
            this.email_textBox.ResetText();
            this.address_textBox.ResetText();
            this.comment_textBox.ResetText();

            //    //--------------------------------------


            MessageBox.Show("Saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
