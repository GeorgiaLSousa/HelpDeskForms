using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using HelpDeskWindowsForms.Model;

namespace HelpDeskWindowsForms
{
    public partial class CardChamado : UserControl
    {
        public CardChamado()
        {
            InitializeComponent();
            AjustarLayout();
        }

        private void CardChamado_Resize(object sender, EventArgs e)
        {
            AjustarLayout();
        }

        private void AjustarLayout()
        {
            const int margem = 20;
            const int espacoBadge = 25;

            var larguraAreaAcoes = Math.Max(btnVerDetalhes.Width, Math.Max(lblStatus.Width, lblPrioridade.Width));
            var esquerdaAcoes = Width - larguraAreaAcoes - margem;

            lblStatus.Left = esquerdaAcoes + (larguraAreaAcoes - lblStatus.Width) / 2;
            lblPrioridade.Left = lblStatus.Left;
            btnVerDetalhes.Left = esquerdaAcoes + (larguraAreaAcoes - btnVerDetalhes.Width) / 2;

            var larguraTexto = Math.Max(220, esquerdaAcoes - espacoBadge - margem);
            lbTitulo.Width = larguraTexto;
            lblDescricao.Width = larguraTexto;
            lblInfo.Width = larguraTexto;
        }

        public void CarregarDados(Chamado chamado)
        {
            lbTitulo.Text = chamado.Titulo;
            lblDescricao.Text = chamado.Descricao;
            lblStatus.Text = chamado.Status;
            lblPrioridade.Text = chamado.Prioridade;
            lblInfo.Text = $"{chamado.Usuario?.Nome ?? "Usuario"}     {chamado.DataAbertura:dd/MM/yyyy}     {chamado.Categoria}";


        }





        private void lblInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
