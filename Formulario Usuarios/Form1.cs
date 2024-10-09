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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Usuario.usuarios.Add("Guillermo", new Usuario("1234", true));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string contrasena = textBoxContrasena.Text;
            Usuario usuario;
            bool hayUsuario = false;

            if (Usuario.usuarios.TryGetValue("Guillermo", out usuario)) hayUsuario = true;

            if (!hayUsuario) MessageBox.Show("El usuario ingresado no se ha encontrado");
            else if (usuario.contrasena == contrasena)
            {
                Form2 form2 = new Form2(nombre, usuario.esAdmin);

                form2.Show();
            }
            else MessageBox.Show("Contraseña incorrecta");
            
        }

    }
}
