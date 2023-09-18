using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFDbRelationshipsExamples.Migrations
{
    /// <inheritdoc />
    public partial class adding_many_to_many_relationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FractionIdPk",
                table: "Characters",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Fraction",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CharacterId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fraction", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterFraction",
                columns: table => new
                {
                    CharactersId = table.Column<int>(type: "int", nullable: false),
                    FractionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterFraction", x => new { x.CharactersId, x.FractionsId });
                    table.ForeignKey(
                        name: "FK_CharacterFraction_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterFraction_Fraction_FractionsId",
                        column: x => x.FractionsId,
                        principalTable: "Fraction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterFraction_FractionsId",
                table: "CharacterFraction",
                column: "FractionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterFraction");

            migrationBuilder.DropTable(
                name: "Fraction");

            migrationBuilder.DropColumn(
                name: "FractionIdPk",
                table: "Characters");
        }
    }
}
