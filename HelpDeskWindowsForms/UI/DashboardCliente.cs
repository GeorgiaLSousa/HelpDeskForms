using HelpDeskWindowsForms.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HelpDeskWindowsForms.UI
{
    public partial class DashboardCliente : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;
        private readonly ChamadoService _chamadoService = null!;

        public DashboardCliente()
        {
            InitializeComponent();
        }

        public DashboardCliente(IServiceProvider serviceProvider, ChamadoService chamadoService) : this()
        {
            _serviceProvider = serviceProvider;
            _chamadoService = chamadoService;
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
            AjustarCabecalho();
            AjustarCards();
            CarregarChamados();
            var usuario = SessaoUsuario.UsuarioLogado;
            lbNomeUsuario.Text = usuario?.Nome ?? "Usuário";
            AjustarCabecalho();
        }

        private void lbTituloPagina_Click(object sender, EventArgs e)
        {

        }

        private void DashboardCliente_Resize(object sender, EventArgs e)
        {
            AjustarCabecalho();
            AjustarCards();
        }

        private void AjustarCabecalho()
        {
            PB_Logo.Width = 120;
            lbTituloSistema.Left = 170;
            lbTituloSistema.Top = (panelHeader.Height - lbTituloSistema.Height) / 2;
            PB_IconeUsuario.Left = panelHeader.Width - PB_IconeUsuario.Width - 24;
            PB_IconeUsuario.Top = (panelHeader.Height - PB_IconeUsuario.Height) / 2;
            lbNomeUsuario.Left = PB_IconeUsuario.Left - lbNomeUsuario.Width - 12;
            lbNomeUsuario.Top = (panelHeader.Height - lbNomeUsuario.Height) / 2;
        }

        private void AjustarCards()
        {
            var largura = Math.Max(600, flowChamados.ClientSize.Width - 24);

            foreach (Control controle in flowChamados.Controls)
            {
                controle.Width = largura;
            }
        }

        private void CarregarChamados()
        {
            if (SessaoUsuario.UsuarioLogado == null)
                return;

            var chamados = _chamadoService.ObterChamadosPorUsuario(SessaoUsuario.UsuarioLogado.Id);

            flowChamados.Controls.Clear();

            foreach (var chamado in chamados)
            {
                var card = new CardChamado();
                card.Width = Math.Max(600, flowChamados.ClientSize.Width - 24);
                card.CarregarDados(chamado);

                flowChamados.Controls.Add(card);
            }
        }

        private void cardChamado1_Load(object sender, EventArgs e)
        {

        }
    }
}
