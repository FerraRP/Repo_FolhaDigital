using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller;
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
using System.CodeDom;
using FolhaFigital_Projeto.model.bean;
using System.Security.Policy;
using FolhaFigital_Projeto.model.bean.TelaUsuario;
using FolhaFigital_Projeto.model.bean.TelaUsuario.Banco;

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

        //public void BloquearCampos()
        //{
        //    txtNome.Enabled = false;
        //    txtPerfil.Enabled = false;
        //    txtSenha.Enabled = false;
        //    txtStatusUser.Enabled = false;
        //    txtTelefone.Enabled = false;
        //    txtMatricula.Enabled = false;
        //    txtEmail.Enabled = false;
        //    txtDataNascimento.Enabled = false;
        //    txtCpf.Enabled = false;
        //}
        public void LimparCampos()
        {
            txtNome.Clear();
            txtPerfil.Clear();
            txtSenha.Clear();
            txtTelefone.Clear();
            txtMatricula.Clear();
            txtEmail.Clear();
            txtDataNascimento.Clear();
            txtCpf.Clear();

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            UseCadastrar CadUsuario = new UseCadastrar();
            EnderecoCadastrar CadEnderec = new EnderecoCadastrar();

            UsuarioBean useEnt = new UsuarioBean(txtNome.Text, Convert.ToInt32(txtMatricula.Text), txtEmail.Text, Convert.ToInt64(txtTelefone.Text), Convert.ToDateTime(txtDataNascimento.Text), Convert.ToInt64(txtCpf.Text), txtPerfil.Text, txtSenha.Text, ComStatusUser.SelectedItem.ToString());
            try
            {

                String mensagem = CadUsuario.InserirUsuario(useEnt);
                if (CadUsuario.logValidado)
                {
                    MessageBox.Show(mensagem, "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btInserir.Enabled = false;

                }
                else
                {
                    MessageBox.Show(CadUsuario.mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            EnderecoBean EnderEnt = new EnderecoBean(Convert.ToInt32(txtEndCep.Text), txtEndLogradouro.Text, Convert.ToInt32(txtEndNumero.Text), txtEndBairro.Text, txtEndCidade.Text, txtEndEstado.Text, txtEndComplemento.Text);
            try
            {

                String mensagem = CadEnderec.InserirEndereco(EnderEnt,useEnt);
                if (CadEnderec.EnderValidado)
                {
                    MessageBox.Show(mensagem, "Cadastro de endereço", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    btInserir.Enabled = false;

                }
                else
                {
                    MessageBox.Show(CadUsuario.mensagem);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            LimparCampos();

        }

        private void btnConsultaUse_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            ConexaoDb url = new ConexaoDb();


            try
            {
                cmd.Connection = url.conectar();
                cmd.CommandText = "select nome, matricula, perfil, status from usuario";

                SqlDataAdapter DbList = new SqlDataAdapter();
                DataTable DtList = new DataTable();

                DbList.SelectCommand = cmd;
                DbList.Fill(DtList);

                listUsuario.DataSource = DtList;

                url.desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtConsultaMatri_TextChanged(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            ConexaoDb url = new ConexaoDb();

            if (txtConsultaMatri.Text != "")
            {
                try
                {
                    cmd.Connection = url.conectar();
                    cmd.CommandText = "select * from usuario where matricula like ('%" + txtConsultaMatri.Text + "%')";

                    SqlDataAdapter DbList = new SqlDataAdapter();
                    DataTable DtList = new DataTable();

                    DbList.SelectCommand = cmd;
                    DbList.Fill(DtList);

                    listUsuario.DataSource = DtList;

                    url.desconectar();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
            else
            {
                listUsuario.DataSource = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}