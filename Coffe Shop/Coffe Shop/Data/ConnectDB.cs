using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Coffe_Shop.Data;
using Coffe_Shop.Forms;

namespace Coffe_Shop.Data
{
    public class ConnectDB
    {

        SqlConnection ocon = new SqlConnection("Data Source=DESKTOP-9KA8F81;Initial Catalog=DBCafeteria;Integrated Security=True");

        public void Login(string Usu,string clave)
        {
            
        }
    }
}
