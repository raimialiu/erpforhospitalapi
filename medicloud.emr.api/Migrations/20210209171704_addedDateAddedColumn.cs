using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations
{
    public partial class addedDateAddedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "dateadded",
                table: "PatientUpload",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ordertypename",
                table: "PatientUpload",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dateadded",
                table: "PatientUpload");

            migrationBuilder.DropColumn(
                name: "ordertypename",
                table: "PatientUpload");
        }
    }
}
