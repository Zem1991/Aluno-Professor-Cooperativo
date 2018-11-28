namespace APC___Forms
{
    partial class MainLogin
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.NovoUsuario = new System.Windows.Forms.Button();
            this.Login_btn = new System.Windows.Forms.Button();
            this.login_txtbox = new System.Windows.Forms.TextBox();
            this.login_lbl = new System.Windows.Forms.Label();
            this.Senha_lbl = new System.Windows.Forms.Label();
            this.senha_txtbox = new System.Windows.Forms.TextBox();
            this.TipoUsuario = new System.Windows.Forms.Label();
            this.tipoUsuario_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NovoUsuario
            // 
            this.NovoUsuario.Location = new System.Drawing.Point(136, 125);
            this.NovoUsuario.Name = "NovoUsuario";
            this.NovoUsuario.Size = new System.Drawing.Size(97, 23);
            this.NovoUsuario.TabIndex = 0;
            this.NovoUsuario.Text = "Novo Usuario";
            this.NovoUsuario.UseVisualStyleBackColor = true;
            this.NovoUsuario.Click += new System.EventHandler(this.NovoUsuario_Click);
            // 
            // Login_btn
            // 
            this.Login_btn.Location = new System.Drawing.Point(254, 125);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(75, 23);
            this.Login_btn.TabIndex = 1;
            this.Login_btn.Text = "Login!";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // login_txtbox
            // 
            this.login_txtbox.Location = new System.Drawing.Point(64, 24);
            this.login_txtbox.Name = "login_txtbox";
            this.login_txtbox.Size = new System.Drawing.Size(265, 20);
            this.login_txtbox.TabIndex = 2;
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Location = new System.Drawing.Point(12, 27);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(33, 13);
            this.login_lbl.TabIndex = 3;
            this.login_lbl.Text = "Login";
            // 
            // Senha_lbl
            // 
            this.Senha_lbl.AutoSize = true;
            this.Senha_lbl.Location = new System.Drawing.Point(12, 52);
            this.Senha_lbl.Name = "Senha_lbl";
            this.Senha_lbl.Size = new System.Drawing.Size(38, 13);
            this.Senha_lbl.TabIndex = 4;
            this.Senha_lbl.Text = "Senha";
            // 
            // senha_txtbox
            // 
            this.senha_txtbox.Location = new System.Drawing.Point(64, 52);
            this.senha_txtbox.Name = "senha_txtbox";
            this.senha_txtbox.PasswordChar = '*';
            this.senha_txtbox.Size = new System.Drawing.Size(265, 20);
            this.senha_txtbox.TabIndex = 5;
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.AutoSize = true;
            this.TipoUsuario.Location = new System.Drawing.Point(15, 91);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(141, 13);
            this.TipoUsuario.TabIndex = 6;
            this.TipoUsuario.Text = "Selecione o Tipo de Usuario";
            // 
            // tipoUsuario_box
            // 
            this.tipoUsuario_box.FormattingEnabled = true;
            this.tipoUsuario_box.Items.AddRange(new object[] {
            "Aluno",
            "Professor"});
            this.tipoUsuario_box.Location = new System.Drawing.Point(163, 91);
            this.tipoUsuario_box.Name = "tipoUsuario_box";
            this.tipoUsuario_box.Size = new System.Drawing.Size(166, 21);
            this.tipoUsuario_box.TabIndex = 7;
            // 
            // MainLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 160);
            this.Controls.Add(this.tipoUsuario_box);
            this.Controls.Add(this.TipoUsuario);
            this.Controls.Add(this.senha_txtbox);
            this.Controls.Add(this.Senha_lbl);
            this.Controls.Add(this.login_lbl);
            this.Controls.Add(this.login_txtbox);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.NovoUsuario);
            this.Name = "MainLogin";
            this.Text = "Aula Particular Cooperativa - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NovoUsuario;
        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox login_txtbox;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label Senha_lbl;
        private System.Windows.Forms.TextBox senha_txtbox;
        private System.Windows.Forms.Label TipoUsuario;
        private System.Windows.Forms.ComboBox tipoUsuario_box;
    }
}

