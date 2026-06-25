using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BandHub.UserService.Migrations
{
    /// <inheritdoc />
    public partial class AddRefreshTokenToAccounts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "RefreshToken",
                table: "accounts",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "RefreshTokenExpiraEm",
                table: "accounts",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RefreshToken",
                table: "accounts");

            migrationBuilder.DropColumn(
                name: "RefreshTokenExpiraEm",
                table: "accounts");
        }
    }
}
