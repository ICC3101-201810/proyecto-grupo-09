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
    public partial class VentanaBibliotecario : Form
    {
        public VentanaBibliotecario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaInicio ventin = new VentanaInicio();
            ventin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcom.Text == "Cambiar/Ver estado")
            {
                this.Hide();

                CambioEstado camb = new CambioEstado();
                camb.Show();
            }
            if (txtcom.Text == "Aceptar reserva")
            {
                this.Hide();

                AceptarReserva acept = new AceptarReserva();
                acept.Show();
            }
        }
    }
}
