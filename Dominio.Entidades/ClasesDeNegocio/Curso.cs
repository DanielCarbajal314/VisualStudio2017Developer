using Dominio.Entidades.Compartido;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades.ClasesDeNegocio
{
    public class Curso : TEntidad
    {
        public string Nombre { get; set; }
        public string Facultad { get; set; }
        public string Descripcion { get; set; }
        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
        public HashSet<Alumno> Alumnos { get; set; }

    }
}
