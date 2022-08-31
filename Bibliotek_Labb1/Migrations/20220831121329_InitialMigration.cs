using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Bibliotek_Labb1.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    IsOnLoan = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 50, nullable: false),
                    Adress = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: false),
                    ZipCode = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "CustomerBooks",
                columns: table => new
                {
                    CustomerBookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(nullable: false),
                    BookID = table.Column<int>(nullable: false),
                    BookBorrowed = table.Column<DateTime>(nullable: false),
                    BookReturned = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerBooks", x => x.CustomerBookID);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Books_BookID",
                        column: x => x.BookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerBooks_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "Author", "BookName", "IsOnLoan" },
                values: new object[,]
                {
                    { 1, "J.R.R. Tolkien", "The Hobbit", true },
                    { 2, "J.R.R. Tolkien", "The Fellowship of the Ring", true },
                    { 3, "J.R.R. Tolkien", "The Two Towers", false },
                    { 4, "J.R.R. Tolkien", "The Return of the King", true },
                    { 5, "Harper Lee", "To Kill A Mockingbird", false },
                    { 6, "F.Scott Fitzgerald", "The Great Gatsby", false },
                    { 7, "Charles Dickens", "Oliver Twist", true },
                    { 8, "Mary Shelley", "Frankenstein", false },
                    { 9, "Emily Brönte", "Wuthering Heights", false },
                    { 10, "Heman Melville", "Moby Dick", true },
                    { 11, "Toni Morrison", "Song of Solomon", false }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerID", "Adress", "City", "Email", "FullName", "PhoneNumber", "ZipCode" },
                values: new object[,]
                {
                    { 1, "Skamman 13", "Varberg", "HannaH@gmail.com", "Hanna Lahtinen", null, "43246" },
                    { 2, "Storgatan 6", "Varberg", "J.Gergi@gmail.com", "Jennifer Gergi", null, "43246" },
                    { 3, "Varberg", "Storgatan 2", "Winborg.98@hotmail.com", "Markus Winborg", null, "43246" },
                    { 4, "Skammerhult 16", "Nösslinge", "SofiaKarlsson98@gmail.com", "Sofia Karlsson", "0738428987", "43299" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_BookID",
                table: "CustomerBooks",
                column: "BookID");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerBooks_CustomerID",
                table: "CustomerBooks",
                column: "CustomerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
