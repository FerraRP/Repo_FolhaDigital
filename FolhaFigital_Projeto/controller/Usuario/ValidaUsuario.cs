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
using FolhaFigital_Projeto.model.bean;
using System.Security.Policy;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.controller.Usuario
{
    internal class ValidaUsuario
    {
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();

        public String InserirUsuario(UsuarioBean useEnt)
        {
            //
            cmd.CommandText = "insert into usuario (nome, matricula, email, telefone, data_nascimento, cpf, senha, perfil, status) values (@nome,@matricula,@email, @telefone, @data_nascimento, @cpf, @senha, @perfil, @status) set @IdRetorno = SCOPE_IDENTITY()";
            cmd.Parameters.AddWithValue("@nome", useEnt.nome);
            cmd.Parameters.AddWithValue("@matricula", useEnt.matricula);
            cmd.Parameters.AddWithValue("@email", useEnt.email);
            cmd.Parameters.AddWithValue("@telefone", useEnt.telefone);
            cmd.Parameters.AddWithValue("@data_nascimento", useEnt.data_nascimento);
            cmd.Parameters.AddWithValue("@cpf", useEnt.cpf);
            cmd.Parameters.AddWithValue("@perfil", useEnt.perfil);
            cmd.Parameters.AddWithValue("@senha", useEnt.senha);            
            cmd.Parameters.AddWithValue("@status", useEnt.status);
            cmd.Parameters.AddWithValue("@IdRetorno", 0).Direction = ParameterDirection.Output;


            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();
                useEnt.Id = Convert.ToInt32(cmd.Parameters["@IdRetorno"].Value);

                this.mensagem = "Cadastrado com sucesso!";

                

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Usuario";
            }
            return mensagem;
        }

        public String AlterarUsuario(UsuarioBean useEnt)
        {
            cmd.CommandText = "update usuario set nome=@nome,matricula=@matricula,email=@email,telefone=@telefone,data_nascimento=@data_nascimento,cpf=@cpf,perfil=@perfil,senha=@senha,status=@status where id_usuario = @IdRetorno";
            cmd.Parameters.AddWithValue("@nome", useEnt.nome);
            cmd.Parameters.AddWithValue("@matricula", useEnt.matricula);
            cmd.Parameters.AddWithValue("@email", useEnt.email);
            cmd.Parameters.AddWithValue("@telefone", useEnt.telefone);
            cmd.Parameters.AddWithValue("@data_nascimento", useEnt.data_nascimento);
            cmd.Parameters.AddWithValue("@cpf", useEnt.cpf);
            cmd.Parameters.AddWithValue("@perfil", useEnt.perfil);
            cmd.Parameters.AddWithValue("@senha", useEnt.senha);
            cmd.Parameters.AddWithValue("@status", useEnt.status);
            cmd.Parameters.AddWithValue("@IdRetorno", useEnt.id_retorno);
            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Editado com sucesso!";

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Usuario ao editar";
            }
            return mensagem;
        }

        public string ExcluirUsuario(UsuarioBean useEnt)
        {            
           return ExcluirUsuario(useEnt.id_retorno);
        }
        public string ExcluirUsuario(int FkUsuario)
        {
            
            cmd.CommandText = $"delete from usuario where id_usuario = {FkUsuario};";
            cmd.Parameters.AddWithValue("@IdRetorno", FkUsuario);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Excluido com sucesso!";

                MessageBox.Show("Controler de excluir endereço ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Usuario ao excluir";
            }
            return mensagem;
        }
    }
}
