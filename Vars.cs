using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public static class Vars
    {
        /// <summary>
        /// Цвет всех кнопок
        /// </summary>
        public static Color BUTTON_COLOR = Color.FromArgb(128, 0, 0);
        /// <summary>
        /// Шрифт всех кнопок
        /// </summary>
        public static Font BUTTON_FONT = new Font("Arial", 10);
        public static Font LABEL_FONT = new Font("Arial", 10);
        public static Image BUTTON_IMAGE;
        public static Image BUTTON_BACKGROUND_IMAGE;
        public static Color BUTTON_TEXT_COLOR = Color.Black;
        public static Color LABEL_COLOR = Color.DarkCyan;
        public static Color PANEL_COLOR = Color.FromArgb(84,156,243);
        public static int size1 = 20;
        public static int size2 = 30;
        /// <summary>
        /// Поменять цвета всех кнопок
        /// </summary>

        public static string CONNECTION_STRING =
           "SslMode=none;" +
           "Server=db4free.net;" +
           "database=ingenerka;" +
           "port=3306;" +
           "uid=ingenerka;" +
           "pwd=Beavis1989;" +
           "old guids=true;";
        public static MySqlConnection CONN;

        /// <summary>
        /// Select-запрос
        /// </summary>
        /// <param name="sqlzapros"></param>
        /// <returns></returns>
        public static List<string> Select(string sqlzapros)
        {
            List<string> res = new List<string>();
            MySqlCommand q = new MySqlCommand(sqlzapros, CONN);
            MySqlDataReader r = q.ExecuteReader();

            while (r.Read())
            {
                for (int inc = 0; inc < r.FieldCount; inc++)
                {
                    res.Add(r[inc].ToString());
                }
            }
            r.Close();

            return res;
        }
        /// <summary>
        /// Update-запрос
        /// </summary>
        public static void Update(string zapros)
        {
            MySqlCommand q = new MySqlCommand(zapros, CONN);
            MySqlDataReader r = q.ExecuteReader();
            r.Close();
        }

        /// <summary>
        /// Читаем дизайн из базы
        /// </summary>
        public static void ReadDesign()
        {
            List<string> DefaultDesign = Select("SELECT Parameter, Value, objectType FROM DefaultDesign");
            

            for (int i =0; i < DefaultDesign.Count; i = i + 3)
            {
                try
                {
                    if (DefaultDesign[i] == "Button_Color")
                    {
                        BUTTON_COLOR = Color.FromArgb(
                            Convert.ToInt32(DefaultDesign[i + 1])
                        );
                    }
                    if (DefaultDesign[i] == "Label_Font")
                    {
                        string[] parts = DefaultDesign[i + 1].Split(new char[] { ',' });
                        LABEL_FONT = new Font(parts[0], Convert.ToInt32(parts[1]));                
                    }
                    if (DefaultDesign[i] == "Button_Font")
                    {
                        string[] parts1 = DefaultDesign[i+1].Split(new char[] { ',' });
                        BUTTON_FONT = new Font(parts1[0], (float)(Convert.ToDouble(parts1[1])));
                    }
                    if (DefaultDesign[i] == "Button_Font_Color")
                    {
                        BUTTON_TEXT_COLOR = Color.FromArgb(
                            Convert.ToInt32(DefaultDesign[i + 1]));
                    }
                    if (DefaultDesign[i] == "Label_Font_Color")
                    {
                      

                      LABEL_COLOR = Color.FromArgb(
                            Convert.ToInt32(DefaultDesign[i + 1]));
                    }
                    if (DefaultDesign[i] == "Panel_Color")
                    {
                      PANEL_COLOR = Color.FromArgb(
                              Convert.ToInt32(DefaultDesign[i + 1]));
                    }
                    if (DefaultDesign[i] == "Button_Background_Image")
                    {
                        PictureBox pb1 = new PictureBox();
                        pb1.Load(@"..\..\images\FON\" + DefaultDesign[i + 1].ToString());

                        BUTTON_BACKGROUND_IMAGE = pb1.Image;
                    }

                }
                catch (Exception) { }
            }
        }
       

        public static void ColorAllButtons(Control panel)
        {
            foreach (Control ctrl in panel.Controls  )
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
                    if (ctrl is Panel)
                    {
                        Panel pnl = (Panel)ctrl;
                        pnl.BackColor = Vars.PANEL_COLOR;
                    }
                    if (ctrl is TabControl)
                    {
                        TabControl pnl = (TabControl)ctrl;
                        pnl.BackColor = Vars.PANEL_COLOR;

                        foreach (TabPage ctrl2 in pnl.TabPages)
                        {
                            ColorAllButtons(ctrl2);
                        }
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
