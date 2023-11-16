using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller.Login;
using FolhaFigital_Projeto.model.bean;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;

namespace FolhaFigital_Projeto.model.bean.Login
{
    internal class ModelLogin
    {
        public bool logValidado;
        public String mensagem = "";
        
         public bool validaLog(string email, string senha)
        {
            ValidaLogin loginValid = new ValidaLogin();
            logValidado = loginValid.verificarlogin(email, senha);

            if(!loginValid.mensagem.Equals(""))
            {
                this.mensagem = loginValid.mensagem;
            }
            return logValidado;
        }
    }
}
