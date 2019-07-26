using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.DAO;

namespace WebLoja2.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }


    }
}
