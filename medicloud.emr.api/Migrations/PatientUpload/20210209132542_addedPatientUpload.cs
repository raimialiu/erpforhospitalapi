using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations.PatientUpload
{
    public partial class addedPatientUpload : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PatientUpload",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    patientid = table.Column<string>(nullable: true),
                    uploadtype = table.Column<string>(nullable: true),
                    filename = table.Column<string>(nullable: true),
                    fileitem = table.Column<string>(nullable: true),
                    filetype = table.Column<string>(nullable: true),
                    filesize = table.Column<string>(nullable: true),
                    adjusterid = table.Column<int>(nullable: true),
                    encounterId = table.Column<int>(nullable: true),
                    providerId = table.Column<int>(nullable: true),
                    locationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientUpload", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PatientUpload");
        }
    }
}
