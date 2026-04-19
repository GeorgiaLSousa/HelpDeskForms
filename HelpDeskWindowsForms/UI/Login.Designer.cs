namespace HelpDeskWindowsForms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            label5 = new Label();
            Senha = new Label();
            Email = new Label();
            Entrar = new Button();
            SenhaText = new TextBox();
            EmailText = new TextBox();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(18, 25, 47);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(728, 32);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.125F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(129, 8);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(145, 17);
            label8.TabIndex = 1;
            label8.Text = "HelpDesk Pro System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 6);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(108, 47);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 25, 47);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(429, 33);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 327);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(19, 237);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(230, 13);
            label7.TabIndex = 2;
            label7.Text = "gerencie chamadas de forma simples e eficiente";
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 13.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(59, 71);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(208, 41);
            label6.TabIndex = 1;
            label6.Text = "Seja bem-vindo!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 107);
            pictureBox2.Margin = new Padding(2, 1, 2, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(207, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(Senha);
            panel3.Controls.Add(Email);
            panel3.Controls.Add(Entrar);
            panel3.Controls.Add(SenhaText);
            panel3.Controls.Add(EmailText);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 32);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(430, 329);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(99, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 24);
            label1.TabIndex = 5;
            label1.Text = "Faça o seu Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(124, 266);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(146, 15);
            label5.TabIndex = 4;
            label5.Text = "Deseja criar a sua conta?";
            label5.Click += label5_Click;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Microsoft Sans Serif", 10.125F);
            Senha.ForeColor = Color.Black;
            Senha.Location = new Point(99, 128);
            Senha.Margin = new Padding(2, 0, 2, 0);
            Senha.Name = "Senha";
            Senha.Size = new Size(49, 17);
            Senha.TabIndex = 2;
            Senha.Text = "Senha";
            Senha.Click += Senha_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Microsoft Sans Serif", 10.125F);
            Email.ForeColor = Color.Black;
            Email.Location = new Point(99, 77);
            Email.Margin = new Padding(2, 0, 2, 0);
            Email.Name = "Email";
            Email.Size = new Size(42, 17);
            Email.TabIndex = 1;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // Entrar
            // 
            Entrar.BackColor = Color.FromArgb(18, 25, 47);
            Entrar.FlatStyle = FlatStyle.Flat;
            Entrar.ForeColor = Color.White;
            Entrar.Location = new Point(99, 208);
            Entrar.Margin = new Padding(2, 1, 2, 1);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(81, 22);
            Entrar.TabIndex = 3;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += button1_Click;
            // 
            // SenhaText
            // 
            SenhaText.Location = new Point(99, 151);
            SenhaText.Margin = new Padding(2, 1, 2, 1);
            SenhaText.Name = "SenhaText";
            SenhaText.Size = new Size(260, 23);
            SenhaText.TabIndex = 2;
            SenhaText.TextChanged += SenhaText_TextChanged;
            // 
            // EmailText
            // 
            EmailText.Location = new Point(99, 101);
            EmailText.Margin = new Padding(2, 1, 2, 1);
            EmailText.Name = "EmailText";
            EmailText.Size = new Size(260, 23);
            EmailText.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(99, 171);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(102, 13);
            label4.TabIndex = 0;
            label4.Text = "Esqueceu a senha?";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 361);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label5;
        private Label Senha;
        private Label Email;
        private Button Entrar;
        private TextBox SenhaText;
        private TextBox EmailText;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
    }
}
