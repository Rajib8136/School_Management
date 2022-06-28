using Microsoft.EntityFrameworkCore.Migrations;

namespace Varsity_Management.Data.Migrations
{
    public partial class Added_asigns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "asigns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClassId = table.Column<int>(nullable: false),
                    class_ManagementId = table.Column<int>(nullable: true),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_asigns_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_asigns_Class_Managements_class_ManagementId",
                        column: x => x.class_ManagementId,
                        principalTable: "Class_Managements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_asigns_StudentId",
                table: "asigns",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_asigns_class_ManagementId",
                table: "asigns",
                column: "class_ManagementId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "asigns");
        }
    }
}
