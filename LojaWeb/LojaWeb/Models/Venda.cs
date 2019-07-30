using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Venda
    {
        public int Id { get;  set; }
        public DateTime Data { get;  set; }
        public string FormaDePagamento { get;  set; }
        public double Desconto { get;  set; }
        public Clientes Cliente { get; set; }
        public Funcionario Funcionario { get;  set; }
        public double Valor { get;  set; }
        public Produtos Produto { get; set; }
        

    }
}