using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Policy;
using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller;

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

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSenha_MouseDown(object sender, MouseEventArgs e)
        {
            txtLogSenha.UseSystemPasswordChar = false;
        }

        private void btnSenha_MouseUp(object sender, MouseEventArgs e)
        {
            txtLogSenha.UseSystemPasswordChar = true;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            DaoUsuarioDb usuarioDao = new DaoUsuarioDb();
            usuarioDao.validaLog(txtLogEmail.Text, txtLogSenha.Text);

            if (usuarioDao.mensagem.Equals(""))
            {
                if (txtLogEmail.Text == "" || txtLogSenha.Text == "")
                {
                    MessageBox.Show("Obrigatório o preenchiemento dos campos: Login e Senha", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (usuarioDao.logValidado)
                    {
                        Menu MenuInicial = new Menu();
                        MenuInicial.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha inválidos-", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLogEmail.Clear();
                        txtLogSenha.Clear();
                        txtLogEmail.Focus();
                    }

                }

            }
            else
            {
                MessageBox.Show(usuarioDao.mensagem);
            }
        }

    }
}
