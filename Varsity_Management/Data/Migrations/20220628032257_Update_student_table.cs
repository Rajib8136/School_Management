using Microsoft.EntityFrameworkCore.Migrations;

namespace Varsity_Management.Data.Migrations
{
    public partial class Update_student_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Class_managementId",
                table: "Students",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Students_Class_managementId",
                table: "Students",
                column: "Class_managementId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Class_Managements_Class_managementId",
                table: "Students",
                column: "Class_managementId",
                principalTable: "Class_Managements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Class_Managements_Class_managementId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_Class_managementId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Class_managementId",
                table: "Students");
        }
    }
}
