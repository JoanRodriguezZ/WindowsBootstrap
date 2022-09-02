using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsBootstrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            if (!textBoxMensaje.Text.Equals(""))
            {
                MessageBox.Show("El mensaje es: " + textBoxMensaje.Text);
            }
            else
                MessageBox.Show("No se ha especficado ningun mensaje.");


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("El deporte seleccionado es: " + listBoxDeportes.SelectedItem.ToString());

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("La fruta seleccionada es: " + comboBoxFrutas.SelectedItem.ToString());

        }

        private void radioButtonMujer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El genero es mujer.");
        }

        private void radioButtonHombre_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El genero es hombre.");
        }
    }
}
