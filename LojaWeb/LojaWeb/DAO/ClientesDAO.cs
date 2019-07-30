using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;

namespace WebLoja2.DAO
{
    public class ClientesDAO
    {
        public void Adicionar(Clientes clientes)
        {
            using (var context = new LojaContext())
            {
                context.Clientes.Add(clientes);

                context.SaveChanges();
            }
        }
        public void Atualizar(Clientes clientes)
        {
            using (var context = new LojaContext())
            {
                context.Clientes.Update(clientes);
                context.SaveChanges();
            }

        }
        public IList<Clientes> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Clientes.ToList();
            }
        }


        public void Excluir(Clientes clientes)
        {
            using (var context = new LojaContext())
            {
                context.Clientes.Remove(clientes);
                context.SaveChanges();
            }
        }
    }

}