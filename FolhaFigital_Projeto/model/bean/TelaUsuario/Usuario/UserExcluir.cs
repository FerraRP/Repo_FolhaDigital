using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Usuario
{
    internal class UserExcluir
    {
        public bool ExcluirUserValidado;
        public String mensagem = "";
        public String ExcluirUsuario(UsuarioBean useEnt)
        {
            ValidaUsuario ExcluirUserValid = new ValidaUsuario();
            this.mensagem = ExcluirUserValid.ExcluirUsuario(useEnt);

            MessageBox.Show("model de excluir endereço ok");

            return mensagem;
        }
        public String ExcluirUsuario(int FkUsuario)
        {
            ValidaUsuario ExcluirUserValid = new ValidaUsuario();
            this.mensagem = ExcluirUserValid.ExcluirUsuario(FkUsuario);

            MessageBox.Show("model de excluir endereço ok");

            return mensagem;
        }

    }

}
//