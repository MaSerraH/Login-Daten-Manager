using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Daten_Manager
{
    public partial class KontoForm : Form
    {
        public KontoForm()
        {
            InitializeComponent();
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
    }
}
