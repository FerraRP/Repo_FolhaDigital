
using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Empresa
{
    internal class EmpresaEditar
    {
        public bool EmpresaEditValidado;
        public String mensagem = "";

        public String AlterarEmpresa(EmpresaBean EmprEnt, UsuarioBean useEnt)
        {
            ValidaEmpresa EmpresaEditarValida = new ValidaEmpresa();
            this.mensagem = EmpresaEditarValida.AlterarEmpresa(EmprEnt, useEnt);


            MessageBox.Show("modelo de endereço ok");


            return mensagem;
        }
    }
}
//