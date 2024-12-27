using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormLogincs f = new FormLogincs();

            while (CadastroUsuarios.UsuarioLogado == null)
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogincs.Cancelar)
                {
                    Application.Exit();
                    return;
                }
            }

            label_BoasVindas.Text = "Bem vindo(a) \n" + CadastroUsuarios.UsuarioLogado.Nome;
            Visible = true;
        }
    }
}
