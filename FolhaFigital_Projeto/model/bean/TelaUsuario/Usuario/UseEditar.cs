using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
using FolhaFigital_Projeto.model.dao;
using FolhaFigital_Projeto.controller;
using FolhaFigital_Projeto.model.bean;
using FolhaFigital_Projeto.view;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;
using System;
using FolhaFigital_Projeto.controller.Usuario;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario
{
    internal class UseEditar
    {
        public bool EditarUserValidado;
        public String mensagem = "";

        public String AlterarUsuario(UsuarioBean useEnt)
        {
            ValidaUsuario EditarUserValid = new ValidaUsuario();
            this.mensagem = EditarUserValid.AlterarUsuario(useEnt);
            return mensagem;
        }
    }
}
//