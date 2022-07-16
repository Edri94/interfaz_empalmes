using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEmplames
{
    public partial class PantallaPrincipal : Form
    {
        bool loggeado;

        Login form;

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrir Reporte Empalme Saldos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void houstonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(loggeado)
            {
                EmpalmeSaldos form = new EmpalmeSaldos();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                MessageBox.Show("Primero debes iniciar sesion", "Error de permisos");
            }
           
        }

      

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new Login();

                if (form != null)
                {
                    //form.MdiParent = this;
                    form.ShowDialog();

                    loggeado = form.loggeado;
                }
            }
            form = null;
            
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new Login();

                if (form != null)
                {
                    //form.MdiParent = this;
                    form.ShowDialog();

                    loggeado = form.loggeado;
                }
            }
            form = null;
        }
    }
}
