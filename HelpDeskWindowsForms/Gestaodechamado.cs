using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace HelpDeskWindowsForms
{
    public partial class Gestaodechamado : Form
    {
        public Gestaodechamado()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ArredondarBordas(panel1, 30, e);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ArredondarBordas(panel3, 30, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Se quiser que algo aconteça ao clicar, coloque aqui
        }

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            ArredondarBordas(lblBadgeStatus, lblBadgeStatus.Height, e);
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        }

        private void ArredondarBordas(Control componente, int raio, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, raio, raio, 180, 90);
            path.AddArc(componente.Width - raio, 0, raio, raio, 270, 90);
            path.AddArc(componente.Width - raio, componente.Height - raio, raio, raio, 0, 90);
            path.AddArc(0, componente.Height - raio, raio, raio, 90, 90);
            path.CloseAllFigures();
            componente.Region = new Region(path);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            ArredondarBordas(panel2, panel2.Height, e);
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Gestaodechamado_Paint(object sender, PaintEventArgs e)
        {
            ArredondarBordas(this, 40, e);
        }

        private void Gestaodechamado_Load(object sender, EventArgs e)
        {

        }
    }
} 