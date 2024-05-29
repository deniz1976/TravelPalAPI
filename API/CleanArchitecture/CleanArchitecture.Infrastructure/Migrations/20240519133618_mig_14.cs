using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakfast_Photos_photosId",
                table: "Breakfast");

            migrationBuilder.DropForeignKey(
                name: "FK_Dinner_Photos_photosId",
                table: "Dinner");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_Photos_photosId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_Photos_photosId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_Lunch_Photos_photosId",
                table: "Lunch");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_Photos_photosId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_Photos_photosId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_Photos_photosId",
                table: "TravelOtel");

            migrationBuilder.DropIndex(
                name: "IX_TravelOtel_photosId",
                table: "TravelOtel");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPlaceForRoute_photosId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_SecondPlaceForRoute_photosId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_Lunch_photosId",
                table: "Lunch");

            migrationBuilder.DropIndex(
                name: "IX_FirstPlaceForRoute_photosId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_EventAfterDinner_photosId",
                table: "EventAfterDinner");

            migrationBuilder.DropIndex(
                name: "IX_Dinner_photosId",
                table: "Dinner");

            migrationBuilder.DropIndex(
                name: "IX_Breakfast_photosId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "TravelOtel");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "Breakfast");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "TravelRoutes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TravelRoutes",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "TravelOtel",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TravelOtel",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "TravelOtel",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ThirdPlaceForRoute",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ThirdPlaceForRoute",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "ThirdPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SecondPlaceForRoute",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SecondPlaceForRoute",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "SecondPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "openNow",
                table: "RegularOpeningHours",
                type: "boolean",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "boolean");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "RegularOpeningHours",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RegularOpeningHours",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "widthPx",
                table: "Photos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "heightPx",
                table: "Photos",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Photos",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Photos",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<Guid>(
                name: "BreakfastId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DinnerId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EventAfterDinnerId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FirstPlaceForRouteId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "LunchId",
                table: "Photos",
                type: "uuid",
                nullable: true);

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

            migrationBuilder.AddColumn<Guid>(
                name: "TravelOtelId",
                table: "Photos",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "Photos",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Period",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Period",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PaymentOptions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentOptions",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<int>(
                name: "minute",
                table: "Open",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "hour",
                table: "Open",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "day",
                table: "Open",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Open",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Open",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Lunch",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Lunch",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "longitude",
                table: "Location",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<double>(
                name: "latitude",
                table: "Location",
                type: "double precision",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "double precision");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Location",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Location",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "FirstPlaceForRoute",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FirstPlaceForRoute",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EventAfterDinner",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EventAfterDinner",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DisplayName",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DisplayName",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Dinner",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Dinner",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "minute",
                table: "Close",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "hour",
                table: "Close",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "day",
                table: "Close",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Close",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Close",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Breakfast",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Breakfast",
                type: "timestamp with time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AddColumn<string>(
                name: "googleId",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_BreakfastId",
                table: "Photos",
                column: "BreakfastId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_DinnerId",
                table: "Photos",
                column: "DinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_EventAfterDinnerId",
                table: "Photos",
                column: "EventAfterDinnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_FirstPlaceForRouteId",
                table: "Photos",
                column: "FirstPlaceForRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_LunchId",
                table: "Photos",
                column: "LunchId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_SecondPlaceForRouteId",
                table: "Photos",
                column: "SecondPlaceForRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ThirdPlaceForRouteId",
                table: "Photos",
                column: "ThirdPlaceForRouteId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_TravelOtelId",
                table: "Photos",
                column: "TravelOtelId");

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropIndex(
                name: "IX_Photos_BreakfastId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_DinnerId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_EventAfterDinnerId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_FirstPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_LunchId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_TravelOtelId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "TravelOtel");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "BreakfastId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "DinnerId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "EventAfterDinnerId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "FirstPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "LunchId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "SecondPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "ThirdPlaceForRouteId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "TravelOtelId",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "name",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "googleId",
                table: "Breakfast");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "TravelRoutes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TravelRoutes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "TravelOtel",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "TravelOtel",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "TravelOtel",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "ThirdPlaceForRoute",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "ThirdPlaceForRoute",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "ThirdPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "SecondPlaceForRoute",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "SecondPlaceForRoute",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "SecondPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "openNow",
                table: "RegularOpeningHours",
                type: "boolean",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "boolean",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "RegularOpeningHours",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "RegularOpeningHours",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "widthPx",
                table: "Photos",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "heightPx",
                table: "Photos",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Photos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Photos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Period",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Period",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "PaymentOptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "PaymentOptions",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "minute",
                table: "Open",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "hour",
                table: "Open",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "day",
                table: "Open",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Open",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Open",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Lunch",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Lunch",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "Lunch",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "longitude",
                table: "Location",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "latitude",
                table: "Location",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "double precision",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Location",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Location",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "FirstPlaceForRoute",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "FirstPlaceForRoute",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "FirstPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "EventAfterDinner",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "EventAfterDinner",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "EventAfterDinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "DisplayName",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "DisplayName",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Dinner",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Dinner",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "Dinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "minute",
                table: "Close",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "hour",
                table: "Close",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "day",
                table: "Close",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Close",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Close",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Breakfast",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Breakfast",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "Breakfast",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelOtel_photosId",
                table: "TravelOtel",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_photosId",
                table: "ThirdPlaceForRoute",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_photosId",
                table: "SecondPlaceForRoute",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_Lunch_photosId",
                table: "Lunch",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstPlaceForRoute_photosId",
                table: "FirstPlaceForRoute",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAfterDinner_photosId",
                table: "EventAfterDinner",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_Dinner_photosId",
                table: "Dinner",
                column: "photosId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakfast_photosId",
                table: "Breakfast",
                column: "photosId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakfast_Photos_photosId",
                table: "Breakfast",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Dinner_Photos_photosId",
                table: "Dinner",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_Photos_photosId",
                table: "EventAfterDinner",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoute_Photos_photosId",
                table: "FirstPlaceForRoute",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Lunch_Photos_photosId",
                table: "Lunch",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoute_Photos_photosId",
                table: "SecondPlaceForRoute",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoute_Photos_photosId",
                table: "ThirdPlaceForRoute",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtel_Photos_photosId",
                table: "TravelOtel",
                column: "photosId",
                principalTable: "Photos",
                principalColumn: "Id");
        }
    }
}
