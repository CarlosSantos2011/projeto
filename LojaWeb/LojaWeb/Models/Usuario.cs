using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.DAO;

namespace WebLoja2.Models
{
    public class Usuario
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public static implicit operator Usuario(UsuariosDAO v)
        {
            throw new NotImplementedException();
        }
    }
}