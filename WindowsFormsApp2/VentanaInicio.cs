using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class VentanaInicio : Form
    {
        public VentanaInicio()
        {
            InitializeComponent();
        }

        private void botIng_Click(object sender, EventArgs e)
        {
            if (txtcom.Text == "Alumno")
            {
                //se abre ventana de opciones de alumno
                this.Hide();

                VentAlumno ventanaalumno = new VentAlumno();
                ventanaalumno.Show();
            }
            if (txtcom.Text == "Profesor")
            {
                //se abre ventana de opciones de profesor
                this.Hide();

                VentProfesor ventanaprof = new VentProfesor();
                ventanaprof.Show();
            }
            if (txtcom.Text == "Bibliotecario")
            {
                //se abre ventana de opciones de bibliotecario
                this.Hide();

                VentBibliotecario ventanabiblio = new VentBibliotecario();
                ventanabiblio.Show();
            }
        }

        private void botvolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 vent = new Form1();
            vent.Show();
        }
    }
}
