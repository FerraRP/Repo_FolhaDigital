using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.view
{
    public partial class MeuPerfil : Form
    {
        public MeuPerfil()
        {
            InitializeComponent();
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            FolhaPagamento TelaPagamento = new FolhaPagamento();
            TelaPagamento.Show();

            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu TelaMenu = new Menu();
            TelaMenu.Show();

            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario TelaUsuario = new FormUsuario();
            TelaUsuario.Show();

            this.Hide();
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
