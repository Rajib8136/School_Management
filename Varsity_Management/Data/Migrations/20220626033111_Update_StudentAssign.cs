using Microsoft.EntityFrameworkCore.Migrations;

namespace Varsity_Management.Data.Migrations
{
    public partial class Update_StudentAssign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentResults_Students_StudentId",
                table: "StudentResults");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentResults",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "classManagementId",
                table: "StudentResults",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_StudentResults_classManagementId",
                table: "StudentResults",
                column: "classManagementId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResults_Students_StudentId",
                table: "StudentResults",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResults_Class_Managements_classManagementId",
                table: "StudentResults",
                column: "classManagementId",
                principalTable: "Class_Managements",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentResults_Students_StudentId",
                table: "StudentResults");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentResults_Class_Managements_classManagementId",
                table: "StudentResults");

            migrationBuilder.DropIndex(
                name: "IX_StudentResults_classManagementId",
                table: "StudentResults");

            migrationBuilder.DropColumn(
                name: "classManagementId",
                table: "StudentResults");

            migrationBuilder.AlterColumn<int>(
                name: "StudentId",
                table: "StudentResults",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentResults_Students_StudentId",
                table: "StudentResults",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
