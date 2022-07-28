using InterfazEmplames.Helpers;
using InterfazEmplames.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEmplames
{
    public partial class Login : Form
    {
        public bool loggeado;

        private string gs_sql;
        private SqlDataReader dr;
        private Encriptacion crpt;

        private PantallaPrincipal frmp;

        public Login(PantallaPrincipal frmp) : this()
        {
            this.frmp = frmp;
            crpt = new Encriptacion();
        }

        public Login()
        {
            InitializeComponent();
        }

        public bool Logging(string in_user, string in_pass)
        {
            string user = "admin";
            string pass = "admin";

            return (user == in_user && pass == in_pass);
        }


        /// <summary>
        /// Evento click al intentar loggearse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string lsFechaPassword;
            string lsFechaUltimoAcceso;
            string lsNombre;
            int lnErroresLog;

            frmp.empalmes.sFechaHoy = frmp.bd.ObtenerFechaServidor();
            frmp.empalmes.gn_Linea = 0;
            frmp.permiso.gn_Origen = 0;
            frmp.permiso.gn_Usuario = 0;
            frmp.permiso.gn_Accesos = 0;
            frmp.empalmes.gn_Tarjeta = 0;
            frmp.permiso.gb_Login = false;
            frmp.empalmes.gn_Funcionario = 0;
            frmp.permiso.gn_Autorizaciones = 0;

            //Consulta de usuario
            using(CATALOGOSEntities db = new CATALOGOSEntities())
            {
                frmp.usuario_loggeado = (
                    from usr in db.USUARIO
                    where usr.login.Trim() == txtUser.Text.Trim()
                          select usr).ToList().First();
 
            }

            //Validando estado del usuario
            if(frmp.usuario_loggeado.password.Contains("BLOQUEAR"))
            {
                MessageBox.Show("se encuentra bloqueada debido a causas de seguridad.", "Acceso");
            }
            else if(frmp.usuario_loggeado.password.Contains("ANULADO"))
            {
                MessageBox.Show($"El login para el usuario {frmp.usuario_loggeado.nombre_usuario} se encuentra anulado");
            }

            //Validando password ingresada
            if(crpt.Decrypt(frmp.usuario_loggeado.password) == txtPass.Text)
            {
                frmp.app = frmp.permiso.NumAplicacion();
                using (CATALOGOSEntities db = new CATALOGOSEntities())
                {
                    if (frmp.app != null)
                    {
                    
                        PERMISOS_X_USUARIO_HEXA perfil_usuario = (
                        from pu in db.PERMISOS_X_USUARIO_HEXA
                        join pf in db.PERFIL_HEXA on pu.perfil equals pf.perfil
                        where 
                            pf.aplicacion == frmp.app.aplicacion1 && pu.usuario == frmp.usuario_loggeado.usuario1
                        select pu
                        ).ToList().First();

                        if(frmp.usuario_loggeado.fecha_cambio_password != null)
                        {
                            if (frmp.usuario_loggeado.fecha_cambio_password.Value.AddDays(Int32.Parse(frmp.empalmes.ValorParametro("CAMBIO_PASSW").valor)) <= frmp.empalmes.sFechaHoy)
                            {
                                MessageBox.Show("Por seguridad es necesario que cambie su password.", "Cambio de password",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }                          
                        }
                        //Si no se tiene una fecha valida se fija la de hoy
                        else
                        {
                            //USUARIO usr = db.USUARIO.SingleOrDefault(u => u.login.Trim() == txtUser.Text.Trim());
                            frmp.usuario_loggeado.fecha_cambio_password = frmp.empalmes.sFechaHoy;
                            frmp.usuario_loggeado.nombre_usuario = "EDRI ALAN ANGULO ARTEAGA";
                            db.Entry(frmp.usuario_loggeado).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();
                        }

                        //Verfica si el password en BANCO001 pide que se cambie.
                        if(txtPass.Text.Contains("Banco001"))
                        {
                            MessageBox.Show("Por seguridad es necesario que cambie su password.", "Cambio de password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    //Actualizando ultimo acceso usuario
                    frmp.usuario_loggeado.fecha_ultimo_acceso = frmp.empalmes.sFechaHoy;
                    db.Entry(frmp.usuario_loggeado).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    if(frmp.usuario_loggeado.origen_usuario == 4 || frmp.usuario_loggeado.origen_usuario == 6)
                    {

                    }

                }
            }

            

        }
    }
}
