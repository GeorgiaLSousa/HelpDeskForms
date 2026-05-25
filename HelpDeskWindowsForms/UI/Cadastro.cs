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
        private readonly Label _tituloFormulario = new();

        public Cadastro()
        {
            InitializeComponent();
            ConfigurarTextos();
            ConfigurarTituloFormulario();
            ArredondarComponentes();
            CMB_Perfil.SelectedIndex = 0;
            AjustarLayout();
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

        private void ConfigurarTextos()
        {
            label1.AutoSize = true;
            label2.Text = "Crie sua conta";
            label3.Text = "Preencha seus dados para acessar a plataforma";
            BT_Cadastrar.Text = "Cadastrar";
            TB_Senha.UseSystemPasswordChar = true;
            CMB_Perfil.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigurarTituloFormulario()
        {
            _tituloFormulario.AutoSize = true;
            _tituloFormulario.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            _tituloFormulario.ForeColor = Color.FromArgb(30, 30, 30);
            _tituloFormulario.Text = "Cadastro";
            panel4.Controls.Add(_tituloFormulario);
            _tituloFormulario.BringToFront();
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
            AjustarLayout();
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
                    Perfil = ObterPerfilSelecionado()
                };

                _usuarioService.CriarUsuario(usuario);

                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                TB_Nome.Clear();
                TB_Email.Clear();
                TB_CPF.Clear();
                TB_Senha.Clear();
                CMB_Perfil.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Perfil ObterPerfilSelecionado()
        {
            return CMB_Perfil.SelectedIndex == 1 ? Perfil.Analista : Perfil.Cliente;
        }

        private void TB_Nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        private void AjustarLayout()
        {
            pictureBox1.Left = 24;
            pictureBox1.Top = (panel1.Height - pictureBox1.Height) / 2;
            label1.Left = 170;
            label1.Top = (panel1.Height - label1.Height) / 2;

            panel3.Width = Math.Min(500, Math.Max(420, (int)(ClientSize.Width * 0.38)));
            panel3.Height = ClientSize.Height - panel1.Height;
            panel4.Left = panel3.Right;
            panel4.Top = panel1.Bottom;
            panel4.Width = ClientSize.Width - panel3.Width;
            panel4.Height = ClientSize.Height - panel1.Height;

            var larguraCampos = Math.Min(420, Math.Max(320, panel4.Width - 220));
            var esquerda = Math.Max(80, (panel4.Width - larguraCampos) / 2);
            var topoFormulario = Math.Max(56, (panel4.Height - 470) / 2);

            _tituloFormulario.Left = esquerda + (larguraCampos - _tituloFormulario.Width) / 2;
            _tituloFormulario.Top = topoFormulario;

            Nome.Top = _tituloFormulario.Bottom + 34;
            TB_Nome.Top = Nome.Bottom + 8;

            Email.Top = TB_Nome.Bottom + 28;
            TB_Email.Top = Email.Bottom + 8;

            CPF.Top = TB_Email.Bottom + 28;
            TB_CPF.Top = CPF.Bottom + 8;

            Senha.Top = TB_CPF.Bottom + 28;
            TB_Senha.Top = Senha.Bottom + 8;

            PerfilLabel.Top = TB_Senha.Bottom + 28;
            CMB_Perfil.Top = PerfilLabel.Bottom + 8;

            Nome.Left = esquerda;
            TB_Nome.Left = esquerda;
            TB_Nome.Width = larguraCampos;
            Email.Left = esquerda;
            TB_Email.Left = esquerda;
            TB_Email.Width = larguraCampos;
            CPF.Left = esquerda;
            TB_CPF.Left = esquerda;
            TB_CPF.Width = larguraCampos;
            Senha.Left = esquerda;
            TB_Senha.Left = esquerda;
            TB_Senha.Width = larguraCampos;
            PerfilLabel.Left = esquerda;
            CMB_Perfil.Left = esquerda;
            CMB_Perfil.Width = larguraCampos;
            BT_Cadastrar.Width = 140;
            BT_Cadastrar.Left = esquerda + (larguraCampos - BT_Cadastrar.Width) / 2;
            BT_Cadastrar.Top = CMB_Perfil.Bottom + 34;

            pictureBox2.Left = Math.Max(40, (panel3.Width - pictureBox2.Width) / 2);
            pictureBox2.Top = Math.Max(130, (panel3.Height - pictureBox2.Height) / 2);
            label2.Left = Math.Max(40, (panel3.Width - label2.Width) / 2);
            label2.Top = Math.Max(56, pictureBox2.Top - 72);
            label3.Left = Math.Max(40, (panel3.Width - label3.Width) / 2);
            label3.Top = pictureBox2.Bottom + 44;

            ArredondarComponentes();
        }
    }
}
