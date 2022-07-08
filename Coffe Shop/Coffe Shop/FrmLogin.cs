using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Coffe_Shop.Forms;
using Coffe_Shop.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Coffe_Shop
{
    public partial class FrmLogin : Form
    {

        ConnectDB DbCon = new ConnectDB();
        
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void bntEntry_Click(object sender, EventArgs e)
        {
            SqlConnection ocon = new SqlConnection("Data Source=DESKTOP-9KA8F81;Initial Catalog=DBCafeteria;Integrated Security=True");
            ocon.Open();

            string sSQL = "select 'S' from Usuarios where Estado = 'A' and UserPass = '" + TxtPass.Text + "' and Users = '" + TxtUser.Text + "'";
            SqlCommand ocmd = new SqlCommand(sSQL, ocon);
            string sExiste = "";

            try
            {
                sExiste = ocmd.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                string sError = ex.Message;
            }

            if (!String.IsNullOrEmpty(sExiste))
            {
                
                FrmInterface frmInter = new FrmInterface();
                frmInter.Show();

                this.Hide();

            }
            else
            {
                MessageBox.Show("Clave incorrecta", "Error");
            }
        }

    }
}
