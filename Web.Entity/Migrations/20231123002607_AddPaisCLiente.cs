using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Entity.Migrations
{
    /// <inheritdoc />
    public partial class AddPaisCLiente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pais",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pais",
                table: "Clientes");
        }
    }
}
