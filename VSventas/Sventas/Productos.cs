using Sventas.Connection_and_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sventas
{
    public partial class Productos : Form
    {
        private Connection con;
        int renglon;
        public Productos(Connection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtCod.Text.Equals("") || txtNom.Text.Equals("") || txtPre.Text.Equals("") || txtRUC.Text.Equals("") || txtExis.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios", "Intentalo, nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            con.InsertProduct(txtCod.Text, txtNom.Text, float.Parse(txtPre.Text), int.Parse(txtExis.Text), txtRUC.Text);
            MessageBox.Show("Producto regristrado, exitosamente!", "Listo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void ListarProd()
        {
            con.listarProductos(dgvProd);
        }

        private void dgvProd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            renglon = e.RowIndex;
        }

        private void dgvProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
