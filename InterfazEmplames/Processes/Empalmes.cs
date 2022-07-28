using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using InterfazEmplames.Models;
using InterfazEmplames.Reports;

namespace InterfazEmplames.Processes
{
    public class Empalmes
    {
        public const int TICKET = 0;
        public const int CUENTA = 1;
        public const int MONTO = 2;
        public const int TASA = 3;
        public const int PLAZO = 4;
        public const int INICIO = 5;
        public const int FIN = 6;
        public const int RENOVACION = 7;
        public const int STATUS = 8;
        public const int MONTO_REN = 9;
        public const int INICIO_REN = 10;
        public const int FIN_REN = 11;

        //Variable para almacenar la ruta de los Reportes del Sistema
        public string GPATH;
        public string DB_SVRNAME;
        public string DB_CATALOGOS;
        public string DBFUNCS;
        public string GsUSer;
        public string lsPassword;
        public string DBDSN;
        public string CNNAME;
        public string DB_DESARROLLO;

        //Ruta donde se ejecuta la aplicacion
        public string ApliPath;
        public string gs_sql;
        public DateTime sFechaHoy;
        public byte gn_Linea;
        public int gn_Tarjeta;
        public int gn_Funcionario;

        public const Int16 HWND_TOPMOST = -1;
        public const Int16 HWND_NOTOPMOST = -2;
        public const Int16 SWP_NOSIZE = 0x1;
        public const Int16 SWP_NOMOVE = 0x2;
        public const Int16 SWP_NOACTIVATE = 0x10;
        public const Int16 SWP_SHOWWINDOW = 0x40;
        public const Int16 SWP_HIDEWINDOW = 0x80;

        public string gsSql;

        //Colores de un botón no seleccionado
        public int ColorCmdONForma;
        public int ColorCmdONPanel;
        public int ColorCmdONFrame;

        //Colores de un botón seleccionado
        public int ColorCmdOFFForma;
        public int ColorCmdOFFFrame;
        public int ColorCmdOFFPanel;

        public bool selec;

        public int gn_ProcessID;
        public int gn_DBSwapNum;
        public List<int> ga_DBSwapFiles;
        public int GnAccion;
        public int gnErrorReporte;


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
        public PARAMETRIZACION ValorParametro(string parametro)
        {
            PARAMETRIZACION param;
            
            using (TICKETEntities db = new TICKETEntities())
            {
                param = (
                from p in db.PARAMETRIZACION
                where p.codigo.Trim() == parametro
                select p
                    ).ToList().First();
            }
            return param;
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

        /// <summary>
        /// Lee del archivo INI el parametro solicitado
        /// </summary>
        /// <param name="Grupo"></param>
        /// <param name="variable"></param>
        /// <param name="Default"></param>
        /// <returns></returns>
        public string obtenParametroINI(string Grupo,string variable,string Default)
        {
            return "";
        }

        /// <summary>
        /// función para el manejo de los botones, dependiendo de dónde este toma el color si no
        /// 
        /// tiene el foco, y si lo tiene toma un color contrario para que se note que tiene el foco
        /// si no esta habilitado toma colores de default pero no hace el cambio.
        /// </summary>
        /// <param name="poBoton">el arreglode  botons a utilizar</param>
        /// <param name="pnOpcion">si tiene el foco es verdadero, si no lo tiene es falso</param>
        /// <param name="habilitado">si el botón esta habilitado o no (enabled)</param>
        /// <param name="fondo">en donde se encuentra el arreglo de botones, forma=0, frame=1,Panel=2, forma deshabilitado=3</param>
        public void pg_ColorBoton(object poBoton,byte pnOpcion,bool habilitado,int fondo)
        {

        }

        /// <summary>
        /// Función que determina los colores que utilizaran los botones dependiendo de dónde se encuentren
        /// </summary>
        /// <param name="caso">establece si ha habido un cambio en los colores(1) o se toman colores establecidos por default(0)</param>
        public void coloresBotones(int caso)
        {

        }

        /// <summary>
        /// Función que manda todas las pantallas al frente del MDI
        /// </summary>
        public void CambiaPosicionPantallas()
        {

        }

        /// <summary>
        /// Crea una base de datos MDB en el directorio Temporal
        /// </summary>
        /// <returns></returns>
        public int DBCreateSwap()
        {
            return 0;
        }

        /// <summary>
        /// Agrega un campo a una base de datos Temporal. Devuelve el numero de error
        /// </summary>
        /// <param name="SwapFile"></param>
        /// <param name="Campo"></param>
        /// <param name="Tipo"></param>
        /// <param name="Size"></param>
        /// <returns></returns>
        public int DBAddSwapField(int SwapFile,string Campo,object Tipo,object Size)
        {
            return 0;
        }


        /// <summary>
        /// Obtiene el nombre de la base del arreglo generado.
        /// </summary>
        /// <param name="indice"></param>
        /// <returns></returns>
        public string DBSwapFile(int indice)
        {
            return "";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SwapFile"></param>
        /// <param name="Query"></param>
        /// <param name="Columnas"></param>
        /// <param name="ProgBar"></param>
        /// <returns></returns>
        public int DBSwapInsert(int SwapFile,string Query,int Columnas,object ProgBar)
        {
            return 0;
        }


        /// <summary>
        /// Transfiere el contenido de una base de datos MDB a Excel
        /// </summary>
        /// <param name="SwapFile"></param>
        /// <param name="ExcelFile"></param>
        /// <returns></returns>
        public bool DBSwapExporta(int SwapFile,string ExcelFile)
        {
            return false;
        }

        /// <summary>
        /// Borra los archivos MDB creados durante la sesion de trabajo
        /// </summary>
        public void DBSwapRemove()
        {

        }

        /// <summary>
        /// Obtiene el numero de sesion en SQL 
        /// Si la funcion falla pone por default 0 al proceso.
        /// </summary>
        public void getProccessID()
        {

        }

        /// <summary>
        /// Obtiene la ruta del directorio Temp de Windows
        /// </summary>
        /// <returns></returns>
        public string GetTempDir()
        {
            return "";
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="SwapFile"></param>
        /// <param name="listviewcontrol"></param>
        /// <param name="Columnas"></param>
        /// <param name="ProgBar"></param>
        /// <returns></returns>
        public int DBSwapInsertFromListview(int SwapFile,ListView listviewcontrol,int Columnas,object ProgBar)
        {
            return 0;
        }







    }
}
