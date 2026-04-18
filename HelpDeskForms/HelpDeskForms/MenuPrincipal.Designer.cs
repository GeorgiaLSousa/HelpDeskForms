namespace HelpDeskWindowsForms
{
    partial class HelpDesk
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            USUARIOlabel = new Label();
            ANALISTA = new Label();
            AbrirChamado = new Button();
            FinalizarChamado = new Button();
            AtualizarChamado = new Button();
            AtenderChamado = new Button();
            AbrirChamadoUsuario = new Button();
            AcompanharChamado = new Button();
            panel3 = new Panel();
            tabControl1 = new TabControl();
            MeusChamados = new TabPage();
            panel4 = new Panel();
            dataGridView1 = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Data = new DataGridViewTextBoxColumn();
            Finalizar = new Button();
            Atender = new Button();
            TodosOsChamados = new TabPage();
            dataGridView2 = new DataGridView();
            Titulo2 = new DataGridViewTextBoxColumn();
            Usuario2 = new DataGridViewTextBoxColumn();
            Status2 = new DataGridViewTextBoxColumn();
            Data2 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tabControl1.SuspendLayout();
            MeusChamados.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            TodosOsChamados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DeepSkyBlue;
            panel1.Controls.Add(USUARIOlabel);
            panel1.Controls.Add(ANALISTA);
            panel1.Controls.Add(AbrirChamado);
            panel1.Controls.Add(FinalizarChamado);
            panel1.Controls.Add(AtualizarChamado);
            panel1.Controls.Add(AtenderChamado);
            panel1.Controls.Add(AbrirChamadoUsuario);
            panel1.Controls.Add(AcompanharChamado);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(295, 600);
            panel1.TabIndex = 0;
            // 
            // USUARIOlabel
            // 
            USUARIOlabel.AutoSize = true;
            USUARIOlabel.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            USUARIOlabel.Location = new Point(52, 342);
            USUARIOlabel.Name = "USUARIOlabel";
            USUARIOlabel.Size = new Size(190, 44);
            USUARIOlabel.TabIndex = 8;
            USUARIOlabel.Text = "USUÁRIO";
            // 
            // ANALISTA
            // 
            ANALISTA.AutoSize = true;
            ANALISTA.Font = new Font("Arial", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ANALISTA.Location = new Point(52, 32);
            ANALISTA.Name = "ANALISTA";
            ANALISTA.Size = new Size(204, 44);
            ANALISTA.TabIndex = 7;
            ANALISTA.Text = "ANALISTA";
            ANALISTA.Click += ANALISTA_Click;
            // 
            // AbrirChamado
            // 
            AbrirChamado.BackColor = Color.SteelBlue;
            AbrirChamado.FlatAppearance.BorderColor = Color.MidnightBlue;
            AbrirChamado.FlatAppearance.BorderSize = 3;
            AbrirChamado.FlatStyle = FlatStyle.Popup;
            AbrirChamado.Location = new Point(31, 269);
            AbrirChamado.Name = "AbrirChamado";
            AbrirChamado.Size = new Size(245, 46);
            AbrirChamado.TabIndex = 4;
            AbrirChamado.Text = "Abrir Chamado";
            AbrirChamado.UseVisualStyleBackColor = false;
            // 
            // FinalizarChamado
            // 
            FinalizarChamado.BackColor = Color.SteelBlue;
            FinalizarChamado.FlatAppearance.BorderColor = Color.MidnightBlue;
            FinalizarChamado.FlatAppearance.BorderSize = 3;
            FinalizarChamado.FlatStyle = FlatStyle.Popup;
            FinalizarChamado.Location = new Point(31, 217);
            FinalizarChamado.Name = "FinalizarChamado";
            FinalizarChamado.Size = new Size(245, 46);
            FinalizarChamado.TabIndex = 3;
            FinalizarChamado.Text = "Finalizar Chamado";
            FinalizarChamado.UseVisualStyleBackColor = false;
            // 
            // AtualizarChamado
            // 
            AtualizarChamado.BackColor = Color.SteelBlue;
            AtualizarChamado.FlatAppearance.BorderColor = Color.MidnightBlue;
            AtualizarChamado.FlatAppearance.BorderSize = 3;
            AtualizarChamado.FlatStyle = FlatStyle.Popup;
            AtualizarChamado.Location = new Point(31, 165);
            AtualizarChamado.Name = "AtualizarChamado";
            AtualizarChamado.Size = new Size(245, 46);
            AtualizarChamado.TabIndex = 2;
            AtualizarChamado.Text = "Atualizar Chamado";
            AtualizarChamado.UseVisualStyleBackColor = false;
            // 
            // AtenderChamado
            // 
            AtenderChamado.BackColor = Color.SteelBlue;
            AtenderChamado.FlatAppearance.BorderColor = Color.MidnightBlue;
            AtenderChamado.FlatAppearance.BorderSize = 3;
            AtenderChamado.FlatStyle = FlatStyle.Popup;
            AtenderChamado.Location = new Point(31, 113);
            AtenderChamado.Name = "AtenderChamado";
            AtenderChamado.Size = new Size(245, 46);
            AtenderChamado.TabIndex = 1;
            AtenderChamado.Text = "Atender Chamado";
            AtenderChamado.UseVisualStyleBackColor = false;
            AtenderChamado.Click += AtenderChamado_Click;
            // 
            // AbrirChamadoUsuario
            // 
            AbrirChamadoUsuario.BackColor = Color.SteelBlue;
            AbrirChamadoUsuario.FlatAppearance.BorderColor = Color.MidnightBlue;
            AbrirChamadoUsuario.FlatAppearance.BorderSize = 3;
            AbrirChamadoUsuario.FlatStyle = FlatStyle.Popup;
            AbrirChamadoUsuario.Location = new Point(31, 425);
            AbrirChamadoUsuario.Name = "AbrirChamadoUsuario";
            AbrirChamadoUsuario.Size = new Size(245, 46);
            AbrirChamadoUsuario.TabIndex = 5;
            AbrirChamadoUsuario.Text = "Abrir Chamado";
            AbrirChamadoUsuario.UseVisualStyleBackColor = false;
            // 
            // AcompanharChamado
            // 
            AcompanharChamado.BackColor = Color.SteelBlue;
            AcompanharChamado.FlatAppearance.BorderColor = Color.MidnightBlue;
            AcompanharChamado.FlatAppearance.BorderSize = 3;
            AcompanharChamado.FlatStyle = FlatStyle.Popup;
            AcompanharChamado.Location = new Point(31, 488);
            AcompanharChamado.Name = "AcompanharChamado";
            AcompanharChamado.Size = new Size(245, 81);
            AcompanharChamado.TabIndex = 6;
            AcompanharChamado.Text = "Acompanhar\r\n Chamado";
            AcompanharChamado.UseVisualStyleBackColor = false;
            AcompanharChamado.Click += AcompanharChamado_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(tabControl1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(295, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(817, 600);
            panel3.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(MeusChamados);
            tabControl1.Controls.Add(TodosOsChamados);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(850, 1504);
            tabControl1.TabIndex = 1;
            // 
            // MeusChamados
            // 
            MeusChamados.BackColor = Color.Transparent;
            MeusChamados.BorderStyle = BorderStyle.Fixed3D;
            MeusChamados.Controls.Add(panel4);
            MeusChamados.ForeColor = SystemColors.ActiveCaptionText;
            MeusChamados.Location = new Point(8, 46);
            MeusChamados.Name = "MeusChamados";
            MeusChamados.Padding = new Padding(3);
            MeusChamados.Size = new Size(834, 1450);
            MeusChamados.TabIndex = 0;
            MeusChamados.Text = "Meus chamados";
            // 
            // panel4
            // 
            panel4.Controls.Add(dataGridView1);
            panel4.Controls.Add(Finalizar);
            panel4.Controls.Add(Atender);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 1440);
            panel4.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titulo, Usuario, Status, Data });
            dataGridView1.Location = new Point(-5, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(826, 852);
            dataGridView1.TabIndex = 4;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Título";
            Titulo.MinimumWidth = 10;
            Titulo.Name = "Titulo";
            // 
            // Usuario
            // 
            Usuario.HeaderText = "Usuário";
            Usuario.MinimumWidth = 10;
            Usuario.Name = "Usuario";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 10;
            Status.Name = "Status";
            // 
            // Data
            // 
            Data.HeaderText = "Data";
            Data.MinimumWidth = 10;
            Data.Name = "Data";
            // 
            // Finalizar
            // 
            Finalizar.BackColor = Color.SteelBlue;
            Finalizar.FlatAppearance.BorderColor = Color.Black;
            Finalizar.FlatAppearance.BorderSize = 3;
            Finalizar.FlatStyle = FlatStyle.Flat;
            Finalizar.Font = new Font("Segoe UI", 9F);
            Finalizar.ForeColor = Color.Black;
            Finalizar.Location = new Point(159, 0);
            Finalizar.Name = "Finalizar";
            Finalizar.Size = new Size(150, 46);
            Finalizar.TabIndex = 3;
            Finalizar.Text = "Finalizar";
            Finalizar.UseVisualStyleBackColor = false;
            Finalizar.Click += button3_Click;
            // 
            // Atender
            // 
            Atender.BackColor = Color.SteelBlue;
            Atender.FlatAppearance.BorderColor = Color.Black;
            Atender.FlatAppearance.BorderSize = 3;
            Atender.FlatStyle = FlatStyle.Flat;
            Atender.ForeColor = Color.Black;
            Atender.Location = new Point(3, 0);
            Atender.Name = "Atender";
            Atender.Size = new Size(150, 46);
            Atender.TabIndex = 3;
            Atender.Text = "Atender";
            Atender.UseVisualStyleBackColor = false;
            // 
            // TodosOsChamados
            // 
            TodosOsChamados.BackColor = Color.Transparent;
            TodosOsChamados.Controls.Add(dataGridView2);
            TodosOsChamados.Location = new Point(8, 46);
            TodosOsChamados.Name = "TodosOsChamados";
            TodosOsChamados.Padding = new Padding(3);
            TodosOsChamados.Size = new Size(834, 1450);
            TodosOsChamados.TabIndex = 1;
            TodosOsChamados.Text = "Todos os Chamados";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView2.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { Titulo2, Usuario2, Status2, Data2 });
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 82;
            dataGridView2.Size = new Size(828, 1444);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // Titulo2
            // 
            Titulo2.HeaderText = "Título";
            Titulo2.MinimumWidth = 10;
            Titulo2.Name = "Titulo2";
            // 
            // Usuario2
            // 
            Usuario2.HeaderText = "Usuário";
            Usuario2.MinimumWidth = 10;
            Usuario2.Name = "Usuario2";
            // 
            // Status2
            // 
            Status2.HeaderText = "Status";
            Status2.MinimumWidth = 10;
            Status2.Name = "Status2";
            // 
            // Data2
            // 
            Data2.HeaderText = "Data";
            Data2.MinimumWidth = 10;
            Data2.Name = "Data2";
            // 
            // HelpDesk
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1112, 600);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "HelpDesk";
            Text = "HelpDesk";
            WindowState = FormWindowState.Maximized;
            Load += HelpDesk_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            MeusChamados.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            TodosOsChamados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button AcompanharChamado;
        private Button AbrirChamadoUsuario;
        private Button AbrirChamado;
        private Button FinalizarChamado;
        private Button AtualizarChamado;
        private Button AtenderChamado;
        private Panel panel3;
        private TabControl tabControl1;
        private TabPage MeusChamados;
        private TabPage TodosOsChamados;
        private Panel panel4;
        private Button Finalizar;
        private Button Atender;
        private DataGridView dataGridView2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Data;
        private DataGridViewTextBoxColumn Titulo2;
        private DataGridViewTextBoxColumn Usuario2;
        private DataGridViewTextBoxColumn Status2;
        private DataGridViewTextBoxColumn Data2;
        private Label USUARIOlabel;
        private Label ANALISTA;
    }
}
