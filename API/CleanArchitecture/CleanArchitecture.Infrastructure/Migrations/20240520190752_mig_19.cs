using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CleanArchitecture.Infrastructure.Migrations
{
    public partial class mig_19 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_RegularOpeningHours~",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_RegularOpeningHours_RegularOpeningHoursId",
                table: "TravelOtel");

            migrationBuilder.RenameColumn(
                name: "RegularOpeningHoursId",
                table: "TravelOtel",
                newName: "regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtel_RegularOpeningHoursId",
                table: "TravelOtel",
                newName: "IX_TravelOtel_regularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "RegularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                newName: "regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoute_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                newName: "IX_ThirdPlaceForRoute_regularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "RegularOpeningHoursId",
                table: "SecondPlaceForRoute",
                newName: "regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoute_RegularOpeningHoursId",
                table: "SecondPlaceForRoute",
                newName: "IX_SecondPlaceForRoute_regularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "RegularOpeningHoursId",
                table: "FirstPlaceForRoute",
                newName: "regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoute_RegularOpeningHoursId",
                table: "FirstPlaceForRoute",
                newName: "IX_FirstPlaceForRoute_regularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "RegularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "regularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_RegularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_regularOpeningHoursId");

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "TravelOtel",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "ThirdPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "SecondPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "FirstPlaceForRoute",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "paymentOptionsId",
                table: "EventAfterDinner",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TravelOtel_paymentOptionsId",
                table: "TravelOtel",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_ThirdPlaceForRoute_paymentOptionsId",
                table: "ThirdPlaceForRoute",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondPlaceForRoute_paymentOptionsId",
                table: "SecondPlaceForRoute",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_FirstPlaceForRoute_paymentOptionsId",
                table: "FirstPlaceForRoute",
                column: "paymentOptionsId");

            migrationBuilder.CreateIndex(
                name: "IX_EventAfterDinner_paymentOptionsId",
                table: "EventAfterDinner",
                column: "paymentOptionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_PaymentOptions_paymentOptionsId",
                table: "EventAfterDinner",
                column: "paymentOptionsId",
                principalTable: "PaymentOptions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_regularOpeningHoursId",
                table: "EventAfterDinner",
                column: "regularOpeningHoursId",
                principalTable: "RegularOpeningHours",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_PaymentOptions_paymentOptionsId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_regularOpeningHoursId",
                table: "EventAfterDinner");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_regularOpeningHours~",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_PaymentOptions_paymentOptionsId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_regularOpeningHoursId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_PaymentOptions_paymentOptionsId",
                table: "TravelOtel");

            migrationBuilder.DropForeignKey(
                name: "FK_TravelOtel_RegularOpeningHours_regularOpeningHoursId",
                table: "TravelOtel");

            migrationBuilder.DropIndex(
                name: "IX_TravelOtel_paymentOptionsId",
                table: "TravelOtel");

            migrationBuilder.DropIndex(
                name: "IX_ThirdPlaceForRoute_paymentOptionsId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_SecondPlaceForRoute_paymentOptionsId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_FirstPlaceForRoute_paymentOptionsId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropIndex(
                name: "IX_EventAfterDinner_paymentOptionsId",
                table: "EventAfterDinner");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "TravelOtel");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "ThirdPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "SecondPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "FirstPlaceForRoute");

            migrationBuilder.DropColumn(
                name: "paymentOptionsId",
                table: "EventAfterDinner");

            migrationBuilder.RenameColumn(
                name: "regularOpeningHoursId",
                table: "TravelOtel",
                newName: "RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_TravelOtel_regularOpeningHoursId",
                table: "TravelOtel",
                newName: "IX_TravelOtel_RegularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "regularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                newName: "RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_ThirdPlaceForRoute_regularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                newName: "IX_ThirdPlaceForRoute_RegularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "regularOpeningHoursId",
                table: "SecondPlaceForRoute",
                newName: "RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_SecondPlaceForRoute_regularOpeningHoursId",
                table: "SecondPlaceForRoute",
                newName: "IX_SecondPlaceForRoute_RegularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "regularOpeningHoursId",
                table: "FirstPlaceForRoute",
                newName: "RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_FirstPlaceForRoute_regularOpeningHoursId",
                table: "FirstPlaceForRoute",
                newName: "IX_FirstPlaceForRoute_RegularOpeningHoursId");

            migrationBuilder.RenameColumn(
                name: "regularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "RegularOpeningHoursId");

            migrationBuilder.RenameIndex(
                name: "IX_EventAfterDinner_regularOpeningHoursId",
                table: "EventAfterDinner",
                newName: "IX_EventAfterDinner_RegularOpeningHoursId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventAfterDinner_RegularOpeningHours_RegularOpeningHoursId",
                table: "EventAfterDinner",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FirstPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "FirstPlaceForRoute",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_SecondPlaceForRoute_RegularOpeningHours_RegularOpeningHours~",
                table: "SecondPlaceForRoute",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ThirdPlaceForRoute_RegularOpeningHours_RegularOpeningHoursId",
                table: "ThirdPlaceForRoute",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TravelOtel_RegularOpeningHours_RegularOpeningHoursId",
                table: "TravelOtel",
                column: "RegularOpeningHoursId",
                principalTable: "RegularOpeningHours",
                principalColumn: "Id");
        }
    }
}
