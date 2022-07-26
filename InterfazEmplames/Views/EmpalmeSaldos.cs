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
    public partial class EmpalmeSaldos : Form
    {
        int mn_Agencia;
        string fechaCalculada;
        string ls_PrefijoAgencia;
        string nameAgencia;
        string fechaHoy;
        string fechaAnterior;
        int conceptoDefinido;
        int producto;

        private PantallaPrincipal pantallaPrincipal;

        public EmpalmeSaldos()
        {
            InitializeComponent();

          
        }

        public void PreparaPantEmpalmesAgencias(int pn_agencia)
        {
            mn_Agencia = pn_agencia;
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
      
            if(!obtieneInformacion(mn_Agencia))
            {

            }
        }

        /// <summary>
        /// Prepara los datos necesarios para el inicio del calculo de empalme de saldos.
        /// </summary>
        /// <param name="mn_Agencia"></param>
        /// <returns></returns>
        private bool obtieneInformacion(int mi_Agencia)
        {
            string saldoCargado = "";
            bool ObtieneInformacion = false;

            try
            {

                lblStatus.Text = "Verificando carga de Saldos";

                pantallaPrincipal.empalmes.gs_sql = $"SELECT error_saldos FROM {pantallaPrincipal.empalmes.DB_DESARROLLO}..PARAMETROS";



            }
            catch (Exception ex)
            {
                Log.Escribe(ex);
            }

            return ObtieneInformacion;
        }

        private void EmpalmeSaldos_Load(object sender, EventArgs e)
        {

        }

        public EmpalmeSaldos(PantallaPrincipal pantallaPrincipal):this()
        {
            this.pantallaPrincipal = pantallaPrincipal;
        }
    }
}
