using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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


        public void Excluir(Produtos produtos)
        {
            using (var context = new LojaContext())
            {
                context.Produtos.Remove(produtos);
                context.SaveChanges();
            }

        }
        public void ExcluirId(int produtoId)
        {
            using (var context = new LojaContext())
            {
                var produto = context.Produtos.FirstOrDefault(p => p.Id == produtoId);
                if (produto != null)
                {

                    context.Produtos.Remove(produto);
                    context.SaveChanges();
                }
            }
        }
        public static Produtos BuscaPorId(int id)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Produtos
                .Where(p => p.Id == id)
                .FirstOrDefault();
            }
        }
        public JsonResult BuscaProduto(string ProdutoId)
        {

            var produto = ProdutosDAO.BuscaPorId(int.Parse(ProdutoId));


            var list = new List<Object>();
            list.Add(produto);
            return Json(list, JsonRequestBehavior.AllowGet);
        }
        
    }

   


}


