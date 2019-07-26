using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Funcionario : Pessoa
    {
        public string NumeroCarteiraDeTrabalho { get;  set; }
        private string Login { get; set; }
        private string Senha { get; set; }
        public DateTime DataDataDeNascimento { get;  set; }
        public string Sexo { get;  set; }
        public string Cpf { get;  set; }

        public Funcionario(int id, string nome, string numeroCarteiraDeTrabalho, string login, string senha, DateTime dataDeNascimento, string cpf, string sexo)
        {
            Login = login;
            Id = id;
            Nome = nome;
            NumeroCarteiraDeTrabalho = numeroCarteiraDeTrabalho;
            Senha = senha;
            DataDataDeNascimento = dataDeNascimento;
            Sexo = sexo;
            Cpf = cpf;
        }

    }
}