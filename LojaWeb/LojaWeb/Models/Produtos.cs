using System.Collections.Generic;
using System.Linq;
using WebLoja2.Context;

namespace WebLoja2.Models
{
    public class Produtos
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string Nome { get; set; }

        public float Valor { get; set; }

        public int TempoGarantia { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

        public int Tipo { get; set; }


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

    


