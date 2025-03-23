using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAtInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Add the CreatedAt column with a default value
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP" // For PostgreSQL
            );

            // Manually update existing users to set a proper CreatedAt timestamp
            migrationBuilder.Sql("UPDATE \"AspNetUsers\" SET \"CreatedAt\" = NOW();"); // PostgreSQL
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers"
            );
        }

    }
}
