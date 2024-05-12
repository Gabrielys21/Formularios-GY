using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Proyecto_windows.Formularios
{
    public partial class Frmheredado : Proyecto_windows.Form1
    {
        public Frmheredado()
        {
            InitializeComponent();
        }

        private void buttonSaludo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saludo");
        }

        private void Frmheredado_Load(object sender, EventArgs e)
        {

        }
    }
}
