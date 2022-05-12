using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Registro
{
    internal class clRegistro : conexion
    {
        private static string grado;
        private static string nombre;
        private static string apellido;
        private static string identidad;

        public static string Grado { get => grado; set => grado = value; }
        public static string Nombre { get => nombre; set => nombre = value; }
        public static string Apellido { get => apellido; set => apellido = value; }
        public static string Identidad { get => identidad; set => identidad = value; }

        public void insertar() {
            conexion con = new conexion();
            try
            {
                abrircn();

                //Este string es para validar que no haya sido registrado anteriormente
                string consulta = "SELECT COUNT(*) FROM `estudiantes` WHERE documento = "+identidad+"";
                MySqlCommand cmd = new MySqlCommand(consulta, cn);
                int cons = Convert.ToInt32(cmd.ExecuteScalar());

                if (cons == 0)
                {
                    string consulta1 = "INSERT INTO `estudiantes`(`grado`, `nombres`, `apellidos`, `documento`,`clave`) VALUES ('" + grado + "','" + nombre + "','" + apellido + "','" + identidad + "',' ')";
                    MySqlCommand cmd1 = new MySqlCommand(consulta1, cn);
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Votante registrado exitosamente","Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else {
                    MessageBox.Show("Ya existe un usuario registrado");
                }
                close();
                
            }
            catch (Exception ex) {
                MessageBox.Show("Se ha encontrado el error " + ex, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
