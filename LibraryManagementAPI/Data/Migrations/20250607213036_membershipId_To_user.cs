using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class membershipId_To_user : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MembershipId",
                table: "AspNetUsers",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MembershipId",
                table: "AspNetUsers",
                column: "MembershipId",
                unique: true);
            migrationBuilder.Sql("UPDATE \"AspNetUsers\" SET \"MembershipId\" = 'MBR-' || to_char(now(), 'YYYYMMDD') || '-' || upper(substring(\"Id\"::text, 1, 6)) WHERE \"MembershipId\" IS NULL;");

            migrationBuilder.AlterColumn<string>(
                name: "MembershipId",
                table: "AspNetUsers",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_MembershipId",
                table: "AspNetUsers");
            migrationBuilder.DropColumn(
                name: "MembershipId",
                table: "AspNetUsers");
           }

    }
}
