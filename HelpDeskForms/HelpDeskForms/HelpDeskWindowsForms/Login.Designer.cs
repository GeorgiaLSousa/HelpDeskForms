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
            label4 = new Label();
            label5 = new Label();
            Senha = new Label();
            Email = new Label();
            label1 = new Label();
            Entrar = new Button();
            Senha1 = new TextBox();
            Email1 = new TextBox();
            panel2 = new Panel();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(Senha);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Entrar);
            panel1.Controls.Add(Senha1);
            panel1.Controls.Add(Email1);
            panel1.Location = new Point(0, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 685);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(134, 459);
            label4.Name = "label4";
            label4.Size = new Size(219, 37);
            label4.TabIndex = 6;
            label4.Text = "Esqueceu a senha?";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Poppins", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(233, 607);
            label5.Name = "label5";
            label5.Size = new Size(334, 38);
            label5.TabIndex = 1;
            label5.Text = "Deseja criar a sua conta?";
            label5.Click += label5_Click;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Poppins", 9F);
            Senha.Location = new Point(134, 372);
            Senha.Name = "Senha";
            Senha.Size = new Size(93, 42);
            Senha.TabIndex = 5;
            Senha.Text = "Senha";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(134, 251);
            Email.Name = "Email";
            Email.Size = new Size(83, 42);
            Email.TabIndex = 4;
            Email.Text = "Email";
            // 
            // label1
            // 
            label1.Font = new Font("Poppins Medium", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 154);
            label1.Name = "label1";
            label1.Size = new Size(621, 139);
            label1.TabIndex = 3;
            label1.Text = "Faça o seu Login";
            // 
            // Entrar
            // 
            Entrar.BackColor = Color.FromArgb(10, 56, 113);
            Entrar.FlatStyle = FlatStyle.Flat;
            Entrar.ForeColor = Color.White;
            Entrar.Location = new Point(134, 527);
            Entrar.Name = "Entrar";
            Entrar.Size = new Size(150, 46);
            Entrar.TabIndex = 2;
            Entrar.Text = "Entrar";
            Entrar.UseVisualStyleBackColor = false;
            Entrar.Click += Entrar_Click;
            // 
            // Senha1
            // 
            Senha1.BackColor = Color.WhiteSmoke;
            Senha1.Location = new Point(134, 417);
            Senha1.Name = "Senha1";
            Senha1.Size = new Size(481, 39);
            Senha1.TabIndex = 1;
            Senha1.BorderStyleChanged += Senha1_BorderStyleChanged;
            // 
            // Email1
            // 
            Email1.BackColor = Color.WhiteSmoke;
            Email1.Location = new Point(134, 296);
            Email1.Name = "Email1";
            Email1.Size = new Size(481, 39);
            Email1.TabIndex = 0;
            Email1.BorderStyleChanged += Senha1_BorderStyleChanged;
            Email1.TextChanged += Email1_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 25, 47);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.ForeColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(765, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(556, 623);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 4.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(115, 504);
            label7.Name = "label7";
            label7.Size = new Size(326, 23);
            label7.TabIndex = 3;
            label7.Text = "Gerencie chamados de forma simples e eficiente";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(168, 127);
            label6.Name = "label6";
            label6.Size = new Size(266, 51);
            label6.TabIndex = 2;
            label6.Text = "Seja bem-vindo!";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(95, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(385, 257);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(18, 25, 47);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(pictureBox2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1321, 68);
            panel3.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(205, 17);
            label8.Name = "label8";
            label8.Size = new Size(289, 42);
            label8.TabIndex = 1;
            label8.Text = "HelpDesk Pro System";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(32, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(200, 100);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1321, 697);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label5;
        private Label Senha;
        private Label Email;
        private Label label1;
        private Button Entrar;
        private TextBox Senha1;
        private TextBox Email1;
        private Label label7;
        private Label label6;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Label label8;
    }
}
