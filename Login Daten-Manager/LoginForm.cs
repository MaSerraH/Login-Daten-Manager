using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_Daten_Manager
{
    public partial class LoginForm : Form
    {
        SqlConnection sqlConnection;
        public LoginForm()
        {
            InitializeComponent();
            String connectionString = ConfigurationManager.ConnectionStrings["Login_Daten_Manager.Properties.Settings.C__DBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            try
            {
                Exit = MessageBox.Show("möchten Sie wirklich schließen?", "Login Daten Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Exit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        public bool zummMain = false;
        private void btnZumMain_Click(object sender, EventArgs e)
        {
            this.zummMain = true;
            this.Close();
        }
        
        public User user = null;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            user = new User();
            String name = tb1.Text;
            String passwort = tb2.Text;

            if (name.Length == 0 || passwort.Length == 0)
            {
                MessageBox.Show("Name und Passwort bitte eingeben!", "die Felde sind leer!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                sqlConnection.Open();
                String query = "declare @pass nvarchar(50) set @pass = CONVERT(NVARCHAR(32), HashBytes('MD5', '" + passwort + "'), 2) select * from LDM_login where Name = '" + name + "' and Passwort = @pass";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);

                SqlDataReader reader = sqlcmd.ExecuteReader();
                if (reader.Read())
                {
                    user.Equals(reader.GetString(1));
                    user.Equals(reader.GetString(3));
                    MessageBox.Show("ein neuer User " + name + " hat sich eingeloggt!", "Login erfogt!", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("der User mit dem Name: " + name + ", existiert nicht!", "Login Fehler", MessageBoxButtons.OK);
                    Application.Exit();
                }
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loding Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                Application.Exit();
            }
            finally {
                
                sqlConnection.Close();
                this.Close();

            }
        }
    }
}
