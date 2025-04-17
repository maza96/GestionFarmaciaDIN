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
            MenuForm menuPrincipal = new MenuForm();
            Hide();
            menuPrincipal.ShowDialog();
            Show();
        }
    }
}
