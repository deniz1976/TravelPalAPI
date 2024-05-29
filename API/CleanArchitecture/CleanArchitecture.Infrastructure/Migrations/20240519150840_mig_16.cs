using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_16 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "TravelRoutes");

            migrationBuilder.DropColumn(
                name: "IsTransportVehicleExist",
                table: "TravelRoutes");

            migrationBuilder.AddColumn<string>(
                name: "TransportVehicle",
                table: "TravelRoutes",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "TravelRoutes",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransportVehicle",
                table: "TravelRoutes");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "TravelRoutes");

            migrationBuilder.AddColumn<double>(
                name: "Budget",
                table: "TravelRoutes",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsTransportVehicleExist",
                table: "TravelRoutes",
                type: "boolean",
                nullable: true);
        }
    }
}
