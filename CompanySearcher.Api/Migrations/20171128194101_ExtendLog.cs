using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CompanySearcher.Api.Migrations
{
    public partial class ExtendLog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Query",
                table: "Logs",
                newName: "QueryString");

            migrationBuilder.AddColumn<string>(
                name: "AcceptLanguage",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Host",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Method",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Origin",
                table: "Logs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Logs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptLanguage",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Host",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Method",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Origin",
                table: "Logs");

            migrationBuilder.DropColumn(
                name: "Path",
                table: "Logs");

            migrationBuilder.RenameColumn(
                name: "QueryString",
                table: "Logs",
                newName: "Query");
        }
    }
}
