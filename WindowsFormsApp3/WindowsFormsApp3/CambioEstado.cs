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
    public partial class CambioEstado : Form
    {
        public CambioEstado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtbox.Text == "asd")
            {
                if (txtcom.Text == "Ver estado")
                {

                }
            }

            if (txtbox.Text == "fdfd")
            {
                if (txtcom.Text == "Cambiar estado")
                {

                }
            }
            if (txtbox.Text == "" || txtcom.Text != "Cambiar estado" && txtcom.Text != "Ver estado")
            {
                MessageBox.Show("Ingrese un usuario y una opción...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaBibliotecario ventbib = new VentanaBibliotecario();
            ventbib.Show();
        }
    }
}
