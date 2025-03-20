using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4ea0a66a-e099-414d-9ba7-7871561a155a"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("741f750d-db0c-4944-bec7-5ebae26d0368"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("c0523089-04a6-4de6-bccd-6a2f0e03467c"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("50c3ebb9-6536-4035-8dad-e351fdaebf29"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("7e48540d-86ff-4921-88ad-ad71079ca66f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a70bbc64-883f-4be4-94ce-c8796489e392"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e04f65a1-5666-40d5-9d8e-4005c5876bb8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("e78bc3a2-5db8-45b5-a946-2150885e9ecf"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("18d66652-d0d6-47bd-b6dd-9bfe0fadbf5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("2f5798e9-d5e2-4d9b-8285-deedf798f6bb"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3b474960-5512-4974-9c1c-722fa2e3fdc8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("4b67e5da-856c-4e56-a022-6da6050166f4"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("966edce6-22f5-47f4-9ff1-f1ee32ed999a"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("9bd5e1b2-779f-443d-b317-ee7fd30e3755"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cac1c49d-1003-4eb6-9077-21ff36588e45"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("cb9f158b-c225-4a79-b9bc-6d3a57696da8"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("fc3bd105-b9da-49d2-8db4-4902e4a169b0"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("ffcf2d96-b1db-49b0-ab06-1dc6ac3d5956"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), null, "User", "USER" },
                    { new Guid("9d6979a7-56cc-48a0-b317-e7cd33547820"), null, "Admin", "ADMIN" },
                    { new Guid("a748ea20-0c11-4d1f-b6da-0e1de0969005"), null, "Librarian", "LIBRARIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("18b951d5-2479-4216-badf-dae9b36ccfc3"), 0, "dee5d354-d0aa-4876-a8fd-439babe3473d", "Orion95@hotmail.com", true, "Annalise Dach", false, null, "ORION95@HOTMAIL.COM", "MAKENZIE_LUEILWITZ15", "AQAAAAIAAYagAAAAEH1rYjt8Ol0ywYmqzZOhTMciA79iIRevrxh41m8OumXxAkQoUpEk1x+PavfpChUfjg==", null, false, null, false, "Makenzie_Lueilwitz15" },
                    { new Guid("5966de3f-86a4-4450-aeaf-f155b7d767c1"), 0, "71148a8e-4618-40b3-bcd0-6c4f5212ff77", "Glenna.Reinger55@yahoo.com", true, "Viva Barrows", false, null, "GLENNA.REINGER55@YAHOO.COM", "MADISYN.JAKUBOWSKI80", "AQAAAAIAAYagAAAAEEUpnIbHFM1SLxNZBYYk8ptDWhzyLsLVySFqStokQ8D+TDxyE5V3ixDUZ3R8C0BBtg==", null, false, null, false, "Madisyn.Jakubowski80" },
                    { new Guid("b21f0a41-c1f8-423f-a9f5-12957a81be8f"), 0, "cd5c95b0-9815-4e4e-aea4-f0d643d72cc5", "Gilda97@hotmail.com", true, "Fausto Berge", false, null, "GILDA97@HOTMAIL.COM", "CANDIDO81", "AQAAAAIAAYagAAAAEGVBb1rkQIbHzYGE19L6P/Qpf27B4f+Wogadw4G24uHhMfPBU4IyIhSU2w+S876ugQ==", null, false, null, false, "Candido81" },
                    { new Guid("c08214e9-f074-4c40-8e76-4d28c4ff0636"), 0, "7ad01700-d02f-42b1-8f6d-8d3a061a5bb7", "Gay.Quitzon68@hotmail.com", true, "Leo Pfannerstill", false, null, "GAY.QUITZON68@HOTMAIL.COM", "TREVOR_RUSSEL", "AQAAAAIAAYagAAAAEDGuHZi/9PbDJhmJ4793eXyaLSpoLWPJuKXRLjDiFqFzlYkjwfq4nCpQReGEHau4DA==", null, false, null, false, "Trevor_Russel" },
                    { new Guid("ddd07fc2-5d35-4c34-8272-7396d1330ac7"), 0, "2d777692-7497-48a3-b758-cf294f7a8090", "Sherman_Witting2@gmail.com", true, "Jennie Okuneva", false, null, "SHERMAN_WITTING2@GMAIL.COM", "WELDON.CRONIN97", "AQAAAAIAAYagAAAAEMNUW6/GXosMQXfQN8/agBx3IuyonuwEqpEzCU72/7a2XkL/uzXPcMBI6vK1DgnRmA==", null, false, null, false, "Weldon.Cronin97" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "CopiesAvailable", "Title" },
                values: new object[,]
                {
                    { new Guid("175acd1d-44c9-4af4-9bc1-4db359145824"), "Eino Corwin", "Mystery", 20, "Exercitationem veniam ea." },
                    { new Guid("36d10b89-d2d3-4155-a2a8-a05ef497b258"), "Bertrand Kuhic", "Technology", 4, "Nulla laudantium voluptatem." },
                    { new Guid("3c4e5293-4226-40df-9f7c-01033eb1ba29"), "Berneice Herzog", "Technology", 2, "Est maxime iusto." },
                    { new Guid("697dec57-574f-4037-b1e6-a41fbf5b2e01"), "Deven Bashirian", "Technology", 11, "Minus accusamus aut." },
                    { new Guid("76921129-fdd2-4b90-b120-a03eb95db241"), "Gia Abshire", "History", 13, "Autem modi rerum." },
                    { new Guid("b4cd1db3-4a2c-48dd-901d-7b4c4df53d5b"), "Emerson Hyatt", "Science", 18, "Ullam voluptas distinctio." },
                    { new Guid("c04e84d9-0b7b-4511-89b1-5fbea306833f"), "Aurelia Mertz", "Fiction", 20, "Necessitatibus sit ut." },
                    { new Guid("e8d253bb-7af8-41e0-addd-a5988dec1ade"), "Arnulfo Braun", "Mystery", 14, "Debitis laboriosam nam." },
                    { new Guid("f09fd31f-efe0-4fe9-b886-d189df4039c7"), "Dana Veum", "Mystery", 14, "Velit quibusdam ut." },
                    { new Guid("f3134330-1fbc-44e0-a7c5-36f669875c0e"), "Aliza Altenwerth", "Science", 18, "Cupiditate in perferendis." }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), new Guid("18b951d5-2479-4216-badf-dae9b36ccfc3") },
                    { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), new Guid("5966de3f-86a4-4450-aeaf-f155b7d767c1") },
                    { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), new Guid("b21f0a41-c1f8-423f-a9f5-12957a81be8f") },
                    { new Guid("a748ea20-0c11-4d1f-b6da-0e1de0969005"), new Guid("c08214e9-f074-4c40-8e76-4d28c4ff0636") },
                    { new Guid("9d6979a7-56cc-48a0-b317-e7cd33547820"), new Guid("ddd07fc2-5d35-4c34-8272-7396d1330ac7") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), new Guid("18b951d5-2479-4216-badf-dae9b36ccfc3") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), new Guid("5966de3f-86a4-4450-aeaf-f155b7d767c1") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"), new Guid("b21f0a41-c1f8-423f-a9f5-12957a81be8f") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a748ea20-0c11-4d1f-b6da-0e1de0969005"), new Guid("c08214e9-f074-4c40-8e76-4d28c4ff0636") });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("9d6979a7-56cc-48a0-b317-e7cd33547820"), new Guid("ddd07fc2-5d35-4c34-8272-7396d1330ac7") });

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("175acd1d-44c9-4af4-9bc1-4db359145824"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("36d10b89-d2d3-4155-a2a8-a05ef497b258"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("3c4e5293-4226-40df-9f7c-01033eb1ba29"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("697dec57-574f-4037-b1e6-a41fbf5b2e01"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("76921129-fdd2-4b90-b120-a03eb95db241"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("b4cd1db3-4a2c-48dd-901d-7b4c4df53d5b"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("c04e84d9-0b7b-4511-89b1-5fbea306833f"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("e8d253bb-7af8-41e0-addd-a5988dec1ade"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f09fd31f-efe0-4fe9-b886-d189df4039c7"));

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: new Guid("f3134330-1fbc-44e0-a7c5-36f669875c0e"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("30c12e6a-0c9d-44c4-8863-3865400bc960"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("9d6979a7-56cc-48a0-b317-e7cd33547820"));

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("a748ea20-0c11-4d1f-b6da-0e1de0969005"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("18b951d5-2479-4216-badf-dae9b36ccfc3"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5966de3f-86a4-4450-aeaf-f155b7d767c1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b21f0a41-c1f8-423f-a9f5-12957a81be8f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c08214e9-f074-4c40-8e76-4d28c4ff0636"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ddd07fc2-5d35-4c34-8272-7396d1330ac7"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("4ea0a66a-e099-414d-9ba7-7871561a155a"), null, "User", "USER" },
                    { new Guid("741f750d-db0c-4944-bec7-5ebae26d0368"), null, "Admin", "ADMIN" },
                    { new Guid("c0523089-04a6-4de6-bccd-6a2f0e03467c"), null, "Librarian", "LIBRARIAN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("50c3ebb9-6536-4035-8dad-e351fdaebf29"), 0, "0b7f50f3-9ae0-4279-a1d9-3e150d12f3c9", "Paolo12@gmail.com", true, null, false, null, "PAOLO12@GMAIL.COM", "ANTONETTE.ROWE72", "AQAAAAIAAYagAAAAELnnDfhJNpd23vCNzSC3RXOy7Wxwlt85PDq/73S3rTvbUhOLhwWFHGCcUoM4ghy7fQ==", null, false, null, false, "Antonette.Rowe72" },
                    { new Guid("7e48540d-86ff-4921-88ad-ad71079ca66f"), 0, "cedd7a38-b6ee-4851-b9e3-4ce383eba6ec", "Gabe.Gerhold66@yahoo.com", true, null, false, null, "GABE.GERHOLD66@YAHOO.COM", "RYLEIGH.FRANECKI65", "AQAAAAIAAYagAAAAEOoj9zSB48yA+d4CJrU2Y0ZJ5tjAfHnDwYH2f4oZsXGqFsACkQmSYdVbnRLoUDM1Jg==", null, false, null, false, "Ryleigh.Franecki65" },
                    { new Guid("a70bbc64-883f-4be4-94ce-c8796489e392"), 0, "c791de26-2065-4130-b3c4-8ebd8c7bbcfb", "Jaquelin_Tremblay@hotmail.com", true, null, false, null, "JAQUELIN_TREMBLAY@HOTMAIL.COM", "CAROLINE.STOKES", "AQAAAAIAAYagAAAAEId5jZhSqYKZpHP5GkleaQetTHYihvMz9hhugET+R4z9LeTRf4vufo194p5SZYDEUg==", null, false, null, false, "Caroline.Stokes" },
                    { new Guid("e04f65a1-5666-40d5-9d8e-4005c5876bb8"), 0, "66f941db-1ead-4c93-885e-a3d6bfae00c0", "Brandt.Hoppe99@yahoo.com", true, null, false, null, "BRANDT.HOPPE99@YAHOO.COM", "RENE_GREENFELDER80", "AQAAAAIAAYagAAAAEPTLcLlew5KHZn3pv6LDXTtm+hVu36flHLo5y3PQ+F+KTQOG0T58ByscAPzZTHElzA==", null, false, null, false, "Rene_Greenfelder80" },
                    { new Guid("e78bc3a2-5db8-45b5-a946-2150885e9ecf"), 0, "860e15e6-fecd-414a-a975-5db0c8357f43", "Rupert_Thiel@hotmail.com", true, null, false, null, "RUPERT_THIEL@HOTMAIL.COM", "ALESSANDRO_KLEIN", "AQAAAAIAAYagAAAAEHwU1ugBQ+h+mA+4aZ/cDzqBIxAcl8JrmCJYhItPEDx6xG0gASaCp85x3ET+pF/x1w==", null, false, null, false, "Alessandro_Klein" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Category", "CopiesAvailable", "Title" },
                values: new object[,]
                {
                    { new Guid("18d66652-d0d6-47bd-b6dd-9bfe0fadbf5b"), "Maybell Schmeler", "Technology", 12, "Non voluptatibus soluta." },
                    { new Guid("2f5798e9-d5e2-4d9b-8285-deedf798f6bb"), "Jazmyne Hartmann", "Technology", 17, "Quibusdam in repudiandae." },
                    { new Guid("3b474960-5512-4974-9c1c-722fa2e3fdc8"), "Krystel Nikolaus", "Fiction", 15, "Minus dolorem facere." },
                    { new Guid("4b67e5da-856c-4e56-a022-6da6050166f4"), "Makayla Buckridge", "Fiction", 18, "Beatae ut voluptas." },
                    { new Guid("966edce6-22f5-47f4-9ff1-f1ee32ed999a"), "Effie Kunde", "Technology", 12, "Optio rerum amet." },
                    { new Guid("9bd5e1b2-779f-443d-b317-ee7fd30e3755"), "Elyse Rutherford", "Fiction", 14, "Vitae fugiat aliquid." },
                    { new Guid("cac1c49d-1003-4eb6-9077-21ff36588e45"), "Rebeca Morar", "Technology", 9, "Non qui mollitia." },
                    { new Guid("cb9f158b-c225-4a79-b9bc-6d3a57696da8"), "Alexandro Howe", "History", 14, "Libero cum tempore." },
                    { new Guid("fc3bd105-b9da-49d2-8db4-4902e4a169b0"), "Gay Mosciski", "Science", 17, "Illum explicabo aut." },
                    { new Guid("ffcf2d96-b1db-49b0-ab06-1dc6ac3d5956"), "Frederick Cummings", "Technology", 9, "Rem impedit reiciendis." }
                });
        }
    }
}
