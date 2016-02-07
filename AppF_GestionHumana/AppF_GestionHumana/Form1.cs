using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppF_GestionHumana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        GestionHumanos _listaPersonas = new GestionHumanos();

        /// <summary>
        /// Botón para añadir personas
        /// </summary>
        private void btn_AnadirPersona_Click(object sender, EventArgs e)
        {
            // Si las tres cajas de texto NO están vacías, entonces añadimos personas
            if (txtb_IntroApellido.Text != "" || txtb_IntroApellido.Text != "" || txtb_IntroApellido2.Text != "")
            {
                _listaPersonas.AnadirCiudadano(txtb_IntroNombre.Text, dtPick_Anadir.ToString(), txtb_IntroApellido.Text, txtb_IntroApellido2.Text);
                MessageBox.Show("Se ha añadido una persona");
            }
            else
            {
                MessageBox.Show("Los campos están incompletos");
            }
        }
    }
}
