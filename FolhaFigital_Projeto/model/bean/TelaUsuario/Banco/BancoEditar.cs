using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Banco
{
    internal class BancoEditar
    {
        public bool BancoEditValidado;
        public String mensagem = "";

        public String AlterarBanco(BancoBean BancEnt, UsuarioBean useEnt)
        {
            ValidaBanco BancoEditarValid = new ValidaBanco();
            this.mensagem = BancoEditarValid.AlterarBanco(BancEnt, useEnt);


            MessageBox.Show("modelo de endereço ok");


            return mensagem;
        }
    }
}
//