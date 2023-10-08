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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public static implicit operator System.Windows.Forms.Menu(Menu v)
        {
            throw new NotImplementedException();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario TelaUsuario = new FormUsuario();
            TelaUsuario.Show();

            this.Hide();
        }

        
    }
}
