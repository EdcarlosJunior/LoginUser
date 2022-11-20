
namespace Login_Usuario
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.btn_Acesso = new System.Windows.Forms.Button();
            this.Lbl_user = new System.Windows.Forms.Label();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.Lbl_pass = new System.Windows.Forms.Label();
            this.btnOcultar = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Acesso
            // 
            this.btn_Acesso.Location = new System.Drawing.Point(275, 192);
            this.btn_Acesso.Name = "btn_Acesso";
            this.btn_Acesso.Size = new System.Drawing.Size(75, 23);
            this.btn_Acesso.TabIndex = 0;
            this.btn_Acesso.Text = "Acesso";
            this.btn_Acesso.UseVisualStyleBackColor = true;
            this.btn_Acesso.Click += new System.EventHandler(this.btn_Acesso_Click);
            // 
            // Lbl_user
            // 
            this.Lbl_user.AutoSize = true;
            this.Lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_user.ForeColor = System.Drawing.Color.White;
            this.Lbl_user.Location = new System.Drawing.Point(120, 138);
            this.Lbl_user.Name = "Lbl_user";
            this.Lbl_user.Size = new System.Drawing.Size(87, 24);
            this.Lbl_user.TabIndex = 1;
            this.Lbl_user.Text = "Usuário:";
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.Location = new System.Drawing.Point(213, 139);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(210, 20);
            this.TxtUsuario.TabIndex = 2;
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(213, 168);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(210, 20);
            this.TxtSenha.TabIndex = 4;
            // 
            // Lbl_pass
            // 
            this.Lbl_pass.AutoSize = true;
            this.Lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pass.ForeColor = System.Drawing.Color.White;
            this.Lbl_pass.Location = new System.Drawing.Point(131, 168);
            this.Lbl_pass.Name = "Lbl_pass";
            this.Lbl_pass.Size = new System.Drawing.Size(76, 24);
            this.Lbl_pass.TabIndex = 3;
            this.Lbl_pass.Text = "Senha:";
            // 
            // btnOcultar
            // 
            this.btnOcultar.BackColor = System.Drawing.Color.White;
            this.btnOcultar.Image = ((System.Drawing.Image)(resources.GetObject("btnOcultar.Image")));
            this.btnOcultar.Location = new System.Drawing.Point(392, 168);
            this.btnOcultar.Name = "btnOcultar";
            this.btnOcultar.Size = new System.Drawing.Size(31, 19);
            this.btnOcultar.TabIndex = 5;
            this.btnOcultar.UseVisualStyleBackColor = false;
            this.btnOcultar.Click += new System.EventHandler(this.btnOcultar_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.White;
            this.btnMostrar.Image = ((System.Drawing.Image)(resources.GetObject("btnMostrar.Image")));
            this.btnMostrar.Location = new System.Drawing.Point(392, 168);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(31, 19);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(664, 345);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnOcultar);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.Lbl_pass);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.Lbl_user);
            this.Controls.Add(this.btn_Acesso);
            this.Name = "FrmLogin";
            this.Text = "FrmLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Acesso;
        private System.Windows.Forms.Label Lbl_user;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label Lbl_pass;
        private System.Windows.Forms.Button btnOcultar;
        private System.Windows.Forms.Button btnMostrar;
    }
}