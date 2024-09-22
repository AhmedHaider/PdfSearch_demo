using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PdfSearch_demo.Migrations
{
    /// <inheritdoc />
    public partial class AddIsAuthorizedField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsAuthorized",
                table: "Users",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsAuthorized",
                table: "Users");
        }
    }
}
