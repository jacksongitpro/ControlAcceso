using System;
using System.Collections.Generic;
using System.Linq;
//JacksonGarcia
using System.Text;
using System.Threading.Tasks;

namespace ControlAcceso
{
    public static class BaseDeDatos
    {
        public static List<Usuario> Usuarios = new List<Usuario>();
        public static void CargarUsuario()
        {

            Usuario admin = new Usuario()
            {
                nombre = "admin",
                password = "admin",
                codigo = "12345",

            };
            Usuarios.Add(admin);
        }
            
    }
}
