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
using FolhaFigital_Projeto.model;


namespace FolhaFigital_Projeto.controller.Usuario
{
    internal class ValidaEmpresa
    {
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand();
        ConexaoDb url = new ConexaoDb();
        SqlDataReader LerDados;

        public String InserirEmpresa(EmpresaBean EmpEnt, UsuarioBean useEnt)
        {
            cmd.CommandText = "insert into empresa (Fk_EmpUsuario,cnpj_empresa,nome_empresa,razao_social,telefone_empresa,logradouro_empresa,numero_empresa,bairro_empresa,cidade_empresa,estado_empresa) values (@Fk_EmpUsuario,@cnpj_empresa,@nome_empresa,@razao_social,@telefone_empresa,@logradouro_empresa,@numero_empresa,@bairro_empresa,@cidade_empresa,@estado_empresa)";
            cmd.Parameters.AddWithValue("@Fk_EmpUsuario", useEnt.Id);
            cmd.Parameters.AddWithValue("@cnpj_empresa", EmpEnt.cnpj_empresa);
            cmd.Parameters.AddWithValue("@nome_empresa", EmpEnt.nome_empresa);
            cmd.Parameters.AddWithValue("@razao_social", EmpEnt.nome_empresa);
            cmd.Parameters.AddWithValue("@telefone_empresa", EmpEnt.telefone_empresa);
            cmd.Parameters.AddWithValue("@logradouro_empresa", EmpEnt.logradouro_empresa);
            cmd.Parameters.AddWithValue("@numero_empresa", EmpEnt.numero_empresa);
            cmd.Parameters.AddWithValue("@bairro_empresa", EmpEnt.bairro_empresa);
            cmd.Parameters.AddWithValue("@cidade_empresa", EmpEnt.cidade_empresa);
            cmd.Parameters.AddWithValue("@estado_empresa", EmpEnt.estado_empresa);
            //
            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Cadastrado com sucesso! Empresa";
                MessageBox.Show("Controller de Empresa ok");
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados de empresa";
            }
            return mensagem;
        }

        public String AlterarEmpresa(EmpresaBean EmprEnt, UsuarioBean useEnt)
        {
            cmd.CommandText = "update empresa set cnpj_empresa = @cnpj_empresa, nome = @nome, razao_social = @razao_social, telefone_empresa = @telefone_empresa, logradouro_empresa = @logradouro_empresa, numero_empresa = @numero_empresa, bairro_empresa = @bairro_empresa, cidade_empresa = @cidade_empresa, estado_empresa = @estado_empresa where Fk_EmpUsuario = @Fk_EmpUsuario";
            cmd.Parameters.AddWithValue("@cnpj_empresa", EmprEnt.cnpj_empresa);
            cmd.Parameters.AddWithValue("@nome", EmprEnt.nome_empresa);
            cmd.Parameters.AddWithValue("@razao_social", EmprEnt.razao_social);
            cmd.Parameters.AddWithValue("@telefone_empresa", EmprEnt.telefone_empresa);
            cmd.Parameters.AddWithValue("@logradouro_empresa", EmprEnt.logradouro_empresa);
            cmd.Parameters.AddWithValue("@numero_empresa", EmprEnt.numero_empresa);
            cmd.Parameters.AddWithValue("@bairro_empresa", EmprEnt.bairro_empresa);
            cmd.Parameters.AddWithValue("@cidade_empresa", EmprEnt.cidade_empresa);
            cmd.Parameters.AddWithValue("@estado_empresa", EmprEnt.estado_empresa);
            cmd.Parameters.AddWithValue("@Fk_EmpUsuario", useEnt.id_retorno);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                MessageBox.Show("Editar banco ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados baancario";
            }
            return mensagem;

        }

        public string ExcluirEmpresa(UsuarioBean useEnt)
        {
            return ExcluirEmpresa(useEnt.id_retorno);
        }
        public string ExcluirEmpresa(int FkUsuario)
        {

            cmd.CommandText = $"delete from empresa where Fk_ContUsuario = {FkUsuario};";
            cmd.Parameters.AddWithValue("@IdRetorno", FkUsuario);

            try
            {
                cmd.Connection = url.conectar();
                cmd.ExecuteNonQuery();
                url.desconectar();

                this.mensagem = "Excluido com sucesso!";

                MessageBox.Show("Controler de excluir empresa ok");

            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados Usuario ao excluir";
            }
            return mensagem;
        }
    }
}
