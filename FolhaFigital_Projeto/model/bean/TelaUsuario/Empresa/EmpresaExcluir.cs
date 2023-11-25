using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Empresa
{
    internal class EmpresaExcluir
    {
        public bool ExcluirEmpresaValidado;
        public String mensagem = "";
        public String ExcluirEmpresa(UsuarioBean useEnt)
        {
            ValidaEmpresa ExcluirEmpreValid = new ValidaEmpresa();
            this.mensagem = ExcluirEmpreValid.ExcluirEmpresa(useEnt);

            MessageBox.Show("model de excluir banco ok");

            return mensagem;
        }
        public String ExcluirEmpresa(int FkUsuario)
        {
            ValidaEmpresa ExcluirEmpValid = new ValidaEmpresa();
            this.mensagem = ExcluirEmpValid.ExcluirEmpresa(FkUsuario);

            MessageBox.Show("model de excluir banco ok");

            return mensagem;
        }
    }
}
//