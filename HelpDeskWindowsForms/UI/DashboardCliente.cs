using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace HelpDeskWindowsForms.UI
{
    public partial class DashboardCliente : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;

        public DashboardCliente()
        {
            InitializeComponent();
        }

        public DashboardCliente(IServiceProvider serviceProvider) : this()
        {
            _serviceProvider = serviceProvider;
        }

        private void btNovoChamado_Click(object sender, EventArgs e)
        {
            var entrar = _serviceProvider.GetRequiredService<NovoChamado>();
            entrar.Show();
            this.Hide();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DashboardCliente_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            this.ActiveControl = lbTituloPagina;
            AjustarCards();
        }

        private void lbTituloPagina_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCliente_Resize(object sender, EventArgs e)
        {
            AjustarCards();
        }

        private void AjustarCards()
        {
            var largura = Math.Max(600, flowChamados.ClientSize.Width - 24);
            cardChamado1.Width = largura;
            cardChamado2.Width = largura;
            cardChamado3.Width = largura;
        }
    }
}
