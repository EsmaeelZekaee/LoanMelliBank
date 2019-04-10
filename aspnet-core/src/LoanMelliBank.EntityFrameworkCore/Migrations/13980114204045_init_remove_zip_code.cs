using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMelliBank.Migrations
{
    public partial class init_remove_zip_code : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "People");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "People",
                nullable: true);
        }
    }
}
