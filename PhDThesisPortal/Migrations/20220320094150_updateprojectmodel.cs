using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PhDThesisPortal.Migrations
{
    public partial class updateprojectmodel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_AspNetUsers_MyIdentityUserId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Faculties_FacultyId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_MyIdentityUserId",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "MyIdentityUserId",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Project",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Project",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Project_Id",
                table: "Project",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_AspNetUsers_Id",
                table: "Project",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Faculties_FacultyId",
                table: "Project",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Project_AspNetUsers_Id",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Faculties_FacultyId",
                table: "Project");

            migrationBuilder.DropIndex(
                name: "IX_Project_Id",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Project");

            migrationBuilder.AlterColumn<int>(
                name: "FacultyId",
                table: "Project",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MyIdentityUserId",
                table: "Project",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Project_MyIdentityUserId",
                table: "Project",
                column: "MyIdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Project_AspNetUsers_MyIdentityUserId",
                table: "Project",
                column: "MyIdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Faculties_FacultyId",
                table: "Project",
                column: "FacultyId",
                principalTable: "Faculties",
                principalColumn: "FacultyId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
