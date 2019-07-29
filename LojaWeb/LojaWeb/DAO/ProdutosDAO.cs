using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;

namespace WebLoja2.DAO
{
    public class ProdutosDAO
    {
        public void Adicionar(Produtos produto)
        {
            using (var context = new LojaContext())
            {
                context.Produtos.Add(produto);

                context.SaveChanges();
            }
        }
        public void Atualizar(Produtos produtos)
        {
            using (var context = new LojaContext())
            {
                context.Produtos.Update(produtos);
                context.SaveChanges();
            }

        }
        public IList<Produtos> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Produtos.ToList();
            }
        }


        public void Excluir(Produtos pais)
        {
            using (var context = new LojaContext())
            {
                context.Produtos.Remove(pais);
                context.SaveChanges();
            }
        }
    }

   


}


