using Microsoft.EntityFrameworkCore.Migrations;

namespace PointsAppWebAPI.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordinates_CoordinatesLists_CoordinatesListId",
                table: "Coordinates");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinates_CoordinatesLists_CoordinatesListId",
                table: "Coordinates",
                column: "CoordinatesListId",
                principalTable: "CoordinatesLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coordinates_CoordinatesLists_CoordinatesListId",
                table: "Coordinates");

            migrationBuilder.AddForeignKey(
                name: "FK_Coordinates_CoordinatesLists_CoordinatesListId",
                table: "Coordinates",
                column: "CoordinatesListId",
                principalTable: "CoordinatesLists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
