using FolhaFigital_Projeto.model.dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using FolhaFigital_Projeto.view;
using System.Security.Policy;
using System.Windows.Forms;
using FolhaFigital_Projeto.model.bean;

namespace FolhaFigital_Projeto.controller.Usuario
{
    internal class ValidaBanco
    {
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();
        SqlDataReader LerDados;

    }
}
