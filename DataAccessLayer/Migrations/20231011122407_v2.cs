using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class v2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedules_FlightDetails_FlightId",
                table: "FlightSchedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightSchedules",
                table: "FlightSchedules");

            migrationBuilder.RenameTable(
                name: "FlightSchedules",
                newName: "FlightSchedule");

            migrationBuilder.RenameIndex(
                name: "IX_FlightSchedules_FlightId",
                table: "FlightSchedule",
                newName: "IX_FlightSchedule_FlightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightSchedule",
                table: "FlightSchedule",
                column: "FlightScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedule_FlightDetails_FlightId",
                table: "FlightSchedule",
                column: "FlightId",
                principalTable: "FlightDetails",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightSchedule_FlightDetails_FlightId",
                table: "FlightSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightSchedule",
                table: "FlightSchedule");

            migrationBuilder.RenameTable(
                name: "FlightSchedule",
                newName: "FlightSchedules");

            migrationBuilder.RenameIndex(
                name: "IX_FlightSchedule_FlightId",
                table: "FlightSchedules",
                newName: "IX_FlightSchedules_FlightId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightSchedules",
                table: "FlightSchedules",
                column: "FlightScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightSchedules_FlightDetails_FlightId",
                table: "FlightSchedules",
                column: "FlightId",
                principalTable: "FlightDetails",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
