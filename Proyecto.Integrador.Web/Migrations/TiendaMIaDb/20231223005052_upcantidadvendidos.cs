using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Integrador.Web.Migrations.TiendaMIaDb
{
    /// <inheritdoc />
    public partial class upcantidadvendidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CantidadVendidos",
                table: "Productos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadVendidos",
                table: "Productos");
        }
    }
}
