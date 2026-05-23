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
        public DashboardCliente()
        {
            InitializeComponent();
        }
        private void btNovoChamado_Click(object sender, EventArgs e)
        {
            var entrar = new NovoChamado();
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
        }
    }
}
