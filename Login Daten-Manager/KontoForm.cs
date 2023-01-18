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

namespace Login_Daten_Manager
{
    public partial class KontoForm : Form
    {
        SqlConnection sqlConnection;
        public KontoForm()
        {
            InitializeComponent();
            String connectionString = ConfigurationManager.ConnectionStrings["Login_Daten_Manager.Properties.Settings.C__DBConnectionString"].ConnectionString;
            sqlConnection = new SqlConnection(connectionString);
            dataView();
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

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            String nameInt = tb1.Text;
            String loginName = tb2.Text;
            String loginPass = tb3.Text;

            if (nameInt.Length == 0 || loginName.Length == 0 || loginPass.Length == 0)
            {
                MessageBox.Show("bitte Daten eingeben!", "die Felde sind leer!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                sqlConnection.Open();
                String query = "insert  into LDM_daten (Name, Loginname, Loginpasswort) values('" + nameInt + "', '" + loginName + "', '" + loginPass + "')";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally
            {
                sqlConnection.Close();
                reset();
                dataView();
            }

        }
        private void reset()
        {
            this.tb1.Text = "";
            this.tb2.Text = string.Empty;
            this.tb3.Text = string.Empty;
            this.tb4.Text = string.Empty;
            this.label4.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                label4.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                tb1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                tb2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                tb3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            }
        }

        private void btnLöschen_Click(object sender, EventArgs e)
        {
            String id = label4.Text;
            try
            {
                sqlConnection.Open();

                String query = "delete from LDM_daten where Id = '" + id + "'";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally 
            { 
                MessageBox.Show("der Eintrag wurde gelöscht", "Login Daten-Manager", MessageBoxButtons.OK, MessageBoxIcon.Information);
                sqlConnection.Close();
                reset();
                dataView();
            }
        }

        private void dataView() 
        {
            try
            {
                sqlConnection.Open();

                String query = "select * from LDM_daten";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = sqlcmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                reader.Close();
                dataGridView1.DataSource= dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally 
            {
                sqlConnection.Close();
            }
        }
        private void btnNeuStart_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                String query = "truncate table LDM_daten";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally
            {
                MessageBox.Show("das Konto wurde neugestarted!", "Login Daten-Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sqlConnection.Close(); 
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String nameInt = tb1.Text;
            String loginName = tb2.Text;
            String loginPass = tb3.Text;
            String id = label4.Text;
            try
            {
                sqlConnection.Open();
                String query = "update LDM_daten set Name = '" + nameInt + "', Loginname = '" + loginName + "', Loginpasswort = '" + loginPass + "' where Id = '" + id + "'";
                SqlCommand sqlcmd = new SqlCommand(query, sqlConnection);
                sqlcmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally
            {
                MessageBox.Show("das Konto wurde aktualisiert!", "Login Daten-Manager", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sqlConnection.Close();
                reset();
                dataView();
            }
        }
        private void btnSuchen_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
    
                SqlDataAdapter sda = new SqlDataAdapter("select * from LDM_daten", sqlConnection);

                DataTable dt = new DataTable();
                sda.Fill(dt);
                DataView dv = dt.DefaultView;
                dv.RowFilter = String.Format("Name LIKE '%{0}%'", tb4.Text);
                dataGridView1.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Daten-Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
