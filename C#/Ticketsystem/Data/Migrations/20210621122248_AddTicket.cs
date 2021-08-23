using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace Ticketsystem.Data.Migrations
{
    public partial class AddTicket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_AspNetUsers_CustomerId1",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Progress_ProgressId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "ProgressId",
                table: "Tickets",
                newName: "ProgressID");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ProgressId",
                table: "Tickets",
                newName: "IX_Tickets_ProgressID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(2000)",
                maxLength: 2000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 200000,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId1",
                table: "Tickets",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Tickets",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Customer_CustomerId1",
                table: "Tickets",
                column: "CustomerId1",
                principalTable: "Customer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Progress_ProgressID",
                table: "Tickets",
                column: "ProgressID",
                principalTable: "Progress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Customer_CustomerId1",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Progress_ProgressID",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "ProgressID",
                table: "Tickets",
                newName: "ProgressId");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ProgressID",
                table: "Tickets",
                newName: "IX_Tickets_ProgressId");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(max)",
                maxLength: 200000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(2000)",
                oldMaxLength: 2000,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerId1",
                table: "Tickets",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_AspNetUsers_CustomerId1",
                table: "Tickets",
                column: "CustomerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Progress_ProgressId",
                table: "Tickets",
                column: "ProgressId",
                principalTable: "Progress",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
