using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Registro
{
    public class conexion
    {
        private static string direccionIP;
        private static string username;
        private static string password;
        private static string database;


        public static string DireccionIP { get => direccionIP; set => direccionIP = value; }
        public static string Username { get => username; set => username = value; }
        public static string Password { get => password; set => password = value; }
        public static string Database { get => database; set => database = value; }


        /*
        public static void con() {
            if (direccionIP != null)
            {
                private static string connectionString = "datasource=" + direccionIP + ";port=3306;username=Votacion;password=12345678;database=colegio;";
            }
            else {
                MessageBox.Show("Hay un error en la conexión, verifique la dirección IP","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        */

        public MySqlConnection cn = new MySqlConnection("datasource=" + direccionIP + ";port=3306;username="+Username+";password="+Password+";database="+Database+";");
        public void abrircn()
        {
            try
            {
                cn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar a base de datos " + e);
            }
        }

        public void close()
        {
            cn.Close();
        }
    }
}
