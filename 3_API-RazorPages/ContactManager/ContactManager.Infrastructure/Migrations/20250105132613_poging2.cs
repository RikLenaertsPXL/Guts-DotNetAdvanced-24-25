using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ContactManager.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class poging2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "City", "Name", "Zip" },
                values: new object[,]
                {
                    { 1, "123 Main Street", "Techville", "TechCo", "12345" },
                    { 2, "456 Elm Street", "Widgetville", "Widgets Inc.", "67890" }
                });

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "CompanyId", "Email", "FirstName", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, 1, "john@example.com", "John", "Doe", "555-1234" },
                    { 2, 1, "jane@example.com", "Jane", "Smith", "555-5678" },
                    { 3, 2, "alice@example.com", "Alice", "Johnson", "555-4321" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
