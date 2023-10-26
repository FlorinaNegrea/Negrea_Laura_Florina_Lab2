using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Negrea_Laura_Florina_Lab2.Migrations
{
    public partial class ResetCategory2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DBCC CHECKIDENT ('Category', RESEED, 0)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
