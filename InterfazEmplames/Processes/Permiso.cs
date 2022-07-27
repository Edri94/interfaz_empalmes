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
        public List<double> Ga_Perfiles;
        public List<TipoPermiso> Ga_Permisos;
        public int gn_TotalPermisos;
        public int gn_Indice;
        public int gn_Usuario;
        public int gn_Origen;
        public double gn_Accesos;
        public int gn_Aplicacion;
        public bool gb_Login;
        public bool gb_CambioComentario;

        //Variables para manejo de autorizaciones
        public List<TipoAutorizacion> ga_Autorizaciones;
        public int gn_TotalAutorizaciones;
        public double gn_Autorizaciones;
        public bool gb_CambioAutorizacion;
        public bool gb_OperacionConPassword;
        public bool gb_Autorizacion;
        public string gs_Autorizacion;

        //Variables para manejo de parametros de operaciones hechas con password
        public int gn_UsuarioAutoriza;

        //Variables para manejo de operaciones remotas
        public string gs_Cuenta_Cliente;
        public string gs_Comentario;
        public string gs_Respuesta;
        public int gn_Operacion_Definida;
        public double gn_Monto;
        public double gn_Tasa;
        public int gn_Plazo;
        public double gn_SobreTasa;
        public List<PermisoRemoto> ga_PermisosRemotos;
        public int gn_Peticion;
        public int gn_IDAutorizacion;

        //Constantes con numeros de operaciones que no se encuentran como Operacion Definida
        public const byte gn_OpIndefinida = 1;

        //Constante para conservar el número de la operación definida en la función Montos
        public int gn_OpDefinida;

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
