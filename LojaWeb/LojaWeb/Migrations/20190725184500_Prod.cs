using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaWeb.Migrations
{
    public partial class Prod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Compras",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Compras_ProdutoId",
                table: "Compras",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Compras_Produtos_ProdutoId",
                table: "Compras",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Compras_Produtos_ProdutoId",
                table: "Compras");

            migrationBuilder.DropIndex(
                name: "IX_Compras_ProdutoId",
                table: "Compras");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Compras");
        }
    }
}
