using Dominio.Entidades.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ClasesDeNegocio
{
    public class Alumno : TEntidad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public virtual HashSet<Curso> Cursos { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }

    }
}
