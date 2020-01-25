using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ButtonDesign : Form
    {
        public static string login;

        public ButtonDesign()
        {
            InitializeComponent();
            Vars.ColorAllButtons(this);



            foreach (Control ctrl in Controls)
            {
                try
                {
                    //ExtremeCode Курс C# для маленьких и тупых
                    if (ctrl is Button)
                    {
                        ctrl.MouseEnter += new System.EventHandler(buttonmovedown);
                        ctrl.MouseLeave += new System.EventHandler(buttonmoveup);
                    }
                }
                catch (Exception) { }
             }

        }

       

        private void Button3_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Standard;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Popup;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
        }

  
        private void Button6_Click(object sender, EventArgs e, int x , int y)
        {
            button1.FlatStyle = FlatStyle.Flat;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.Load(openFileDialog1.FileName);
           Vars.BUTTON_IMAGE= pictureBox2.Image;
           
            Vars.ColorAllButtons(this);
            //fontDialog1.Color
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = false;
            DirectoryInfo di1 = new DirectoryInfo(@"..\..\images\FON");
            openFileDialog1.InitialDirectory = di1.FullName;

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                Vars.BUTTON_BACKGROUND_IMAGE = pictureBox1.Image;
                Vars.ColorAllButtons(this);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Vars.LABEL_COLOR;
            colorDialog1.ShowDialog();
            Vars.LABEL_COLOR = colorDialog1.Color;
            Vars.ColorAllButtons(this);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
          
        }


        private void Button12_Click(object sender, EventArgs e)
        {

        }

      void buttonmoveup(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Location = new Point(btn.Location.X, btn.Location.Y + 15);
            System.Threading.Thread.Sleep(30);
        }
        void buttonmovedown(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.Location = new Point(btn.Location.X, btn.Location.Y - 15);
            System.Threading.Thread.Sleep(30);
        }

       

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            
            fontDialog1.Font = Vars.LABEL_FONT;
            fontDialog1.ShowDialog();
            Vars.LABEL_FONT = fontDialog1.Font;
            Vars.ColorAllButtons(this);
            //fontDialog1.Color*/
        }

        private void Текст_Click(object sender, EventArgs e)
        {

        }

      

        private void BunifuFlatButton3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.Load(openFileDialog1.FileName);
            Vars.BUTTON_IMAGE = pictureBox2.Image;

            Vars.ColorAllButtons(this);
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            openFileDialog1.RestoreDirectory = false;
            DirectoryInfo di1 = new DirectoryInfo(@"..\..\images\FON");
            openFileDialog1.InitialDirectory = di1.FullName;

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                pictureBox1.Load(openFileDialog1.FileName);
                Vars.BUTTON_BACKGROUND_IMAGE = pictureBox1.Image;
                Vars.ColorAllButtons(this);
            }
        }

        private void BunifuFlatButton5_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Vars.BUTTON_COLOR;
            colorDialog1.ShowDialog();
            Vars.BUTTON_COLOR = colorDialog1.Color;
            Vars.ColorAllButtons(this);
        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Vars.BUTTON_TEXT_COLOR;
            colorDialog1.ShowDialog();
            Vars.BUTTON_TEXT_COLOR = colorDialog1.Color;
            Vars.ColorAllButtons(this);
        }

        private void BunifuFlatButton7_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = Vars.BUTTON_FONT;
            fontDialog1.ShowDialog();
            Vars.BUTTON_FONT = fontDialog1.Font;
            Vars.ColorAllButtons(this);
            //fontDialog1.Color
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Vars.LABEL_COLOR;
            colorDialog1.ShowDialog();
            Vars.LABEL_COLOR = colorDialog1.Color;
            Vars.ColorAllButtons(this);
        }

        private void BunifuFlatButton9_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Vars.PANEL_COLOR;
            colorDialog1.ShowDialog();
            Vars.PANEL_COLOR = colorDialog1.Color;
            Vars.ColorAllButtons(this);
        }

       

        private void BunifuFlatButton12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }

        private void BunifuFlatButton13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void BunifuFlatButton11_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void BunifuFlatButton10_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;

        }

        private void BunifuFlatButton15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
        }

        private void BunifuFlatButton14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
        }
    }
}
