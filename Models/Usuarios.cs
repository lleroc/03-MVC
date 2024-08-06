using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MVC.Models
{
    class Usuarios
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido{ get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
        public int Estado { get; set; }
        public DateTime Creado { get; set; }     
    }
   
}
