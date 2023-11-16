using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FolhaFigital_Projeto.view;
using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller;


namespace FolhaFigital_Projeto.controller
{
     class CadEndereco
    {
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();
        SqlDataReader LerDados;



        //

        public String InserirEndereco(int Fk_EndUsuario, int cep, string Logradouro, int numero, string bairro, string cidade, string estado, string complemento)
        {

            cmd.CommandText = "insert into endereco (Fk_EndUsuario, cep, Logradouro, numero, bairro, cidade, estado, complemento) values (('" + idUser + "),@cep,@Logradouro,@numero,@bairro, @cidade,@estado,@complemento)";
            cmd.Parameters.AddWithValue("@cep", cep);
            cmd.Parameters.AddWithValue("@Logradouro", Logradouro);
            cmd.Parameters.AddWithValue("@numero", numero);
            cmd.Parameters.AddWithValue("@bairro", bairro);
            cmd.Parameters.AddWithValue("@cidade", cidade);
            cmd.Parameters.AddWithValue("@estado", estado);
            cmd.Parameters.AddWithValue("@complemento", complemento);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Cadastrado endereço com sucesso!";

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Usuario";
            }
            return mensagem;





            //try
            //{
            //    cmd.Connection = url.conectar();
            //    cmd.ExecuteNonQuery();
            //    url.desconectar();

            //    this.mensagem = "Cadastrado com sucesso!";

            //}
            //catch (SqlException)
            //{
            //    this.mensagem = "Erro com o banco de dados endereço";
            //}
            //return mensagem;


        }
    }
}
