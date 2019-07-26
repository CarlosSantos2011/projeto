using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Fornecedor : Pessoa
    {
        public string Cnpj { get; private set; }
        public string RazaoSocial { get; private set; }

        public Fornecedor(int id, string nome, string cnpj, string razaoSocial)
        {
            Id = id;
            Nome = nome;
            Cnpj = cnpj;
            RazaoSocial = razaoSocial;
        }
    }
}