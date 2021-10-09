using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MascotasEnCasa.App.Persistencia.Migrations
{
    public partial class Inicial1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Veterinario_Licencia",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "HorasLaborales",
                table: "Personas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AuxVeterinarioId",
                table: "Pacientes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VeterinarioId",
                table: "Pacientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_AuxVeterinarioId",
                table: "Pacientes",
                column: "AuxVeterinarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Pacientes_VeterinarioId",
                table: "Pacientes",
                column: "VeterinarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Personas_AuxVeterinarioId",
                table: "Pacientes",
                column: "AuxVeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pacientes_Personas_VeterinarioId",
                table: "Pacientes",
                column: "VeterinarioId",
                principalTable: "Personas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Personas_AuxVeterinarioId",
                table: "Pacientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Pacientes_Personas_VeterinarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_AuxVeterinarioId",
                table: "Pacientes");

            migrationBuilder.DropIndex(
                name: "IX_Pacientes_VeterinarioId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "AuxVeterinarioId",
                table: "Pacientes");

            migrationBuilder.DropColumn(
                name: "VeterinarioId",
                table: "Pacientes");

            migrationBuilder.AlterColumn<int>(
                name: "Veterinario_Licencia",
                table: "Personas",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HorasLaborales",
                table: "Personas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
