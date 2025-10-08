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
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_usuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "TB_PERSONAGENS",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERSONAGENS_usuarioId",
                table: "TB_PERSONAGENS",
                newName: "IX_TB_PERSONAGENS_UsuarioId");

            migrationBuilder.AlterColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 20, "Invocar o pai" },
                    { 2, 10, "Arremeço de pastel" },
                    { 3, 30, "Choque do trovão" },
                    { 4, 15, "Saque de volei" }
                });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                column: "UsuarioId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_USUARIO",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 234, 87, 92, 160, 128, 34, 135, 94, 232, 40, 109, 35, 104, 12, 80, 35, 64, 230, 58, 217, 164, 235, 15, 209, 2, 68, 49, 2, 214, 71, 243, 63, 60, 61, 106, 213, 218, 72, 36, 89, 44, 150, 108, 47, 87, 215, 195, 38, 112, 102, 93, 111, 33, 27, 178, 196, 237, 5, 169, 114, 49, 119, 15 }, new byte[] { 219, 148, 255, 94, 107, 62, 145, 52, 66, 8, 154, 120, 0, 216, 174, 25, 108, 254, 226, 212, 170, 194, 87, 91, 12, 251, 73, 190, 169, 88, 50, 196, 15, 181, 227, 158, 53, 79, 17, 117, 158, 155, 170, 160, 51, 125, 203, 84, 91, 175, 42, 80, 159, 115, 80, 92, 128, 87, 195, 182, 46, 211, 250, 198, 33, 159, 175, 191, 202, 15, 247, 242, 137, 14, 84, 60, 164, 15, 86, 252, 34, 138, 77, 216, 86, 244, 31, 111, 128, 74, 121, 51, 84, 2, 99, 48, 3, 43, 194, 201, 207, 168, 62, 96, 203, 162, 250, 165, 10, 200, 228, 133, 188, 179, 123, 211, 47, 17, 93, 238, 52, 133, 16, 160, 175, 180, 89, 252 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 4, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIO",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                newName: "IX_TB_PERSONAGENS_usuarioId");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "UsuarioId", "usuarioId" },
                values: new object[] { 1, null });

            migrationBuilder.UpdateData(
                table: "TB_USUARIO",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 143, 228, 38, 115, 207, 255, 41, 233, 94, 201, 206, 229, 66, 24, 82, 212, 45, 55, 133, 9, 97, 70, 33, 201, 31, 88, 26, 241, 190, 237, 80, 181, 248, 114, 158, 225, 97, 6, 58, 168, 236, 56, 20, 212, 91, 188, 173, 144, 205, 189, 196, 114, 246, 102, 108, 206, 252, 73, 97, 181, 194, 55, 125, 253 }, new byte[] { 138, 178, 255, 9, 77, 59, 216, 130, 132, 164, 95, 76, 98, 119, 194, 63, 11, 174, 142, 127, 253, 13, 168, 155, 8, 12, 18, 192, 226, 245, 143, 217, 122, 71, 168, 175, 180, 77, 19, 102, 216, 233, 125, 155, 145, 39, 65, 189, 99, 239, 234, 15, 102, 73, 152, 176, 205, 190, 205, 254, 114, 91, 145, 115, 83, 241, 247, 124, 164, 4, 35, 41, 176, 104, 251, 51, 89, 48, 45, 84, 218, 211, 187, 77, 37, 189, 201, 200, 94, 102, 85, 90, 134, 50, 233, 134, 28, 12, 131, 237, 196, 191, 231, 165, 38, 187, 89, 166, 206, 112, 241, 222, 138, 34, 246, 209, 45, 41, 196, 51, 198, 144, 33, 213, 49, 190, 230, 203 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMA_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                unique: true,
                filter: "[PersonagemId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMA_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMA",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIO",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_usuarioId",
                table: "TB_PERSONAGENS",
                column: "usuarioId",
                principalTable: "TB_USUARIO",
                principalColumn: "Id");
        }
    }
}
