﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA_1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void hISTORIACLINICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            HistoriaClinica VentanaDeHistoria = new HistoriaClinica();
            VentanaDeHistoria.Show();
        }

        private void rEGISTRARDATOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
            Registro VentanaDeRegistro = new Registro();
            VentanaDeRegistro.Show();
        }
    }
}
