﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaInventario.AccesoDatos.Migrations
{
    /// <inheritdoc />
    public partial class AgregarTablaCarroCompra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "carroCompras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioAplicacionId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductoId = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carroCompras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_carroCompras_AspNetUsers_UsuarioAplicacionId",
                        column: x => x.UsuarioAplicacionId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_carroCompras_Productos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "Productos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_carroCompras_ProductoId",
                table: "carroCompras",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_carroCompras_UsuarioAplicacionId",
                table: "carroCompras",
                column: "UsuarioAplicacionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "carroCompras");
        }
    }
}