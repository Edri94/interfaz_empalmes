using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEmplames.Models
{
    public class TipoPerfil
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Fecha { get; set; }
        public double Accesos { get; set; }
        public string Marcacion { get; set; }
    }
}
