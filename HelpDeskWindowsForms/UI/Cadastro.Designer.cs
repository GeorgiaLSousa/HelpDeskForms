namespace HelpDeskWindowsForms.UI
{
    partial class Cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Cadastrar = new Button();
            panel4 = new Panel();
            Nome = new Label();
            Senha = new Label();
            CPF = new Label();
            Email = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 25, 47);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1364, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(242, 22);
            label1.Name = "label1";
            label1.Size = new Size(341, 46);
            label1.TabIndex = 2;
            label1.Text = "HelpDesk Pro System";
            // 
            // panel2
            // 
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 700);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(250, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 43);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(250, 268);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(479, 43);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(250, 372);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(479, 43);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(249, 467);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(479, 43);
            textBox4.TabIndex = 3;
            // 
            // Cadastrar
            // 
            Cadastrar.BackColor = Color.FromArgb(18, 25, 47);
            Cadastrar.FlatStyle = FlatStyle.Popup;
            Cadastrar.ForeColor = Color.White;
            Cadastrar.Location = new Point(410, 544);
            Cadastrar.Name = "Cadastrar";
            Cadastrar.Size = new Size(150, 46);
            Cadastrar.TabIndex = 8;
            Cadastrar.Text = "Cadastrar";
            Cadastrar.UseVisualStyleBackColor = false;
            Cadastrar.Click += Cadastrar_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(Nome);
            panel4.Controls.Add(Cadastrar);
            panel4.Controls.Add(Senha);
            panel4.Controls.Add(CPF);
            panel4.Controls.Add(Email);
            panel4.Controls.Add(textBox4);
            panel4.Controls.Add(textBox3);
            panel4.Controls.Add(textBox2);
            panel4.Controls.Add(textBox1);
            panel4.Font = new Font("Poppins", 9F);
            panel4.Location = new Point(524, 97);
            panel4.Name = "panel4";
            panel4.Size = new Size(841, 676);
            panel4.TabIndex = 2;
            // 
            // Nome
            // 
            Nome.AutoSize = true;
            Nome.Font = new Font("Poppins", 9F);
            Nome.Location = new Point(247, 117);
            Nome.Name = "Nome";
            Nome.Size = new Size(90, 42);
            Nome.TabIndex = 9;
            Nome.Text = "Nome";
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Poppins", 9F);
            Senha.Location = new Point(247, 425);
            Senha.Name = "Senha";
            Senha.Size = new Size(93, 42);
            Senha.TabIndex = 6;
            Senha.Text = "Senha";
            // 
            // CPF
            // 
            CPF.AutoSize = true;
            CPF.Font = new Font("Poppins", 9F);
            CPF.Location = new Point(247, 327);
            CPF.Name = "CPF";
            CPF.Size = new Size(63, 42);
            CPF.TabIndex = 5;
            CPF.Text = "CPF";
            CPF.Click += CPF_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Poppins", 9F);
            Email.Location = new Point(247, 223);
            Email.Name = "Email";
            Email.Size = new Size(83, 42);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(96, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 257);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 25, 47);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(-37, 71);
            panel3.Name = "panel3";
            panel3.Size = new Size(587, 699);
            panel3.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(175, 160);
            label2.Name = "label2";
            label2.Size = new Size(233, 42);
            label2.TabIndex = 3;
            label2.Text = "Crie sua conta !!";
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(96, 498);
            label3.Name = "label3";
            label3.Size = new Size(413, 34);
            label3.TabIndex = 2;
            label3.Text = "Preencha os dados abaixo para começar";
            label3.Click += label3_Click;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1364, 764);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cadastro";
            Text = "Cadastro";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Cadastrar;
        private Panel panel4;
        private Label Nome;
        private PictureBox pictureBox2;
        private Panel panel3;
        private Label label1;
        private Label Senha;
        private Label CPF;
        private Label Email;
        private Label label2;
        private Label label3;
    }
}