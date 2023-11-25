using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Empresa
{
    internal class EmpresaCadastrar
    {
        public bool EmpresaValidado;
        public String mensagem = "";

        public String InserirEmpresa(EmpresaBean EmpEnt,UsuarioBean useEnt)
        {
            ValidaEmpresa EmpresaValid = new ValidaEmpresa();
            this.mensagem = EmpresaValid.InserirEmpresa(EmpEnt, useEnt);

            MessageBox.Show("modelo de Empresa ok");


            return mensagem;
        }
    }
}

//