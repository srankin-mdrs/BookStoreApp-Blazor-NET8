using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededUserandRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a9f1997-9fca-4902-8c14-4d4e9bf2fe6a", null, "User", "USER" },
                    { "c4675574-d664-48aa-93b0-e2368514bcc6", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "084eacc6-32de-47c8-bde1-0cd746032f4f", 0, "1ad357f1-8a08-4a6b-8351-1cb21392b2cf", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEOkfniTFFo2MCfPnm7Js4IPhsnyoK6m+u2wPHV2Egzeb5VlLj3SgwbbyIYYI5PF1Aw==", null, false, "0f861dc9-f537-4dfe-be2b-e8034d63d919", false, "user@bookstore.com" },
                    { "5a2a01aa-74bf-46d9-b098-152125102652", 0, "9d490bc8-cebd-49b7-8706-57407b60daba", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEBYlykdxH6m6u4f6akQMICsYvh9sb7f3VqHV6jodUGkPMm6TTbgu9pGHL/u+Bxz/bw==", null, false, "41016ccb-4b6b-4883-82c9-db46373b2287", false, "admin@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5a9f1997-9fca-4902-8c14-4d4e9bf2fe6a", "084eacc6-32de-47c8-bde1-0cd746032f4f" },
                    { "c4675574-d664-48aa-93b0-e2368514bcc6", "5a2a01aa-74bf-46d9-b098-152125102652" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5a9f1997-9fca-4902-8c14-4d4e9bf2fe6a", "084eacc6-32de-47c8-bde1-0cd746032f4f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c4675574-d664-48aa-93b0-e2368514bcc6", "5a2a01aa-74bf-46d9-b098-152125102652" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a9f1997-9fca-4902-8c14-4d4e9bf2fe6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4675574-d664-48aa-93b0-e2368514bcc6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "084eacc6-32de-47c8-bde1-0cd746032f4f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a2a01aa-74bf-46d9-b098-152125102652");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "lastName");
        }
    }
}
