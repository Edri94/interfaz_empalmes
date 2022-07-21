using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEmplames.Models
{
    public class PermisoRemoto
    {
        public int Peticion { get; set; }
        public int Autorizacion { get; set; }
        public int UsuarioAutoriza { get; set; }
        public string Comentario { get; set; }
        public string Respuesta { get; set; }
        public double Sobretasa { get; set; }

    }
}
