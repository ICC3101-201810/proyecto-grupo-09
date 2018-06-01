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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aca se ve si es que el usuario ya ha sido ingresado o no
            //tambien se tiene que crear una ventana para que pregunte como se quiere agregar el usuario (con un combobox)
           
            /*
            if ( && txtcont.Text=!"")
            {
                MessageBox.Show("Ha sido ingresado exitosamente");
            }
            */
            if (txtid.Text == "" || txtcont.Text == "")

            {
                MessageBox.Show("Ingrese usuario y contraseña para registrarse");
                txtcont.Text = "";
                txtid.Text = "";
                txtid.Focus();
            }
            /*
            else ()
            {
                MessageBox.Show("El usuario ya ha sido ingresado");
            }
            */
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //aca se revisa si el usuario existe, en el caso de existir se inicia sesion
            //por ahora lo hare con un unico usuario y con una contraseña unica
            if (txtid.Text == "asdf" && txtcont.Text == "123")
            {
                //se inicio sesion
                this.Hide();

                VentanaInicio ventana2 = new VentanaInicio();
                ventana2.Show();
            }
            else
            {
                MessageBox.Show("Error en el ingreso, intentelo de nuevo");

                txtid.Text = "";
                txtcont.Text = "";
                txtid.Focus();
            }
        }

        
    }
}
