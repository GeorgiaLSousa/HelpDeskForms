using HelpDeskWindowsForms.Data;
using HelpDeskWindowsForms.Repositories;
using HelpDeskWindowsForms.Service;
using Microsoft.Extensions.DependencyInjection;



namespace HelpDeskWindowsForms
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly UsuarioService _usuarioService = null!;

        // ✅ Construtor com DI (principal)
        public Login(UsuarioService usuarioService)
        {
            InitializeComponent();
            _usuarioService = usuarioService;

            ArredondarComponentes();
        }

        // ✅ Construtor vazio (necessário pro Designer)
        public Login()
        {
            InitializeComponent();
        }


        private void ArredondarComponentes()
        {
            EmailText.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EmailText.Width, EmailText.Height, 15, 15));
            SenhaText.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SenhaText.Width, SenhaText.Height, 15, 15));
            Entrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Entrar.Width, Entrar.Height, 15, 15));
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alteração de senha enviada para esse e-mail!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                var usuario = _usuarioService.Login(EmailText.Text, SenhaText.Text);
                MessageBox.Show("Login realizado com sucesso!");

                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Email ou Senha está errado");
            }

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SenhaText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
