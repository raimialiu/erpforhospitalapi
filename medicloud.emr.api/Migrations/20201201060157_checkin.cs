using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations
{
    public partial class checkin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CheckIn",
                columns: table => new
                {
                    encounterId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Patientid = table.Column<string>(nullable: true),
                    Accountid = table.Column<int>(nullable: false),
                    Locationid = table.Column<int>(nullable: false),
                    ischeckedin = table.Column<bool>(type: "bit", nullable: false),
                    ischeckedout = table.Column<bool>(type: "bit", nullable: false),
                    checkindate = table.Column<DateTime>(type: "datetime", nullable: false),
                    checkoutdate = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Checke__3A71E2D82A4295FC", x => x.encounterId);
                    table.ForeignKey(
                        name: "FK_CheckIn_Patient_Account",
                        column: x => x.Accountid,
                        principalTable: "AccountManager",
                        principalColumn: "ProviderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIn_Location",
                        column: x => x.Locationid,
                        principalTable: "Location",
                        principalColumn: "locationid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CheckIn_Patient",
                        column: x => x.Patientid,
                        principalTable: "Patient",
                        principalColumn: "patientid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_Accountid",
                table: "CheckIn",
                column: "Accountid");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_Locationid",
                table: "CheckIn",
                column: "Locationid");

            migrationBuilder.CreateIndex(
                name: "IX_CheckIn_Patientid",
                table: "CheckIn",
                column: "Patientid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CheckIn");
        }
    }
}
