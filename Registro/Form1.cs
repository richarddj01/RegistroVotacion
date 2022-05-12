namespace Registro
{
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDireccionIP_Click(object sender, EventArgs e)
        {
            conexion.DireccionIP = txtDireccionIP.Text;
            conexion.Username = txtUsername.Text;
            conexion.Password = txtPassword.Text;
            conexion.Database = txtBD.Text;
            MessageBox.Show("Los datos de conexion han sido guardados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clRegistro.Grado = txtGrado.Text;
            clRegistro.Nombre = txtNombre.Text;
            clRegistro.Apellido = txtApellido.Text;
            clRegistro.Identidad = txtIdentidad.Text;

            clRegistro registro = new clRegistro();
            registro.insertar();
            txtGrado.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtIdentidad.Clear();
        }
    }
}