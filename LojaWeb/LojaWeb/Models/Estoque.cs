using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebLoja2.Models
{
    public class Estoque
    {


        public Produtos Produtos { get;  set; }

        public Compra Compra { get;  set; }
        public Venda Venda { get;  set; }
        public int Saida { get;  set; }
        public int Entrada { get;  set; }
        public bool Garantia { get;  set; }
        public string TipoMovimentacao { get;  set; }

        

        public Estoque(Produtos produto, Compra compra, Venda venda, int saida, int entrada, bool garantia, string tipoMovimentacao)


        {
            produto = Produtos;
            compra = Compra;
            saida = Saida;
            entrada = Entrada;
            venda = Venda;
            garantia = Garantia;
            tipoMovimentacao = TipoMovimentacao;
        }


        //public static bool LancarEstoque(Venda venda)
        //{
        //    foreach (var item in Venda.itens)
        //    {
        //        Estoque x = new Estoque();
        //        x.Produtos = item.Produto.Handle;
        //        x.Saida = item.Produto.Quantidade;
        //        x.Venda = item.Venda;
        //        x.save()
        //    }

        //}

        //public static bool EstornarEstoque()
        //{

        //}

    }
}
