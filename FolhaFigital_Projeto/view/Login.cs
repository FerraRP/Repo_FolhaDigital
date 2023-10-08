using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FolhaFigital_Projeto.model.dao;

namespace FolhaFigital_Projeto.view
    
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtLogSenha.UseSystemPasswordChar = false;
        }

        private void txtLogSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtLogSenha.UseSystemPasswordChar = true;
        }

        private void txtLogEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }
    }
}
