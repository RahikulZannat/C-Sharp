using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dairy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string user, pass;
            user = txtuser.Text;
            pass = txtpass.Text;
            if(user=="admin"&& pass=="1234")
            {
                MessageBox.Show("Successful");
                Form2 f2 = new Form2();
                f2.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Error");
            }

            

        }
    }
}
