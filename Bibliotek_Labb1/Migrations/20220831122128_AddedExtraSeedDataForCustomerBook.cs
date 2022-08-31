using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bibliotek_Labb1.Migrations
{
    public partial class AddedExtraSeedDataForCustomerBook : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookID", "BookBorrowed", "BookID", "BookReturned", "CustomerID" },
                values: new object[] { 1, new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2022, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "CustomerBooks",
                columns: new[] { "CustomerBookID", "BookBorrowed", "BookID", "BookReturned", "CustomerID" },
                values: new object[] { 2, new DateTime(2022, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CustomerBooks",
                keyColumn: "CustomerBookID",
                keyValue: 2);
        }
    }
}
