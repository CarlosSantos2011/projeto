using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Funcionario : Pessoa
    {
        public string NumeroCarteiraDeTrabalho { get;  set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public DateTime DataDeNascimento { get;  set; }
        public string Sexo { get;  set; }
        public string Cpf { get;  set; }
    }
}