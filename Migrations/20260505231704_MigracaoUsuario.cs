using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUsuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "FotoPersonagem",
                table: "TB_PERSONAGEM",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGEM",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TB_USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: true),
                    DataAcesso = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Perfil = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true, defaultValue: "Jogador"),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_USUARIOS", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGEM",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FotoPersonagem", "UsuarioId" },
                values: new object[] { null, 1 });

            migrationBuilder.InsertData(
                table: "TB_USUARIOS",
                columns: new[] { "Id", "DataAcesso", "Email", "Foto", "Latitude", "Longitude", "PasswordHash", "PasswordSalt", "Perfil", "Username" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "seuEmail@gmail.com", null, -23.520024100000001, 46.596497999999997, new byte[] { 65, 57, 139, 176, 59, 60, 152, 227, 37, 202, 140, 145, 189, 231, 202, 53, 71, 72, 175, 14, 180, 115, 101, 52, 214, 198, 145, 12, 190, 22, 137, 137, 190, 79, 81, 68, 245, 233, 229, 143, 232, 152, 119, 58, 226, 107, 235, 14, 20, 163, 132, 111, 54, 95, 197, 87, 79, 1, 203, 53, 93, 250, 33, 220 }, new byte[] { 67, 0, 179, 26, 113, 31, 175, 109, 198, 8, 53, 9, 252, 47, 101, 96, 149, 96, 233, 179, 141, 247, 249, 103, 14, 116, 73, 156, 233, 49, 105, 86, 17, 194, 132, 220, 195, 85, 15, 125, 245, 19, 154, 1, 151, 235, 188, 160, 184, 190, 209, 86, 230, 228, 134, 196, 206, 82, 121, 170, 218, 247, 154, 206, 6, 17, 108, 219, 141, 62, 235, 145, 70, 174, 51, 83, 99, 250, 236, 78, 29, 142, 11, 91, 197, 118, 39, 232, 31, 5, 236, 238, 155, 149, 215, 246, 158, 241, 129, 214, 85, 242, 173, 96, 7, 69, 185, 250, 212, 20, 249, 164, 39, 172, 43, 24, 102, 15, 156, 108, 105, 32, 245, 165, 228, 22, 5, 62 }, "Admin", "UsuarioAdmin" });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGEM_UsuarioId",
                table: "TB_PERSONAGEM",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGEM_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGEM",
                column: "UsuarioId",
                principalTable: "TB_USUARIOS",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGEM_TB_USUARIOS_UsuarioId",
                table: "TB_PERSONAGEM");

            migrationBuilder.DropTable(
                name: "TB_USUARIOS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERSONAGEM_UsuarioId",
                table: "TB_PERSONAGEM");

            migrationBuilder.DropColumn(
                name: "FotoPersonagem",
                table: "TB_PERSONAGEM");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGEM");
        }
    }
}
