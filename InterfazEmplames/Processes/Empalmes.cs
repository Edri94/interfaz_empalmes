using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using InterfazEmplames.Reports;

namespace InterfazEmplames.Processes
{
    public class Empalmes
    {
        private const int TICKET = 0;
        private const int CUENTA = 1;
        private const int MONTO = 2;
        private const int TASA = 3;
        private const int PLAZO = 4;
        private const int INICIO = 5;
        private const int FIN = 6;
        private const int RENOVACION = 7;
        private const int STATUS = 8;
        private const int MONTO_REN = 9;
        private const int INICIO_REN = 10;
        private const int FIN_REN = 11;

        //Variable para almacenar la ruta de los Reportes del Sistema
        private string GPATH;
        private string DB_SVRNAME;
        private string DB_CATALOGOS;
        private string DBFUNCS;
        private string GsUSer;
        private string lsPassword;
        private string DBDSN;
        private string CNNAME;
        private string DB_DESARROLLO;

        //Ruta donde se ejecuta la aplicacion
        private string ApliPath;
        private string gs_sql;
        private string sFechaHoy;
        private byte gn_Linea;
        private int gn_Tarjeta;
        private int gn_Funcionario;

        private const Int16 HWND_TOPMOST = -1;
        private const Int16 HWND_NOTOPMOST = -2;
        private const Int16 SWP_NOSIZE = 0x1;
        private const Int16 SWP_NOMOVE = 0x2;
        private const Int16 SWP_NOACTIVATE = 0x10;
        private const Int16 SWP_SHOWWINDOW = 0x40;
        private const Int16 SWP_HIDEWINDOW = 0x80;

        private string gsSql;

        //Colores de un botón no seleccionado
        private int ColorCmdONForma;
        private int ColorCmdONPanel;
        private int ColorCmdONFrame;

        //Colores de un botón seleccionado
        private int ColorCmdOFFForma;
        private int ColorCmdOFFFrame;
        private int ColorCmdOFFPanel;

        private bool selec;

        private int gn_ProcessID;
        private int gn_DBSwapNum;
        private List<int> ga_DBSwapFiles;
        private int GnAccion;
        private int gnErrorReporte;


        /// <summary>
        /// Devuelve la fecha con formato dd-mm-yyyy si el parametro es una fecha valida
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public string FechaY2K(string fecha)
        {
            return "";
        }


        /// <summary>
        /// Verifica que el string que recibe sea una fecha valida para Año 2000
        /// </summary>
        /// <param name="Fecha"></param>
        /// <returns></returns>
        public bool EsFechaY2K(string Fecha)
        {
            return false;
        }


        /// <summary>
        /// Invierte la entre los formatos dd-mm-yy y mm-dd-yy si el parametro es una fecha valida
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public string InvierteFecha(string fecha)
        {
            return "";
        }

        /// <summary>
        /// Define un grid con los parámetros deseados
        /// </summary>
        /// <param name="control"></param>
        /// <param name="columna"></param>
        /// <param name="texto"></param>
        /// <param name="alinea"></param>
        /// <param name="ancho"></param>
        public void DefineGrid(Control objeto, int columna, string texto, int alinea, int ancho)
        {

        }

        /// <summary>
        /// Llena el Grid deseado en base al resultado de un Query
        /// </summary>
        /// <param name="control"></param>
        /// <param name="query"></param>
        /// <param name="fixcols"></param>
        /// <param name="fixrows"></param>
        /// <param name="moneycols"></param>
        /// <returns></returns>
        public bool LlenaGrid(Control objeto, string query, int fixcols, int fixrows, string moneycols)
        {
            return false; 
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public string FechaOpera(string fecha)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cadena"></param>
        /// <param name="longitud"></param>
        /// <param name="direccion"></param>
        /// <returns></returns>
        public string Justifica(string cadena, int longitud, byte direccion)
        {
            return "";
        }

        /// <summary>
        /// Verifica que el texto escrito sea valido para un query de SQL Server
        /// </summary>
        /// <param name="cadena"></param>
        /// <returns></returns>
        public string ChecaTexto(string cadena)
        {
            return "";
        }

        /// <summary>
        /// Obtiene la identificacion de la PC bajo la Red
        /// </summary>
        /// <returns></returns>
        public string gnGetComputer()
        {
            return "";
        }

        /// <summary>
        /// Centra la pantalla en el area de trabajo
        /// </summary>
        public void CenterForm()
        {

        }

        /// <summary>
        /// Pone en Highligth el Texto del Objeto Seleccioado
        /// </summary>
        /// <param name="objeto"></param>
        public void MarcaTexto(Control objeto)
        {

        }

        ///// <summary>
        ///// Centra los Reportes de Cristal en el Area de la Aplicación
        ///// </summary>
        ///// <param name="Reporte"></param>
        ///// <param name="OwnConnect"></param>
        ///// <param name="OwnConnect"></param>
        //public void MaximizaReporte(CrystalReport Reporte, object OwnConnect, object OwnConnect)
        //{

        //}


        ///// <summary>
        ///// Limpia las formulas remanentes en un Reporte de Crystal
        ///// </summary>
        ///// <param name="Reporte"></param>
        //public void LimpiaFormulas(CrystalReport Reporte)
        //{

        //}

        /// <summary>
        /// Convierte una cadena de Mayusculas a Mayusculas-Minusculas EJEMPLO -> Ejemplo
        /// </summary>
        /// <param name="Nombre"></param>
        /// <returns></returns>
        public string LowCaseName(string Nombre)
        {
            return "";
        }

        /// <summary>
        /// Devuelve la hora actual del servidor (o en su defecto la de la PC)
        /// </summary>
        /// <returns></returns>
        public string HoraHora_Sistema()
        {
            return "";
        }

        /// <summary>
        /// Devuelve el valor de un parametro de la tabla PARAMETRIZACION
        /// </summary>
        /// <param name="parametro"></param>
        /// <returns></returns>
        public string ValorParametro(string parametro)
        {
            return "";
        }

        /// <summary>
        /// Emite Beeps después de alcanzar la longitud máxima especificada
        /// </summary>
        /// <param name="lnAscii"></param>
        /// <param name="LnControl"></param>
        /// <param name="lnLongitudMax"></param>
        /// <param name="Optional"></param>
        public void BeepLongitud(int lnAscii,Control LnControl,int lnLongitudMax,object Optional)
        {

        }
        /// <summary>
        /// Funcion que calcula los dias Feriados
        /// </summary>
        /// <param name="strFecha"></param>
        /// <returns></returns>
        public string CalculaDiasFeriados(string strFecha)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        public void ShowWaitCursor()
        {

        }

        /// <summary>
        /// LOG de Eventos de la bitácora de empalmes
        /// </summary>
        /// <param name="lsTipoEmpalme"></param>
        /// <param name="lsAgencia"></param>
        /// <param name="lsSalida"></param>
        /// <param name="lsComentario"></param>
        /// <returns></returns>
        public bool InsertaEvento(string lsTipoEmpalme,string lsAgencia,string lsSalida,string lsComentario)
        {
            return false;
        }
    }
}
