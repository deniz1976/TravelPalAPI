using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_travel_entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OtelId",
                table: "TravelRoutes",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "ThirdPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "ThirdPlaceForRoute",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "ThirdPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "ThirdPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForChildren",
                table: "ThirdPlaceForRoute",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "ThirdPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "ThirdPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "ThirdPlaceForRoute",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "ThirdPlaceForRoute",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "ThirdPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "SecondPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "SecondPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "SecondPlaceForRoute",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "SecondPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "SecondPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForChildren",
                table: "SecondPlaceForRoute",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "SecondPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "SecondPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "SecondPlaceForRoute",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "SecondPlaceForRoute",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "SecondPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Lunch",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "Lunch",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "Lunch",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "Lunch",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForGroups",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "liveMusic",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "menuForChildren",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "outdoorSeating",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "Lunch",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "Lunch",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "reservable",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBeer",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBrunch",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesVegetarianFood",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesWine",
                table: "Lunch",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shortFormattedAddress",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "FirstPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "FirstPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "FirstPlaceForRoute",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "FirstPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForChildren",
                table: "FirstPlaceForRoute",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "FirstPlaceForRoute",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "FirstPlaceForRoute",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "EventAfterDinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "EventAfterDinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "EventAfterDinner",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "EventAfterDinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForChildren",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "EventAfterDinner",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "EventAfterDinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Dinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "Dinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "Dinner",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "Dinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForGroups",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "liveMusic",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "menuForChildren",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "outdoorSeating",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "Dinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "Dinner",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "reservable",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBeer",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBrunch",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesVegetarianFood",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesWine",
                table: "Dinner",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shortFormattedAddress",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LocationId",
                table: "Breakfast",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RegularOpeningHoursId",
                table: "Breakfast",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_PRICE_LEVEL",
                table: "Breakfast",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "displayNameId",
                table: "Breakfast",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "formattedAddress",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "goodForGroups",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "googleMapsUri",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "liveMusic",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "menuForChildren",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nationalPhoneNumber",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "outdoorSeating",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "Breakfast",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "rating",
                table: "Breakfast",
                type: "double precision",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "reservable",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "restroom",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesBrunch",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "servesVegetarianFood",
                table: "Breakfast",
                type: "boolean",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "shortFormattedAddress",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "websiteUri",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Close",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    day = table.Column<int>(type: "integer", nullable: false),
                    hour = table.Column<int>(type: "integer", nullable: false),
                    minute = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Close", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DisplayName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    text = table.Column<string>(type: "text", nullable: true),
                    langugageCode = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisplayName", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Location",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    latitude = table.Column<double>(type: "double precision", nullable: false),
                    longitude = table.Column<double>(type: "double precision", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Location", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Open",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    day = table.Column<int>(type: "integer", nullable: false),
                    hour = table.Column<int>(type: "integer", nullable: false),
                    minute = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Open", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentOptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    acceptsCreditCards = table.Column<string>(type: "text", nullable: true),
                    acceptsDebitCards = table.Column<string>(type: "text", nullable: true),
                    acceptsCashOnly = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentOptions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RegularOpeningHours",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    openNow = table.Column<bool>(type: "boolean", nullable: false),
                    weekdayDescriptions = table.Column<List<string>>(type: "text[]", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegularOpeningHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Period",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    openId = table.Column<Guid>(type: "uuid", nullable: true),
                    closeId = table.Column<Guid>(type: "uuid", nullable: true),
                    RegularOpeningHoursId = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Period", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Period_Close_closeId",
                        column: x => x.closeId,
                        principalTable: "Close",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Period_Open_openId",
                        column: x => x.openId,
                        principalTable: "Open",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Period_RegularOpeningHours_RegularOpeningHoursId",
                        column: x => x.RegularOpeningHoursId,
                        principalTable: "RegularOpeningHours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TravelOtel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    star = table.Column<string>(type: "text", nullable: true),
                    internationalPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    nationalPhoneNumber = table.Column<string>(type: "text", nullable: true),
                    formattedAddress = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: true),
                    rating = table.Column<double>(type: "double precision", nullable: true),
                    googleMapsUri = table.Column<string>(type: "text", nullable: true),
                    websiteUri = table.Column<string>(type: "text", nullable: true),
                    RegularOpeningHoursId = table.Column<Guid>(type: "uuid", nullable: true),
                    displayNameId = table.Column<Guid>(type: "uuid", nullable: true),
                    goodForChildren = table.Column<bool>(type: "boolean", nullable: true),
                    restroom = table.Column<bool>(type: "boolean", nullable: true),
                    _PRICE_LEVEL = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TravelOtel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TravelOtel_DisplayName_displayNameId",
                        column: x => x.displayNameId,
                        principalTable: "DisplayName",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TravelOtel_Location_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Location",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TravelOtel_RegularOpeningHours_RegularOpeningHoursId",
                        column: x => x.RegularOpeningHoursId,
                        principalTable: "RegularOpeningHours",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TravelRoutes_OtelId",
                table: "TravelRoutes",
                column: "OtelId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_displayNameId",
                table: "ThirdPlaceForRoute",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_LocationId",
                table: "ThirdPlaceForRoute",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_displayNameId",
                table: "SecondPlaceForRoute",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_LocationId",
                table: "SecondPlaceForRoute",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_RegularOpeningHoursId",
                table: "SecondPlaceForRoute",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_displayNameId",
                table: "Lunch",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_LocationId",
                table: "Lunch",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_paymentOptionsId",
                table: "Lunch",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_RegularOpeningHoursId",
                table: "Lunch",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstPlaceForRoute_displayNameId",
                table: "FirstPlaceForRoute",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstPlaceForRoute_LocationId",
                table: "FirstPlaceForRoute",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstPlaceForRoute_RegularOpeningHoursId",
                table: "FirstPlaceForRoute",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAfterDinner_displayNameId",
                table: "EventAfterDinner",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAfterDinner_LocationId",
                table: "EventAfterDinner",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAfterDinner_RegularOpeningHoursId",
                table: "EventAfterDinner",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_displayNameId",
                table: "Dinner",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_LocationId",
                table: "Dinner",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_paymentOptionsId",
                table: "Dinner",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_RegularOpeningHoursId",
                table: "Dinner",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfast_displayNameId",
                table: "Breakfast",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfast_LocationId",
                table: "Breakfast",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfast_paymentOptionsId",
                table: "Breakfast",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfast_RegularOpeningHoursId",
                table: "Breakfast",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_Period_closeId",
                table: "Period",
                column: "closeId");

            migrationBuilder.CreateIndex(
                name: "IX_Period_openId",
                table: "Period",
                column: "openId");

            migrationBuilder.CreateIndex(
                name: "IX_Period_RegularOpeningHoursId",
                table: "Period",
                column: "RegularOpeningHoursId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelOtel_displayNameId",
                table: "TravelOtel",
                column: "displayNameId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelOtel_LocationId",
                table: "TravelOtel",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_TravelOtel_RegularOpeningHoursId",
                table: "TravelOtel",
                column: "RegularOpeningHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfast_DisplayName_displayNameId",
                table: "Breakfast",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfast_Location_LocationId",
                table: "Breakfast",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfast_PaymentOptions_paymentOptionsId",
                table: "Breakfast",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfast_RegularOpeningHours_RegularOpeningHoursId",
                table: "Breakfast",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinner_DisplayName_displayNameId",
                table: "Dinner",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinner_Location_LocationId",
                table: "Dinner",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinner_PaymentOptions_paymentOptionsId",
                table: "Dinner",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "Dinner",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_DisplayName_displayNameId",
                table: "EventAfterDinner",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_Location_LocationId",
                table: "EventAfterDinner",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinner",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoute_DisplayName_displayNameId",
                table: "FirstPlaceForRoute",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoute_Location_LocationId",
                table: "FirstPlaceForRoute",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "FirstPlaceForRoute",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunch_DisplayName_displayNameId",
                table: "Lunch",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunch_Location_LocationId",
                table: "Lunch",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunch_PaymentOptions_paymentOptionsId",
                table: "Lunch",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunch_RegularOpeningHours_RegularOpeningHoursId",
                table: "Lunch",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoute_DisplayName_displayNameId",
                table: "SecondPlaceForRoute",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoute_Location_LocationId",
                table: "SecondPlaceForRoute",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_RegularOpeningHours~",
                table: "SecondPlaceForRoute",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoute_DisplayName_displayNameId",
                table: "ThirdPlaceForRoute",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoute_Location_LocationId",
                table: "ThirdPlaceForRoute",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_TravelOtel_OtelId",
                table: "TravelRoutes",
                column: "OtelId",
                principalTable: "TravelOtel",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakfast_DisplayName_displayNameId",
                table: "Breakfast");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakfast_Location_LocationId",
                table: "Breakfast");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakfast_PaymentOptions_paymentOptionsId",
                table: "Breakfast");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakfast_RegularOpeningHours_RegularOpeningHoursId",
                table: "Breakfast");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinner_DisplayName_displayNameId",
                table: "Dinner");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinner_Location_LocationId",
                table: "Dinner");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinner_PaymentOptions_paymentOptionsId",
                table: "Dinner");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "Dinner");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_DisplayName_displayNameId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_Location_LocationId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_DisplayName_displayNameId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_Location_LocationId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunch_DisplayName_displayNameId",
                table: "Lunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunch_Location_LocationId",
                table: "Lunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunch_PaymentOptions_paymentOptionsId",
                table: "Lunch");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunch_RegularOpeningHours_RegularOpeningHoursId",
                table: "Lunch");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_DisplayName_displayNameId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_Location_LocationId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_RegularOpeningHours~",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_DisplayName_displayNameId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_Location_LocationId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_TravelOtel_OtelId",
                table: "TravelRoutes");

            migrationBuilder.DropTable(
                name: "PaymentOptions");

            migrationBuilder.DropTable(
                name: "Period");

            migrationBuilder.DropTable(
                name: "TravelOtel");

            migrationBuilder.DropTable(
                name: "Close");

            migrationBuilder.DropTable(
                name: "Open");

            migrationBuilder.DropTable(
                name: "DisplayName");

            migrationBuilder.DropTable(
                name: "Location");

            migrationBuilder.DropTable(
                name: "RegularOpeningHours");

            migrationBuilder.DropIndex(
                name: "IX_TravelRoutes_OtelId",
                table: "TravelRoutes");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPlaceForRoute_displayNameId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPlaceForRoute_LocationId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPlaceForRoute_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_SecondPlaceForRoute_displayNameId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_SecondPlaceForRoute_LocationId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_SecondPlaceForRoute_RegularOpeningHoursId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_Lunch_displayNameId",
                table: "Lunch");

            migrationBuilder.DropIndex(
                name: "IX_Lunch_LocationId",
                table: "Lunch");

            migrationBuilder.DropIndex(
                name: "IX_Lunch_paymentOptionsId",
                table: "Lunch");

            migrationBuilder.DropIndex(
                name: "IX_Lunch_RegularOpeningHoursId",
                table: "Lunch");

            migrationBuilder.DropIndex(
                name: "IX_FirstPlaceForRoute_displayNameId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_FirstPlaceForRoute_LocationId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_FirstPlaceForRoute_RegularOpeningHoursId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_EventAfterDinner_displayNameId",
                table: "EventAfterDinner");

            migrationBuilder.DropIndex(
                name: "IX_EventAfterDinner_LocationId",
                table: "EventAfterDinner");

            migrationBuilder.DropIndex(
                name: "IX_EventAfterDinner_RegularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropIndex(
                name: "IX_Dinner_displayNameId",
                table: "Dinner");

            migrationBuilder.DropIndex(
                name: "IX_Dinner_LocationId",
                table: "Dinner");

            migrationBuilder.DropIndex(
                name: "IX_Dinner_paymentOptionsId",
                table: "Dinner");

            migrationBuilder.DropIndex(
                name: "IX_Dinner_RegularOpeningHoursId",
                table: "Dinner");

            migrationBuilder.DropIndex(
                name: "IX_Breakfast_displayNameId",
                table: "Breakfast");

            migrationBuilder.DropIndex(
                name: "IX_Breakfast_LocationId",
                table: "Breakfast");

            migrationBuilder.DropIndex(
                name: "IX_Breakfast_paymentOptionsId",
                table: "Breakfast");

            migrationBuilder.DropIndex(
                name: "IX_Breakfast_RegularOpeningHoursId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "OtelId",
                table: "TravelRoutes");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "goodForChildren",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "goodForChildren",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "goodForGroups",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "liveMusic",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "menuForChildren",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "outdoorSeating",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "reservable",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "servesBeer",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "servesBrunch",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "servesVegetarianFood",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "servesWine",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "shortFormattedAddress",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "goodForChildren",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "goodForChildren",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "goodForGroups",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "liveMusic",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "menuForChildren",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "outdoorSeating",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "reservable",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "servesBeer",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "servesBrunch",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "servesVegetarianFood",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "servesWine",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "shortFormattedAddress",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "LocationId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "RegularOpeningHoursId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "_PRICE_LEVEL",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "displayNameId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "formattedAddress",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "goodForGroups",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "googleMapsUri",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "liveMusic",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "menuForChildren",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "nationalPhoneNumber",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "outdoorSeating",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "rating",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "reservable",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "restroom",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "servesBrunch",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "servesVegetarianFood",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "shortFormattedAddress",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "websiteUri",
                table: "Breakfast");
        }
    }
}
