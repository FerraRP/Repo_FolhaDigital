using FolhaFigital_Projeto.controller.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean.TelaUsuario.Banco
{
    internal class EnderecoCadastrar
    {
        public bool EnderValidado;
        public String mensagem = "";

        public String InserirEndereco(EnderecoBean EnderEnt, UsuarioBean useEnt)
        {
            ValidaEndereco EnderecoValid = new ValidaEndereco();
            this.mensagem = EnderecoValid.InserirEndereco(EnderEnt, useEnt);


            MessageBox.Show("modelo de endereço ok");


            return mensagem;
        }
    }
}
