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
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1347, 68);
            panel1.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 10.125F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(240, 17);
            label8.Name = "label8";
            label8.Size = new Size(302, 48);
            label8.TabIndex = 1;
            label8.Text = "HelpDesk Pro System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(18, 25, 47);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(797, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 697);
            panel2.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins", 7.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(36, 506);
            label7.Name = "label7";
            label7.Size = new Size(489, 34);
            label7.TabIndex = 2;
            label7.Text = "gerencie chamadas de forma simples e eficiente";
            // 
            // label6
            // 
            label6.Font = new Font("Poppins", 13.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(110, 152);
            label6.Name = "label6";
            label6.Size = new Size(386, 88);
            label6.TabIndex = 1;
            label6.Text = "Seja bem-vindo!";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(79, 229);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(385, 257);
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
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(798, 700);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins Medium", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(183, 87);
            label1.Name = "label1";
            label1.Size = new Size(355, 65);
            label1.TabIndex = 5;
            label1.Text = "Faça o seu Login";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DeepSkyBlue;
            label5.Location = new Point(230, 567);
            label5.Name = "label5";
            label5.Size = new Size(322, 42);
            label5.TabIndex = 4;
            label5.Text = "Deseja criar a sua conta?";
            label5.Click += label5_Click;
            // 
            // Senha
            // 
            Senha.AutoSize = true;
            Senha.Font = new Font("Poppins", 10.125F);
            Senha.ForeColor = Color.Black;
            Senha.Location = new Point(183, 272);
            Senha.Name = "Senha";
            Senha.Size = new Size(105, 48);
            Senha.TabIndex = 2;
            Senha.Text = "Senha";
            Senha.Click += Senha_Click;
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Poppins", 10.125F);
            Email.ForeColor = Color.Black;
            Email.Location = new Point(183, 164);
            Email.Name = "Email";
            Email.Size = new Size(94, 48);
            Email.TabIndex = 1;
            Email.Text = "Email";
            Email.Click += Email_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(18, 25, 47);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(183, 443);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(183, 323);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(479, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 215);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 39);
            textBox1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 7.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(183, 365);
            label4.Name = "label4";
            label4.Size = new Size(219, 37);
            label4.TabIndex = 0;
            label4.Text = "Esqueceu a senha?";
            label4.Click += label4_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1347, 768);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
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
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label1;
    }
}
