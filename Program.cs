using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            Color color = Color.Red;
            int x = color.ToArgb();

            Color color2 = Color.FromArgb(x);

            Vars.CONN = new MySqlConnection(Vars.CONNECTION_STRING);
            while (Vars.CONN.State != ConnectionState.Open)
            {
                Vars.CONN.Open();
            }

            Vars.ReadDesign();
            Application.Run(new DesignMenu());

            Vars.CONN.Close();
        }
    }
}
