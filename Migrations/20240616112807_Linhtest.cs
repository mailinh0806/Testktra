using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestKT.Migrations
{
    /// <inheritdoc />
    public partial class Linhtest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Linh",
                columns: table => new
                {
                    IDten = table.Column<string>(type: "TEXT", nullable: false),
                    Ten = table.Column<string>(type: "TEXT", nullable: false),
                    Tinhcach = table.Column<string>(type: "TEXT", nullable: false),
                    Ma = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Linh", x => x.IDten);
                    table.ForeignKey(
                        name: "FK_Linh_People_Ma",
                        column: x => x.Ma,
                        principalTable: "People",
                        principalColumn: "Ma",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Linh_Ma",
                table: "Linh",
                column: "Ma");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Linh");
        }
    }
}
