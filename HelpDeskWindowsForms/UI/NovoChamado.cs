using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HelpDeskWindowsForms.Model;
using HelpDeskWindowsForms.Service;
using Microsoft.Extensions.DependencyInjection;

namespace HelpDeskWindowsForms.UI
{
    public partial class NovoChamado : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;
        private readonly ChamadoService _chamadoService = null!;

        public NovoChamado()
        {
            InitializeComponent();
        }

        public NovoChamado(IServiceProvider serviceProvider, ChamadoService chamadoService) : this()
        {
            _serviceProvider = serviceProvider;
            _chamadoService = chamadoService;
        }

        private void NovoChamado_Load(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        private void lbVoltar_Click(object sender, EventArgs e)
        {

        }

        private void lbVoltar_Click_1(object sender, EventArgs e)
        {
            var sair = _serviceProvider.GetRequiredService<DashboardCliente>();
            sair.Show();
            this.Hide();
        }

        private void NovoChamado_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        private void AjustarLayout()
        {
            pctLogo.Width = 120;
            lbSistema.Left = 170;
            lbSistema.Top = (panelHeader.Height - lbSistema.Height) / 2;

            panel1.Width = Math.Min(420, Math.Max(340, (int)(ClientSize.Width * 0.30)));
            lbAjuda.Left = (panel1.Width - lbAjuda.Width) / 2;
            lbAjuda.Top = Math.Max(96, (panel1.Height - picAjuda.Height) / 2 - 70);

            picAjuda.Width = Math.Min(280, panel1.Width - 96);
            picAjuda.Height = 180;
            picAjuda.Left = (panel1.Width - picAjuda.Width) / 2;
            picAjuda.Top = lbAjuda.Bottom + 48;

            var larguraForm = Math.Min(560, Math.Max(460, panelConteudo.ClientSize.Width - 160));
            var alturaForm = Math.Min(540, Math.Max(500, panelConteudo.ClientSize.Height - 120));
            panelForm.Size = new Size(larguraForm, alturaForm);
            panelForm.Left = Math.Max(24, (panelConteudo.ClientSize.Width - panelForm.Width) / 2);
            panelForm.Top = Math.Max(24, (panelConteudo.ClientSize.Height - panelForm.Height) / 2);

            lbAbraChamado.Left = (panelForm.Width - lbAbraChamado.Width) / 2;
            lbAbraChamado.Top = 48;

            var campoLeft = 64;
            var campoWidth = panelForm.Width - (campoLeft * 2);
            txbTitulo.Left = campoLeft;
            txbTitulo.Width = campoWidth;
            txbTitulo.Top = 128;
            lbTitulo.Left = campoLeft;
            lbTitulo.Top = txbTitulo.Top - 24;

            txbDescricao.Left = campoLeft;
            txbDescricao.Width = campoWidth;
            txbDescricao.Height = 72;
            txbDescricao.Multiline = true;
            txbDescricao.Top = txbTitulo.Bottom + 48;
            lbDescricao.Left = campoLeft;
            lbDescricao.Top = txbDescricao.Top - 24;

            cmbPrioridade.Left = campoLeft;
            cmbPrioridade.Width = campoWidth;
            cmbPrioridade.Top = txbDescricao.Bottom + 48;
            label2.Left = campoLeft;
            label2.Top = cmbPrioridade.Top - 24;

            cmbCategoria.Left = campoLeft;
            cmbCategoria.Width = campoWidth;
            cmbCategoria.Top = cmbPrioridade.Bottom + 48;
            label3.Left = campoLeft;
            label3.Top = cmbCategoria.Top - 24;

            btnConfirmar.Width = 136;
            btnConfirmar.Left = (panelForm.Width - btnConfirmar.Width) / 2;
            btnConfirmar.Top = panelForm.Height - btnConfirmar.Height - 48;

            lbVoltar.Left = 36;
            lbVoltar.Top = 24;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (SessaoUsuario.UsuarioLogado == null)
                {
                    MessageBox.Show("Usuário não identificado. Faça login novamente.");
                    return;
                }

                var chamado = new Chamado
                {
                    Titulo = txbTitulo.Text.Trim(),
                    Descricao = txbDescricao.Text.Trim(),
                    Prioridade = cmbPrioridade.Text,
                    Categoria = cmbCategoria.Text,
                    Status = "Aberto",
                    DataAbertura = DateTime.Now,
                    UsuarioId = SessaoUsuario.UsuarioLogado.Id
                };

                _chamadoService.CriarChamado(chamado);

                MessageBox.Show("Chamado aberto com sucesso!");
                txbTitulo.Clear();
                txbDescricao.Clear();
                cmbPrioridade.SelectedIndex = -1;
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
