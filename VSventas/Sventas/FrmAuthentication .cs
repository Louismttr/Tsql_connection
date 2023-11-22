using Sventas.Connection_and_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sventas
{
    public partial class Authentication : Form
    {
        Connection con;
        public Authentication()
        {
            InitializeComponent();
        }

        #region Cambiar nombre de los textbox
        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Usuario")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.FromArgb(0,0,0);
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Contraseña")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.FromArgb(0, 0, 0);
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Usuario";
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Contraseña";
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void cbView_CheckedChanged(object sender, EventArgs e)
        {
            if (cbView.Checked == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }


        #endregion

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if(txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios", "Intente de nuevo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
                return;
            }

            con = new Connection(txtUser.Text, txtPass.Text);
        }

        //Validaciones
        //private void SoloLetras(object sender, KeyPressEventArgs e)
        //{
        //    if (char.IsLetter(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else if (char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}
    }
}
