﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WebLoja2.Context;

namespace LojaWeb.Migrations
{
    [DbContext(typeof(LojaContext))]
    partial class LojaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebLoja2.Models.Clientes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<string>("Nome");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("WebLoja2.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Data");

                    b.Property<int?>("FornecedorId");

                    b.Property<int?>("FuncionarioId");

                    b.Property<string>("Observacoes");

                    b.Property<int?>("ProdutoId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Compra");
                });

            modelBuilder.Entity("WebLoja2.Models.CompraItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CompraId");

                    b.Property<double>("DescontoPorItem");

                    b.Property<int?>("ProdutosId");

                    b.Property<int>("Quantidade");

                    b.Property<double>("ValorTotal");

                    b.Property<float>("ValorUnitario");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("ItensComprados");
                });

            modelBuilder.Entity("WebLoja2.Models.Contatos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Celular");

                    b.Property<string>("Comercial");

                    b.Property<string>("Email");

                    b.Property<string>("Residencial");

                    b.HasKey("Id");

                    b.ToTable("Contatos");
                });

            modelBuilder.Entity("WebLoja2.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Bairro");

                    b.Property<string>("Cep");

                    b.Property<string>("Cidade");

                    b.Property<string>("Complemento");

                    b.Property<string>("Logradouro");

                    b.Property<string>("NomeLogradouro");

                    b.Property<double>("Numero");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("WebLoja2.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cnpj");

                    b.Property<string>("Nome");

                    b.Property<string>("RazaoSocial");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("WebLoja2.Models.Funcionario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Cpf");

                    b.Property<DateTime>("DataDeNascimento");

                    b.Property<string>("Login");

                    b.Property<string>("Nome");

                    b.Property<string>("NumeroCarteiraDeTrabalho");

                    b.Property<string>("Senha");

                    b.Property<string>("Sexo");

                    b.HasKey("Id");

                    b.ToTable("Funcionario");
                });

            modelBuilder.Entity("WebLoja2.Models.Produtos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Categoria");

                    b.Property<string>("Descricao");

                    b.Property<string>("Modelo");

                    b.Property<string>("Nome");

                    b.Property<int>("Quantidade");

                    b.Property<int>("TempoGarantia");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("WebLoja2.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("WebLoja2.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClienteId");

                    b.Property<DateTime>("Data");

                    b.Property<double>("Desconto");

                    b.Property<string>("FormaDePagamento");

                    b.Property<int?>("FuncionarioId");

                    b.Property<int?>("ProdutoId");

                    b.Property<double>("Valor");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FuncionarioId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("WebLoja2.Models.VendaItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<float>("DescontoPorItem");

                    b.Property<int?>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.Property<double>("ValorTotal");

                    b.Property<float>("ValorUnitario");

                    b.Property<int?>("VendaId");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoId");

                    b.HasIndex("VendaId");

                    b.ToTable("ItensVendidos");
                });

            modelBuilder.Entity("WebLoja2.Models.Compra", b =>
                {
                    b.HasOne("WebLoja2.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.HasOne("WebLoja2.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("WebLoja2.Models.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("WebLoja2.Models.CompraItem", b =>
                {
                    b.HasOne("WebLoja2.Models.Fornecedor", "Compra")
                        .WithMany()
                        .HasForeignKey("CompraId");

                    b.HasOne("WebLoja2.Models.Produtos", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId");
                });

            modelBuilder.Entity("WebLoja2.Models.Venda", b =>
                {
                    b.HasOne("WebLoja2.Models.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("WebLoja2.Models.Funcionario", "Funcionario")
                        .WithMany()
                        .HasForeignKey("FuncionarioId");

                    b.HasOne("WebLoja2.Models.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");
                });

            modelBuilder.Entity("WebLoja2.Models.VendaItem", b =>
                {
                    b.HasOne("WebLoja2.Models.Produtos", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("WebLoja2.Models.Venda", "Venda")
                        .WithMany()
                        .HasForeignKey("VendaId");
                });
        }
    }
}
