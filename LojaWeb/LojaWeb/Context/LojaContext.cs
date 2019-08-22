
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebLoja2.Models;


namespace WebLoja2.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Contatos> Contatos { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaItem> ItensVendidos { get; set; }
        public DbSet<Compra> Compra { get; set; }
        public DbSet<CompraItem> ItensComprados { get; set; }
        
       
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
        }
    }
}