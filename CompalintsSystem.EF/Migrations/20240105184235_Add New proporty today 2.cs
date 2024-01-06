using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CompalintsSystem.EF.Migrations
{
    public partial class AddNewproportytoday2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfBirth",
                schema: "Identity",
                table: "UsersCommunications",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e803883-c018-4f7c-90e3-c3c1db0d8f00",
                column: "ConcurrencyStamp",
                value: "23452499-7786-495c-8119-81980b0f9084");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64a8ff4a-f4a2-405c-9c1a-85f0f9f46145",
                column: "ConcurrencyStamp",
                value: "0447c4d2-5de9-45a4-8db6-8f213b519786");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f95d3fd-8840-466e-9da6-d7dcf06298de",
                column: "ConcurrencyStamp",
                value: "4fc8e01e-f90e-457f-80e6-21bb687e2aa8");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81b7a93d-4221-4d50-884c-08d98676a9c8",
                column: "ConcurrencyStamp",
                value: "714454ee-dd62-4c69-9e74-e6873cd039fb");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8faa31eb-ded0-4711-8e0b-0f509c4b332f",
                column: "ConcurrencyStamp",
                value: "c29d9fb7-0096-4f4f-8592-b03d9dfa077d");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 230, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 230, DateTimeKind.Local).AddTicks(8556));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 231, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 42, 33, 231, DateTimeKind.Local).AddTicks(7113));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                schema: "Identity",
                table: "UsersCommunications");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e803883-c018-4f7c-90e3-c3c1db0d8f00",
                column: "ConcurrencyStamp",
                value: "d1132c78-1c34-4f81-8319-a663138ee3e5");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "64a8ff4a-f4a2-405c-9c1a-85f0f9f46145",
                column: "ConcurrencyStamp",
                value: "e271d810-b120-4b92-b9f1-f13eeddc3825");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f95d3fd-8840-466e-9da6-d7dcf06298de",
                column: "ConcurrencyStamp",
                value: "a61dedc2-e50e-4f32-a5f1-63dbaf959530");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81b7a93d-4221-4d50-884c-08d98676a9c8",
                column: "ConcurrencyStamp",
                value: "a4e004b8-3117-43a0-884e-33ce161cea4f");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8faa31eb-ded0-4711-8e0b-0f509c4b332f",
                column: "ConcurrencyStamp",
                value: "a318c051-b2e3-4c17-b0a4-691201db847e");

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 13, 8, 160, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeCommunications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 13, 8, 160, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 13, 8, 161, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                schema: "Identity",
                table: "TypeComplaints",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 5, 21, 13, 8, 161, DateTimeKind.Local).AddTicks(3543));
        }
    }
}
