using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InvesTrace.Identity.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddingNameField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "783185db-2a6a-4a11-be02-a979edb19b87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce5e6740-a2e0-413b-b597-7280fb7565b7");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "character varying(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1d11f30d-7d3a-474e-b272-a1e3ffb59155", null, "User", "USER" },
                    { "dea809e6-c6ae-4f05-8a28-407d99c3af15", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d11f30d-7d3a-474e-b272-a1e3ffb59155");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dea809e6-c6ae-4f05-8a28-407d99c3af15");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "783185db-2a6a-4a11-be02-a979edb19b87", null, "Admin", "ADMIN" },
                    { "ce5e6740-a2e0-413b-b597-7280fb7565b7", null, "User", "USER" }
                });
        }
    }
}
