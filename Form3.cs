using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int power(int x, int n)
        {
            if (n == 0)
                return 1;
            else
                return x * power(x, n - 1);
        }

        int factorial(int x)
        {
            if (x == 0)
                return 1;
            return x * factorial(x - 1);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);

            textBox3.Text = power(x, n).ToString() + "   " +
                factorial(x).ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            Vars.ColorAllButtons(this);
        }
    }
}
