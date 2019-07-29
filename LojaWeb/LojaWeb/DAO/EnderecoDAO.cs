using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;

namespace LojaWeb.DAO
{
    public class EnderecoDAO
    {
        public void Adicionar(Endereco endereco)
        {
            using (var context = new LojaContext())
            {
                context.Enderecos.Add(endereco);

                context.SaveChanges();
            }
        }
        public void Atualizar(Endereco endereco)
        {
            using (var context = new LojaContext())
            {
                context.Enderecos.Update(endereco);
                context.SaveChanges();
            }

        }
        public IList<Endereco> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Enderecos.ToList();
            }
        }


        public void Excluir(Endereco endereco)
        {
            using (var context = new LojaContext())
            {
                context.Enderecos.Remove(endereco);
                context.SaveChanges();
            }
        }
    }
}