using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "TravelOtel",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "TravelOtel",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "ThirdPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "ThirdPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "SecondPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "SecondPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "Lunch",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "Lunch",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "FirstPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "FirstPlaceForRoute",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "EventAfterDinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "EventAfterDinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "Dinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "Dinner",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "photosId",
                table: "Breakfast",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryType",
                table: "Breakfast",
                type: "text",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    widthPx = table.Column<int>(type: "integer", nullable: false),
                    heightPx = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropTable(
                name: "Photos");

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
                name: "primaryType",
                table: "TravelOtel");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "Lunch");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "Dinner");

            migrationBuilder.DropColumn(
                name: "photosId",
                table: "Breakfast");

            migrationBuilder.DropColumn(
                name: "primaryType",
                table: "Breakfast");
        }
    }
}
