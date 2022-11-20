using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Usuario
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btn_Acesso_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";

            if(TxtUsuario.Text == User && TxtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                Form1 FrmMain = new Form1();
                FrmMain.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario/Senha incorretos");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if(TxtSenha.PasswordChar=='*')
            {
                btnOcultar.BringToFront();
                TxtSenha.PasswordChar = '\0';
            }

        }

        private void btnOcultar_Click(object sender, EventArgs e)
        {
            if (TxtSenha.PasswordChar == '\0')
            {
                btnMostrar.BringToFront();
                TxtSenha.PasswordChar = '*';
            }
        }
    }
}
