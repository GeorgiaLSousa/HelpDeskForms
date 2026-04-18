using System.Drawing.Drawing2D;
using System.Diagnostics.Metrics;

namespace HelpDeskWindowsForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            // Use o (Name) que você deu no Design. 
            // Se for Entrar, Email e Senha, o código é:
            Arredondar(Entrar, 20);
            Arredondar(Email1, 10);
            Arredondar(Senha1, 10);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Mensagem informativa(opcional, pode manter ou tirar)
            MessageBox.Show("Você será redirecionado para o formulário de cadastro!",
                            "Novo Cadastro",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            // ESTE É O CÓDIGO DE TROCA:
            // 1. Cria a tela (amanhã, quando criar o Form, dê o nome de FormCadastro)
            // Cadastro telaCadastro = new Cadastro();

            // Mostra a tela
            // telaCadastro.Show();

            // Esconde a tela de login
            this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string email = Email1.Text;
            string senha = Senha1.Text;

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(senha))
            {
                MessageBox.Show("Por favor, preencha e-mail e senha!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Chama a validação
            ValidarUsuario(email, senha);
        }
        private void Arredondar(Control componente, int raio)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(componente.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(componente.Width - raio, componente.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, componente.Height - raio, raio, raio, 90, 90);
            componente.Region = new Region(gp);
        }

        // 2. Função de Validação (Onde você checa se o login existe)
        private void ValidarUsuario(string email, string senha)
        {
            // Para teste inicial:
            if (email == "admin@helpdesk.com" && senha == "1234")
            {
                MessageBox.Show("Login realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Mensagem que aparecerá para o usuário
            MessageBox.Show("Um link de recuperação foi enviado para o e-mail informado!",
                            "Recuperação de Senha",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

        }

        private void Email1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Senha1_BorderStyleChanged(object sender, EventArgs e)
        {

        }
    }
}
