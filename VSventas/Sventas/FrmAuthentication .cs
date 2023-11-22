using Sventas.Connection_and_Class;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sventas
{
    public partial class Authentication : Form
    {
        BackgroundWorker bg = new BackgroundWorker();
        Connection con;
        frmMenu men;
        int cont = 3;
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


        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            int progreso = 0, porciento = 0;


            for (int i = 0; i <= 100; i++)
            {
                progreso++;
                Thread.Sleep(50);
                bg.ReportProgress(i);
            }
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            progressBar.Style = ProgressBarStyle.Blocks;


            if (e.ProgressPercentage > 100)
            {
                Prtj.Text = "100%";
                progressBar.Value = progressBar.Maximum;
            }
            else
            {
                Prtj.Text = Convert.ToString(e.ProgressPercentage) + "%";
                progressBar.Value = e.ProgressPercentage;
            }

        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            men = new frmMenu(con);

            men.Show();
            this.Hide();
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            //Validar espacios vacios 
            if (txtUser.Text.Equals("") || txtPass.Text.Equals(""))
            {
                MessageBox.Show("No pueden haber campos vacios ", "Intente de nuevo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
                return;
            }

            con = new Connection(txtUser.Text, txtPass.Text);
            if (this.con.connect.State == ConnectionState.Open)
            {

                bg.WorkerReportsProgress = true;
                bg.ProgressChanged += bgw_ProgressChanged;
                bg.DoWork += bgw_DoWork;
                bg.RunWorkerCompleted += bgw_RunWorkerCompleted;
                bg.RunWorkerAsync();
                Prtj.Visible = true;
                progressBar.Visible = true;

            }
            else
            {
                Cursor.Current = Cursors.Default;
                --cont;
                MessageBox.Show("Error:usuario o contraseña incorrecta ", cont + " Intentos restantes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (cont == 0)
                {
                    cont = 3;
                    btnAceptar.Enabled = false;
                    btnCancelar.Enabled = false;
                    Thread.Sleep(5000);
                    btnAceptar.Enabled = true;
                    btnCancelar.Enabled = true;

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
