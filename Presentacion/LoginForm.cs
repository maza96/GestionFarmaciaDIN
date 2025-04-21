using Negocio;

namespace Presentacion
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
            {
                MessageBox.Show("Por favor, rellena todos los campos.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var empleado = EmpleadoService.Autenticar(usuario, contrasena);

            if (empleado != null)
            {
                MessageBox.Show($"¡Bienvenid@, {empleado.Nombre}!", "Inicio de sesión exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenuForm menu = new MenuForm();
                this.Hide();
                menu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = "lgomez";
            txtPassword.Text = "lucia2025";
        }
    }
}
