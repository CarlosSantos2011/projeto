using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;

namespace LojaWeb.DAO
{
    public class FornecedorDAO
    {
        public void Adicionar(Fornecedor fornecedor)
        {
            using (var context = new LojaContext())
            {
                context.Fornecedor.Add(fornecedor);

                context.SaveChanges();
            }
        }

        
        public void Atualizar(Fornecedor fornecedor)
        {
            using (var context = new LojaContext())
            {
                context.Fornecedor.Update(fornecedor);
                context.SaveChanges();
            }

        }
        public IList<Fornecedor> Lista(Fornecedor fornecedor)
        {
            using (var context = new LojaContext())
            {
                return context.Fornecedor.ToList();
            }
        }


        public void Excluir(Fornecedor fornecedor)
        {
            using (var context = new LojaContext())
            {
                context.Fornecedor.Remove(fornecedor);
                context.SaveChanges();
            }
        }
    }
}