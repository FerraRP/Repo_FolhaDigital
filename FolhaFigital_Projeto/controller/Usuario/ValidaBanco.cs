using FolhaFigital_Projeto.model.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FolhaFigital_Projeto.view;
using System.Security.Policy;
using System.Windows.Forms;
using FolhaFigital_Projeto.model.bean;

namespace FolhaFigital_Projeto.controller.Usuario
{
    internal class ValidaBanco
    {
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();
        SqlDataReader LerDados;

        public String InserirBanco(BancoBean BancEnt, UsuarioBean useEnt)
        {
            cmd.CommandText = "insert into banco (Fk_ContUsuario, nome_banco,tipo_conta,agencia,conta) values (@Fk_EndUsuario,@nome_banco,@tipo_conta,@agencia,@conta)";
            cmd.Parameters.AddWithValue("@Fk_EndUsuario", useEnt.Id);
            cmd.Parameters.AddWithValue("@nome_banco", BancEnt.nome_banco);
            cmd.Parameters.AddWithValue("@tipo_conta", BancEnt.tipo_conta);
            cmd.Parameters.AddWithValue("@agencia", BancEnt.agencia);
            cmd.Parameters.AddWithValue("@conta", BancEnt.conta);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Cadastrado com sucesso!";
                MessageBox.Show("Conntroller de Banco  ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados baancario";
            }
            return mensagem;


        }

        public String AlterarBanco(BancoBean BancEnt, UsuarioBean useEnt)
        {
            cmd.CommandText = "update banco set nome_banco = @nome_banco,tipo_conta = @tipo_conta,agencia = @agencia,conta = @conta where Fk_ContUsuario = @Fk_ContUsuario";
            cmd.Parameters.AddWithValue("@nome_banco", BancEnt.nome_banco);
            cmd.Parameters.AddWithValue("@tipo_conta", BancEnt.tipo_conta);
            cmd.Parameters.AddWithValue("@agencia", BancEnt.agencia);
            cmd.Parameters.AddWithValue("@conta", BancEnt.conta);
            cmd.Parameters.AddWithValue("@Fk_ContUsuario", useEnt.id_retorno);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                MessageBox.Show("Editar banco ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados baancario";
            }
            return mensagem;

        }

        public string ExcluirBanco(UsuarioBean useEnt)
        {
            return ExcluirBanco(useEnt.id_retorno);
        }
        public string ExcluirBanco(int FkUsuario)
        {

            cmd.CommandText = $"delete from banco where Fk_ContUsuario = {FkUsuario};";
            cmd.Parameters.AddWithValue("@IdRetorno", FkUsuario);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Excluido com sucesso!";

                MessageBox.Show("Controler de excluir banco ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Usuario ao excluir";
            }
            return mensagem;
        } //
    }
}