using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Bulky.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddPrdouctTableWithData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISBN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListPrice = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Price50 = table.Column<double>(type: "float", nullable: false),
                    Price100 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "products",
                columns: new[] { "Id", "Author", "Description", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[,]
                {
                    { 1, "Billy Spark", "A thrilling journey through the mysteries of time.", "SWD999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" },
                    { 2, "Jane Doe", "Unlock the secrets of programming with practical examples.", "SWD999002", 120.0, 110.0, 100.0, 105.0, "Mastering the Code" },
                    { 3, "Chef Ramsey", "Delicious recipes with a contemporary twist.", "SWD999003", 45.0, 40.0, 35.0, 38.0, "Cooking the Modern Way" },
                    { 4, "John Fit", "Your ultimate guide to a healthy and active lifestyle.", "SWD999004", 60.0, 55.0, 48.0, 50.0, "Fitness for Life" },
                    { 5, "Creative Mind", "Explore the beauty and functionality of modern design.", "SWD999005", 80.0, 75.0, 65.0, 70.0, "Art of Design" },
                    { 6, "Astro Nova", "A fascinating look into the wonders of the universe.", "SWD999006", 150.0, 140.0, 130.0, 135.0, "Space and Beyond" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);
        }
    }
}
