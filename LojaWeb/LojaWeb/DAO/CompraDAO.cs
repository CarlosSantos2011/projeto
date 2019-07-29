using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;

namespace WebLoja2.DAO
{
    public class CompraDAO
    {
        public void Adicionar(Fornecedor compra)
        {
            using (var context = new LojaContext())
            {
                context.Compras.Add(compra);

                context.SaveChanges();
            }
        }
        public void Atualizar(Fornecedor compra)
        {
            using (var context = new LojaContext())
            {
                context.Compras.Update(compra);
                context.SaveChanges();
            }

        }
        public IList<Fornecedor> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Compras.ToList();
            }
        }


        public void Excluir(Fornecedor compra)
        {
            using (var context = new LojaContext())
            {
                context.Compras.Remove(compra);
                context.SaveChanges();
            }
        }
    }
}