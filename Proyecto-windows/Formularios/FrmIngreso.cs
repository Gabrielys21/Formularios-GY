using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_windows.Formularios
{
    public partial class FrmIngreso : Form
    {
        public FrmIngreso()
        {
            InitializeComponent();
        }

        private void Sumar_Click(object sender, EventArgs e)
        {

            comboBoxFacultades.Items.Add("Ingenieria");
            comboBoxFacultades.Items.Add("Medicina");
            comboBoxFacultades.Items.Add("Derecho");


            int numero1 = int.Parse(textBoxNumero1.Text);
            int numero2 = int.Parse(textBoxNumero2.Text);
            int resultado = numero1 + numero2;
            textBoxResultado.Text = resultado.ToString();
        }

        private void comboBoxFacultades_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(comboBoxFacultades.SelectedItem.ToString());
        }
    }
}
