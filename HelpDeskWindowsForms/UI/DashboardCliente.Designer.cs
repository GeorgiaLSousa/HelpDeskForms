namespace HelpDeskWindowsForms.UI
{
    partial class DashboardCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCliente));
            panelHeader = new Panel();
            PB_IconeUsuario = new PictureBox();
            lbNomeUsuario = new Label();
            lbTituloSistema = new Label();
            PB_Logo = new PictureBox();
            lbTituloPagina = new Label();
            cmbStatus = new ComboBox();
            btNovoChamado = new Button();
            flowChamados = new FlowLayoutPanel();
            cardChamado1 = new CardChamado();
            cardChamado2 = new CardChamado();
            cardChamado3 = new CardChamado();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IconeUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Logo).BeginInit();
            flowChamados.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(11, 22, 51);
            panelHeader.Controls.Add(PB_IconeUsuario);
            panelHeader.Controls.Add(lbNomeUsuario);
            panelHeader.Controls.Add(lbTituloSistema);
            panelHeader.Controls.Add(PB_Logo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1366, 104);
            panelHeader.TabIndex = 0;
            // 
            // PB_IconeUsuario
            // 
            PB_IconeUsuario.BackColor = Color.Transparent;
            PB_IconeUsuario.Dock = DockStyle.Right;
            PB_IconeUsuario.Image = (Image)resources.GetObject("PB_IconeUsuario.Image");
            PB_IconeUsuario.Location = new Point(1306, 0);
            PB_IconeUsuario.Margin = new Padding(3, 4, 3, 4);
            PB_IconeUsuario.Name = "PB_IconeUsuario";
            PB_IconeUsuario.Size = new Size(60, 104);
            PB_IconeUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            PB_IconeUsuario.TabIndex = 3;
            PB_IconeUsuario.TabStop = false;
            // 
            // lbNomeUsuario
            // 
            lbNomeUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbNomeUsuario.AutoSize = true;
            lbNomeUsuario.BackColor = Color.Transparent;
            lbNomeUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNomeUsuario.ForeColor = Color.White;
            lbNomeUsuario.Location = new Point(1230, 40);
            lbNomeUsuario.Name = "lbNomeUsuario";
            lbNomeUsuario.Size = new Size(61, 25);
            lbNomeUsuario.TabIndex = 2;
            lbNomeUsuario.Text = "Maria";
            // 
            // lbTituloSistema
            // 
            lbTituloSistema.AutoSize = true;
            lbTituloSistema.BackColor = Color.Transparent;
            lbTituloSistema.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloSistema.ForeColor = Color.White;
            lbTituloSistema.Location = new Point(132, 30);
            lbTituloSistema.Name = "lbTituloSistema";
            lbTituloSistema.Size = new Size(301, 41);
            lbTituloSistema.TabIndex = 1;
            lbTituloSistema.Text = "HelpDesk Pro System";
            // 
            // PB_Logo
            // 
            PB_Logo.BackColor = Color.Transparent;
            PB_Logo.Dock = DockStyle.Left;
            PB_Logo.Image = Properties.Resources.logo;
            PB_Logo.Location = new Point(0, 0);
            PB_Logo.Margin = new Padding(3, 4, 3, 4);
            PB_Logo.Name = "PB_Logo";
            PB_Logo.Size = new Size(116, 104);
            PB_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            PB_Logo.TabIndex = 0;
            PB_Logo.TabStop = false;
            // 
            // lbTituloPagina
            // 
            lbTituloPagina.AutoSize = true;
            lbTituloPagina.BackColor = Color.Transparent;
            lbTituloPagina.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloPagina.ForeColor = Color.FromArgb(30, 30, 30);
            lbTituloPagina.Location = new Point(48, 144);
            lbTituloPagina.Name = "lbTituloPagina";
            lbTituloPagina.Size = new Size(556, 50);
            lbTituloPagina.TabIndex = 1;
            lbTituloPagina.Text = "Acompanhar os meus chamados";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FlatStyle = FlatStyle.Flat;
            cmbStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Todos os status", "Aberto", "Em progresso", "Fechado" });
            cmbStatus.Location = new Point(48, 192);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(260, 33);
            cmbStatus.TabIndex = 2;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btNovoChamado
            // 
            btNovoChamado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btNovoChamado.BackColor = Color.FromArgb(190, 190, 190);
            btNovoChamado.Cursor = Cursors.Hand;
            btNovoChamado.FlatAppearance.BorderSize = 0;
            btNovoChamado.FlatStyle = FlatStyle.Flat;
            btNovoChamado.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btNovoChamado.ForeColor = Color.FromArgb(40, 40, 40);
            btNovoChamado.Location = new Point(1115, 185);
            btNovoChamado.Name = "btNovoChamado";
            btNovoChamado.Size = new Size(200, 40);
            btNovoChamado.TabIndex = 3;
            btNovoChamado.Text = "+ Novo Chamado";
            btNovoChamado.UseVisualStyleBackColor = false;
            btNovoChamado.Click += btNovoChamado_Click;
            // 
            // flowChamados
            // 
            flowChamados.AutoScroll = true;
            flowChamados.BackColor = Color.Transparent;
            flowChamados.Controls.Add(cardChamado1);
            flowChamados.Controls.Add(cardChamado2);
            flowChamados.Controls.Add(cardChamado3);
            flowChamados.FlowDirection = FlowDirection.TopDown;
            flowChamados.Location = new Point(35, 230);
            flowChamados.Name = "flowChamados";
            flowChamados.Size = new Size(1285, 450);
            flowChamados.TabIndex = 4;
            flowChamados.WrapContents = false;
            // 
            // cardChamado1
            // 
            cardChamado1.BackColor = Color.FromArgb(17, 27, 58);
            cardChamado1.Location = new Point(0, 0);
            cardChamado1.Margin = new Padding(0, 0, 0, 10);
            cardChamado1.Name = "cardChamado1";
            cardChamado1.Size = new Size(1260, 145);
            cardChamado1.TabIndex = 0;
            // 
            // cardChamado2
            // 
            cardChamado2.BackColor = Color.FromArgb(17, 27, 58);
            cardChamado2.Location = new Point(0, 155);
            cardChamado2.Margin = new Padding(0, 0, 0, 10);
            cardChamado2.Name = "cardChamado2";
            cardChamado2.Size = new Size(1260, 145);
            cardChamado2.TabIndex = 1;
            // 
            // cardChamado3
            // 
            cardChamado3.BackColor = Color.FromArgb(17, 27, 58);
            cardChamado3.Location = new Point(0, 310);
            cardChamado3.Margin = new Padding(0, 0, 0, 10);
            cardChamado3.Name = "cardChamado3";
            cardChamado3.Size = new Size(1260, 145);
            cardChamado3.TabIndex = 2;
            // 
            // DashboardCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(235, 235, 235);
            ClientSize = new Size(1366, 768);
            Controls.Add(flowChamados);
            Controls.Add(btNovoChamado);
            Controls.Add(cmbStatus);
            Controls.Add(lbTituloPagina);
            Controls.Add(panelHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DashboardCliente";
            Text = "DashboardCliente";
            Load += DashboardCliente_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IconeUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Logo).EndInit();
            flowChamados.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private PictureBox PB_Logo;
        private Label lbNomeUsuario;
        private Label lbTituloSistema;
        private PictureBox PB_IconeUsuario;
        private Label lbTituloPagina;
        private ComboBox cmbStatus;
        private Button btNovoChamado;
        private FlowLayoutPanel flowChamados;
        private CardChamado cardChamado1;
        private CardChamado cardChamado2;
        private CardChamado cardChamado3;
    }
}
