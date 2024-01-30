using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestXAFAppBlazor.Module.Migrations
{
    /// <inheritdoc />
    public partial class AuthWebserv : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Setups",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Authorization",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserCode = table.Column<int>(type: "int", nullable: false),
                    UserCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SetupID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authorization", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Authorization_Setups_SetupID",
                        column: x => x.SetupID,
                        principalTable: "Setups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "WebService",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Enpoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Body = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthorizationID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SetupID = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WebService", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WebService_Authorization_AuthorizationID",
                        column: x => x.AuthorizationID,
                        principalTable: "Authorization",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_WebService_Setups_SetupID",
                        column: x => x.SetupID,
                        principalTable: "Setups",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authorization_SetupID",
                table: "Authorization",
                column: "SetupID");

            migrationBuilder.CreateIndex(
                name: "IX_WebService_AuthorizationID",
                table: "WebService",
                column: "AuthorizationID");

            migrationBuilder.CreateIndex(
                name: "IX_WebService_SetupID",
                table: "WebService",
                column: "SetupID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WebService");

            migrationBuilder.DropTable(
                name: "Authorization");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Setups");
        }
    }
}
