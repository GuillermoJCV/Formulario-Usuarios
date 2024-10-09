using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formulario_Usuarios
{
    internal class Usuario
    {
        public Usuario(string contrasena, bool esAdmin)
        {
            this.contrasena = contrasena;
            this.esAdmin = esAdmin;

        }

        public string contrasena { get; set; }
        public bool esAdmin { get; set; }

        public static Dictionary<string, Usuario> usuarios = new Dictionary<string, Usuario>();
    }
}
