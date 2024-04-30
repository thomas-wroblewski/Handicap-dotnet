using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handicap.Migrations
{
    /// <inheritdoc />
    public partial class rearrangeratingtypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "slope",
                table: "Rounds",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<float>(
                name: "rating",
                table: "Rounds",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<float>(
                name: "slope",
                table: "Rounds",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "rating",
                table: "Rounds",
                type: "integer",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");
        }
    }
}
