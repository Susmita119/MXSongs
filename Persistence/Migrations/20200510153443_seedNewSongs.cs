using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class seedNewSongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 5, "Palak Muchhal", "MS Dhoni", "Kaun tujhe" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 6, "Neha Kakkar", "Fever", "Mile ho tum" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 7, "Neha Kakkar", "Wajah tum", "Mahi ve" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 8, "Young Desi", "Luka Chuppi", "Coca cola" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 1, "Palak Muchhal", "MS Dhoni", "Kaun tujhe" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 2, "Neha Kakkar", "Fever", "Mile ho tum" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 3, "Neha Kakkar", "Wajah tum", "Mahi ve" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Movie", "Name" },
                values: new object[] { 4, "Young Desi", "Luka Chuppi", "Coca cola" });
        }
    }
}
