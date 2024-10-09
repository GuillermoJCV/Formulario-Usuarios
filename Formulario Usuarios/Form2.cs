using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_Usuarios
{
    public partial class Form2 : Form
    {
        public Form2(string nombre, bool esAdmin)
        {
            InitializeComponent();

            string admin = esAdmin ? "Eres admin" : "No eres admin";

            labelBienvenida.Text = "Bienvenido " + nombre + ". " + admin;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
