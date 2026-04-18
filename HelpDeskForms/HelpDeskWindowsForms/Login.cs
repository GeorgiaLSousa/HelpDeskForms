namespace HelpDeskWindowsForms
{
    public partial class Login : Form
    {
        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        
        public Login()
        {
            InitializeComponent();
            ArredondarComponentes();
        }
        private void ArredondarComponentes()
        {
            textBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15));
            textBox2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, textBox2.Width, textBox2.Height, 15, 15));
            button1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, button1.Width, button1.Height, 15, 15));
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
            // Verifica se os campos estão preenchidos (exemplo simples)
            if (Email.Text == "admin" && Senha.Text == "123")
            {
                // Abre o formulário principal
                Login principal = new Login();
                principal.Show();

                // Fecha ou esconde a tela de login
                this.Hide();
            }
            else
            {
                MessageBox.Show("E-mail ou senha incorretos!", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Email_Click(object sender, EventArgs e)
        {

        }
    }
}
