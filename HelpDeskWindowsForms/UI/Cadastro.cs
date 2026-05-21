using HelpDeskWindowsForms.Model;
using HelpDeskWindowsForms.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HelpDeskWindowsForms.UI
{
    public partial class Cadastro : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private readonly UsuarioService _usuarioService = null!;

        public Cadastro()
        {
            InitializeComponent();
            ArredondarComponentes();
        }

        public Cadastro(UsuarioService usuarioService) : this()
        {
            _usuarioService = usuarioService;
        }

        private void ArredondarComponentes()
        {
            TB_Nome.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_Nome.Width, TB_Nome.Height, 15, 15));
            TB_Email.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_Email.Width, TB_Email.Height, 15, 15));
            TB_CPF.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_CPF.Width, TB_CPF.Height, 15, 15));
            TB_Senha.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, TB_Senha.Width, TB_Senha.Height, 15, 15));
            BT_Cadastrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BT_Cadastrar.Width, BT_Cadastrar.Height, 15, 15));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void CPF_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void BT_Cadastrar_Click(object sender, EventArgs e)
        {
            CadastrarUsuario();
        }

        private void CadastrarUsuario()
        {
            if (string.IsNullOrWhiteSpace(TB_Nome.Text) || string.IsNullOrWhiteSpace(TB_Email.Text) ||
                string.IsNullOrWhiteSpace(TB_CPF.Text) || string.IsNullOrWhiteSpace(TB_Senha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = new Usuario
                {
                    Nome = TB_Nome.Text.Trim(),
                    Email = TB_Email.Text.Trim(),
                    CPF = TB_CPF.Text.Trim(),
                    Senha = TB_Senha.Text,
                    Perfil = Perfil.Cliente
                };

                _usuarioService.CriarUsuario(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TB_Nome.Clear();
                TB_Email.Clear();
                TB_CPF.Clear();
                TB_Senha.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TB_Nome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
