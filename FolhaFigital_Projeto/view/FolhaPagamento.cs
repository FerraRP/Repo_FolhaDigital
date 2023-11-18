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
    public partial class FolhaPagamento : Form
    {
        public FolhaPagamento()
        {
            InitializeComponent();

            // Funções do listview carregam logo apos o inicialize

            string[] row = new string[3] { "Davi", "Nome", "Status" }; // cria uma classe para os objetos
            ListViewItem listItem = new ListViewItem(row);             // adicionam os objetos numa linha
            listFolha.Items.Add(listItem);                             // carrega os itens na lista

            string[] row2 = new string[3] { "a", "b", "c" };
            ListViewItem listItem2 = new ListViewItem(row2);
            listFolha.Items.Add(listItem2);

            string[] row3 = new string[3] { "D", "e", "f" };
            ListViewItem listItem3 = new ListViewItem(row3);
            listFolha.Items.Add(listItem3);

            string[] row4 = new string[3] { "g", "h", "i" };
            ListViewItem listItem4 = new ListViewItem(row4);
            listFolha.Items.Add(listItem4);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FolhaPagamento_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void listFolha_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Menu TelaMenu = new Menu();
            TelaMenu.Show();

            this.Hide();
        }

        private void btnFolhaPagamento_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario TelaUsuario = new FormUsuario();
            TelaUsuario.Show();

            this.Hide();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void bntPerfil(object sender, EventArgs e)
        {
            MeuPerfil TelaPerfil = new MeuPerfil();
            TelaPerfil.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Você tem certeza?", "Confirmar",MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
