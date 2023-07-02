using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinesssApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Address", "Description", "Name", "Rating", "Review" },
                values: new object[,]
                {
                    { 1, "1234 Fifth Street WA", "Bakery", "Pierres Bakery", 4.7999999999999998, "Very tastey!" },
                    { 2, "1234 Fifth Street WA", "Factory", "Silly String Factory", 2.2000000000000002, "Too much work" },
                    { 3, "1234 Fifth Street WA", "Hair Salon", "Hair Salon", 3.3999999999999999, "I got an awesome mullet!" },
                    { 4, "1234 Fifth Street WA", "Pizza Parlor", "Goodboy's Pizza Parlor", 5.0, "Best Pizza In The World!" },
                    { 5, "1234 Fifth Street WA", "Dessert Shop", "James J. Jameson's Treats", 0.5, "Wouldnt give me a free treat:(" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Businesses",
                keyColumn: "BusinessId",
                keyValue: 5);
        }
    }
}