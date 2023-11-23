using Sventas.Connection_and_Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sventas
{
    public partial class frmMenu : Form
    {
        public Connection con;
        
        public frmMenu(Connection con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenPanel(new Productos(con));

            //Otra opcion para abrir formularios
            //Productos pro = new Productos(con);
            //pro.MdiParent = this;

            //pro.Show();

        }

        ///Abrir formularios
        ///
        private void OpenPanel(object FrmSon)
        {
            if (this.pContiene.Controls.Count > 0)
                this.pContiene.Controls.RemoveAt(0);
            Form fh = (Form)FrmSon;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pContiene.Controls.Add(fh);
            this.pContiene.Tag = fh;
            fh.Show();
        }
    }
}
