using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGEM_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGEM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adomecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 134, 230, 144, 195, 234, 119, 225, 245, 40, 17, 148, 227, 30, 21, 105, 120, 29, 95, 113, 42, 179, 58, 194, 72, 225, 243, 153, 4, 24, 238, 239, 45, 101, 93, 247, 196, 26, 73, 207, 182, 152, 209, 69, 24, 169, 80, 175, 191, 132, 231, 195, 98, 150, 36, 176, 100, 35, 113, 142, 39, 165, 242, 224, 230 }, new byte[] { 241, 230, 126, 121, 74, 193, 144, 219, 103, 6, 251, 81, 98, 166, 234, 195, 3, 227, 117, 193, 101, 86, 71, 2, 14, 186, 153, 215, 218, 192, 252, 199, 254, 56, 232, 242, 231, 98, 211, 169, 103, 218, 171, 205, 16, 212, 36, 79, 3, 180, 136, 83, 240, 58, 176, 178, 95, 122, 142, 67, 42, 211, 65, 101, 28, 102, 198, 60, 67, 82, 137, 140, 232, 120, 120, 160, 245, 67, 192, 93, 56, 227, 22, 254, 12, 148, 165, 196, 157, 2, 186, 33, 81, 173, 255, 69, 220, 207, 48, 44, 205, 57, 80, 40, 132, 118, 12, 107, 233, 219, 156, 63, 87, 41, 104, 9, 32, 61, 73, 44, 171, 56, 56, 188, 59, 242, 247, 249 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 114, 83, 30, 1, 190, 112, 229, 81, 132, 157, 207, 53, 138, 19, 72, 126, 14, 21, 174, 60, 47, 20, 50, 227, 40, 182, 42, 51, 252, 75, 226, 134, 150, 117, 138, 99, 148, 64, 222, 91, 75, 27, 212, 92, 2, 122, 186, 181, 22, 142, 165, 187, 104, 12, 15, 234, 241, 199, 36, 233, 187, 152, 2 }, new byte[] { 63, 133, 26, 32, 127, 74, 209, 95, 68, 141, 51, 160, 208, 182, 242, 236, 180, 220, 112, 244, 169, 243, 126, 16, 125, 23, 17, 71, 231, 94, 85, 208, 68, 41, 110, 252, 111, 44, 96, 111, 192, 34, 57, 96, 52, 82, 38, 161, 76, 203, 52, 116, 18, 116, 171, 125, 241, 205, 208, 179, 251, 100, 253, 2, 182, 31, 106, 210, 223, 47, 142, 103, 48, 112, 38, 158, 148, 233, 233, 190, 202, 39, 239, 32, 242, 127, 5, 201, 211, 200, 68, 200, 163, 103, 220, 126, 72, 42, 152, 114, 201, 170, 81, 218, 180, 176, 79, 71, 173, 161, 9, 12, 25, 15, 30, 66, 222, 193, 102, 40, 156, 21, 203, 193, 49, 31, 235, 93 } });
        }
    }
}
