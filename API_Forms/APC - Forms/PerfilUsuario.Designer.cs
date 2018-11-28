namespace APC___Forms
{
    partial class PerfilUsuario
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
            this.nome_lbl = new System.Windows.Forms.Label();
            this.cpf_label = new System.Windows.Forms.Label();
            this.idade_lbl = new System.Windows.Forms.Label();
            this.loginAluno_btn = new System.Windows.Forms.Button();
            this.professorLogin_btn = new System.Windows.Forms.Button();
            this.atualizarPerfil_btn = new System.Windows.Forms.Button();
            this.nome_txtbox = new System.Windows.Forms.TextBox();
            this.cpf_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.idade_txtbox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nome_lbl
            // 
            this.nome_lbl.AutoSize = true;
            this.nome_lbl.Location = new System.Drawing.Point(13, 13);
            this.nome_lbl.Name = "nome_lbl";
            this.nome_lbl.Size = new System.Drawing.Size(35, 13);
            this.nome_lbl.TabIndex = 0;
            this.nome_lbl.Text = "Nome";
            // 
            // cpf_label
            // 
            this.cpf_label.AutoSize = true;
            this.cpf_label.Location = new System.Drawing.Point(13, 41);
            this.cpf_label.Name = "cpf_label";
            this.cpf_label.Size = new System.Drawing.Size(27, 13);
            this.cpf_label.TabIndex = 1;
            this.cpf_label.Text = "CPF";
            // 
            // idade_lbl
            // 
            this.idade_lbl.AutoSize = true;
            this.idade_lbl.Location = new System.Drawing.Point(13, 69);
            this.idade_lbl.Name = "idade_lbl";
            this.idade_lbl.Size = new System.Drawing.Size(34, 13);
            this.idade_lbl.TabIndex = 2;
            this.idade_lbl.Text = "Idade";
            // 
            // loginAluno_btn
            // 
            this.loginAluno_btn.Location = new System.Drawing.Point(13, 143);
            this.loginAluno_btn.Name = "loginAluno_btn";
            this.loginAluno_btn.Size = new System.Drawing.Size(110, 23);
            this.loginAluno_btn.TabIndex = 3;
            this.loginAluno_btn.Text = "Entrar como Aluno";
            this.loginAluno_btn.UseVisualStyleBackColor = true;
            this.loginAluno_btn.Click += new System.EventHandler(this.loginAluno_btn_Click);
            // 
            // professorLogin_btn
            // 
            this.professorLogin_btn.Location = new System.Drawing.Point(144, 143);
            this.professorLogin_btn.Name = "professorLogin_btn";
            this.professorLogin_btn.Size = new System.Drawing.Size(128, 23);
            this.professorLogin_btn.TabIndex = 4;
            this.professorLogin_btn.Text = "Entrar como Professor";
            this.professorLogin_btn.UseVisualStyleBackColor = true;
            this.professorLogin_btn.Click += new System.EventHandler(this.professorLogin_btn_Click);
            // 
            // atualizarPerfil_btn
            // 
            this.atualizarPerfil_btn.Location = new System.Drawing.Point(13, 105);
            this.atualizarPerfil_btn.Name = "atualizarPerfil_btn";
            this.atualizarPerfil_btn.Size = new System.Drawing.Size(259, 23);
            this.atualizarPerfil_btn.TabIndex = 5;
            this.atualizarPerfil_btn.Text = "Atualizar Perfil";
            this.atualizarPerfil_btn.UseVisualStyleBackColor = true;
            this.atualizarPerfil_btn.Click += new System.EventHandler(this.atualizarPerfil_btn_Click);
            // 
            // nome_txtbox
            // 
            this.nome_txtbox.Location = new System.Drawing.Point(55, 13);
            this.nome_txtbox.Name = "nome_txtbox";
            this.nome_txtbox.Size = new System.Drawing.Size(217, 20);
            this.nome_txtbox.TabIndex = 6;
            // 
            // cpf_txtbox
            // 
            this.cpf_txtbox.Location = new System.Drawing.Point(55, 41);
            this.cpf_txtbox.Mask = "999.999.999-99";
            this.cpf_txtbox.Name = "cpf_txtbox";
            this.cpf_txtbox.Size = new System.Drawing.Size(217, 20);
            this.cpf_txtbox.TabIndex = 9;
            // 
            // idade_txtbox
            // 
            this.idade_txtbox.Location = new System.Drawing.Point(55, 69);
            this.idade_txtbox.Mask = "99";
            this.idade_txtbox.Name = "idade_txtbox";
            this.idade_txtbox.Size = new System.Drawing.Size(217, 20);
            this.idade_txtbox.TabIndex = 10;
            // 
            // PerfilUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.idade_txtbox);
            this.Controls.Add(this.cpf_txtbox);
            this.Controls.Add(this.nome_txtbox);
            this.Controls.Add(this.atualizarPerfil_btn);
            this.Controls.Add(this.professorLogin_btn);
            this.Controls.Add(this.loginAluno_btn);
            this.Controls.Add(this.idade_lbl);
            this.Controls.Add(this.cpf_label);
            this.Controls.Add(this.nome_lbl);
            this.Name = "PerfilUsuario";
            this.Text = "Perfil do Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nome_lbl;
        private System.Windows.Forms.Label cpf_label;
        private System.Windows.Forms.Label idade_lbl;
        private System.Windows.Forms.Button loginAluno_btn;
        private System.Windows.Forms.Button professorLogin_btn;
        private System.Windows.Forms.Button atualizarPerfil_btn;
        private System.Windows.Forms.TextBox nome_txtbox;
        private System.Windows.Forms.MaskedTextBox cpf_txtbox;
        private System.Windows.Forms.MaskedTextBox idade_txtbox;
    }
}