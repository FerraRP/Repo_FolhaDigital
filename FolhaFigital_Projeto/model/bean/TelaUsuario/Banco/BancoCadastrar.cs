using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Banco
{
    internal class BancoCadastrar
    {
        public bool BancoValidado;
        public String mensagem = "";

        public String InserirBanco(BancoBean BancEnt, UsuarioBean useEnt)
        {
            ValidaBanco BancoValid = new ValidaBanco();
            this.mensagem = BancoValid.InserirBanco(BancEnt, useEnt);


            MessageBox.Show("modelo de endereço ok");


            return mensagem;
        }
    }
}
//