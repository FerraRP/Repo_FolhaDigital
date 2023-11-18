using FolhaFigital_Projeto.model.dao;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.controller
{
     class ValidaLogUsuario
    {
        public bool logValidado;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();
        SqlDataReader LerDados;
        public bool verificarlogin(String email, String senha)
        {
            cmd.CommandText = "select * from usuario where email = @email and senha = @senha";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = url.conectar();
                LerDados = cmd.ExecuteReader();

                if (LerDados.HasRows)
                {
                    logValidado = true;
                }
                url.desconectar();
                
            }
            catch (Exception)
            {
                this.mensagem = "Erro de acesso";
            }

            return logValidado;
        }


        
        public String Inserir(String nome, String email, string senha)
        {
            cmd.CommandText = "insert into usuario_teste (nome, email, senha) values (@nome,@email,@senha)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            
            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Cadastrado com sucesso!";
                
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados";
            }
            return mensagem;
        }
    }

}
