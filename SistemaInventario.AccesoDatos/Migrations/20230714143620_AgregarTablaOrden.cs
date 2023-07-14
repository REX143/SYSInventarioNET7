using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablaOrden : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_carroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "carroCompras");

            migrationBuilder.DropForeignKey(
                name: "FK_carroCompras_Productos_ProductoId",
                table: "carroCompras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_carroCompras",
                table: "carroCompras");

            migrationBuilder.RenameTable(
                name: "carroCompras",
                newName: "CarroCompras");

            migrationBuilder.RenameIndex(
                name: "IX_carroCompras_UsuarioAplicacionId",
                table: "CarroCompras",
                newName: "IX_CarroCompras_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_carroCompras_ProductoId",
                table: "CarroCompras",
                newName: "IX_CarroCompras_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarroCompras",
                table: "CarroCompras",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Ordenes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioAplicacionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FechaOrden = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaEnvio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumeroEnvio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Currier = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalOrden = table.Column<double>(type: "float", nullable: false),
                    EstadoOrden = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstadoPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaMaximaPago = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TransaccionId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Telefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NombresCliente = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordenes_AspNetUsers_UsuarioAplicacionId",
                        column: x => x.UsuarioAplicacionId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ordenes_UsuarioAplicacionId",
                table: "Ordenes",
                column: "UsuarioAplicacionId");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompras",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CarroCompras_Productos_ProductoId",
                table: "CarroCompras",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "CarroCompras");

            migrationBuilder.DropForeignKey(
                name: "FK_CarroCompras_Productos_ProductoId",
                table: "CarroCompras");

            migrationBuilder.DropTable(
                name: "Ordenes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarroCompras",
                table: "CarroCompras");

            migrationBuilder.RenameTable(
                name: "CarroCompras",
                newName: "carroCompras");

            migrationBuilder.RenameIndex(
                name: "IX_CarroCompras_UsuarioAplicacionId",
                table: "carroCompras",
                newName: "IX_carroCompras_UsuarioAplicacionId");

            migrationBuilder.RenameIndex(
                name: "IX_CarroCompras_ProductoId",
                table: "carroCompras",
                newName: "IX_carroCompras_ProductoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_carroCompras",
                table: "carroCompras",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carroCompras_AspNetUsers_UsuarioAplicacionId",
                table: "carroCompras",
                column: "UsuarioAplicacionId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_carroCompras_Productos_ProductoId",
                table: "carroCompras",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }
    }
}
