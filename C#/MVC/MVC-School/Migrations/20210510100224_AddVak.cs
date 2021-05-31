using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_School.Migrations
{
    public partial class AddVak : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DocentVak");

            migrationBuilder.CreateIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken",
                column: "DocentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vakken_Docenten_DocentId",
                table: "Vakken",
                column: "DocentId",
                principalTable: "Docenten",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vakken_Docenten_DocentId",
                table: "Vakken");

            migrationBuilder.DropIndex(
                name: "IX_Vakken_DocentId",
                table: "Vakken");

            migrationBuilder.CreateTable(
                name: "DocentVak",
                columns: table => new
                {
                    DocentenId = table.Column<int>(type: "int", nullable: false),
                    VakkenId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocentVak", x => new { x.DocentenId, x.VakkenId });
                    table.ForeignKey(
                        name: "FK_DocentVak_Docenten_DocentenId",
                        column: x => x.DocentenId,
                        principalTable: "Docenten",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocentVak_Vakken_VakkenId",
                        column: x => x.VakkenId,
                        principalTable: "Vakken",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DocentVak_VakkenId",
                table: "DocentVak",
                column: "VakkenId");
        }
    }
}
