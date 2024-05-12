using Proyecto_windows.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            //MessageBox.Show("Bienvenido!!!");
        }

        private int intentosfallido = 0;
        private void buttonIngreso_Click(object sender, EventArgs e)
        {
            string usuario = textBoxUsr.Text.ToLower();
            string contraseña = textBoxPwd.Text;

            if (usuario.Equals ("admin") && contraseña.Equals("admin"))
            {
                FrmIngreso formas = new FrmIngreso();
                formas.Show();

                textBoxUsr.Text = "";
                textBoxPwd.Text = "";
                
                intentosfallido = 0;
            }
            else  
            {
                MessageBox.Show("Usuario y Contraseña Incorrecta");
                textBoxUsr.Text = "";
                textBoxPwd.Text = "";

                intentosfallido++;

                if (intentosfallido >= 3)
                {
                    buttonIngreso.Enabled = false;
                    MessageBox.Show("Ha excedido el limite de intentos fallidos. Por favor contacte al administador.");
                }
            }


        }

        //private void buttonInicio_Click(object sender, EventArgs e)
        //{
        //    labelTitulo.Text = "Bienvenido a mi App";
        //    FrmIngreso forma = new FrmIngreso();
        //    forma.Show();
        //}
    }
}
