using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcom.Text == "Alumno")
            {
                //se abre la ventana del mennu de alumnos
                this.Hide();

                VentanaAlumno ventalum = new VentanaAlumno();
                ventalum.Show();
            }
            if (txtcom.Text == "Profesor")
            {
                //se abre la ventana del mennu de profesores
                this.Hide();

                VentanaProfesor ventaprof = new VentanaProfesor();
                ventaprof.Show();
            }
            if (txtcom.Text == "Bibliotecario")
            {
                //se abre la ventana del mennu de bibliotecarios
                this.Hide();

                VentanaBibliotecario ventabib = new VentanaBibliotecario();
                ventabib.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            VentanaPrincipal vent = new VentanaPrincipal();
            vent.Show();
        }
    }
}
