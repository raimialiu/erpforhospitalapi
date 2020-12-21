using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations
{
    public partial class paq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ChangedLocationAt",
                table: "PatientQueue",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "isCurrent",
                table: "PatientQueue",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangedLocationAt",
                table: "PatientQueue");

            migrationBuilder.DropColumn(
                name: "isCurrent",
                table: "PatientQueue");
        }
    }
}
