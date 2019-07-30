using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LojaWeb.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataDataDeNascimento",
                table: "Funcionario",
                newName: "DataDeNascimento");

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "Funcionario",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "Funcionario",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Login",
                table: "Funcionario");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "Funcionario");

            migrationBuilder.RenameColumn(
                name: "DataDeNascimento",
                table: "Funcionario",
                newName: "DataDataDeNascimento");
        }
    }
}
