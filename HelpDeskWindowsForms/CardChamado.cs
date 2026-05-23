using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
            const int margem = 15;
            const int larguraBadge = 90;
            const int espacoBadge = 25;

            lblStatus.Left = Width - larguraBadge - margem;
            lblPrioridade.Left = lblStatus.Left;

            var larguraTexto = Math.Max(220, lblStatus.Left - espacoBadge - margem);
            lbTitulo.Width = larguraTexto;
            lblDescricao.Width = larguraTexto;
            lblInfo.Width = larguraTexto;
        }
    }
}
