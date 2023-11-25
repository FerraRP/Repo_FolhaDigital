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
                MessageBox.Show("Controller de Emdereco  ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Endereço";
            }
            return mensagem;

        }
        //
        public String AlterarEndereco(EnderecoBean EndrEnt, UsuarioBean useEnt)
        {
            cmd.CommandText = "update empresa set cep = @cep, Logradouro = @Logradouro, numero = @numero, bairro = @bairro, cidade = @cidade, estado = @estado, complemento = @complemento where Fk_EndUsuario = @Fk_EndUsuario";
            cmd.Parameters.AddWithValue("@cep", EndrEnt.cep);
            cmd.Parameters.AddWithValue("@Logradouro", EndrEnt.logradouro);
            cmd.Parameters.AddWithValue("@numero", EndrEnt.numero);
            cmd.Parameters.AddWithValue("@bairro", EndrEnt.bairro);
            cmd.Parameters.AddWithValue("@cidade", EndrEnt.cidade);
            cmd.Parameters.AddWithValue("@estado", EndrEnt.estado);
            cmd.Parameters.AddWithValue("@complemento", EndrEnt.complemento);
            cmd.Parameters.AddWithValue("@Fk_EndUsuario", useEnt.id_retorno);

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

        public string ExcluirEndereco(UsuarioBean useEnt)
        {
            return ExcluirEndereco(useEnt.id_retorno);
        }
        public string ExcluirEndereco(int FkUsuario)
        {

            cmd.CommandText = $"delete from endereco where Fk_EndUsuario = {FkUsuario};";
            cmd.Parameters.AddWithValue("@IdRetorno", FkUsuario);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Excluido com sucesso!";

                MessageBox.Show("Controler de excluir endeereço ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados endeereço ao excluir";
            }
            return mensagem;
        }
    }
}
