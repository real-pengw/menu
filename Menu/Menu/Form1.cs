using System.Security.Cryptography;

namespace Menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string Msg;
        public static string[] Main = ["Big Mac",
                                 "Quarter Pounder with Cheese",
                                 "Double Cheeseburger",
                                 "McChicken",
                                 "Filet-O-Fish"];
        public static double[] MainPrice = [81, 95, 75, 51, 60];
        public static string[] Addons = ["World Famous Fries(S)",
                                  "Chicken McNuggets(4)",
                                  "Chicken McNuggets(6)",
                                  "Chicken McNuggets(10)",
                                  "Chicken McNuggets(20)"];
        public static double[] AddonsPrice = [40, 49, 69, 110, 220];
        public static double pricesum;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Msg = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Msg += "內用" + Environment.NewLine +"------------"+ Environment.NewLine;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Msg += "外帶" + Environment.NewLine +"------------"+ Environment.NewLine;
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            textBox1.Text = Msg;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Msg = "";
        }
    }
}
