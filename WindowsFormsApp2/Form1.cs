﻿using System;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //aca se ve si es que el usuario ya ha sido ingresado o no
            /*
            if ()
            {
                MessageBox.Show("Ha sido ingresado exitosamente");
            }
            else ()
            {
                MessageBox.Show("El usuario ya ha sido ingresado");
            }
            */

        }

        private void button2_Click(object sender, EventArgs e)
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
