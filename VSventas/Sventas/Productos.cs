using Sventas.Connection_and_Class;
using System;
using System.Windows.Forms;

namespace Sventas
{
    public partial class Productos : Form
    {
        public Connection con;
        int renglon;

        public Productos(Connection con)
        {
            this.con = con;
            InitializeComponent();
            ListarProd();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (txtCod.Text.Equals("") || txtNom.Text.Equals("") || txtPre.Text.Equals("") || txtRUC.Text.Equals("") || txtExis.Text.Equals(""))
            {
                MessageBox.Show("No se puede dejar campos vacios", "Intentalo, nuevamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            con.InsertProduct(txtCod.Text, txtNom.Text, Convert.ToInt32(txtPre.Text), Convert.ToInt32(txtExis.Text), txtRUC.Text);
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

        private void dgvProd_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCod.Text = "";
            txtNom.Text = "";
            txtPre.Text = "";
            txtExis.Text = "";
            txtRUC.Text = "";   
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
