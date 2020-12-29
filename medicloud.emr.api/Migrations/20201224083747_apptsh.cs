using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations
{
    public partial class apptsh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK__Appointme__patie__308412F8",
                table: "AppointmentSchedule",
                column: "patientNumber",
                principalTable: "Patient",
                principalColumn: "patientid",
                onDelete: ReferentialAction.Restrict);

            
        }
    }
}
