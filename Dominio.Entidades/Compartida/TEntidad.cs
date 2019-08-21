using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.Compartido
{
    public class TEntidad
    {
        public int Id { get; set; }
        public DateTime DiaDeCreacion { get; set; } = DateTime.Now;
    }
}
