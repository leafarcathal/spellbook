using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Spellbook.Migrations
{
    public partial class UpdateAllTablesAndCreatePaymentLogAndPaymentTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "User_group_id",
                table: "User",
                newName: "User_Group_Id");

            migrationBuilder.RenameColumn(
                name: "UserGroupId",
                table: "Permission",
                newName: "User_Group_Id");

            migrationBuilder.RenameColumn(
                name: "CardToken",
                table: "PaymentMethod",
                newName: "Card_Token");

            migrationBuilder.RenameColumn(
                name: "CardEnding",
                table: "PaymentMethod",
                newName: "Card_Ending");

            migrationBuilder.RenameColumn(
                name: "CardBin",
                table: "PaymentMethod",
                newName: "Card_Bin");

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bill_Id = table.Column<int>(type: "int", nullable: false),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    User_Id = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Payment_Method_Id = table.Column<int>(type: "int", nullable: false),
                    Payment_Token = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_Api_Response = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Payment_Type = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentLog",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payment_Id = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Created_at = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentLog", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "PaymentLog");

            migrationBuilder.RenameColumn(
                name: "User_Group_Id",
                table: "User",
                newName: "User_group_id");

            migrationBuilder.RenameColumn(
                name: "User_Group_Id",
                table: "Permission",
                newName: "UserGroupId");

            migrationBuilder.RenameColumn(
                name: "Card_Token",
                table: "PaymentMethod",
                newName: "CardToken");

            migrationBuilder.RenameColumn(
                name: "Card_Ending",
                table: "PaymentMethod",
                newName: "CardEnding");

            migrationBuilder.RenameColumn(
                name: "Card_Bin",
                table: "PaymentMethod",
                newName: "CardBin");
        }
    }
}
