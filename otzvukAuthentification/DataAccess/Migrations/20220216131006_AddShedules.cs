using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddShedules : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql($"INSERT INTO Shedules (Name, Description) VALUES ('Monday','10-13')");
            migrationBuilder.Sql($"INSERT INTO Shedules (Name, Description) VALUES ('Friday','12-13')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
