using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LojaWeb.Migrations
{
    public partial class CompraItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ItensComprados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompraId = table.Column<int>(nullable: true),
                    DescontoPorItem = table.Column<double>(nullable: false),
                    ProdutosId = table.Column<int>(nullable: true),
                    Quantidade = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false),
                    ValorUnitario = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensComprados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensComprados_Compras_CompraId",
                        column: x => x.CompraId,
                        principalTable: "Compras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ItensComprados_Produtos_ProdutosId",
                        column: x => x.ProdutosId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensComprados_CompraId",
                table: "ItensComprados",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_ItensComprados_ProdutosId",
                table: "ItensComprados",
                column: "ProdutosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensComprados");
        }
    }
}
