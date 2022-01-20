using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApp.Server.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 787, DateTimeKind.Local).AddTicks(3065), new DateTime(2022, 1, 19, 18, 11, 21, 788, DateTimeKind.Local).AddTicks(6282) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 788, DateTimeKind.Local).AddTicks(7077), new DateTime(2022, 1, 19, 18, 11, 21, 788, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8466), new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8476), new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8477) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8479), new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8481), new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8483), new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8483) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8485), new DateTime(2022, 1, 19, 18, 11, 21, 789, DateTimeKind.Local).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2827), new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2835) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2839), new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2840) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2841), new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2842) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2843), new DateTime(2022, 1, 19, 18, 11, 21, 790, DateTimeKind.Local).AddTicks(2844) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 97, DateTimeKind.Local).AddTicks(2483), new DateTime(2022, 1, 19, 12, 51, 41, 100, DateTimeKind.Local).AddTicks(5850) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 100, DateTimeKind.Local).AddTicks(6863), new DateTime(2022, 1, 19, 12, 51, 41, 100, DateTimeKind.Local).AddTicks(6868) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(523), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(532) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(536), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(538), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(540), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(541) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(543), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(544) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(545), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(546) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4557), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4567), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4568) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4570), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4571) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4573), new DateTime(2022, 1, 19, 12, 51, 41, 102, DateTimeKind.Local).AddTicks(4574) });
        }
    }
}
