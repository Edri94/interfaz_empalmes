using InterfazEmplames.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazEmplames.Processes
{
    public class Permiso
    {


        //Variables para manejo de permisos
        private List<double> Ga_Perfiles;
        private List<TipoPermiso> Ga_Permisos;
        private int gn_TotalPermisos;
        private int gn_Indice;
        private int gn_Usuario;
        private int gn_Origen;
        private double gn_Accesos;
        private int gn_Aplicacion;
        private bool gb_Login;
        private bool gb_CambioComentario;

        //Variables para manejo de autorizaciones
        private List<TipoAutorizacion> ga_Autorizaciones;
        private int gn_TotalAutorizaciones;
        private double gn_Autorizaciones;
        private bool gb_CambioAutorizacion;
        private bool gb_OperacionConPassword;
        private bool gb_Autorizacion;
        private string gs_Autorizacion;

        //Variables para manejo de parametros de operaciones hechas con password
        private int gn_UsuarioAutoriza;

        //Variables para manejo de operaciones remotas
        private string gs_Cuenta_Cliente;
        private string gs_Comentario;
        private string gs_Respuesta;
        private int gn_Operacion_Definida;
        private double gn_Monto;
        private double gn_Tasa;
        private int gn_Plazo;
        private double gn_SobreTasa;
        private List<PermisoRemoto> ga_PermisosRemotos;
        private int gn_Peticion;
        private int gn_IDAutorizacion;

        //Constantes con numeros de operaciones que no se encuentran como Operacion Definida
        private const byte gn_OpIndefinida = 1;

        //Constante para conservar el número de la operación definida en la función Montos
        private int gn_OpDefinida;

        public Permiso()
        {

        }

        /// <summary>
        /// Obtiene la ruta del directorio de Sistema de Windows
        /// </summary>
        /// <returns></returns>
        public string GetSysDir()
        {
            return null;
        }

        /// <summary>
        /// Metodo encargado de Deshabilitar Menus
        /// </summary>
        public void Deshabilitar_Menu()
        {

        }

        /// <summary>
        /// Ejecuta ordenes del modulo de passwords para confirmacion o actualizacion
        /// </summary>
        /// <param name="Accion"></param>
        /// <param name="Palabra"></param>
        /// <returns></returns>
        public string Encryption(byte Accion, string Palabra)
        {
            return null;
        }


        /// <summary>
        /// Devuelve el resultado de la combinación binaria de dos numeros decimales
        /// </summary>
        /// <param name="NumDec1"></param>
        /// <param name="NumDec2"></param>
        /// <returns></returns>
        public string CombinaValores(double NumDec1, double NumDec2)
        {
            return null;
        }

        /// <summary>
        /// Descompone un numero decimal en su correspondiente binario
        /// </summary>
        /// <param name="NumDecimal"></param>
        /// <param name="Orden"></param>
        /// <returns></returns>
        public string ObtenBinario(double NumDecimal, string Orden = "")
        {
            return null;
        }

        /// <summary>
        /// Reinicializa las variables de Autorizacion para operaciones posteriores
        /// </summary>
        public void CancelaAutorizacion()
        {

        }

        /// <summary>
        /// Devuelve el numero de fuente disponible en el sistema para impresion monotype
        /// </summary>
        /// <returns></returns>
        public int FuenteImpresion()
        {
            return 0;
        }


        public int ObtenExponente(double numero)
        {
            return 0;
        }

        /// <summary>
        /// Hace las modificaciones a la tabla de EVENTO_AUTORIZACION como sea necesario
        /// </summary>
        /// <param name="Operacion"></param>
        /// <param name="Comentario"></param>
        public void RegistraAutorizacion(string Operacion, string Comentario)
        {

        }

        /// <summary>
        /// Muestra la pantalla de validación de acceso segun sea necesario
        /// </summary>
        /// <returns></returns>
        public bool LogOn()
        {
            return false;
        }

        /// <summary>
        /// Verifica que la aplicación se encuentre registrada en la Base de Datos
        /// </summary>
        /// <returns></returns>
        public bool RegistraAplicacion()
        {
            return false;
        }

        /// <summary>
        /// Inicializa las Variables de acceso
        /// </summary>
        public void LogOff()
        {

        }

        /// <summary>
        /// Inhabilita los checkboxes de permisos y autorizaciones
        /// </summary>
        /// <param name="formulario"></param>
        public void BloqueaCheckboxes(Form formulario)
        { 

        }

        /// <summary>
        /// Limpia los CheckBoxes de las Listas
        /// </summary>
        /// <param name="formulario"></param>
        public void LimpiaChecks(Form formulario)
        {

        }

        /// <summary>
        /// Lee la base de datos para llenar los arreglos de permisos y autorizaciones
        /// </summary>
        public void CargaPermisos()
        {

        }

        /// <summary>
        /// Llena la lista de autorizaciones con los encontrados en la base de datos
        /// </summary>
        /// <param name="formulario"></param>
        public void LlenaListaAutorizaciones(Form formulario)
        {

        }

        /// <summary>
        /// Llena la lista de permisos con los encontrados en la base de datos
        /// </summary>
        /// <param name="formulario"></param>
        public void LlenaListaPermisos(Form formulario)
        {

        }

        /// <summary>
        /// Llena la lista de Usuarios disponibles por Base de Datos
        /// </summary>
        /// <param name="formulario"></param>
        public void LlenaListaUsuarios(Form formulario)
        {

        }

        /// <summary>
        /// Regresa el numero con que se encuentra registrada la aplicacion
        /// </summary>
        public int NumAplicacion()
        {
            return 0;
        }

        /// <summary>
        /// Llena el combo de perfiles dependiendo de la aplicacion que se trate.
        /// </summary>
        /// <param name="formulario"></param>
        public void LlenaListaPerfiles(Form formulario)
        {

        }






    }
}
