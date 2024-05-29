using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "TravelRoutes",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelRoutes_ApplicationUserId",
                table: "TravelRoutes",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_AspNetUsers_ApplicationUserId",
                table: "TravelRoutes",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_AspNetUsers_ApplicationUserId",
                table: "TravelRoutes");

            migrationBuilder.DropIndex(
                name: "IX_TravelRoutes_ApplicationUserId",
                table: "TravelRoutes");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "TravelRoutes");
        }
    }
}
