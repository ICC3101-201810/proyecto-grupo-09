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
    public partial class VentanaAlumno : Form
    {
        public VentanaAlumno()
        {
            InitializeComponent();
        }

        private void botaceptar_Click(object sender, EventArgs e)
        {
            if (txtcom.Text == "Hacer reserva")
            {
                this.Hide();

                ReservaAlumno reser = new ReservaAlumno();
                reser.Show();
            }

        }

        private void botvolver_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaInicio ventin = new VentanaInicio();
            ventin.Show();
        }
    }
}
