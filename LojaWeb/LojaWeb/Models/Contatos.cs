using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
   
        public class Contatos
        {   public int Id { get; private set; }
            public string Residencial { get; set; }
            public string Celular { get; set; }
            public string Comercial { get; set; }
            public string Email { get; set; }

        }
    
}