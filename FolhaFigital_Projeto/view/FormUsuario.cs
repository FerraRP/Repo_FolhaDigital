﻿using FolhaFigital_Projeto.model.dao;
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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Menu MenuInicial = new Menu();
            MenuInicial.Show();

            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            DaoUsuarioDb CadUsuario = new DaoUsuarioDb();

            String mensagem = CadUsuario.Inserir(txtNome.Text, txtEmail.Text, txtSenha.Text);
            if (CadUsuario.logValidado)
            {
                MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show(CadUsuario.mensagem);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
