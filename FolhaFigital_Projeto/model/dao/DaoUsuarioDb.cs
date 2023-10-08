using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;

namespace FolhaFigital_Projeto.model.dao
{
    using FolhaFigital_Projeto.controller;
    using FolhaFigital_Projeto.model.bean;

    internal class DaoUsuarioDb
    {
        private SqlConnection con;
        private SqlCommand cmd;      
        private readonly String url = "Data Source=DESKTOP-6MM7300\\HEXTEC;Initial Catalog = db_HexTec; Integrated Security = True";

        public Usuario Inserir (Usuario useEnt)
        {
            try
            {
                con = new SqlConnection(url);
                String sql = "insert into usuario[nome, matricula, email, telefone, data_nascimento, cpf, senha, status] values(@nome,@matricula,@email,@telefone,@data_nascimento,@cpf,@senha, @status);";
                cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@nome", useEnt.nome);
                cmd.Parameters.AddWithValue("@matricula", useEnt.matricula);
                cmd.Parameters.AddWithValue("@email", useEnt.email);
                cmd.Parameters.AddWithValue("@telefone", useEnt.telefone);
                cmd.Parameters.AddWithValue("@data_nascimento", useEnt.data_nascimento);
                cmd.Parameters.AddWithValue("@cpf", useEnt.cpf);
                cmd.Parameters.AddWithValue("@senha", useEnt.senha);
                cmd.Parameters.AddWithValue("@status", useEnt.status);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return useEnt;

        }

    }

}
