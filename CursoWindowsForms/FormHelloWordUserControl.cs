﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class FormHelloWordUserControl : UserControl
    {
        public FormHelloWordUserControl()
        {
            InitializeComponent();
        }

        private void BtnModificaTexto_Click(object sender, EventArgs e)
        {
            LblTitulo.Text = TxtConteudoLabel.Text;
        }
    }
}
