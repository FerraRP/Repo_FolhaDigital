using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Endereco
{
    internal class EnderecoExcluir
    {
        public bool ExcluirEnderecoValidado;
        public String mensagem = "";
        public String ExcluirEndereco(UsuarioBean useEnt)
        {
            ValidaEndereco ExcluirEnderValid = new ValidaEndereco();
            this.mensagem = ExcluirEnderValid.ExcluirEndereco(useEnt);

            MessageBox.Show("model de excluir endereço ok");

            return mensagem;
        }
        public String ExcluirEndereco(int FkUsuario)
        {
            ValidaEndereco ExcluirEnderValid = new ValidaEndereco();
            this.mensagem = ExcluirEnderValid.ExcluirEndereco(FkUsuario);

            MessageBox.Show("model de excluir banco ok");

            return mensagem;
        }
    }
}
//