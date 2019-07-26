using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get;  set; }
        public string NomeLogradouro { get;  set; }
        public double Numero { get;  set; }
        public string Cep { get;  set; }
        public string Bairro { get;  set; }
        public string Complemento { get;  set; }
        public string Cidade { get;  set; }

        public Endereco(string logradouro, string nomeLogradouro, double numero, string cep)
        {
            Logradouro = logradouro;
            Numero = numero;
            Cep = cep;
            NomeLogradouro = nomeLogradouro;

        }
    }
}