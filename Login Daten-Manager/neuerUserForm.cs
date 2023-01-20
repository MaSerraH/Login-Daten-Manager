using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_Daten_Manager
{
    public partial class neuerUserForm : Form
    {
        SqlConnection sqlConnection;
        public neuerUserForm()
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

        public bool zumLogin = false;
        private void btnZumLogin_Click(object sender, EventArgs e)
        {
            this.zumLogin = true;
            this.Close();
        }
        public User user = null;
        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            User user = new User();

            String name = this.tb1.Text;
            String email = this.tb2.Text;
            String passwort = this.tb3.Text;
            

            if (name.Length == 0 || email.Length == 0 || passwort.Length == 0)
            {
                MessageBox.Show("eine der Felder (Name, email oder Passwort) ist leer, bitte Daten eingeben!", "Login Daten-Manager", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                sqlConnection.Open();
     
                String query = "declare @pass nvarchar(50) set @pass = CONVERT(NVARCHAR(32), HashBytes('MD5', '" + passwort +"'), 2) insert into LDM_login(Name, Email, Passwort)" + "values('" + name + "', '" + email + "',  @pass )";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Loding Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                Application.Exit();
                
            }
            finally {
                MessageBox.Show("neuer User gespeichert", "Login Daten-Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.tb1.Text = "";
                this.tb2.Text = "";
                this.tb3.Text = "";
                sqlConnection.Close(); 
            }

        }

        private void btnUserLoeschen_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                String query = "truncate table LDM_login";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Login Daten Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                MessageBox.Show("der User wurde gelöscht!", "Lodin Daten-Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sqlConnection.Close(); 
            }
        }
    }
}
