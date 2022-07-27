using InterfazEmplames.Data;
using InterfazEmplames.Helpers;
using InterfazEmplames.Processes;
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
        public Empalmes empalmes;
        public bool loggeado;
        public bool conectado_bd;
        public Permiso permiso;

        Login form_login;
        Reporte_SaldoVencimientos form_reporte;
        Vencimientos form_vencimientos;
        EmpalmeHoldHou form_empalmeholds;
        Encriptacion crpt;
        public FuncionesBD bd;

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
           

            empalmes = new Empalmes();
            crpt = new Encriptacion();
            permiso = new Permiso();

            string lsCommandLine;
            int lnSpacePoint;
            string[] Parametros;
            string rutaIni;

            if (form_login == null)
            {
                EstablecrParametros();
                EstableceConexionBD();

                form_login = new Login(this);

                if (form_login != null)
                {
                    form_login.ShowDialog();

                    loggeado = form_login.loggeado;

                    
                }
            }
            form_login = null;
        }

        private void EstablecrParametros()
        {
            empalmes.DB_SVRNAME = crpt.Decrypt(Funcion.getValueAppConfig("Servidor", "BD"));
            empalmes.GsUSer = crpt.Decrypt(Funcion.getValueAppConfig("Usuario", "BD"));
            empalmes.lsPassword = crpt.Decrypt(Funcion.getValueAppConfig("Password", "BD"));
            empalmes.DB_DESARROLLO = crpt.Decrypt(Funcion.getValueAppConfig("BaseDesarrollo", "BD"));
            empalmes.DB_CATALOGOS = crpt.Decrypt(Funcion.getValueAppConfig("BaseCatalogos", "BD"));
            empalmes.DBFUNCS = crpt.Decrypt(Funcion.getValueAppConfig("BaseFuncionarios", "BD"));
            empalmes.GPATH = Funcion.getValueAppConfig("RutaReportes", "APP");
            empalmes.CNNAME = Funcion.getValueAppConfig("NombreConexion", "APP");
            empalmes.DBDSN = Funcion.getValueAppConfig("DSN", "APP");
        }

        /// <summary>
        /// Establece conexion con la base de datos de SQL Server
        /// </summary>
        /// <returns></returns>
        public bool EstableceConexionBD()
        {
            try
            {
                string conn_str = $"Data source={empalmes.DB_SVRNAME}; uid={empalmes.GsUSer}; PWD={empalmes.lsPassword}; initial catalog={empalmes.DB_DESARROLLO}";

                if (bd == null)
                {
                    bd = new FuncionesBD(conn_str);
                    bd.ActiveConnection = true;
                    conectado_bd = true;
                    return true;
                }

            }
            catch (Exception ex)
            {
                conectado_bd = false;
                Log.Escribe(ex);
            }

            return false;
        }

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
                EmpalmeSaldos form = new EmpalmeSaldos(this);
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
