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
                    neuerUserForm form2 = new neuerUserForm();
                    form2.ShowDialog();

                    if (form2.zumLogin)
                    {
                        continue;
                    }
                }
                if (form1.zumLogin)
                {
                    LoginForm loginForm= new LoginForm();
                    loginForm.ShowDialog();
                    if (loginForm.zummMain)
                    {
                        continue;
                    }
                    User user = loginForm.user;
                    if (user != null)
                    {
                        KontoForm kontoForm = new KontoForm();
                        kontoForm.ShowDialog();
                    }
                }
                break;
            } 
        }
    }
}
