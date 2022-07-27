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

        private PantallaPrincipal frmp;

        public Login(PantallaPrincipal frmp) : this()
        {
            this.frmp = frmp;
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

            gs_sql = $@"
                SELECT 
                    usuario, 
                    origen_usuario, 
                    convert(char(10),fecha_cambio_password,105),
                    convert(char(10),fecha_ultimo_acceso,105),
                    password, 
                    nombre_usuario
                FROM
                    {frmp.empalmes.DB_CATALOGOS}..USUARIO
                WHERE 
                    login = '{txtUser.Text}';
            ";

            dr = frmp.bd.ejecutarConsulta(gs_sql);

            while(dr.Read())
            {
                string nombre = dr.GetString(5);
            }



        }
    }
}
