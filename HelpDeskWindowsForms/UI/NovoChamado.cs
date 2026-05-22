using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDeskWindowsForms.UI
{
    public partial class NovoChamado : Form
    {
        public NovoChamado()
        {
            InitializeComponent();
        }

        private void NovoChamado_Load(object sender, EventArgs e)
        {

        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {

        }

        private void lbVoltar_Click_1(object sender, EventArgs e)
        {
            var sair = new DashboardCliente();
            sair.Show();
            this.Hide();
        }
    }
}
