using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestXAFAppBlazor.Module.Migrations
{
    /// <inheritdoc />
    public partial class AddedEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Appearence",
                table: "WebService",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Appearence",
                table: "WebService");
        }
    }
}
