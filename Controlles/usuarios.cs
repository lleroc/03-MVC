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
    class usuarios
    {
        private Conexion conexion;

        public void AbriBaseDatos() {
            
            conexion.AbrirConexion();
        }

        public Usuarios Login(login datosLogin) {
            string cadena = "select * from usuarios where nombreusuario ='" + datosLogin.NombreUsuario
                + "' and contrasenia='" + datosLogin.Contrasenia + "'";

            Console.WriteLine(cadena);
            conexion = new Conexion();
            conexion.AbrirConexion();
            using (MySqlCommand cmd = new MySqlCommand(cadena,conexion.ObtenerConexion()))
            {
                Usuarios cls_usuario = new Usuarios();
                using (MySqlDataReader lector = cmd.ExecuteReader())
                {
                    
                    //lector.Read();
                    while (lector.Read()) {
                        cls_usuario.Apellido = lector.GetString("Apellido");
                        cls_usuario.Contrasenia = lector.GetString("Contrasenia");
                        cls_usuario.Estado = lector.GetInt32("Estado");
                        cls_usuario.Nombre = lector.GetString("Nombre");
                        cls_usuario.NombreUsuario = lector.GetString("NombreUsuario");
                        cls_usuario.UsuarioId = lector.GetInt32("UsuarioId");
                        cls_usuario.Creado = lector.GetDateTime("Creado");
                        };
                   }
                    return cls_usuario;
                }
            }
        
        
        }

    }

