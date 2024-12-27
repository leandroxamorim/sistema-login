using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_login
{
    public partial class FormLogincs : Form
    {
        public static bool Cancelar = false;
        public FormLogincs()
        {
            InitializeComponent();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            string nome = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Acesso Negado! ");
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
                this.Close();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            this.Close();
        }
    }
}
