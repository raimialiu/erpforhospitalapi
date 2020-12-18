using Microsoft.EntityFrameworkCore.Migrations;

namespace medicloud.emr.api.Migrations
{
    public partial class proc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaRequest_Diagnosis",
                table: "PaRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PaRequest_Procedure",
                table: "PaRequest");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "PaRequest",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DiagnosisId",
                table: "PaRequest",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisCode",
                table: "PaRequest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DiagnosisDesc",
                table: "PaRequest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EnrolleeNumber",
                table: "PaRequest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcedureCode",
                table: "PaRequest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProcedureDesc",
                table: "PaRequest",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PaRequest_diagnosis_DiagnosisId",
                table: "PaRequest",
                column: "DiagnosisId",
                principalTable: "diagnosis",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaRequest_procedure_ProcedureId",
                table: "PaRequest",
                column: "ProcedureId",
                principalTable: "procedure",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaRequest_diagnosis_DiagnosisId",
                table: "PaRequest");

            migrationBuilder.DropForeignKey(
                name: "FK_PaRequest_procedure_ProcedureId",
                table: "PaRequest");

            migrationBuilder.DropColumn(
                name: "DiagnosisCode",
                table: "PaRequest");

            migrationBuilder.DropColumn(
                name: "DiagnosisDesc",
                table: "PaRequest");

            migrationBuilder.DropColumn(
                name: "EnrolleeNumber",
                table: "PaRequest");

            migrationBuilder.DropColumn(
                name: "ProcedureCode",
                table: "PaRequest");

            migrationBuilder.DropColumn(
                name: "ProcedureDesc",
                table: "PaRequest");

            migrationBuilder.AlterColumn<int>(
                name: "ProcedureId",
                table: "PaRequest",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DiagnosisId",
                table: "PaRequest",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_PaRequest_Diagnosis",
                table: "PaRequest",
                column: "DiagnosisId",
                principalTable: "diagnosis",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PaRequest_Procedure",
                table: "PaRequest",
                column: "ProcedureId",
                principalTable: "procedure",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
