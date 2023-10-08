using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace FolhaFigital_Projeto.model.dao
{
    using FolhaFigital_Projeto.model.dao;
    using FolhaFigital_Projeto.controller;
    using FolhaFigital_Projeto.model.bean;
    using FolhaFigital_Projeto.view;
    using System.Windows.Forms;

    internal class DaoUsuarioDb
    {
        public bool logValidado;
        public String mensagem = "";

       
        public bool validaLog(string email, string senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            logValidado = loginDao.verificarlogin(email, senha);

            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return logValidado;
        }



        public Usuario Inserir (Usuario useEnt)
        {
            ConexaoDb conexaoBanco = new ConexaoDb();
            
            try
            {
                //url = new SqlConnection();
                String sql = "insert into usuario[nome, matricula, email, telefone, data_nascimento, cpf, senha, status] values(@nome,@matricula,@email,@telefone,@data_nascimento,@cpf,@senha, @status);";
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@nome", useEnt.nome);
                cmd.Parameters.AddWithValue("@matricula", useEnt.matricula);
                cmd.Parameters.AddWithValue("@email", useEnt.email);
                cmd.Parameters.AddWithValue("@telefone", useEnt.telefone);
                cmd.Parameters.AddWithValue("@data_nascimento", useEnt.data_nascimento);
                cmd.Parameters.AddWithValue("@cpf", useEnt.cpf);
                cmd.Parameters.AddWithValue("@senha", useEnt.senha);
                cmd.Parameters.AddWithValue("@status", useEnt.status);

                //url.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                throw ex;
            }
            finally
            {
                //.Close();
            }
            return useEnt;

        }

    }

}
