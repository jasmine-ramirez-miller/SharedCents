using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedCents.Migrations
{
    /// <inheritdoc />
    public partial class SeedExpenses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "PartnerId", "Email", "FirstName", "MonthlyIncome" },
                values: new object[,]
                {
                    { 1, "jasmine@email.com", "Jasmine", 3200m },
                    { 2, "Adrian@email.com", "Adrian", 3500m }
                });

            migrationBuilder.InsertData(
                table: "Expenses",
                columns: new[] { "ExpenseId", "Amount", "Category", "DueDate", "ExpenseName", "IsPaid", "IsShared", "PartnerId" },
                values: new object[,]
                {
                    { 1, 1000m, "Housing", new DateTime(2026, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rent", false, true, 1 },
                    { 2, 145m, "Utilities", new DateTime(2026, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric Bill", false, true, 2 },
                    { 3, 72m, "Utilities", new DateTime(2026, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water Bill", false, true, 1 },
                    { 4, 85m, "Utilities", new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internet", true, true, 2 },
                    { 5, 210m, "Food", new DateTime(2026, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Groceries", true, true, 1 },
                    { 6, 168m, "Transportation", new DateTime(2026, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car Insurance", false, false, 1 },
                    { 7, 95m, "Utilities", new DateTime(2026, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill", false, false, 2 },
                    { 8, 48m, "Entertainment", new DateTime(2026, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Streaming Services", true, true, 1 },
                    { 9, 120m, "Transportation", new DateTime(2026, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gas", false, false, 2 },
                    { 10, 90m, "Food", new DateTime(2026, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dining Out", true, true, 1 },
                    { 11, 1000m, "Housing", new DateTime(2026, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rent", false, true, 2 },
                    { 12, 138m, "Utilities", new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Electric Bill", false, true, 1 },
                    { 13, 69m, "Utilities", new DateTime(2026, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water Bill", false, true, 2 },
                    { 14, 85m, "Utilities", new DateTime(2026, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Internet", false, true, 1 },
                    { 15, 235m, "Food", new DateTime(2026, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Groceries", false, true, 2 },
                    { 16, 420m, "Transportation", new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car Payment", false, false, 1 },
                    { 17, 168m, "Transportation", new DateTime(2026, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Car Insurance", false, false, 2 },
                    { 18, 95m, "Utilities", new DateTime(2026, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone Bill", false, false, 1 },
                    { 19, 76m, "Household", new DateTime(2026, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Household Supplies", false, true, 2 },
                    { 20, 48m, "Entertainment", new DateTime(2026, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Streaming Services", false, true, 1 },
                    { 21, 115m, "Transportation", new DateTime(2026, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gas", false, false, 2 },
                    { 22, 105m, "Food", new DateTime(2026, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dining Out", false, true, 1 },
                    { 23, 64m, "Pets", new DateTime(2026, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pet Supplies", false, true, 2 },
                    { 24, 40m, "Health", new DateTime(2026, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical Copay", false, false, 1 },
                    { 25, 250m, "Savings", new DateTime(2026, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Savings Transfer", false, true, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Expenses",
                keyColumn: "ExpenseId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "PartnerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Partners",
                keyColumn: "PartnerId",
                keyValue: 2);
        }
    }
}
