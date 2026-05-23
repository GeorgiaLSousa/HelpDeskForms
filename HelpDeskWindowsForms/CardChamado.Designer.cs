namespace HelpDeskWindowsForms
{
    partial class CardChamado
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            lbTitulo = new Label();
            lblDescricao = new Label();
            lblInfo = new Label();
            lblStatus = new Label();
            lblPrioridade = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // lbTitulo
            // 
            lbTitulo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.White;
            lbTitulo.Location = new Point(15, 15);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(960, 31);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "Problema no sistema de login";
            // 
            // lblDescricao
            // 
            lblDescricao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblDescricao.BackColor = Color.Transparent;
            lblDescricao.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescricao.ForeColor = Color.White;
            lblDescricao.Location = new Point(15, 50);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(960, 50);
            lblDescricao.TabIndex = 2;
            lblDescricao.Text = "Usuários estão relatando dificuldade para acessar o sistema...";
            // 
            // lblInfo
            // 
            lblInfo.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInfo.ForeColor = Color.White;
            lblInfo.Location = new Point(15, 110);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(500, 23);
            lblInfo.TabIndex = 3;
            lblInfo.Text = "Maria     01/04/2026     Sistema";
            // 
            // lblStatus
            // 
            lblStatus.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblStatus.BackColor = Color.White;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.Blue;
            lblStatus.Location = new Point(1150, 20);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 30);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Aberto";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrioridade
            // 
            lblPrioridade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblPrioridade.BackColor = Color.White;
            lblPrioridade.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrioridade.ForeColor = Color.Red;
            lblPrioridade.Location = new Point(1150, 59);
            lblPrioridade.Name = "lblPrioridade";
            lblPrioridade.Size = new Size(90, 30);
            lblPrioridade.TabIndex = 5;
            lblPrioridade.Text = "Alta";
            lblPrioridade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CardChamado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(17, 27, 58);
            Controls.Add(lblPrioridade);
            Controls.Add(lblStatus);
            Controls.Add(lblInfo);
            Controls.Add(lblDescricao);
            Controls.Add(lbTitulo);
            Margin = new Padding(0, 0, 0, 10);
            Name = "CardChamado";
            Size = new Size(1280, 155);
            Resize += CardChamado_Resize;
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label lbTitulo;
        private Label lblDescricao;
        private Label lblInfo;
        private Label lblStatus;
        private Label lblPrioridade;
    }
}
