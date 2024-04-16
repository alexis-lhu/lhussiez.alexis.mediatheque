using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mediatheque.Core.Migrations
{
    /// <inheritdoc />
    public partial class CDModif : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateDeSortie",
                table: "CDs",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateDeSortie",
                table: "CDs");
        }
    }
}
