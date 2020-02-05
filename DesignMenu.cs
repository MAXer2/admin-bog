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
    public partial class DesignMenu : Form
    {
        public DesignMenu()
        {
            InitializeComponent();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            ButtonDesign buttonDesign = new ButtonDesign();
            buttonDesign.ShowDialog();
            Vars.ColorAllButtons(this);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            RecursiaCalc form2 = new RecursiaCalc();
            form2.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Vars.ColorAllButtons(this);
        }
    }
}
