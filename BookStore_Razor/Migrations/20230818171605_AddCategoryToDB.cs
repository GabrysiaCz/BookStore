using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreRazor.Migrations
{
    /// <inheritdoc />
    public partial class DodajKategorieDoBazyDanych : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nazwa = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    KolejnośćWyświetlania = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Kategorie",
                columns: new[] { "Id", "KolejnośćWyświetlania", "Nazwa" },
                values: new object[,]
                {
                    { 1, 1, "Akcja" },
                    { 2, 2, "SciFi" },
                    { 3, 3, "Historia" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kategorie");
        }
    }
}
