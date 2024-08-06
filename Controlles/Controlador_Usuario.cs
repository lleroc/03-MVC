using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///mysql
using MySql.Data.MySqlClient;
//llamar a los models
using _03_MVC.Models;
//Invocar a la conexion
using _03_MVC.Config;

namespace _03_MVC.Controlles
{
    class Controlador_Usuario
    {
        private Conexion conexion;

        public Modelo_Usuario login(login login) {

            string cadena = "slecet df";

            using (MySqlCommand cmd = new MySqlCommand(cadena, conexion.ObtenerConexion()))
            {

            }
        
        }
    }
}
