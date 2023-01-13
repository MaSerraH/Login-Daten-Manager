using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Daten_Manager
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            while (true)
            {
                Form1 form1 = new Form1();  
                form1.ShowDialog();

                if (form1.neuerUser)
                {
                    Form2 form2 = new Form2();
                    form2.ShowDialog();

                }


                break;
            }
            
        }
    }
}
