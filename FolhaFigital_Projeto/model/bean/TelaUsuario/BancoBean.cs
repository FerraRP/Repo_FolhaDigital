using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.model.bean
{
    internal class BancoBean
    {
        public int id_conta { get; set; }
        public string nome_banco { get; set; }
        public string tipo_conta { get; set; } 
        public int agencia { get; set; }
        public int conta { get; set;}
        
        public BancoBean(int idConta)
        {
            this.id_conta = idConta;
        }

        public BancoBean(string nomeBanco, string tipoConta, int Agencia, int Conta)
        {
            this.nome_banco = nomeBanco;
            this.tipo_conta = tipoConta;
            this.agencia = Agencia;
            this.conta = Conta;
        }
    }
}
//