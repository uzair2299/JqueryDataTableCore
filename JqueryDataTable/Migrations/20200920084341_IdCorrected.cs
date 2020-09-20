using Microsoft.EntityFrameworkCore.Migrations;

namespace JqueryDataTable.Migrations
{
    public partial class IdCorrected : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "iD",
                table: "Customers",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "iD");
        }
    }
}
