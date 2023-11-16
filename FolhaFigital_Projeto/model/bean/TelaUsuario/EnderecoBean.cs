using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.model.bean
{
    internal class EnderecoBean
    {
        public int id_endereco { get; set; }
        public int cep { get; set; }
        public string logradouro { get; set; }
        public int numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string complemento { get; set; }

        public EnderecoBean()
        {

        }

        public EnderecoBean(int idEndereco)
        {
            this.id_endereco = idEndereco;
        }

        public EnderecoBean(int Cep, string Logradouro, int Numero, string Bairro, string Cidade, string Estado, string Complemento)
        {
            this.cep = Cep;
            this.logradouro = Logradouro;
            this.numero = Numero;
            this.bairro = Bairro;
            this.cidade = Cidade;
            this.estado = Estado;
            this.complemento = Complemento;

        }
    }
}
