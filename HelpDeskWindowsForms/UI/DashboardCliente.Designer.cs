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
            panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IconeUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PB_Logo).BeginInit();
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
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(717, 75);
            panelHeader.TabIndex = 0;
            // 
            // PB_IconeUsuario
            // 
            PB_IconeUsuario.BackColor = Color.Transparent;
            PB_IconeUsuario.Dock = DockStyle.Right;
            PB_IconeUsuario.Image = (Image)resources.GetObject("PB_IconeUsuario.Image");
            PB_IconeUsuario.Location = new Point(677, 0);
            PB_IconeUsuario.Name = "PB_IconeUsuario";
            PB_IconeUsuario.Size = new Size(40, 75);
            PB_IconeUsuario.SizeMode = PictureBoxSizeMode.Zoom;
            PB_IconeUsuario.TabIndex = 3;
            PB_IconeUsuario.TabStop = false;
            // 
            // lbNomeUsuario
            // 
            lbNomeUsuario.AutoSize = true;
            lbNomeUsuario.BackColor = Color.Transparent;
            lbNomeUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNomeUsuario.ForeColor = Color.White;
            lbNomeUsuario.Location = new Point(612, 30);
            lbNomeUsuario.Name = "lbNomeUsuario";
            lbNomeUsuario.Size = new Size(47, 20);
            lbNomeUsuario.TabIndex = 2;
            lbNomeUsuario.Text = "Maria";
            // 
            // lbTituloSistema
            // 
            lbTituloSistema.AutoSize = true;
            lbTituloSistema.BackColor = Color.Transparent;
            lbTituloSistema.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTituloSistema.ForeColor = Color.White;
            lbTituloSistema.Location = new Point(100, 20);
            lbTituloSistema.Name = "lbTituloSistema";
            lbTituloSistema.Size = new Size(241, 32);
            lbTituloSistema.TabIndex = 1;
            lbTituloSistema.Text = "HelpDesk Pro System";
            // 
            // PB_Logo
            // 
            PB_Logo.BackColor = Color.Transparent;
            PB_Logo.Dock = DockStyle.Left;
            PB_Logo.Image = Properties.Resources.logo;
            PB_Logo.Location = new Point(0, 0);
            PB_Logo.Name = "PB_Logo";
            PB_Logo.Size = new Size(90, 75);
            PB_Logo.SizeMode = PictureBoxSizeMode.Zoom;
            PB_Logo.TabIndex = 0;
            PB_Logo.TabStop = false;
            PB_Logo.Click += PB_Logo_Click;
            // 
            // DashboardCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 355);
            Controls.Add(panelHeader);
            Name = "DashboardCliente";
            Text = "DashboardCliente";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PB_IconeUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)PB_Logo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHeader;
        private PictureBox PB_Logo;
        private Label lbNomeUsuario;
        private Label lbTituloSistema;
        private PictureBox PB_IconeUsuario;
    }
}