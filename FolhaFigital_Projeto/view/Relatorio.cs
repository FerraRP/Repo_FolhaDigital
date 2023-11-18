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
    public partial class Relatorio : Form
    {
        public Relatorio()
        {
            InitializeComponent();
        }

        private void Relatorio_Load(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
            FolhaPagamento TelaPagamento = new FolhaPagamento();
            TelaPagamento.Show();

            this.Hide();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario TelaUsuario = new FormUsuario();
            TelaUsuario.Show();

            this.Hide();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu TelaMenu = new Menu();
            TelaMenu.Show();

            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            MeuPerfil TelaPerfil = new MeuPerfil();
            TelaPerfil.Show();

            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
