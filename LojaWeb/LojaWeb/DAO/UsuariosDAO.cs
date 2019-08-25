using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Context;
using WebLoja2.Models;


namespace WebLoja2.DAO
{

    public class UsuariosDAO
    {
        public void Adicionar(Usuario usuario)
        {
            using (var context = new LojaContext())
            {
                context.Usuarios.Add(usuario);

                context.SaveChanges();
            }
        }
        public void Atualizar(Usuario usuario)
        {
            using (var context = new LojaContext())
            {
                context.Usuarios.Update(usuario);
                context.SaveChanges();
            }

        }
        public IList<Usuario> Lista()
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Usuarios.ToList();
            }
        }


        public void Excluir(Usuario usuario)
        {
            using (var context = new LojaContext())
            {
                context.Usuarios.Remove(usuario);
                context.SaveChanges();
            }
        }
        public Usuario Busca(string login, string senha)
        {
            using (var contexto = new LojaContext())
            {
                return contexto.Usuarios.FirstOrDefault(u => u.Nome == login && u.Senha == senha);
            }
        }
        private static void GravarEntity()
        {
            Usuario usuario = new UsuariosDAO();
            usuario.Nome = "Carlos";
            usuario.Senha = "Carlos";

            using (var contexto = new LojaContext())
            {
                contexto.Usuarios.Add(usuario);
                contexto.SaveChanges();
            }

        }

    }
    
}