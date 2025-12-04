using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GesApprovisionnement.Migrations
{
    /// <inheritdoc />
    public partial class FixturesInit1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Approvisionnements",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateApprovisionnement",
                value: new DateTime(2023, 4, 15, 11, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Approvisionnements",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateApprovisionnement",
                value: new DateTime(2023, 4, 10, 11, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "Approvisionnements",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateApprovisionnement",
                value: new DateTime(2023, 4, 5, 11, 0, 0, 0, DateTimeKind.Utc));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Approvisionnements",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateApprovisionnement",
                value: new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Approvisionnements",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateApprovisionnement",
                value: new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Approvisionnements",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateApprovisionnement",
                value: new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
