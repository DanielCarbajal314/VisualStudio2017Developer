using Dominio.Entidades.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ClasesDeNegocio
{
    public class Profesor : TEntidad
    {
        public string Nombre { get; set; }
        public string Profesion { get; set; }
        public HashSet<Curso> Cursos { get; set; }
    }
}
