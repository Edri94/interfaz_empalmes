using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
