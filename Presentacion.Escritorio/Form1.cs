using Dominio.Entidades.ClasesDeNegocio;
using Dominio.Entidades.Contexto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.Escritorio
{
    public partial class Form1 : Form
    {
        private UniversidadDb db = new UniversidadDb();
        private List<Alumno> AlumnosCargados;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.db.Alumnos.ToList().ForEach(x =>
            {
                comboBox1.Items.Add(x);
            });


            this.AlumnosCargados = db.Alumnos.ToList();
            this.actualizarTablaDeAlumnos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nuevoAlumno = new Alumno()
            {
                Nombre = this.NombreAlumno.Text,
                Edad = int.Parse(this.EdadAlumno.Text)
            };
            this.db.Alumnos.Add(nuevoAlumno);
            this.db.SaveChanges();
            this.AlumnosCargados.Add(nuevoAlumno);
            this.actualizarTablaDeAlumnos();
            this.limpiarFormulario();
        }

        private void actualizarTablaDeAlumnos()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this.AlumnosCargados;
            dataGridView1.Columns["Cursos"].Visible = false;
            dataGridView1.Columns["Id"].Visible = false;
        }

        private void limpiarFormulario()
        {
            this.NombreAlumno.Text = "";
            this.EdadAlumno.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.db.SaveChanges();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var alumnoABorrar = this.AlumnosCargados.ElementAt(e.RowIndex);
            var cursos = alumnoABorrar.Cursos.ToList();
            this.db.Alumnos.Remove(alumnoABorrar);
            this.db.SaveChanges();
            this.AlumnosCargados.Remove(alumnoABorrar);
            this.actualizarTablaDeAlumnos();

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            var value = (Alumno)comboBox1.SelectedItem;
            if (value != null)
            {

            }
        }
    }
}
