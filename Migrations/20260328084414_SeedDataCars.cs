using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebAppAdvance.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "Model", "Pasengers", "PricePerDay", "Year" },
                values: new object[,]
                {
                    { 1, "BMW", "X5", 5, 150m, 2022 },
                    { 2, "Audi", "A6", 5, 130m, 2021 },
                    { 3, "Mercedes", "C220", 5, 140m, 2020 },
                    { 4, "Toyota", "Corolla", 5, 70m, 2019 },
                    { 5, "Volkswagen", "Golf", 5, 65m, 2018 },
                    { 6, "Ford", "Focus", 5, 60m, 2017 },
                    { 7, "Honda", "Civic", 5, 85m, 2021 },
                    { 8, "Hyundai", "Tucson", 5, 110m, 2022 },
                    { 9, "Kia", "Sportage", 5, 115m, 2023 },
                    { 10, "Nissan", "Qashqai", 5, 95m, 2020 },
                    { 11, "Peugeot", "3008", 5, 100m, 2021 },
                    { 12, "Renault", "Megane", 5, 75m, 2019 },
                    { 13, "Skoda", "Octavia", 5, 90m, 2022 },
                    { 14, "Mazda", "CX-5", 5, 120m, 2021 },
                    { 15, "Subaru", "Forester", 5, 110m, 2020 },
                    { 16, "Chevrolet", "Malibu", 5, 80m, 2018 },
                    { 17, "Dacia", "Duster", 5, 70m, 2022 },
                    { 18, "Volvo", "XC60", 5, 160m, 2023 },
                    { 19, "Tesla", "Model 3", 5, 180m, 2023 },
                    { 20, "Opel", "Insignia", 5, 85m, 2019 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
