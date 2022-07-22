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

        Login form_login;
        Reporte_SaldoVencimientos form_reporte;
        Vencimientos form_vencimientos;
        EmpalmeHoldHou form_empalmeholds;

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Abrir Formulario Reporte Empalme Saldos
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

      
        /// <summary>
        /// Abrir Formulario Loggeo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form_login == null)
            {
                form_login = new Login();

                if (form_login != null)
                {
                    //form.MdiParent = this;
                    form_login.ShowDialog();

                    loggeado = form_login.loggeado;
                }
            }
            form_login = null;
            
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            if (form_login == null)
            {
                form_login = new Login();

                if (form_login != null)
                {
                    //form.MdiParent = this;
                    form_login.ShowDialog();

                    loggeado = form_login.loggeado;
                }
            }
            form_login = null;
        }

        /// <summary>
        /// Abrir Formulario  Reporte Saldo de Vencimientos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loggeado)
            {
                if(form_reporte == null)
                {
                    form_reporte = new Reporte_SaldoVencimientos();

                    if(form_reporte != null)
                    {
                        form_reporte.MdiParent = this;
                        form_reporte.Show();
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Primero debes iniciar sesion", "Error de permisos");
            }
        }

        /// <summary>
        /// Abrir formulario Vencimientos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void houstonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (loggeado)
            {
                if (form_vencimientos == null)
                {
                    form_vencimientos = new Vencimientos();

                    if (form_vencimientos != null)
                    {
                        form_vencimientos.MdiParent = this;
                        form_vencimientos.Show();
                    }
                }

            }
            else
            {
                MessageBox.Show("Primero debes iniciar sesion", "Error de permisos");
            }
        }

        /// <summary>
        /// Abrir formulario Empalmes Hold's
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (loggeado)
            {
                if (form_empalmeholds == null)
                {
                    form_empalmeholds = new EmpalmeHoldHou();

                    if (form_empalmeholds != null)
                    {
                        form_empalmeholds.MdiParent = this;
                        form_empalmeholds.Show();
                    }
                }

            }
            else
            {
                MessageBox.Show("Primero debes iniciar sesion", "Error de permisos");
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
