using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FolhaFigital_Projeto.model.bean
{
    internal class EmpresaBean
    {
        public int id_empresa { get; set; }
        public string cnpj_empresa { get; set; }
        public string nome_empresa { get; set; }
        public string razao_social { get; set; }
        public string telefone_empresa { get; set; }
        public string logradouro_empresa { get; set; }
        public int numero_empresa { get; set; }
        public string bairro_empresa { get; set; }
        public string cidade_empresa { get; set; }
        public string estado_empresa { get; set; }


        public EmpresaBean(int idEmpresa)
        {
            this.id_empresa= idEmpresa;
        }

        public EmpresaBean(string cnpjEmpresa,string nomeEmpresa,string razaoSocial,string telefoneEmpresa,string logradouroEmpresa, int numeroEmpresa, string bairroEmpresa, string cidadeEmpresa, string estadoEmpresa)
        { 
            this.cnpj_empresa = cnpjEmpresa;
            this.nome_empresa = nomeEmpresa;
            this.razao_social = razaoSocial;
            this.telefone_empresa = telefoneEmpresa;
            this.logradouro_empresa = logradouroEmpresa;
            this.numero_empresa = numeroEmpresa;
            this.bairro_empresa = bairroEmpresa;
            this.cidade_empresa = cidadeEmpresa;
            this.estado_empresa = estadoEmpresa;

            MessageBox.Show("modelo de EmpresaBean ok");
        }
    }
}

// //