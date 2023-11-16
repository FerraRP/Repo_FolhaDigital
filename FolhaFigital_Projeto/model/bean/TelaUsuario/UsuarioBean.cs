using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.model.bean
{
    internal class UsuarioBean
    {
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

        public UsuarioBean() 
        {
        }

        public UsuarioBean(int id)
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

        public override string ToString()
        {
            return "[ ID Usuário: " +Id+ "Nome: " +nome+ "Matricula: " +matricula+ "E-mail: " +email+ "Telefone: " +telefone+ "CPF: " +cpf+ "Senha: " +senha+ "Status: " +status+ "]";
        }
    }
}
