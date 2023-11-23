using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web.Entity.Migrations
{
    /// <inheritdoc />
    public partial class AddGuid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Guid",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: Guid.NewGuid().ToString());
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Guid",
                table: "Clientes");
        }
    }
}
