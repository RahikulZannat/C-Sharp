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
    public partial class Form2 : Form
    {

        string eName;
        string priority;
        string date;
        string desc;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eName = this.txteName.Text.ToString();

            if (radioButtonh.Checked)
                priority = "High";
            if (radioButtonm.Checked)
                priority = "Moderate";
            else if (radioButtonl.Checked)
                priority = "Less Importand";
            desc = this.txtdesc.Text.ToString();

            Form3 f3 = new Form3();
            f3.leName.Text = eName;
            f3.lpriority.Text = priority;
            f3.ldesc.Text = desc;
            f3.Show();
            this.Visible = false; 


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
