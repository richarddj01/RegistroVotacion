using System;
using System.Collections.Generic;using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RegistroColegio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            // Tu consulta en SQL

            string connectionString = "datasource=192.168.239.109;port=3306;username=Votacion;password=12345678;database=colegio;";
            MySqlConnection conn = new MySqlConnection(connectionString);
            conn.Open();

            string consulta = "INSERT INTO `estudiantes`(`grado`, `nombres`, `apellidos`, `documento`, `clave`) VALUES ('" + txtGrado.Text+"','"+txtNombre.Text+"','"+txtApellido.Text+"','"+txtIdentidad.Text+"','"+txtClave.Text+"')";
            MySqlCommand cmd = new MySqlCommand(consulta, conn);

            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Votante registrado exitosamente";
            txtGrado.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";

        }
    }
}
