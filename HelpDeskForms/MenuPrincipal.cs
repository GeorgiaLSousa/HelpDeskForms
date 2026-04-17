using System.Drawing.Drawing2D;
namespace HelpDeskWindowsForms
{
    public partial class HelpDesk : Form
    {
        public HelpDesk()
        {
            InitializeComponent();
            ArredondarBotao(AtenderChamado, 20);
            ArredondarBotao(AtualizarChamado, 20);
            ArredondarBotao(FinalizarChamado, 20);
            ArredondarBotao(AbrirChamado, 20);
            ArredondarBotao(AcompanharChamado, 20);
            ArredondarBotao(AbrirChamadoUsuario, 20);
            ArredondarBotao(Atender, 20);
            ArredondarBotao(Finalizar, 20);

        }

        private void HelpDesk_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ArredondarBotao(Button btn, int raio)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, raio, raio, 180, 90);
            gp.AddArc(btn.Width - raio, 0, raio, raio, 270, 90);
            gp.AddArc(btn.Width - raio, btn.Height - raio, raio, raio, 0, 90);
            gp.AddArc(0, btn.Height - raio, raio, raio, 90, 90);
            gp.CloseFigure();
            btn.Region = new Region(gp);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AtenderChamado_Click(object sender, EventArgs e)
        {

        }

        private void ANALISTA_Click(object sender, EventArgs e)
        {

        }

        private void AcompanharChamado_Click(object sender, EventArgs e)
        {

        }
    }
}
