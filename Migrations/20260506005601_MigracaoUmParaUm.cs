using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGEM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGEM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGEM",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMA",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 168, 114, 83, 30, 1, 190, 112, 229, 81, 132, 157, 207, 53, 138, 19, 72, 126, 14, 21, 174, 60, 47, 20, 50, 227, 40, 182, 42, 51, 252, 75, 226, 134, 150, 117, 138, 99, 148, 64, 222, 91, 75, 27, 212, 92, 2, 122, 186, 181, 22, 142, 165, 187, 104, 12, 15, 234, 241, 199, 36, 233, 187, 152, 2 }, new byte[] { 63, 133, 26, 32, 127, 74, 209, 95, 68, 141, 51, 160, 208, 182, 242, 236, 180, 220, 112, 244, 169, 243, 126, 16, 125, 23, 17, 71, 231, 94, 85, 208, 68, 41, 110, 252, 111, 44, 96, 111, 192, 34, 57, 96, 52, 82, 38, 161, 76, 203, 52, 116, 18, 116, 171, 125, 241, 205, 208, 179, 251, 100, 253, 2, 182, 31, 106, 210, 223, 47, 142, 103, 48, 112, 38, 158, 148, 233, 233, 190, 202, 39, 239, 32, 242, 127, 5, 201, 211, 200, 68, 200, 163, 103, 220, 126, 72, 42, 152, 114, 201, 170, 81, 218, 180, 176, 79, 71, 173, 161, 9, 12, 25, 15, 30, 66, 222, 193, 102, 40, 156, 21, 203, 193, 49, 31, 235, 93 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGEM_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGEM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGEM_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGEM");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGEM");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGEM");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 65, 57, 139, 176, 59, 60, 152, 227, 37, 202, 140, 145, 189, 231, 202, 53, 71, 72, 175, 14, 180, 115, 101, 52, 214, 198, 145, 12, 190, 22, 137, 137, 190, 79, 81, 68, 245, 233, 229, 143, 232, 152, 119, 58, 226, 107, 235, 14, 20, 163, 132, 111, 54, 95, 197, 87, 79, 1, 203, 53, 93, 250, 33, 220 }, new byte[] { 67, 0, 179, 26, 113, 31, 175, 109, 198, 8, 53, 9, 252, 47, 101, 96, 149, 96, 233, 179, 141, 247, 249, 103, 14, 116, 73, 156, 233, 49, 105, 86, 17, 194, 132, 220, 195, 85, 15, 125, 245, 19, 154, 1, 151, 235, 188, 160, 184, 190, 209, 86, 230, 228, 134, 196, 206, 82, 121, 170, 218, 247, 154, 206, 6, 17, 108, 219, 141, 62, 235, 145, 70, 174, 51, 83, 99, 250, 236, 78, 29, 142, 11, 91, 197, 118, 39, 232, 31, 5, 236, 238, 155, 149, 215, 246, 158, 241, 129, 214, 85, 242, 173, 96, 7, 69, 185, 250, 212, 20, 249, 164, 39, 172, 43, 24, 102, 15, 156, 108, 105, 32, 245, 165, 228, 22, 5, 62 } });
        }
    }
}
