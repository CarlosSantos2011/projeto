using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;

namespace WebLoja2.DAO
{
    public class FuncionariosDAO
    {
        public void Adicionar(Funcionario funcionario)
        {
            using (var context = new LojaContext())
            {
                context.Funcionario.Add(funcionario);

                context.SaveChanges();
            }
        }
        public void Atualizar(Funcionario funcionario)
        {
            using (var context = new LojaContext())
            {
                context.Funcionario.Update(funcionario);
                context.SaveChanges();
            }

        }
        public IList<Funcionario> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Funcionario.ToList();
            }
        }


        public void Excluir(Funcionario funcionario)
        {
            using (var context = new LojaContext())
            {
                context.Funcionario.Remove(funcionario);
                context.SaveChanges();
            }
        }
    }
}