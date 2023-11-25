using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Banco
{
    internal class BancoEsxcluir
    {
        public bool ExcluirBancoValidado;
        public String mensagem = "";
        public String ExcluirBanco(UsuarioBean useEnt)
        {
            ValidaBanco ExcluirBancValid = new ValidaBanco();
            this.mensagem = ExcluirBancValid.ExcluirBanco(useEnt);

            MessageBox.Show("model de excluir endereço ok");

            return mensagem;
        }
        public String ExcluirBanco(int FkUsuario)
        {
            ValidaBanco ExcluirBancValid = new ValidaBanco();
            this.mensagem = ExcluirBancValid.ExcluirBanco(FkUsuario);

            MessageBox.Show("model de excluir banco ok");

            return mensagem;
        }
    }
}
//