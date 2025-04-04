using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddManyToManyBookGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Books"
            );

            // Create Genres table
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                }
            );

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ea0a66a-e099-414d-9ba7-7871561a155a"), "Fiction" },
                    { new Guid("741f750d-db0c-4944-bec7-5ebae26d0368"), "Science" },
                    { new Guid("c0523089-04a6-4de6-bccd-6a2f0e03467c"), "History" },
                    { new Guid("04c03b38-4fcf-4092-9fb0-d25f738c8c79"), "Mystery" }
                }
            );


            // Add unique constraint to Genre name
            migrationBuilder.CreateIndex(
                name: "IX_Genres_Name",
                table: "Genres",
                column: "Name",
                unique: true
            );

            // Create BookGenres join table
            migrationBuilder.CreateTable(
                name: "BookGenres",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    GenreId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookGenres", x => new { x.BookId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_BookGenres_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                    table.ForeignKey(
                        name: "FK_BookGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade
                    );
                }
            );

            migrationBuilder.CreateIndex(
                name: "IX_BookGenres_GenreId",
                table: "BookGenres",
                column: "GenreId"
            );

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)  {
            // Drop BookGenres table first
            migrationBuilder.DropTable(
                name: "BookGenres"
            );

            // Drop Genres table
            migrationBuilder.DropTable(
                name: "Genres"
            );

            // Add Category column back to Books
            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Books",
                type: "text",
                nullable: true
            );
        }
    }
}
