using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Clientes : Pessoa
    {
        
        public string Cpf { get;  set; }            
        public Clientes(string nome, int id, string cpf)
        {
            Nome = nome;
            Id = id;
            Cpf = cpf;
        }
        
    }
}
