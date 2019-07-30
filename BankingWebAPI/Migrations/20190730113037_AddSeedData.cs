using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace BankingWebAPI.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] {"Id", "Holder", "HolderDocument", "PasswordHash", "PasswordSalt", "AllowsOverdraft", "UpdatedPosition", "CreationDate" },
                values: new object[] {1, "Alan Turing", "123456789", "", "", true, 98741.66, "2002-12-21" }
                );
            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "Id", "Holder", "HolderDocument", "PasswordHash", "PasswordSalt", "AllowsOverdraft", "UpdatedPosition", "CreationDate" },
                values: new object[] {2, "Nikola Tesla", "987654321", "", "", false, 142526.58, "1987-03-31" }
                );
            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "Id", "Holder", "HolderDocument", "PasswordHash", "PasswordSalt", "AllowsOverdraft", "UpdatedPosition", "CreationDate" },
                values: new object[] {3, "Guido von Rossum", "123987456", "", "", true, 4415.89, "2011-10-30" }
                );
            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "Id", "Holder", "HolderDocument", "PasswordHash", "PasswordSalt", "AllowsOverdraft", "UpdatedPosition", "CreationDate" },
                values: new object[] {4, "Linus Torvalds", "456123987", "", "", false, 22.0, "1998-02-12" }
                );
            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "Id", "Holder", "HolderDocument", "PasswordHash", "PasswordSalt", "AllowsOverdraft", "UpdatedPosition", "CreationDate" },
                values: new object[] {5, "Andrew Tanenbaum", "789654123", "", "", true, 415.21, "2010-06-27" }
                );
            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "Id", "Holder", "HolderDocument", "PasswordHash", "PasswordSalt", "AllowsOverdraft", "UpdatedPosition", "CreationDate" },
                values: new object[] {6, "Ken Thompson", "321456987", "", "", false, 4456.11, "2019-04-01" }
                );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "Id",
                keyValue: 1
                );
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "Id",
                keyValue: 2
                );
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "Id",
                keyValue: 3
                );
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "Id",
                keyValue: 4
                );
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "Id",
                keyValue: 5
                );
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "Id",
                keyValue: 6
                );
        }
    }
}
