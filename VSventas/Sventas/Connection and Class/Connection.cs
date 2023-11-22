using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sventas.Connection_and_Class
{
    public class Connection
    {
        public SqlConnection connect = new SqlConnection();
        public Connection(String user, String pass)
        {
            try
            {

                connect = new SqlConnection("Server=Luisa\\SQLEXPRESS;Database=Clientes;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede conectar al servidor!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
