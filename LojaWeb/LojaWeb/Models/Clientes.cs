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
       
        
    }
}
