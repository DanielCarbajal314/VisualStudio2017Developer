using Dominio.Entidades.ClasesDeNegocio;
using Dominio.Entidades.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pruebas.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new UniversidadDb())
            {
                db.Cursos.Add(new Curso()
                {
                    Descripcion = "Calculo en varias variables multidimencional",
                    Facultad = "Matematicas",
                    Nombre = "Calculo 4",
                    Profesor = new Profesor()
                    {
                        Nombre = "Roberto Agapito",
                        Profesion = "Matematico"
                    },
                    Alumnos = new HashSet<Alumno>()
                    {
                        new Alumno() { Nombre = "Daniel",Edad = 29 },
                        new Alumno() { Nombre = "Luis",Edad = 22 },
                        new Alumno() { Nombre = "Alberto",Edad = 25 }
                    }
                });
                db.SaveChanges();
            }
        }
    }
}
