using Microsoft.EntityFrameworkCore.Migrations;

namespace Varsity_Management.Data.Migrations
{
    public partial class added_studentresult : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asigns_Students_StudentId",
                table: "asigns");

            migrationBuilder.DropForeignKey(
                name: "FK_asigns_Class_Managements_class_ManagementId",
                table: "asigns");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentResults_exams_ExamId",
                table: "StudentResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_exams",
                table: "exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_asigns",
                table: "asigns");

            migrationBuilder.RenameTable(
                name: "exams",
                newName: "Exams");

            migrationBuilder.RenameTable(
                name: "asigns",
                newName: "Asigns");

            migrationBuilder.RenameColumn(
                name: "session",
                table: "Exams",
                newName: "Session");

            migrationBuilder.RenameColumn(
                name: "grade",
                table: "Exams",
                newName: "Grade");

            migrationBuilder.RenameIndex(
                name: "IX_asigns_class_ManagementId",
                table: "Asigns",
                newName: "IX_Asigns_class_ManagementId");

            migrationBuilder.RenameIndex(
                name: "IX_asigns_StudentId",
                table: "Asigns",
                newName: "IX_Asigns_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Asigns",
                table: "Asigns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Asigns_Students_StudentId",
                table: "Asigns",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Asigns_Class_Managements_class_ManagementId",
                table: "Asigns",
                column: "class_ManagementId",
                principalTable: "Class_Managements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResults_Exams_ExamId",
                table: "StudentResults",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Asigns_Students_StudentId",
                table: "Asigns");

            migrationBuilder.DropForeignKey(
                name: "FK_Asigns_Class_Managements_class_ManagementId",
                table: "Asigns");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentResults_Exams_ExamId",
                table: "StudentResults");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Asigns",
                table: "Asigns");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "exams");

            migrationBuilder.RenameTable(
                name: "Asigns",
                newName: "asigns");

            migrationBuilder.RenameColumn(
                name: "Session",
                table: "exams",
                newName: "session");

            migrationBuilder.RenameColumn(
                name: "Grade",
                table: "exams",
                newName: "grade");

            migrationBuilder.RenameIndex(
                name: "IX_Asigns_class_ManagementId",
                table: "asigns",
                newName: "IX_asigns_class_ManagementId");

            migrationBuilder.RenameIndex(
                name: "IX_Asigns_StudentId",
                table: "asigns",
                newName: "IX_asigns_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_exams",
                table: "exams",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_asigns",
                table: "asigns",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_asigns_Students_StudentId",
                table: "asigns",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asigns_Class_Managements_class_ManagementId",
                table: "asigns",
                column: "class_ManagementId",
                principalTable: "Class_Managements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResults_exams_ExamId",
                table: "StudentResults",
                column: "ExamId",
                principalTable: "exams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
