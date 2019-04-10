using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMelliBank.Migrations
{
    public partial class rename_IdentityCode1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "Guarantors",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "Guarantors");
        }
    }
}
