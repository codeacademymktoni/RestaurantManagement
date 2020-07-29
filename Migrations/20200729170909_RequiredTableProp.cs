using Microsoft.EntityFrameworkCore.Migrations;

namespace RestorantManagement.Migrations
{
    public partial class RequiredTableProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TableName",
                table: "Tables",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TableName",
                table: "Tables",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
