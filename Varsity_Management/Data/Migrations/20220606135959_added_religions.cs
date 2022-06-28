using Microsoft.EntityFrameworkCore.Migrations;

namespace Varsity_Management.Data.Migrations
{
    public partial class added_religions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Religions",
                table: "Students",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "Religions",
                table: "Students",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
