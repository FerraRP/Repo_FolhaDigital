using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolhaFigital_Projeto.model.bean
{
    internal class Usuario
    {
        public int id_usuario { get; set; }
        public string nome { get; set; }
        public string matricula { get; set; }
        public string email { get; set; }
        public int telefone { get; set; }
        public DateTime data_nascimento { get; set; }
        public int cpf {  get; set; }
        public string senha {  get; set; } 

        public Usuario() 
        {
        }

        public Usuario(string Email)
        {
            this.email = Email;
        }

        public Usuario(string Nome, string Matricula, string Email, int Telefone, DateTime Data_nascimento, int Cpf, string Senha)
        {
            this.nome = Nome;
            this.matricula = Matricula;
            this.email = Email;
            this.telefone = Telefone;
            this.data_nascimento = Data_nascimento;
            this.cpf = Cpf;
            this.senha = Senha;
        }

        public Usuario(int Id_usuario, string Nome, string Matricula, string Email, int Telefone, DateTime Data_nascimento, int Cpf, string Senha)
        {
            this.id_usuario = Id_usuario;
            this.nome = Nome;
            this.matricula = Matricula;
            this.email = Email;
            this.telefone = Telefone;
            this.data_nascimento = Data_nascimento;
            this.cpf = Cpf;
            this.senha = Senha;
        }

        public override string ToString()
        {
            return "[ ID Usuário: " +id_usuario+ "Nome: " +nome+ "Matricula: " +matricula+ "E-mail: " +email+ "Telefone: " +telefone+ "Data de Nascimento: " +data_nascimento+ "CPF: " +cpf+ "Senha: " +senha+ "]";
        }
    }
}
