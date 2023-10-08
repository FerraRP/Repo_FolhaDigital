using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.model.dao
{
     class LoginDaoComandos
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
            }
            catch (Exception ex)
            {
                this.mensagem = "Erro de acesso";
            }

            return logValidado;
        }

        
    }
}
