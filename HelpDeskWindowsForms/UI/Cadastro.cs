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
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15));
            textBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 15, 15));
            textBox3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox3.Width, textBox3.Height, 15, 15));
            textBox4.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox4.Width, textBox4.Height, 15, 15));
            Cadastrar.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Cadastrar.Width, Cadastrar.Height, 15, 15));
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
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
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
                        comando.Parameters.AddWithValue("@nome", textBox1.Text);
                        comando.Parameters.AddWithValue("@email", textBox2.Text);
                        comando.Parameters.AddWithValue("@cpf", textBox3.Text);
                        comando.Parameters.AddWithValue("@senha", textBox4.Text);

                        comando.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpa os campos após cadastrar
                        textBox1.Clear();
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();
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
