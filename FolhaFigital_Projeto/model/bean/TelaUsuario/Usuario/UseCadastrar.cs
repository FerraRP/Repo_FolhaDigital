using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller.Usuario;
using FolhaFigital_Projeto.model.bean;
using FolhaFigital_Projeto.view;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;
using System;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario
{
    internal class UseCadastrar
    {
        public bool logValidado;
        public String mensagem = "";

        public String InserirUsuario(UsuarioBean useEnt)
        {
            ValidaUsuario CadastroValid = new ValidaUsuario();
            this.mensagem = CadastroValid.InserirUsuario(useEnt);
            return mensagem;
        }
    }
}
