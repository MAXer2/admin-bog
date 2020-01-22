using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Vars
    {
        /// <summary>
        /// Цвет всех кнопок
        /// </summary>
        public static Color BUTTON_COLOR = Color.Aqua;
        /// <summary>
        /// Шрифт всех кнопок
        /// </summary>
        public static Font BUTTON_FONT = new Font("Arial", 10);
        public static Font LABEL_FONT = new Font("Arial", 10);
        public static Image BUTTON_IMAGE;
        public static Image BUTTON_BACKGROUND_IMAGE;
        public static Color BUTTON_TEXT_COLOR = Color.Black;
        public static Color LABEL_COLOR = Color.Black;
        public static int size1 = 20;
        public static int size2 = 30;
        /// <summary>
        /// Поменять цвета всех кнопок
        /// </summary>
        public static void ColorAllButtons(Control panel)
        {
            foreach (Control ctrl in panel.Controls)
            {
                try
                {
                    //ExtremeCode Курс C# для маленьких и тупых
                    if (ctrl is Button)
                    {
                        Button btn = (Button)ctrl;
                        btn.BackColor = Vars.BUTTON_COLOR;
                        btn.Font = Vars.BUTTON_FONT;
                        btn.ForeColor = Vars.BUTTON_TEXT_COLOR;

                        btn.BackgroundImage = Vars.BUTTON_BACKGROUND_IMAGE;
                        btn.BackgroundImageLayout = ImageLayout.Stretch;

                        btn.Image = Vars.BUTTON_IMAGE;
                        btn.ImageAlign = ContentAlignment.MiddleLeft;
                    }
                    if (ctrl is Label)
                    {
                        Label lbl = (Label)ctrl;
                        lbl.ForeColor = Vars.LABEL_COLOR;
                        lbl.Font = Vars.LABEL_FONT;
                    }
                }
                catch (Exception)
                {
                    ColorAllButtons(ctrl);
                }
            }
        }
    }
}
