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
        public void Adicionar(Compra compra)
        {
            using (var context = new LojaContext())
            {
                context.Compra.Add(compra);

                context.SaveChanges();
            }
        }
        public void Atualizar(Compra compra)
        {
            using (var context = new LojaContext())
            {
                context.Compra.Update(compra);
                context.SaveChanges();
            }

        }
        public IList<Compra> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Compra.ToList();
            }
        }


        public void Excluir(Compra compra)
        {
            using (var context = new LojaContext())
            {
                context.Compra.Remove(compra);
                context.SaveChanges();
            }
        }
    }
}