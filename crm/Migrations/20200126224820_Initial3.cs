using Microsoft.EntityFrameworkCore.Migrations;

namespace crm.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PatrientId",
                table: "Tests");

            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Tests",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PatientId",
                table: "Tests",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "PatrientId",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
