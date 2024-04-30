using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handicap.Migrations
{
    /// <inheritdoc />
    public partial class addremainingroundentities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "course",
                table: "Rounds",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "date",
                table: "Rounds",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<int>(
                name: "rating",
                table: "Rounds",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "score",
                table: "Rounds",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "slope",
                table: "Rounds",
                type: "real",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "course",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "date",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "score",
                table: "Rounds");

            migrationBuilder.DropColumn(
                name: "slope",
                table: "Rounds");
        }
    }
}
