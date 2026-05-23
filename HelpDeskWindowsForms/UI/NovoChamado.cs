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
    public partial class NovoChamado : Form
    {
        private readonly IServiceProvider _serviceProvider = null!;

        public NovoChamado()
        {
            InitializeComponent();
        }

        public NovoChamado(IServiceProvider serviceProvider) : this()
        {
            _serviceProvider = serviceProvider;
        }

        private void NovoChamado_Load(object sender, EventArgs e)
        {
            CentralizarFormulario();
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
            CentralizarFormulario();
        }

        private void CentralizarFormulario()
        {
            panelForm.Left = Math.Max(24, (panelConteudo.ClientSize.Width - panelForm.Width) / 2);
            panelForm.Top = Math.Max(24, (panelConteudo.ClientSize.Height - panelForm.Height) / 2);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
