﻿using BL.Cosmeticos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.ProCosmeticos
{
    public partial class FormBrochas : Form
    {
        BrochasBL _brochas; 
        public FormBrochas()
        {
            InitializeComponent();
            _brochas = new BrochasBL();
            listaEsponjaBindingSource.DataSource = _brochas.ObtenerBrochasBL();

            
        }

        private void FormBrochas_Load(object sender, EventArgs e)
        {
           

        }

        private void listaEsponjaDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
