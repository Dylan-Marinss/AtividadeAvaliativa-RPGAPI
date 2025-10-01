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
            migrationBuilder.DropForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                newName: "usuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERSONAGENS_UsuarioId",
                table: "TB_PERSONAGENS",
                newName: "IX_TB_PERSONAGENS_usuarioId");

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMA",
                type: "int",
                nullable: true);

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
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "UsuarioId", "Vitorias", "usuarioId" },
                values: new object[] { 0, 0, 1, 0, null });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMA");

            migrationBuilder.RenameColumn(
                name: "usuarioId",
                table: "TB_PERSONAGENS",
                newName: "UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_TB_PERSONAGENS_usuarioId",
                table: "TB_PERSONAGENS",
                newName: "IX_TB_PERSONAGENS_UsuarioId");

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
                values: new object[] { new byte[] { 230, 224, 128, 83, 66, 81, 253, 131, 248, 137, 114, 22, 184, 116, 244, 28, 135, 22, 168, 215, 204, 147, 49, 59, 57, 51, 226, 248, 178, 89, 13, 66, 183, 135, 206, 174, 175, 221, 100, 97, 195, 89, 140, 74, 64, 246, 154, 2, 220, 168, 89, 22, 220, 35, 216, 175, 91, 143, 126, 130, 53, 2, 45, 132 }, new byte[] { 13, 136, 195, 211, 47, 179, 140, 170, 13, 173, 92, 219, 231, 79, 63, 136, 37, 125, 29, 244, 229, 189, 122, 78, 123, 224, 201, 41, 74, 85, 54, 60, 119, 134, 166, 211, 14, 69, 184, 198, 39, 41, 55, 207, 32, 237, 213, 218, 193, 125, 191, 182, 83, 84, 49, 166, 45, 57, 199, 142, 238, 114, 96, 234, 244, 67, 91, 180, 160, 48, 18, 130, 147, 128, 201, 110, 212, 50, 76, 74, 160, 4, 96, 171, 65, 251, 10, 166, 61, 147, 190, 61, 231, 204, 174, 121, 234, 116, 254, 245, 242, 94, 27, 118, 84, 70, 200, 148, 191, 250, 4, 86, 189, 3, 122, 123, 228, 202, 16, 245, 0, 40, 37, 226, 2, 158, 203, 154 } });

            migrationBuilder.AddForeignKey(
                name: "FK_TB_PERSONAGENS_TB_USUARIO_UsuarioId",
                table: "TB_PERSONAGENS",
                column: "UsuarioId",
                principalTable: "TB_USUARIO",
                principalColumn: "Id");
        }
    }
}
