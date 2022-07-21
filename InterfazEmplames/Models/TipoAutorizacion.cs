using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazEmplames.Models
{
    public class TipoAutorizacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Comentario { get; set; }
        public string Hora { get; set; }
        public double Valor { get; set; }
    }
}
