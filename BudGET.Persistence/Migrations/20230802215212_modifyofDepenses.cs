using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BudGET.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class modifyofDepenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depenses_Comptes_CompteId",
                table: "Depenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaires_Comptes_CompteId",
                table: "Salaires");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompteId",
                table: "Salaires",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CompteId",
                table: "Depenses",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Prevu",
                table: "Depenses",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddForeignKey(
                name: "FK_Depenses_Comptes_CompteId",
                table: "Depenses",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Salaires_Comptes_CompteId",
                table: "Salaires",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Depenses_Comptes_CompteId",
                table: "Depenses");

            migrationBuilder.DropForeignKey(
                name: "FK_Salaires_Comptes_CompteId",
                table: "Salaires");

            migrationBuilder.DropColumn(
                name: "Prevu",
                table: "Depenses");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompteId",
                table: "Salaires",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AlterColumn<Guid>(
                name: "CompteId",
                table: "Depenses",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uuid");

            migrationBuilder.AddForeignKey(
                name: "FK_Depenses_Comptes_CompteId",
                table: "Depenses",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Salaires_Comptes_CompteId",
                table: "Salaires",
                column: "CompteId",
                principalTable: "Comptes",
                principalColumn: "Id");
        }
    }
}
