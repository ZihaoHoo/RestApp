using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApp.Server.Migrations
{
    public partial class new_db : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cuisines",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "French", null },
                    { 2, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Japanese", null },
                    { 3, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indian", null },
                    { 4, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thai", null },
                    { 5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chinese", null },
                    { 6, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "American", null },
                    { 7, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Italian", null }
                });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 427, DateTimeKind.Local).AddTicks(9586), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(5313) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(6078), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(6082) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9529), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9536), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9537) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9539), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9540) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9541), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9542) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9544) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9545), new DateTime(2022, 1, 27, 10, 2, 58, 429, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2634), new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2638) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2641), new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2643), new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2645), new DateTime(2022, 1, 27, 10, 2, 58, 430, DateTimeKind.Local).AddTicks(2645) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cuisines",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 319, DateTimeKind.Local).AddTicks(4453), new DateTime(2022, 1, 27, 10, 0, 16, 321, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 321, DateTimeKind.Local).AddTicks(2352), new DateTime(2022, 1, 27, 10, 0, 16, 321, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6552), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6559) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6562), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6563) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6564), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6565) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6566), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6567) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6568), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6569) });

            migrationBuilder.UpdateData(
                table: "PaymentTypes",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6570), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(6571) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9741), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9745) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9748), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9749) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9751) });

            migrationBuilder.UpdateData(
                table: "Tables",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9752), new DateTime(2022, 1, 27, 10, 0, 16, 322, DateTimeKind.Local).AddTicks(9753) });
        }
    }
}
