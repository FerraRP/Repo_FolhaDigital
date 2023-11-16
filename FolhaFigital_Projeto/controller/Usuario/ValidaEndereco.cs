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
    internal class ValidaEndereco
    {
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();
        SqlDataReader LerDados;

        public String InserirEndereco(EnderecoBean EnderEnt, UsuarioBean useEnt)
        {
            cmd.CommandText = "insert into endereco (Fk_EndUsuario, cep, Logradouro, numero, bairro, cidade, estado, complemento) values (@Fk_EndUsuario,@cep,@Logradouro,@numero,@bairro, @cidade,@estado,@complemento)";
            cmd.Parameters.AddWithValue("@Fk_EndUsuario", useEnt.Id);
            cmd.Parameters.AddWithValue("@cep", EnderEnt.cep);
            cmd.Parameters.AddWithValue("@Logradouro", EnderEnt.logradouro);
            cmd.Parameters.AddWithValue("@numero", EnderEnt.numero);
            cmd.Parameters.AddWithValue("@bairro", EnderEnt.bairro);
            cmd.Parameters.AddWithValue("@cidade", EnderEnt.cidade);
            cmd.Parameters.AddWithValue("@estado", EnderEnt.estado);
            cmd.Parameters.AddWithValue("@complemento", EnderEnt.complemento);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Cadastrado com sucesso!";
                MessageBox.Show("Conntroller de Emdereco  ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Endereço";
            }
            return mensagem;

        }
    }
}
