using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_25 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_EventAfterDinner_PaymentOptions_paymentOptionsId",
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
                name: "FK_FirstPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
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
                name: "FK_Period_Close_closeId",
                table: "Period");

            migrationBuilder.DropForeignKey(
                name: "FK_Period_Open_openId",
                table: "Period");

            migrationBuilder.DropForeignKey(
                name: "FK_Period_RegularOpeningHours_RegularOpeningHoursId",
                table: "Period");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Breakfast_BreakfastId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Dinner_DinnerId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_EventAfterDinner_EventAfterDinnerId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_FirstPlaceForRoute_FirstPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Lunch_LunchId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_SecondPlaceForRoute_SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_ThirdPlaceForRoute_ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_TravelOtel_TravelOtelId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_DisplayName_displayNameId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_Location_LocationId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_regularOpeningHours~",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_DisplayName_displayNameId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_Location_LocationId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_DisplayName_displayNameId",
                table: "TravelOtel");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_Location_LocationId",
                table: "TravelOtel");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_PaymentOptions_paymentOptionsId",
                table: "TravelOtel");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_RegularOpeningHours_regularOpeningHoursId",
                table: "TravelOtel");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_Breakfast_BreakfastId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_Dinner_DinnerId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_EventAfterDinner_EventAfterDinnerId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoute_FirstPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_Lunch_LunchId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_SecondPlaceForRoute_SecondPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_ThirdPlaceForRoute_ThirdPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_TravelOtel_OtelId",
                table: "TravelRoutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelOtel",
                table: "TravelOtel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThirdPlaceForRoute",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecondPlaceForRoute",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Period",
                table: "Period");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Open",
                table: "Open");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lunch",
                table: "Lunch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstPlaceForRoute",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventAfterDinner",
                table: "EventAfterDinner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisplayName",
                table: "DisplayName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dinner",
                table: "Dinner");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Close",
                table: "Close");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breakfast",
                table: "Breakfast");

            migrationBuilder.RenameTable(
                name: "TravelOtel",
                newName: "TravelOtels");

            migrationBuilder.RenameTable(
                name: "ThirdPlaceForRoute",
                newName: "ThirdPlaceForRoutes");

            migrationBuilder.RenameTable(
                name: "SecondPlaceForRoute",
                newName: "SecondPlaceForRoutes");

            migrationBuilder.RenameTable(
                name: "Period",
                newName: "Periods");

            migrationBuilder.RenameTable(
                name: "Open",
                newName: "Opens");

            migrationBuilder.RenameTable(
                name: "Lunch",
                newName: "Lunches");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.RenameTable(
                name: "FirstPlaceForRoute",
                newName: "FirstPlaceForRoutes");

            migrationBuilder.RenameTable(
                name: "EventAfterDinner",
                newName: "EventAfterDinners");

            migrationBuilder.RenameTable(
                name: "DisplayName",
                newName: "DisplayNames");

            migrationBuilder.RenameTable(
                name: "Dinner",
                newName: "Dinners");

            migrationBuilder.RenameTable(
                name: "Close",
                newName: "Closes");

            migrationBuilder.RenameTable(
                name: "Breakfast",
                newName: "Breakfasts");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtel_regularOpeningHoursId",
                table: "TravelOtels",
                newName: "IX_TravelOtels_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtel_paymentOptionsId",
                table: "TravelOtels",
                newName: "IX_TravelOtels_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtel_LocationId",
                table: "TravelOtels",
                newName: "IX_TravelOtels_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtel_displayNameId",
                table: "TravelOtels",
                newName: "IX_TravelOtels_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoute_regularOpeningHoursId",
                table: "ThirdPlaceForRoutes",
                newName: "IX_ThirdPlaceForRoutes_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoute_paymentOptionsId",
                table: "ThirdPlaceForRoutes",
                newName: "IX_ThirdPlaceForRoutes_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoute_LocationId",
                table: "ThirdPlaceForRoutes",
                newName: "IX_ThirdPlaceForRoutes_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoute_displayNameId",
                table: "ThirdPlaceForRoutes",
                newName: "IX_ThirdPlaceForRoutes_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoute_regularOpeningHoursId",
                table: "SecondPlaceForRoutes",
                newName: "IX_SecondPlaceForRoutes_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoute_paymentOptionsId",
                table: "SecondPlaceForRoutes",
                newName: "IX_SecondPlaceForRoutes_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoute_LocationId",
                table: "SecondPlaceForRoutes",
                newName: "IX_SecondPlaceForRoutes_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoute_displayNameId",
                table: "SecondPlaceForRoutes",
                newName: "IX_SecondPlaceForRoutes_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Period_RegularOpeningHoursId",
                table: "Periods",
                newName: "IX_Periods_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Period_openId",
                table: "Periods",
                newName: "IX_Periods_openId");

            migrationBuilder.RenameIndex(
                name: "IX_Period_closeId",
                table: "Periods",
                newName: "IX_Periods_closeId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunch_RegularOpeningHoursId",
                table: "Lunches",
                newName: "IX_Lunches_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunch_paymentOptionsId",
                table: "Lunches",
                newName: "IX_Lunches_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunch_LocationId",
                table: "Lunches",
                newName: "IX_Lunches_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunch_displayNameId",
                table: "Lunches",
                newName: "IX_Lunches_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoute_regularOpeningHoursId",
                table: "FirstPlaceForRoutes",
                newName: "IX_FirstPlaceForRoutes_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoute_paymentOptionsId",
                table: "FirstPlaceForRoutes",
                newName: "IX_FirstPlaceForRoutes_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoute_LocationId",
                table: "FirstPlaceForRoutes",
                newName: "IX_FirstPlaceForRoutes_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoute_displayNameId",
                table: "FirstPlaceForRoutes",
                newName: "IX_FirstPlaceForRoutes_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_RegularOpeningHoursId",
                table: "EventAfterDinners",
                newName: "IX_EventAfterDinners_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_paymentOptionsId",
                table: "EventAfterDinners",
                newName: "IX_EventAfterDinners_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_LocationId",
                table: "EventAfterDinners",
                newName: "IX_EventAfterDinners_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_displayNameId",
                table: "EventAfterDinners",
                newName: "IX_EventAfterDinners_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinner_RegularOpeningHoursId",
                table: "Dinners",
                newName: "IX_Dinners_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinner_paymentOptionsId",
                table: "Dinners",
                newName: "IX_Dinners_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinner_LocationId",
                table: "Dinners",
                newName: "IX_Dinners_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinner_displayNameId",
                table: "Dinners",
                newName: "IX_Dinners_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfast_RegularOpeningHoursId",
                table: "Breakfasts",
                newName: "IX_Breakfasts_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfast_paymentOptionsId",
                table: "Breakfasts",
                newName: "IX_Breakfasts_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfast_LocationId",
                table: "Breakfasts",
                newName: "IX_Breakfasts_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfast_displayNameId",
                table: "Breakfasts",
                newName: "IX_Breakfasts_displayNameId");

            migrationBuilder.AlterColumn<bool>(
                name: "isLiked",
                table: "TravelRoutes",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelOtels",
                table: "TravelOtels",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThirdPlaceForRoutes",
                table: "ThirdPlaceForRoutes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecondPlaceForRoutes",
                table: "SecondPlaceForRoutes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Periods",
                table: "Periods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Opens",
                table: "Opens",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lunches",
                table: "Lunches",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstPlaceForRoutes",
                table: "FirstPlaceForRoutes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventAfterDinners",
                table: "EventAfterDinners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisplayNames",
                table: "DisplayNames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dinners",
                table: "Dinners",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Closes",
                table: "Closes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breakfasts",
                table: "Breakfasts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "PrimaryTypeDisplayName",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    text = table.Column<string>(type: "text", nullable: true),
                    languageCode = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimaryTypeDisplayName", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfasts_DisplayNames_displayNameId",
                table: "Breakfasts",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfasts_Locations_LocationId",
                table: "Breakfasts",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfasts_PaymentOptions_paymentOptionsId",
                table: "Breakfasts",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfasts_RegularOpeningHours_RegularOpeningHoursId",
                table: "Breakfasts",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinners_DisplayNames_displayNameId",
                table: "Dinners",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinners_Locations_LocationId",
                table: "Dinners",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinners_PaymentOptions_paymentOptionsId",
                table: "Dinners",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinners_RegularOpeningHours_RegularOpeningHoursId",
                table: "Dinners",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinners_DisplayNames_displayNameId",
                table: "EventAfterDinners",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinners_Locations_LocationId",
                table: "EventAfterDinners",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinners_PaymentOptions_paymentOptionsId",
                table: "EventAfterDinners",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinners_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinners",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoutes_DisplayNames_displayNameId",
                table: "FirstPlaceForRoutes",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoutes_Locations_LocationId",
                table: "FirstPlaceForRoutes",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoutes_PaymentOptions_paymentOptionsId",
                table: "FirstPlaceForRoutes",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoutes_RegularOpeningHours_regularOpeningHours~",
                table: "FirstPlaceForRoutes",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunches_DisplayNames_displayNameId",
                table: "Lunches",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunches_Locations_LocationId",
                table: "Lunches",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunches_PaymentOptions_paymentOptionsId",
                table: "Lunches",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunches_RegularOpeningHours_RegularOpeningHoursId",
                table: "Lunches",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Periods_Closes_closeId",
                table: "Periods",
                column: "closeId",
                principalTable: "Closes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Periods_Opens_openId",
                table: "Periods",
                column: "openId",
                principalTable: "Opens",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Periods_RegularOpeningHours_RegularOpeningHoursId",
                table: "Periods",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Breakfasts_BreakfastId",
                table: "Photos",
                column: "BreakfastId",
                principalTable: "Breakfasts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Dinners_DinnerId",
                table: "Photos",
                column: "DinnerId",
                principalTable: "Dinners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_EventAfterDinners_EventAfterDinnerId",
                table: "Photos",
                column: "EventAfterDinnerId",
                principalTable: "EventAfterDinners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_FirstPlaceForRoutes_FirstPlaceForRouteId",
                table: "Photos",
                column: "FirstPlaceForRouteId",
                principalTable: "FirstPlaceForRoutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Lunches_LunchId",
                table: "Photos",
                column: "LunchId",
                principalTable: "Lunches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_SecondPlaceForRoutes_SecondPlaceForRouteId",
                table: "Photos",
                column: "SecondPlaceForRouteId",
                principalTable: "SecondPlaceForRoutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_ThirdPlaceForRoutes_ThirdPlaceForRouteId",
                table: "Photos",
                column: "ThirdPlaceForRouteId",
                principalTable: "ThirdPlaceForRoutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_TravelOtels_TravelOtelId",
                table: "Photos",
                column: "TravelOtelId",
                principalTable: "TravelOtels",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoutes_DisplayNames_displayNameId",
                table: "SecondPlaceForRoutes",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoutes_Locations_LocationId",
                table: "SecondPlaceForRoutes",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoutes_PaymentOptions_paymentOptionsId",
                table: "SecondPlaceForRoutes",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoutes_RegularOpeningHours_regularOpeningHour~",
                table: "SecondPlaceForRoutes",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoutes_DisplayNames_displayNameId",
                table: "ThirdPlaceForRoutes",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoutes_Locations_LocationId",
                table: "ThirdPlaceForRoutes",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoutes_PaymentOptions_paymentOptionsId",
                table: "ThirdPlaceForRoutes",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoutes_RegularOpeningHours_regularOpeningHours~",
                table: "ThirdPlaceForRoutes",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtels_DisplayNames_displayNameId",
                table: "TravelOtels",
                column: "displayNameId",
                principalTable: "DisplayNames",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtels_Locations_LocationId",
                table: "TravelOtels",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtels_PaymentOptions_paymentOptionsId",
                table: "TravelOtels",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtels_RegularOpeningHours_regularOpeningHoursId",
                table: "TravelOtels",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_Breakfasts_BreakfastId",
                table: "TravelRoutes",
                column: "BreakfastId",
                principalTable: "Breakfasts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_Dinners_DinnerId",
                table: "TravelRoutes",
                column: "DinnerId",
                principalTable: "Dinners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_EventAfterDinners_EventAfterDinnerId",
                table: "TravelRoutes",
                column: "EventAfterDinnerId",
                principalTable: "EventAfterDinners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoutes_FirstPlaceForRouteId",
                table: "TravelRoutes",
                column: "FirstPlaceForRouteId",
                principalTable: "FirstPlaceForRoutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_Lunches_LunchId",
                table: "TravelRoutes",
                column: "LunchId",
                principalTable: "Lunches",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_SecondPlaceForRoutes_SecondPlaceForRouteId",
                table: "TravelRoutes",
                column: "SecondPlaceForRouteId",
                principalTable: "SecondPlaceForRoutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_ThirdPlaceForRoutes_ThirdPlaceForRouteId",
                table: "TravelRoutes",
                column: "ThirdPlaceForRouteId",
                principalTable: "ThirdPlaceForRoutes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_TravelOtels_OtelId",
                table: "TravelRoutes",
                column: "OtelId",
                principalTable: "TravelOtels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakfasts_DisplayNames_displayNameId",
                table: "Breakfasts");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakfasts_Locations_LocationId",
                table: "Breakfasts");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakfasts_PaymentOptions_paymentOptionsId",
                table: "Breakfasts");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakfasts_RegularOpeningHours_RegularOpeningHoursId",
                table: "Breakfasts");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinners_DisplayNames_displayNameId",
                table: "Dinners");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinners_Locations_LocationId",
                table: "Dinners");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinners_PaymentOptions_paymentOptionsId",
                table: "Dinners");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinners_RegularOpeningHours_RegularOpeningHoursId",
                table: "Dinners");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinners_DisplayNames_displayNameId",
                table: "EventAfterDinners");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinners_Locations_LocationId",
                table: "EventAfterDinners");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinners_PaymentOptions_paymentOptionsId",
                table: "EventAfterDinners");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinners_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinners");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoutes_DisplayNames_displayNameId",
                table: "FirstPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoutes_Locations_LocationId",
                table: "FirstPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoutes_PaymentOptions_paymentOptionsId",
                table: "FirstPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoutes_RegularOpeningHours_regularOpeningHours~",
                table: "FirstPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunches_DisplayNames_displayNameId",
                table: "Lunches");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunches_Locations_LocationId",
                table: "Lunches");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunches_PaymentOptions_paymentOptionsId",
                table: "Lunches");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunches_RegularOpeningHours_RegularOpeningHoursId",
                table: "Lunches");

            migrationBuilder.DropForeignKey(
                name: "FK_Periods_Closes_closeId",
                table: "Periods");

            migrationBuilder.DropForeignKey(
                name: "FK_Periods_Opens_openId",
                table: "Periods");

            migrationBuilder.DropForeignKey(
                name: "FK_Periods_RegularOpeningHours_RegularOpeningHoursId",
                table: "Periods");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Breakfasts_BreakfastId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Dinners_DinnerId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_EventAfterDinners_EventAfterDinnerId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_FirstPlaceForRoutes_FirstPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_Lunches_LunchId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_SecondPlaceForRoutes_SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_ThirdPlaceForRoutes_ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_TravelOtels_TravelOtelId",
                table: "Photos");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoutes_DisplayNames_displayNameId",
                table: "SecondPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoutes_Locations_LocationId",
                table: "SecondPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoutes_PaymentOptions_paymentOptionsId",
                table: "SecondPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoutes_RegularOpeningHours_regularOpeningHour~",
                table: "SecondPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoutes_DisplayNames_displayNameId",
                table: "ThirdPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoutes_Locations_LocationId",
                table: "ThirdPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoutes_PaymentOptions_paymentOptionsId",
                table: "ThirdPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoutes_RegularOpeningHours_regularOpeningHours~",
                table: "ThirdPlaceForRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtels_DisplayNames_displayNameId",
                table: "TravelOtels");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtels_Locations_LocationId",
                table: "TravelOtels");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtels_PaymentOptions_paymentOptionsId",
                table: "TravelOtels");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtels_RegularOpeningHours_regularOpeningHoursId",
                table: "TravelOtels");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_Breakfasts_BreakfastId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_Dinners_DinnerId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_EventAfterDinners_EventAfterDinnerId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoutes_FirstPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_Lunches_LunchId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_SecondPlaceForRoutes_SecondPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_ThirdPlaceForRoutes_ThirdPlaceForRouteId",
                table: "TravelRoutes");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelRoutes_TravelOtels_OtelId",
                table: "TravelRoutes");

            migrationBuilder.DropTable(
                name: "PrimaryTypeDisplayName");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TravelOtels",
                table: "TravelOtels");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ThirdPlaceForRoutes",
                table: "ThirdPlaceForRoutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SecondPlaceForRoutes",
                table: "SecondPlaceForRoutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Periods",
                table: "Periods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Opens",
                table: "Opens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Lunches",
                table: "Lunches");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FirstPlaceForRoutes",
                table: "FirstPlaceForRoutes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EventAfterDinners",
                table: "EventAfterDinners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DisplayNames",
                table: "DisplayNames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dinners",
                table: "Dinners");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Closes",
                table: "Closes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Breakfasts",
                table: "Breakfasts");

            migrationBuilder.RenameTable(
                name: "TravelOtels",
                newName: "TravelOtel");

            migrationBuilder.RenameTable(
                name: "ThirdPlaceForRoutes",
                newName: "ThirdPlaceForRoute");

            migrationBuilder.RenameTable(
                name: "SecondPlaceForRoutes",
                newName: "SecondPlaceForRoute");

            migrationBuilder.RenameTable(
                name: "Periods",
                newName: "Period");

            migrationBuilder.RenameTable(
                name: "Opens",
                newName: "Open");

            migrationBuilder.RenameTable(
                name: "Lunches",
                newName: "Lunch");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.RenameTable(
                name: "FirstPlaceForRoutes",
                newName: "FirstPlaceForRoute");

            migrationBuilder.RenameTable(
                name: "EventAfterDinners",
                newName: "EventAfterDinner");

            migrationBuilder.RenameTable(
                name: "DisplayNames",
                newName: "DisplayName");

            migrationBuilder.RenameTable(
                name: "Dinners",
                newName: "Dinner");

            migrationBuilder.RenameTable(
                name: "Closes",
                newName: "Close");

            migrationBuilder.RenameTable(
                name: "Breakfasts",
                newName: "Breakfast");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtels_regularOpeningHoursId",
                table: "TravelOtel",
                newName: "IX_TravelOtel_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtels_paymentOptionsId",
                table: "TravelOtel",
                newName: "IX_TravelOtel_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtels_LocationId",
                table: "TravelOtel",
                newName: "IX_TravelOtel_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtels_displayNameId",
                table: "TravelOtel",
                newName: "IX_TravelOtel_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoutes_regularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                newName: "IX_ThirdPlaceForRoute_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoutes_paymentOptionsId",
                table: "ThirdPlaceForRoute",
                newName: "IX_ThirdPlaceForRoute_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoutes_LocationId",
                table: "ThirdPlaceForRoute",
                newName: "IX_ThirdPlaceForRoute_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoutes_displayNameId",
                table: "ThirdPlaceForRoute",
                newName: "IX_ThirdPlaceForRoute_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoutes_regularOpeningHoursId",
                table: "SecondPlaceForRoute",
                newName: "IX_SecondPlaceForRoute_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoutes_paymentOptionsId",
                table: "SecondPlaceForRoute",
                newName: "IX_SecondPlaceForRoute_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoutes_LocationId",
                table: "SecondPlaceForRoute",
                newName: "IX_SecondPlaceForRoute_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoutes_displayNameId",
                table: "SecondPlaceForRoute",
                newName: "IX_SecondPlaceForRoute_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Periods_RegularOpeningHoursId",
                table: "Period",
                newName: "IX_Period_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Periods_openId",
                table: "Period",
                newName: "IX_Period_openId");

            migrationBuilder.RenameIndex(
                name: "IX_Periods_closeId",
                table: "Period",
                newName: "IX_Period_closeId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunches_RegularOpeningHoursId",
                table: "Lunch",
                newName: "IX_Lunch_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunches_paymentOptionsId",
                table: "Lunch",
                newName: "IX_Lunch_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunches_LocationId",
                table: "Lunch",
                newName: "IX_Lunch_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Lunches_displayNameId",
                table: "Lunch",
                newName: "IX_Lunch_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoutes_regularOpeningHoursId",
                table: "FirstPlaceForRoute",
                newName: "IX_FirstPlaceForRoute_regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoutes_paymentOptionsId",
                table: "FirstPlaceForRoute",
                newName: "IX_FirstPlaceForRoute_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoutes_LocationId",
                table: "FirstPlaceForRoute",
                newName: "IX_FirstPlaceForRoute_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoutes_displayNameId",
                table: "FirstPlaceForRoute",
                newName: "IX_FirstPlaceForRoute_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinners_RegularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinners_paymentOptionsId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinners_LocationId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinners_displayNameId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinners_RegularOpeningHoursId",
                table: "Dinner",
                newName: "IX_Dinner_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinners_paymentOptionsId",
                table: "Dinner",
                newName: "IX_Dinner_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinners_LocationId",
                table: "Dinner",
                newName: "IX_Dinner_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Dinners_displayNameId",
                table: "Dinner",
                newName: "IX_Dinner_displayNameId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfasts_RegularOpeningHoursId",
                table: "Breakfast",
                newName: "IX_Breakfast_RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfasts_paymentOptionsId",
                table: "Breakfast",
                newName: "IX_Breakfast_paymentOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfasts_LocationId",
                table: "Breakfast",
                newName: "IX_Breakfast_LocationId");

            migrationBuilder.RenameIndex(
                name: "IX_Breakfasts_displayNameId",
                table: "Breakfast",
                newName: "IX_Breakfast_displayNameId");

            migrationBuilder.AlterColumn<bool>(
                name: "isLiked",
                table: "TravelRoutes",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TravelOtel",
                table: "TravelOtel",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ThirdPlaceForRoute",
                table: "ThirdPlaceForRoute",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SecondPlaceForRoute",
                table: "SecondPlaceForRoute",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Period",
                table: "Period",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Open",
                table: "Open",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Lunch",
                table: "Lunch",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FirstPlaceForRoute",
                table: "FirstPlaceForRoute",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EventAfterDinner",
                table: "EventAfterDinner",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DisplayName",
                table: "DisplayName",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dinner",
                table: "Dinner",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Close",
                table: "Close",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Breakfast",
                table: "Breakfast",
                column: "Id");

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
                name: "FK_EventAfterDinner_PaymentOptions_paymentOptionsId",
                table: "EventAfterDinner",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
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
                name: "FK_FirstPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "FirstPlaceForRoute",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
                table: "FirstPlaceForRoute",
                column: "regularOpeningHoursId",
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
                name: "FK_Period_Close_closeId",
                table: "Period",
                column: "closeId",
                principalTable: "Close",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Period_Open_openId",
                table: "Period",
                column: "openId",
                principalTable: "Open",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Period_RegularOpeningHours_RegularOpeningHoursId",
                table: "Period",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Breakfast_BreakfastId",
                table: "Photos",
                column: "BreakfastId",
                principalTable: "Breakfast",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Dinner_DinnerId",
                table: "Photos",
                column: "DinnerId",
                principalTable: "Dinner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_EventAfterDinner_EventAfterDinnerId",
                table: "Photos",
                column: "EventAfterDinnerId",
                principalTable: "EventAfterDinner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_FirstPlaceForRoute_FirstPlaceForRouteId",
                table: "Photos",
                column: "FirstPlaceForRouteId",
                principalTable: "FirstPlaceForRoute",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_Lunch_LunchId",
                table: "Photos",
                column: "LunchId",
                principalTable: "Lunch",
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
                name: "FK_Photos_TravelOtel_TravelOtelId",
                table: "Photos",
                column: "TravelOtelId",
                principalTable: "TravelOtel",
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
                name: "FK_SecondPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "SecondPlaceForRoute",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_regularOpeningHours~",
                table: "SecondPlaceForRoute",
                column: "regularOpeningHoursId",
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
                name: "FK_ThirdPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "ThirdPlaceForRoute",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtel_DisplayName_displayNameId",
                table: "TravelOtel",
                column: "displayNameId",
                principalTable: "DisplayName",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtel_Location_LocationId",
                table: "TravelOtel",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtel_PaymentOptions_paymentOptionsId",
                table: "TravelOtel",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtel_RegularOpeningHours_regularOpeningHoursId",
                table: "TravelOtel",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_Breakfast_BreakfastId",
                table: "TravelRoutes",
                column: "BreakfastId",
                principalTable: "Breakfast",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_Dinner_DinnerId",
                table: "TravelRoutes",
                column: "DinnerId",
                principalTable: "Dinner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_EventAfterDinner_EventAfterDinnerId",
                table: "TravelRoutes",
                column: "EventAfterDinnerId",
                principalTable: "EventAfterDinner",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_FirstPlaceForRoute_FirstPlaceForRouteId",
                table: "TravelRoutes",
                column: "FirstPlaceForRouteId",
                principalTable: "FirstPlaceForRoute",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_Lunch_LunchId",
                table: "TravelRoutes",
                column: "LunchId",
                principalTable: "Lunch",
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

            migrationBuilder.AddForeignKey(
                name: "FK_TravelRoutes_TravelOtel_OtelId",
                table: "TravelRoutes",
                column: "OtelId",
                principalTable: "TravelOtel",
                principalColumn: "Id");
        }
    }
}
