﻿using GestionEmpresa.Codigo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpresa.Interfaz
{
    public partial class Region : Form
    {
        public Region()
        {
            InitializeComponent();
            ctrlRegion R = new ctrlRegion(this); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
