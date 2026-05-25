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
    public partial class DashboardAnalista : Form
    {
        private readonly ChamadoService _chamadoService = null!;

        public DashboardAnalista()
        {
            InitializeComponent();
        }

        public DashboardAnalista(ChamadoService chamadoService) : this()
        {
            _chamadoService = chamadoService;
        }

        private void DashboardAnalista_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbAtendimento.SelectedIndex = 0;
            AjustarCabecalho();
            AjustarCards();
            CarregarChamados();
            var usuario = SessaoUsuario.UsuarioLogado;
            lblUsuario.Text = usuario?.Nome ?? "Usuário";
            AjustarCabecalho();
        }

        private void DashboardAnalista_Resize(object sender, EventArgs e)
        {
            AjustarCabecalho();
            AjustarCards();
        }

        private void AjustarCabecalho()
        {
            picLogo.Width = 120;

            lblTituloSistema.Left = 170;
            lblTituloSistema.Top = (panelHeader.Height - lblTituloSistema.Height) / 2;

            pictureBox1.Left = panelHeader.Width - pictureBox1.Width - 24;
            pictureBox1.Top = (panelHeader.Height - pictureBox1.Height) / 2;

            lblUsuario.Left = pictureBox1.Left - lblUsuario.Width - 12;
            lblUsuario.Top = (panelHeader.Height - lblUsuario.Height) / 2;
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
            var chamados = _chamadoService.ObterTodosChamados();

            flowChamados.Controls.Clear();

            foreach (var chamado in chamados)
            {
                var card = new CardChamado();
                card.Width = Math.Max(600, flowChamados.ClientSize.Width - 24);
                card.CarregarDados(chamado);

                flowChamados.Controls.Add(card);
            }
        }
    }
}
