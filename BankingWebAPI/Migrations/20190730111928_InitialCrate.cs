using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BankingWebAPI.Migrations
{
    public partial class InitialCrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "BankAccount",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Holder = table.Column<string>(unicode: false, nullable: false),
            //        HolderDocument = table.Column<string>(unicode: false, nullable: false),
            //        PasswordHash = table.Column<string>(unicode: false, nullable: false),
            //        PasswordSalt = table.Column<string>(unicode: false, nullable: false),
            //        AllowsOverdraft = table.Column<bool>(nullable: false),
            //        UpdatedPosition = table.Column<decimal>(type: "decimal(18,2)", unicode: false, nullable: false),
            //        CreationDate = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_BankAccount", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Entry",
            //    columns: table => new
            //    {
            //        Id = table.Column<long>(nullable: false)
            //            .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
            //        Type = table.Column<int>(nullable: false),
            //        TransactionId = table.Column<string>(unicode: false, nullable: false),
            //        CounterPart = table.Column<long>(nullable: true),
            //        OccurenceDate = table.Column<DateTime>(type: "datetime", nullable: false, defaultValueSql: "(getdate())")
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Entry", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK__Entry__CounterPa__6FE99F9F",
            //            column: x => x.CounterPart,
            //            principalTable: "BankAccount",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Entry_CounterPart",
            //    table: "Entry",
            //    column: "CounterPart");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "BankAccount");
        }
    }
}
