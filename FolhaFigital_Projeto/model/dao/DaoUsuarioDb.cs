using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller;
using FolhaFigital_Projeto.model.bean;
using FolhaFigital_Projeto.view;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.dao
{
    internal class DaoUsuarioDb
    {
        public bool logValidado;
        public String mensagem = "";

       
        public bool validaLog(string email, string senha)
        {
            ValidaLogUsuario loginValid = new ValidaLogUsuario();
            logValidado = loginValid.verificarlogin(email, senha);

            if(!loginValid.mensagem.Equals(""))
            {
                this.mensagem = loginValid.mensagem;
            }
            return logValidado;
        }

        public String Inserir(String nome, String email, string senha)
        {
            ValidaLogUsuario CadastroValid = new ValidaLogUsuario();
            this.mensagem = CadastroValid.Inserir(nome, email, senha);
            return mensagem;
        }

    }

}
