using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proyecto.Integrador.Web.Migrations.TiendaMIaDb
{
    /// <inheritdoc />
    public partial class updatecategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Categorias",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Categorias");
        }
    }
}
