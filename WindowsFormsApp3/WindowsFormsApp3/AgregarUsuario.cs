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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aca se ve si es que el usuario ya ha sido ingresado o no
            

            /*
            if ( && txtcont.Text != "")
            {
                MessageBox.Show("Ha sido ingresado exitosamente");
            }
            */
            if (txtid.Text == "" || txtcont.Text == "" || txtmail.Text == "" || txtcom.Text != "Alumno" && txtcom.Text != "Profesor" && txtcom.Text != "Bibliotecario")

            {
                MessageBox.Show("Ingrese usuario, contraseña, mail y tipo para registrarse");
                txtcont.Text = "";
                txtid.Text = "";
                txtmail.Text = "";
                txtid.Focus();
            }
            /*
            else ()
            {
                MessageBox.Show("El usuario ya ha sido ingresado");
            }
            */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            VentanaPrincipal ventprin = new VentanaPrincipal();
            ventprin.Show();
        }
    }
}
