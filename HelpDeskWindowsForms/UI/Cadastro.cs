using HelpDeskWindowsForms.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;


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
            // O número 20 define o quão arredondado será o canto
            //panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
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
            // 1. Validar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(TB_Nome.Text) || string.IsNullOrWhiteSpace(TB_Email.Text) ||
                string.IsNullOrWhiteSpace(TB_CPF.Text) || string.IsNullOrWhiteSpace(TB_Senha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. String de conexão (Substitua pelo caminho do SEU banco de dados)
            // Dica: Você encontra isso nas propriedades do seu arquivo .mdf ou no Server Explorer
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SeuBanco.mdf;Integrated Security=True";

            // 3. Comando SQL para inserir
            string query = "INSERT INTO Usuarios (Nome, Email, CPF, Senha) VALUES (@nome, @email, @cpf, @senha)";

            // 4. Executar a operação no banco de dados
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Vincula os valores das caixas de texto aos parâmetros do SQL
                        comando.Parameters.AddWithValue("@nome", TB_Nome.Text);
                        comando.Parameters.AddWithValue("@email", TB_Email.Text);
                        comando.Parameters.AddWithValue("@cpf", TB_CPF.Text);
                        comando.Parameters.AddWithValue("@senha", TB_Senha.Text);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos após cadastrar
                        TB_Nome.Clear();
                        TB_Email.Clear();
                        TB_CPF.Clear();
                        TB_Senha.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BT_Cadastrar_Click(object sender, EventArgs e)
        {
            // 1. Validar se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(TB_Nome.Text) || string.IsNullOrWhiteSpace(TB_Email.Text) ||
                string.IsNullOrWhiteSpace(TB_CPF.Text) || string.IsNullOrWhiteSpace(TB_Senha.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos obrigatórios.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. String de conexão (Substitua pelo caminho do SEU banco de dados)
            // Dica: Você encontra isso nas propriedades do seu arquivo .mdf ou no Server Explorer
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SeuBanco.mdf;Integrated Security=True";

            // 3. Comando SQL para inserir
            string query = "INSERT INTO Usuarios (Nome, Email, CPF, Senha) VALUES (@nome, @email, @cpf, @senha)";

            // 4. Executar a operação no banco de dados
            try
            {
                using (SqlConnection conexao = new SqlConnection(connectionString))
                {
                    conexao.Open();
                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        // Vincula os valores das caixas de texto aos parâmetros do SQL
                        comando.Parameters.AddWithValue("@nome", TB_Nome.Text);
                        comando.Parameters.AddWithValue("@email", TB_Email.Text);
                        comando.Parameters.AddWithValue("@cpf", TB_CPF.Text);
                        comando.Parameters.AddWithValue("@senha", TB_Senha.Text);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos após cadastrar
                        TB_Nome.Clear();
                        TB_Email.Clear();
                        TB_CPF.Clear();
                        TB_Senha.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar com o banco: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

