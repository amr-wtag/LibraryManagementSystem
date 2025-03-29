using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateBookAuthorRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookReservations");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0b31be93-452e-4242-a056-c3d4063574a4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("22a6ab54-1337-46d9-b984-5a25d91df843"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("273e5125-6a23-41c9-9055-c209f2adac58"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("38f0a3be-5175-4569-8751-616d5fd25b21"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("936cec3e-d186-445f-b7e0-d2a1ce1d1b44"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("aded6b06-1dfb-4ff1-a888-5269c85a64de"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("bd6b5fab-1dbb-4aaf-bf75-abbdec206fbc"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c595c05c-b4b5-4763-957b-36980ce003e3"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c9a36236-6a74-4afa-b9b2-8da68d3a408c"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e7348b37-7dbe-42f2-8f82-4dd9fee7dcb1"));


            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("216a2c9b-c087-4359-b837-bc2ccda7ebab"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("24006aa5-5735-4af1-976f-d2ede1ba8dc7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a8160966-6ac8-4b53-ba97-0fa91e18ce12"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a93d4f98-7058-462c-b350-2f26756771ac"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cf11a5f5-84b6-489e-9d9a-786f53f810ea"));

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Books");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookReservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthors",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    AuthorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthors", x => new { x.BookId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_BookAuthors_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthors_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("526d6236-71f6-4f61-a6fe-6d68a96f6552"), 0, "79d8b145-1b84-4f55-b698-b942fc28738e", new DateTime(2025, 3, 29, 8, 25, 27, 745, DateTimeKind.Utc).AddTicks(5300), "Barton51@hotmail.com", true, "Curtis Muller", false, null, "BARTON51@HOTMAIL.COM", "TESSIE_SCHINNER", "AQAAAAIAAYagAAAAEKx+miouBFqtJtRVL8ZhQ8RgNvoyMPkd3NsGxPfJmDi7DtO02ffGC9al7omYi8Zq3g==", null, false, null, false, "Tessie_Schinner" },
                    { new Guid("7a2eae60-ebf7-4dd4-a699-cbb3463edff9"), 0, "e4aa22ef-58e4-47a5-b2ab-9e00ec47b4ad", new DateTime(2025, 3, 29, 8, 25, 27, 745, DateTimeKind.Utc).AddTicks(5210), "Michale19@gmail.com", true, "Deven Willms", false, null, "MICHALE19@GMAIL.COM", "WALDO.ZBONCAK", "AQAAAAIAAYagAAAAEPoCTsn2IGb9vUeGO23onMQ1Ai0JFseAO/ovy80tpg1QXIpQLkstrtpkTtWWjGonyw==", null, false, null, false, "Waldo.Zboncak" },
                    { new Guid("beb6ff40-70ba-41b8-a669-ed52b17d2dfa"), 0, "f26a0c8e-409b-45ae-b16e-c581adb3b6dc", new DateTime(2025, 3, 29, 8, 25, 27, 745, DateTimeKind.Utc).AddTicks(5380), "Dashawn.Lowe98@gmail.com", true, "Jocelyn Hand", false, null, "DASHAWN.LOWE98@GMAIL.COM", "JAYLEN73", "AQAAAAIAAYagAAAAENhk/KDSyasKvBzlg/SSGy+6mNdnVGZzBbV75s0K1xac3XmOLB0XgVdWGcNmliq0tQ==", null, false, null, false, "Jaylen73" },
                    { new Guid("f15abfdd-7d66-4357-8f6a-6fe7ae39d913"), 0, "c0ac9435-afca-43f8-b4f3-5377c6ecf426", new DateTime(2025, 3, 29, 8, 25, 27, 745, DateTimeKind.Utc).AddTicks(3510), "Leonard.Welch72@hotmail.com", true, "Jedediah Terry", false, null, "LEONARD.WELCH72@HOTMAIL.COM", "ERVIN.HAMILL32", "AQAAAAIAAYagAAAAEEmkdichRt4G2Vft7Sxej3FQI5gvAbY1GMuHm5l3ez5XNJ8lpEoY+i7g0HxFwGIIuw==", null, false, null, false, "Ervin.Hamill32" },
                    { new Guid("f84cf6ef-8308-4642-9a7c-df9797a0f98a"), 0, "1379add8-982e-48cf-b926-d64d39b9d7af", new DateTime(2025, 3, 29, 8, 25, 27, 745, DateTimeKind.Utc).AddTicks(5430), "Hillary.Kessler@hotmail.com", true, "Javon Stanton", false, null, "HILLARY.KESSLER@HOTMAIL.COM", "MARK68", "AQAAAAIAAYagAAAAEE1uSU0EwFSCUWiuiETGAOt5S9W8M7won8riNVPDYqKoFFkYq9tIQEe/gkIaawbCmg==", null, false, null, false, "Mark68" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("261a3457-12d7-406b-97a1-174fb25f1fad"), "Trenton Swift" },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), "Kailyn Daugherty" },
                    { new Guid("74b496a8-146c-4a1a-a9e7-84dfc33f4111"), "Billie Maggio" },
                    { new Guid("8e2474a7-8eaf-40d1-88ff-356e42e9497c"), "Kristoffer Pfannerstill" },
                    { new Guid("9d0a4884-2530-419c-81c2-0fb1de96d0d9"), "Bernita Mueller" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Category", "CopiesAvailable", "Title" },
                values: new object[,]
                {
                    { new Guid("04c03b38-4fcf-4092-9fb0-d25f738c8c79"), "Technology", 17, "Facilis autem ducimus." },
                    { new Guid("0ba4ea03-0062-4f1e-99da-0a8cd6f6c567"), "Technology", 2, "Qui ut quo." },
                    { new Guid("138bd7ae-7719-4b55-9eda-258e8f23559b"), "Science", 16, "Exercitationem rerum maiores." },
                    { new Guid("31ca8b1c-4f89-4d86-963e-fa6d5ef9ea7a"), "History", 13, "Magnam eum autem." },
                    { new Guid("35a00c8d-8a9c-43e0-9bfa-9ad849530da2"), "Science", 15, "Dolore culpa natus." },
                    { new Guid("3e4876a8-95ee-4d43-ba5a-5c8dd0ec3492"), "Mystery", 3, "Expedita molestiae quo." },
                    { new Guid("49fe8fe4-1201-45f2-b01e-7d4359293c10"), "Fiction", 4, "Rem est pariatur." },
                    { new Guid("c202adf8-58c6-4dbd-91c6-5efa4c76407f"), "Technology", 10, "Quia quam voluptatem." },
                    { new Guid("d22e799a-7e4f-4c2d-81b6-8042c9c5aa68"), "Mystery", 20, "Quis error accusamus." },
                    { new Guid("df785ddc-2626-49a6-8241-9d88f8fbf201"), "History", 19, "A quaerat accusantium." }
                });


            migrationBuilder.InsertData(
                table: "BookAuthors",
                columns: new[] { "AuthorId", "BookId" },
                values: new object[,]
                {
                    { new Guid("261a3457-12d7-406b-97a1-174fb25f1fad"), new Guid("04c03b38-4fcf-4092-9fb0-d25f738c8c79") },
                    { new Guid("8e2474a7-8eaf-40d1-88ff-356e42e9497c"), new Guid("04c03b38-4fcf-4092-9fb0-d25f738c8c79") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("0ba4ea03-0062-4f1e-99da-0a8cd6f6c567") },
                    { new Guid("74b496a8-146c-4a1a-a9e7-84dfc33f4111"), new Guid("0ba4ea03-0062-4f1e-99da-0a8cd6f6c567") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("138bd7ae-7719-4b55-9eda-258e8f23559b") },
                    { new Guid("74b496a8-146c-4a1a-a9e7-84dfc33f4111"), new Guid("138bd7ae-7719-4b55-9eda-258e8f23559b") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("31ca8b1c-4f89-4d86-963e-fa6d5ef9ea7a") },
                    { new Guid("74b496a8-146c-4a1a-a9e7-84dfc33f4111"), new Guid("31ca8b1c-4f89-4d86-963e-fa6d5ef9ea7a") },
                    { new Guid("8e2474a7-8eaf-40d1-88ff-356e42e9497c"), new Guid("35a00c8d-8a9c-43e0-9bfa-9ad849530da2") },
                    { new Guid("9d0a4884-2530-419c-81c2-0fb1de96d0d9"), new Guid("35a00c8d-8a9c-43e0-9bfa-9ad849530da2") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("3e4876a8-95ee-4d43-ba5a-5c8dd0ec3492") },
                    { new Guid("8e2474a7-8eaf-40d1-88ff-356e42e9497c"), new Guid("3e4876a8-95ee-4d43-ba5a-5c8dd0ec3492") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("49fe8fe4-1201-45f2-b01e-7d4359293c10") },
                    { new Guid("74b496a8-146c-4a1a-a9e7-84dfc33f4111"), new Guid("49fe8fe4-1201-45f2-b01e-7d4359293c10") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("c202adf8-58c6-4dbd-91c6-5efa4c76407f") },
                    { new Guid("9d0a4884-2530-419c-81c2-0fb1de96d0d9"), new Guid("c202adf8-58c6-4dbd-91c6-5efa4c76407f") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("d22e799a-7e4f-4c2d-81b6-8042c9c5aa68") },
                    { new Guid("9d0a4884-2530-419c-81c2-0fb1de96d0d9"), new Guid("d22e799a-7e4f-4c2d-81b6-8042c9c5aa68") },
                    { new Guid("261a3457-12d7-406b-97a1-174fb25f1fad"), new Guid("df785ddc-2626-49a6-8241-9d88f8fbf201") },
                    { new Guid("2d9e31bd-9195-4cd1-b0cb-2cf0decb3991"), new Guid("df785ddc-2626-49a6-8241-9d88f8fbf201") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthors_AuthorId",
                table: "BookAuthors",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReservations_BookId",
                table: "BookReservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReservations_UserId",
                table: "BookReservations",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthors");

            migrationBuilder.DropTable(
                name: "BookReservations");

            migrationBuilder.DropTable(
                name: "Authors");


            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("04c03b38-4fcf-4092-9fb0-d25f738c8c79"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("0ba4ea03-0062-4f1e-99da-0a8cd6f6c567"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("138bd7ae-7719-4b55-9eda-258e8f23559b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("31ca8b1c-4f89-4d86-963e-fa6d5ef9ea7a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("35a00c8d-8a9c-43e0-9bfa-9ad849530da2"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3e4876a8-95ee-4d43-ba5a-5c8dd0ec3492"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("49fe8fe4-1201-45f2-b01e-7d4359293c10"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c202adf8-58c6-4dbd-91c6-5efa4c76407f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("d22e799a-7e4f-4c2d-81b6-8042c9c5aa68"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("df785ddc-2626-49a6-8241-9d88f8fbf201"));


            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("526d6236-71f6-4f61-a6fe-6d68a96f6552"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a2eae60-ebf7-4dd4-a699-cbb3463edff9"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("beb6ff40-70ba-41b8-a669-ed52b17d2dfa"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f15abfdd-7d66-4357-8f6a-6fe7ae39d913"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f84cf6ef-8308-4642-9a7c-df9797a0f98a"));

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Books",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookReservations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    BookId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    IssuedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ReturnDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookReservations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookReservations_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("216a2c9b-c087-4359-b837-bc2ccda7ebab"), 0, "dedf0a33-0671-4267-ab81-15edfc7da6bb", new DateTime(2025, 3, 26, 15, 5, 23, 912, DateTimeKind.Utc).AddTicks(7970), "Abbey.Roob52@yahoo.com", true, "Phyllis Schumm", false, null, "ABBEY.ROOB52@YAHOO.COM", "ROWENA.FRITSCH3", "AQAAAAIAAYagAAAAEJ22CTtVJGr4ZIO5OMns8Sm4/rZV+WSGL9ozeUKvtPOyel2AEM4GOJdFsliKepZwOA==", null, false, null, false, "Rowena.Fritsch3" },
                    { new Guid("24006aa5-5735-4af1-976f-d2ede1ba8dc7"), 0, "175f4ea2-722f-4b4c-ad0a-2d9df154cf36", new DateTime(2025, 3, 26, 15, 5, 23, 912, DateTimeKind.Utc).AddTicks(9340), "Korey_Rodriguez@gmail.com", true, "Delfina Monahan", false, null, "KOREY_RODRIGUEZ@GMAIL.COM", "JACQUELYN63", "AQAAAAIAAYagAAAAENgfop/HRyjSw7r8ECcFAoTwvXnpeV2HXxOrXT0q/sG971GcAfG18Dj4kiXuDdfE5w==", null, false, null, false, "Jacquelyn63" },
                    { new Guid("a8160966-6ac8-4b53-ba97-0fa91e18ce12"), 0, "5a319905-b5d5-40a1-800e-ff14ee006d31", new DateTime(2025, 3, 26, 15, 5, 23, 912, DateTimeKind.Utc).AddTicks(9430), "Colby3@gmail.com", true, "Vicente Waelchi", false, null, "COLBY3@GMAIL.COM", "DARRON48", "AQAAAAIAAYagAAAAEMRKqP/kuzL65cs1efG0ajJdUzjBfk8sF6lcLJR79Euhvr+jHGX5q2klS6q4jjBmkA==", null, false, null, false, "Darron48" },
                    { new Guid("a93d4f98-7058-462c-b350-2f26756771ac"), 0, "c5c2785b-34d7-4735-82a0-cfc3695ba692", new DateTime(2025, 3, 26, 15, 5, 23, 912, DateTimeKind.Utc).AddTicks(9500), "Eldred5@hotmail.com", true, "Mack Hoeger", false, null, "ELDRED5@HOTMAIL.COM", "JADE_PACOCHA", "AQAAAAIAAYagAAAAEIoC5fhd4o2R3e+irEj7C0bAraXkjQMCm5Oyj4I54zyA0aG6P6DKINJvNqnPWaDAyg==", null, false, null, false, "Jade_Pacocha" },
                    { new Guid("cf11a5f5-84b6-489e-9d9a-786f53f810ea"), 0, "f2a32e38-2311-4210-a231-2f4eea50a4ab", new DateTime(2025, 3, 26, 15, 5, 23, 912, DateTimeKind.Utc).AddTicks(9550), "Jairo20@hotmail.com", true, "Maryse Kihn", false, null, "JAIRO20@HOTMAIL.COM", "AURORE0", "AQAAAAIAAYagAAAAEGgzP/bXI3VlPKmfN1btE+mRYNyEKSI5jSL7tYh3WtKYSPAolEtstE7WIfO1CPGUGg==", null, false, null, false, "Aurore0" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "CopiesAvailable", "Title" },
                values: new object[,]
                {
                    { new Guid("0b31be93-452e-4242-a056-c3d4063574a4"), "Margaret Pfeffer", "History", 16, "Quia quia et." },
                    { new Guid("22a6ab54-1337-46d9-b984-5a25d91df843"), "Abdiel Mertz", "Mystery", 3, "Earum laboriosam consequuntur." },
                    { new Guid("273e5125-6a23-41c9-9055-c209f2adac58"), "Tad Dietrich", "Technology", 15, "Atque non dicta." },
                    { new Guid("38f0a3be-5175-4569-8751-616d5fd25b21"), "Esther Reinger", "Fiction", 13, "Quo consequuntur consequuntur." },
                    { new Guid("936cec3e-d186-445f-b7e0-d2a1ce1d1b44"), "Maximilian Lakin", "Technology", 6, "Repellendus incidunt non." },
                    { new Guid("aded6b06-1dfb-4ff1-a888-5269c85a64de"), "Ottilie Shanahan", "Science", 9, "Quo sed sint." },
                    { new Guid("bd6b5fab-1dbb-4aaf-bf75-abbdec206fbc"), "Maritza Muller", "Mystery", 7, "Nobis et vel." },
                    { new Guid("c595c05c-b4b5-4763-957b-36980ce003e3"), "Lucinda Kshlerin", "Mystery", 2, "Temporibus est quam." },
                    { new Guid("c9a36236-6a74-4afa-b9b2-8da68d3a408c"), "Armani Gerhold", "Science", 12, "Quidem incidunt quibusdam." },
                    { new Guid("e7348b37-7dbe-42f2-8f82-4dd9fee7dcb1"), "Antone Ernser", "History", 20, "Ducimus et necessitatibus." }
                });

            
            migrationBuilder.CreateIndex(
                name: "IX_BookReservations_BookId",
                table: "BookReservations",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookReservations_UserId",
                table: "BookReservations",
                column: "UserId");
        }
    }
}
