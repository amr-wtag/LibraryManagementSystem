using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LibraryManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class Convert_CopiesAvailable_ToInt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // 1. Add a temporary column (REQUIRED for data migration)
            migrationBuilder.AddColumn<int>(
                name: "CopiesAvailable_temp",
                table: "Books",
                type: "int",
                nullable: true); // Allow nulls temporarily

            // 2. Migrate the data, setting NULLs to 0
            migrationBuilder.Sql(@"
    UPDATE ""Books""
    SET ""CopiesAvailable_temp"" = COALESCE(NULLIF(""CopiesAvailable"", '')::INTEGER, 0);
");


            // 3. Drop the old CopiesAvailable column
            migrationBuilder.DropColumn(
                name: "CopiesAvailable",
                table: "Books");

            // 4. Rename the temporary column
            migrationBuilder.RenameColumn(
                name: "CopiesAvailable_temp",
                table: "Books",
                newName: "CopiesAvailable");
            // 5. Make the CopiesAvailable column NOT NULL (now safe because all values are 0 or valid integers)
            migrationBuilder.AlterColumn<int>(
                name: "CopiesAvailable",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0); // Important: Same default as in SQL.  This is technically redundant because the SQL already sets the default, but it's good practice.
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Revert (more complex - see explanation below)
            migrationBuilder.DropColumn(
                name: "CopiesAvailable",
                table: "Books");

            migrationBuilder.AddColumn<string>(
                name: "CopiesAvailable",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true); // Revert to original type and nullability
        }
    }
}
