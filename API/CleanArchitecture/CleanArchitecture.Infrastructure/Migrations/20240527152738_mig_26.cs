using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PrimaryTypeDisplayName",
                table: "PrimaryTypeDisplayName");

            migrationBuilder.RenameTable(
                name: "PrimaryTypeDisplayName",
                newName: "PrimaryTypeDisplayNames");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrimaryTypeDisplayNames",
                table: "PrimaryTypeDisplayNames",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_PrimaryTypeDisplayNames",
                table: "PrimaryTypeDisplayNames");

            migrationBuilder.RenameTable(
                name: "PrimaryTypeDisplayNames",
                newName: "PrimaryTypeDisplayName");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PrimaryTypeDisplayName",
                table: "PrimaryTypeDisplayName",
                column: "Id");
        }
    }
}
