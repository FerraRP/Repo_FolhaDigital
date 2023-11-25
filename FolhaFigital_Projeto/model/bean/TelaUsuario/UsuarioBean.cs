using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.model.bean
{
    internal class UsuarioBean
    {
        private int v;

        public int Id { get; set; }
        public string nome { get; set; }
        public int matricula { get; set; }
        public string email { get; set; }
        public long telefone { get; set; }
        public DateTime data_nascimento { get; set; }
        public long cpf {  get; set; }
        public string perfil { get; set; }
        public string senha {  get; set; } 
        public string status {  get; set; }
        public int id_retorno { get; set; }

        public UsuarioBean(int id, int idRetorno)
        {
            this.Id = id;
        }

        public UsuarioBean(string Nome, int Matricula, string Email, long Telefone, DateTime Data_nascimento, long Cpf, string Senha, string Status, string Perfil)
        {
            this.nome = Nome;
            this.matricula = Matricula;
            this.email = Email;
            this.telefone = Telefone;
            this.data_nascimento = Data_nascimento;
            this.cpf = Cpf;
            this.senha = Senha;
            this.status = Status;            
            this.perfil = Perfil;

        }

        public UsuarioBean(string Nome, int Matricula, string Email, long Telefone, DateTime Data_nascimento, long Cpf, string Senha, string Status, string Perfil, int idRetorno)
        {
            this.nome = Nome;
            this.matricula = Matricula;
            this.email = Email;
            this.telefone = Telefone;
            this.data_nascimento = Data_nascimento;
            this.cpf = Cpf;
            this.senha = Senha;
            this.status = Status;
            this.perfil = Perfil;
            this.id_retorno = idRetorno;
        }

        public UsuarioBean(int v)
        {
            this.v = v;
        }
    }
}
//