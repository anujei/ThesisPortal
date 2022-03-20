using Microsoft.EntityFrameworkCore.Migrations;

namespace PhDThesisPortal.Migrations
{
    public partial class changesadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StudentEnrollmentId",
                table: "AspNetUsers",
                newName: "EnrollmentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EnrollmentId",
                table: "AspNetUsers",
                newName: "StudentEnrollmentId");
        }
    }
}
