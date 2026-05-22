namespace HelpDeskWindowsForms.UI
{
    partial class NovoChamado
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
            panelHeader = new Panel();
            pctLogo = new PictureBox();
            lbSistema = new Label();
            panel1 = new Panel();
            lbAjuda = new Label();
            picAjuda = new PictureBox();
            panelConteudo = new Panel();
            lbVoltar = new Label();
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pctLogo).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAjuda).BeginInit();
            panelConteudo.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(17, 27, 58);
            panelHeader.Controls.Add(lbSistema);
            panelHeader.Controls.Add(pctLogo);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1348, 65);
            panelHeader.TabIndex = 0;
            // 
            // pctLogo
            // 
            pctLogo.Dock = DockStyle.Left;
            pctLogo.Image = Properties.Resources.logo;
            pctLogo.Location = new Point(0, 0);
            pctLogo.Name = "pctLogo";
            pctLogo.Size = new Size(110, 65);
            pctLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pctLogo.TabIndex = 0;
            pctLogo.TabStop = false;
            // 
            // lbSistema
            // 
            lbSistema.BackColor = Color.Transparent;
            lbSistema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSistema.ForeColor = Color.White;
            lbSistema.Location = new Point(155, 9);
            lbSistema.Name = "lbSistema";
            lbSistema.Size = new Size(210, 36);
            lbSistema.TabIndex = 1;
            lbSistema.Text = "HelpDesk Pro System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 27, 58);
            panel1.Controls.Add(picAjuda);
            panel1.Controls.Add(lbAjuda);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(430, 656);
            panel1.TabIndex = 1;
            // 
            // lbAjuda
            // 
            lbAjuda.AutoSize = true;
            lbAjuda.BackColor = Color.Transparent;
            lbAjuda.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAjuda.ForeColor = Color.White;
            lbAjuda.Location = new Point(115, 100);
            lbAjuda.Name = "lbAjuda";
            lbAjuda.Size = new Size(231, 31);
            lbAjuda.TabIndex = 2;
            lbAjuda.Text = "Precisando de ajuda?";
            // 
            // picAjuda
            // 
            picAjuda.Image = Properties.Resources.ajuda;
            picAjuda.Location = new Point(75, 180);
            picAjuda.Name = "picAjuda";
            picAjuda.Size = new Size(301, 201);
            picAjuda.SizeMode = PictureBoxSizeMode.Zoom;
            picAjuda.TabIndex = 3;
            picAjuda.TabStop = false;
            // 
            // panelConteudo
            // 
            panelConteudo.Controls.Add(lbVoltar);
            panelConteudo.Dock = DockStyle.Fill;
            panelConteudo.Location = new Point(430, 65);
            panelConteudo.Name = "panelConteudo";
            panelConteudo.Size = new Size(918, 656);
            panelConteudo.TabIndex = 2;
            // 
            // lbVoltar
            // 
            lbVoltar.AutoSize = true;
            lbVoltar.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbVoltar.Location = new Point(30, 25);
            lbVoltar.Name = "lbVoltar";
            lbVoltar.Size = new Size(58, 54);
            lbVoltar.TabIndex = 0;
            lbVoltar.Text = "←";
            // 
            // NovoChamado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1348, 721);
            Controls.Add(panelConteudo);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Name = "NovoChamado";
            Text = "NovoChamado";
            Load += NovoChamado_Load;
            panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pctLogo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAjuda).EndInit();
            panelConteudo.ResumeLayout(false);
            panelConteudo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox pctLogo;
        private Label lbSistema;
        private Panel panel1;
        private PictureBox picAjuda;
        private Label lbAjuda;
        private Panel panelConteudo;
        private Label lbVoltar;
    }
}