﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class VentanaDeAltaCrucero : Form
    {
        public VentanaDeAltaCrucero()
        {
            InitializeComponent();
        }
        private VentanaListadoCrucero ventanaListado = new VentanaListadoCrucero();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void botonSeleccionar_Click(object sender, EventArgs e)
        {
            ventanaListado.Show();
        }

        private void botonSeleccionar2_Click(object sender, EventArgs e)
        {
            ventanaListado.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VentanaDeAlta_Load(object sender, EventArgs e)
        {

        }
    }
}
