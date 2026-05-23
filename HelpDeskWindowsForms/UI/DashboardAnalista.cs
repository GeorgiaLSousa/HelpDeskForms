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
        public DashboardAnalista()
        {
            InitializeComponent();
        }

        private void DashboardAnalista_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbAtendimento.SelectedIndex = 0;
            AjustarCards();
        }

        private void DashboardAnalista_Resize(object sender, EventArgs e)
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
