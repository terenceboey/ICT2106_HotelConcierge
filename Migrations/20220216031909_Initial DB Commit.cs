using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace _2106_Project.Migrations
{
    public partial class InitialDBCommit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Staffs");

            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "Guests");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Guests");

            migrationBuilder.RenameColumn(
                name: "AccountStatus",
                table: "Staffs",
                newName: "account_id1");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Guests",
                newName: "account_id1");

            migrationBuilder.AlterColumn<string>(
                name: "hotel_id",
                table: "Staffs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Staffs",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    account_id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true),
                    AccountStatus = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.account_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Staffs_account_id1",
                table: "Staffs",
                column: "account_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Guests_account_id1",
                table: "Guests",
                column: "account_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_Guests_Accounts_account_id1",
                table: "Guests",
                column: "account_id1",
                principalTable: "Accounts",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Staffs_Accounts_account_id1",
                table: "Staffs",
                column: "account_id1",
                principalTable: "Accounts",
                principalColumn: "account_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Guests_Accounts_account_id1",
                table: "Guests");

            migrationBuilder.DropForeignKey(
                name: "FK_Staffs_Accounts_account_id1",
                table: "Staffs");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropIndex(
                name: "IX_Staffs_account_id1",
                table: "Staffs");

            migrationBuilder.DropIndex(
                name: "IX_Guests_account_id1",
                table: "Guests");

            migrationBuilder.RenameColumn(
                name: "account_id1",
                table: "Staffs",
                newName: "AccountStatus");

            migrationBuilder.RenameColumn(
                name: "account_id1",
                table: "Guests",
                newName: "Password");

            migrationBuilder.AlterColumn<int>(
                name: "hotel_id",
                table: "Staffs",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Staffs",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Staffs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Staffs",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                table: "Guests",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Guests",
                type: "TEXT",
                nullable: true);
        }
    }
}
