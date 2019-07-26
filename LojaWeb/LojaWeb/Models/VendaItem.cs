using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class VendaItem           
    {
        public int Id { get; set; }
        public double ValorTotal { get;  set; }
        public int Quantidade { get;  set; }
        public Venda Venda { get; set; }
        public Produtos Produto { get;  set; }
        public float ValorUnitario { get;  set; }
        public float DescontoPorItem { get;  set; }

        public VendaItem(Venda venda, Produtos produto, int quantidade, double valorTotal, float valorUnitario)

        {
            Venda = venda;
            Produto = produto;
            Quantidade = quantidade;
            ValorTotal = valorTotal;
            ValorUnitario = ValorUnitario;

        }
    }
}