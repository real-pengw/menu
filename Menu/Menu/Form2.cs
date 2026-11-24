using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1.pricesum = Form1.MainPrice[comboBox1.SelectedIndex] + Form1.AddonsPrice[comboBox2.SelectedIndex];
            Form1.Msg += comboBox1.Text + Environment.NewLine + "------------" + Environment.NewLine;
            Form1.Msg += comboBox2.Text + Environment.NewLine + "------------" + Environment.NewLine;
            Form3 form3 = new Form3();
            form3.ShowDialog();

        }
    }
}
