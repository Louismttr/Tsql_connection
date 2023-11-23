using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics.Contracts;
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

                connect = new SqlConnection("Server=Luisa\\SQLEXPRESS;Database=SVentas;UID=" + user + ";PWD=" + pass);
                connect.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("No se puede conectar al servidor!", "Advertencia!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public void InsertProduct(string cod, string NombreProd, float precio, int exits, string RUC  )
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                SqlParameter[] param = new SqlParameter[5];
                param[0] = new SqlParameter("@CodP", SqlDbType.Char);
                param[0].Value = cod;
                param[1] = new SqlParameter("@NP", SqlDbType.VarChar);
                param[1].Value = NombreProd;
                param[2] = new SqlParameter("@PrecioP", SqlDbType.Money);
                param[2].Value = precio;
                param[3] = new SqlParameter("@ExistP", SqlDbType.VarChar);
                param[3].Value = exits;
                param[4] = new SqlParameter("@RUC", SqlDbType.VarChar);
                param[4].Value = RUC;
                

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertProduct";
                cmd.Connection = connect;
                cmd.Parameters.AddRange(param);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(ds);
            }
            catch (Exception)
            {

                MessageBox.Show("Error en la insercion",  "Intentalo, nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }
        public void ModificarPro(DataGridView GridView1, string cod, string NombreProd, float precio, int exits, string RUC)
        {

        }
        public void listarProductos(DataGridView GridView1)
        {

            SqlCommand cmd = new SqlCommand();
            //SqlDataReader read;

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "MostrarProd";
            cmd.Connection = connect;


            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            GridView1.DataSource = dt;

        }
    }
}
