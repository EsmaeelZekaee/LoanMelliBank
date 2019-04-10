using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanMelliBank.Migrations
{
    public partial class rename_IdentityCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentityNumber",
                table: "People",
                newName: "IdentityCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentityCode",
                table: "People",
                newName: "IdentityNumber");
        }
    }
}
