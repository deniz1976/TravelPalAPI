using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_regularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoute_SecondPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoute_ThirdPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "FirstPlaceForRoute");

            migrationBuilder.RenameColumn(
                name: "regularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_regularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_RegularOpeningHoursId");

            migrationBuilder.AddColumn<Guid>(
                name: "SecondPlaceForRouteId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ThirdPlaceForRouteId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "curbsidePickup",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "delivery",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForGroups",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "liveMusic",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "menuForChildren",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "outdoorSeating",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "reservable",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBeer",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBrunch",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesCocktails",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesVegetarianFood",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesWine",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shortFormattedAddress",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "takeout",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SecondPlaceForRoute",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    nationalPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    formattedAddress = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: true),
                    rating = table.Column<double>(type: "double precision", nullable: true),
                    googleMapsUri = table.Column<string>(type: "text", nullable: true),
                    websiteUri = table.Column<string>(type: "text", nullable: true),
                    regularOpeningHoursId = table.Column<Guid>(type: "uuid", nullable: true),
                    displayNameId = table.Column<Guid>(type: "uuid", nullable: true),
                    goodForChildren = table.Column<bool>(type: "boolean", nullable: true),
                    restroom = table.Column<bool>(type: "boolean", nullable: true),
                    _PRICE_LEVEL = table.Column<int>(type: "integer", nullable: true),
                    primaryType = table.Column<string>(type: "text", nullable: true),
                    googleId = table.Column<string>(type: "text", nullable: true),
                    paymentOptionsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondPlaceForRoute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondPlaceForRoute_DisplayName_displayNameId",
                        column: x => x.displayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SecondPlaceForRoute_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SecondPlaceForRoute_PaymentOptions_paymentOptionsId",
                        column: x => x.paymentOptionsId,
                        principalTable: "PaymentOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SecondPlaceForRoute_RegularOpeningHours_regularOpeningHours~",
                        column: x => x.regularOpeningHoursId,
                        principalTable: "RegularOpeningHours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThirdPlaceForRoute",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    nationalPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    formattedAddress = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: true),
                    rating = table.Column<double>(type: "double precision", nullable: true),
                    googleMapsUri = table.Column<string>(type: "text", nullable: true),
                    websiteUri = table.Column<string>(type: "text", nullable: true),
                    regularOpeningHoursId = table.Column<Guid>(type: "uuid", nullable: true),
                    displayNameId = table.Column<Guid>(type: "uuid", nullable: true),
                    goodForChildren = table.Column<bool>(type: "boolean", nullable: true),
                    restroom = table.Column<bool>(type: "boolean", nullable: true),
                    _PRICE_LEVEL = table.Column<int>(type: "integer", nullable: true),
                    primaryType = table.Column<string>(type: "text", nullable: true),
                    googleId = table.Column<string>(type: "text", nullable: true),
                    paymentOptionsId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThirdPlaceForRoute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThirdPlaceForRoute_DisplayName_displayNameId",
                        column: x => x.displayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThirdPlaceForRoute_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThirdPlaceForRoute_PaymentOptions_paymentOptionsId",
                        column: x => x.paymentOptionsId,
                        principalTable: "PaymentOptions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThirdPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
                        column: x => x.regularOpeningHoursId,
                        principalTable: "RegularOpeningHours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SecondPlaceForRouteId",
                table: "Photos",
                column: "SecondPlaceForRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ThirdPlaceForRouteId",
                table: "Photos",
                column: "ThirdPlaceForRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_displayNameId",
                table: "SecondPlaceForRoute",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_LocationId",
                table: "SecondPlaceForRoute",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_paymentOptionsId",
                table: "SecondPlaceForRoute",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_regularOpeningHoursId",
                table: "SecondPlaceForRoute",
                column: "regularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_displayNameId",
                table: "ThirdPlaceForRoute",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_LocationId",
                table: "ThirdPlaceForRoute",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_paymentOptionsId",
                table: "ThirdPlaceForRoute",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_regularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                column: "regularOpeningHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinner",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_SecondPlaceForRoute_SecondPlaceForRouteId",
                table: "Photos",
                column: "SecondPlaceForRouteId",
                principalTable: "SecondPlaceForRoute",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_ThirdPlaceForRoute_ThirdPlaceForRouteId",
                table: "Photos",
                column: "ThirdPlaceForRouteId",
                principalTable: "ThirdPlaceForRoute",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_SecondPlaceForRoute_SecondPlaceForRouteId",
                table: "TravelRoutes",
                column: "SecondPlaceForRouteId",
                principalTable: "SecondPlaceForRoute",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_ThirdPlaceForRoute_ThirdPlaceForRouteId",
                table: "TravelRoutes",
                column: "ThirdPlaceForRouteId",
                principalTable: "ThirdPlaceForRoute",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_SecondPlaceForRoute_SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_ThirdPlaceForRoute_ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_SecondPlaceForRoute_SecondPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_ThirdPlaceForRoute_ThirdPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropTable(
                name: "SecondPlaceForRoute");

            migrationBuilder.DropTable(
                name: "ThirdPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_Photos_SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "curbsidePickup",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "delivery",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "goodForGroups",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "liveMusic",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "menuForChildren",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "outdoorSeating",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "reservable",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "servesBeer",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "servesBrunch",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "servesCocktails",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "servesVegetarianFood",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "servesWine",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "shortFormattedAddress",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "takeout",
                table: "EventAfterDinner");

            migrationBuilder.RenameColumn(
                name: "RegularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_RegularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_regularOpeningHoursId");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_regularOpeningHoursId",
                table: "EventAfterDinner",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoute_SecondPlaceForRouteId",
                table: "TravelRoutes",
                column: "SecondPlaceForRouteId",
                principalTable: "FirstPlaceForRoute",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoute_ThirdPlaceForRouteId",
                table: "TravelRoutes",
                column: "ThirdPlaceForRouteId",
                principalTable: "FirstPlaceForRoute",
                principalColumn: "Id");
        }
    }
}
