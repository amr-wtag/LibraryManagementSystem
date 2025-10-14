using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LibraryManagementAPI.Migrations;

public partial class RenameTransactionsToBookReservations : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameTable(
            name: "Transactions",
            newName: "BookReservations"
        );
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.RenameTable(
            name: "BookReservations",
            newName: "Transactions"
        );
    }
}
