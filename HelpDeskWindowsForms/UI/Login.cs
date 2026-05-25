using HelpDeskWindowsForms.Data;
using HelpDeskWindowsForms.Model;
using HelpDeskWindowsForms.Repositories;
using HelpDeskWindowsForms.Service;
using HelpDeskWindowsForms.UI;
using Microsoft.Extensions.DependencyInjection;



namespace HelpDeskWindowsForms
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly UsuarioService _usuarioService = null!;
        private readonly IServiceProvider _serviceProvider = null!;

        // ✅ Construtor com DI (principal)
        public Login(UsuarioService usuarioService, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _usuarioService = usuarioService;
            _serviceProvider = serviceProvider;

            ArredondarComponentes();
            AjustarLayout();
        }

        // ✅ Construtor vazio (necessário pro Designer)
        public Login()
        {
            InitializeComponent();
            AjustarLayout();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AjustarLayout();
        }


        private void ArredondarComponentes()
        {
            EmailText.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, EmailText.Width, EmailText.Height, 15, 15));
            SenhaText.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, SenhaText.Width, SenhaText.Height, 15, 15));
            Entrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Entrar.Width, Entrar.Height, 15, 15));
        }

        private void AjustarLayout()
        {
            if (ClientSize.Width == 0 || ClientSize.Height == 0)
                return;

            pictureBox1.Left = 24;
            pictureBox1.Top = (panel1.Height - pictureBox1.Height) / 2;
            label8.Left = 170;
            label8.Top = (panel1.Height - label8.Height) / 2;

            panel3.Width = (int)(ClientSize.Width * 0.6);
            panel3.Height = ClientSize.Height - panel1.Height;
            panel2.Left = panel3.Right;
            panel2.Top = panel1.Bottom;
            panel2.Width = ClientSize.Width - panel3.Width;
            panel2.Height = panel3.Height;

            var larguraCampos = Math.Min(360, Math.Max(300, panel3.Width - 260));
            var esquerda = Math.Max(80, (panel3.Width - larguraCampos) / 2);
            var topo = Math.Max(80, (panel3.Height - 300) / 2);

            label1.Left = esquerda;
            label1.Top = topo;
            Email.Left = esquerda;
            Email.Top = label1.Bottom + 28;
            EmailText.Left = esquerda;
            EmailText.Top = Email.Bottom + 6;
            EmailText.Width = larguraCampos;
            Senha.Left = esquerda;
            Senha.Top = EmailText.Bottom + 28;
            SenhaText.Left = esquerda;
            SenhaText.Top = Senha.Bottom + 6;
            SenhaText.Width = larguraCampos;
            Entrar.Left = esquerda;
            Entrar.Top = SenhaText.Bottom + 28;
            label5.Left = esquerda + (larguraCampos - label5.Width) / 2;
            label5.Top = Math.Min(panel3.Height - 48, Entrar.Bottom + 88);

            label6.Left = (panel2.Width - label6.Width) / 2;
            label6.Top = Math.Max(80, panel2.Height / 4);
            pictureBox2.Left = (panel2.Width - pictureBox2.Width) / 2;
            pictureBox2.Top = label6.Bottom + 36;
            label7.Left = (panel2.Width - label7.Width) / 2;
            label7.Top = pictureBox2.Bottom + 48;
        }
        private void label5_Click(object sender, EventArgs e)
        {




            // Cria uma nova instância da sua tela de cadastro
            Cadastro telaDeCadastro = _serviceProvider.GetRequiredService<Cadastro>();

            // Mostra a tela de cadastro
            telaDeCadastro.Show();

            // Esconde a tela de login atual
            this.Hide();
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
                SessaoUsuario.UsuarioLogado = usuario;
                RedirecionarUsuario(usuario);

            }
            catch
            {
                MessageBox.Show("Email ou Senha está errado");
            }

        }

        private void Email_Click(object sender, EventArgs e)
        {

        }

        private void RedirecionarUsuario(Usuario usuario)
        {
            switch (usuario.Perfil)
            {
                case Perfil.Cliente:
                    var dashboardCliente = _serviceProvider.GetRequiredService<DashboardCliente>();
                    dashboardCliente.Show();
                    Hide();
                    break;

                case Perfil.Analista:
                    var dashboardAnalista = _serviceProvider.GetRequiredService<DashboardAnalista>();
                    dashboardAnalista.Show();
                    Hide();
                    break;

                default:
                    MessageBox.Show("Perfil de usuário inválido.");
                    break;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SenhaText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.DeepSkyBlue;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Cyan;
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
