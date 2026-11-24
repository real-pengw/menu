using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.Msg += "費收" + (int)Form1.pricesum + "元" + Environment.NewLine;
           }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Form1.pricesum *= 0.95;
                Form1.Msg += "會員95折" + Environment.NewLine;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Form1.pricesum -= 20;
            Form1.Msg += "折價券折20元" + Environment.NewLine;
        }
    }
}
