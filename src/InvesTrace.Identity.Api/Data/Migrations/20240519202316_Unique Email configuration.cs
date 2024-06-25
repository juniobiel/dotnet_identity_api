using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvesTrace.Identity.Data.Migrations
{
    /// <inheritdoc />
    public partial class UniqueEmailconfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d11f30d-7d3a-474e-b272-a1e3ffb59155");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea809e6-c6ae-4f05-8a28-407d99c3af15");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9f11972-9652-48f0-a3f8-38f5baa4f13e", null, "Admin", "ADMIN" },
                    { "aa7cfcad-77a0-4ed2-9887-6fa9970496e8", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9f11972-9652-48f0-a3f8-38f5baa4f13e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "aa7cfcad-77a0-4ed2-9887-6fa9970496e8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d11f30d-7d3a-474e-b272-a1e3ffb59155", null, "User", "USER" },
                    { "dea809e6-c6ae-4f05-8a28-407d99c3af15", null, "Admin", "ADMIN" }
                });
        }
    }
}
