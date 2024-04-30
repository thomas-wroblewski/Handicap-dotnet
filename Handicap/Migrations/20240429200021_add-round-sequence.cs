using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Handicap.Migrations
{
    /// <inheritdoc />
    public partial class addroundsequence : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "round_id_seq");

            migrationBuilder.CreateTable(
                name: "Rounds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, defaultValueSql: "nextval('round_id_seq')")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rounds", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rounds");

            migrationBuilder.DropSequence(
                name: "round_id_seq");
        }
    }
}
