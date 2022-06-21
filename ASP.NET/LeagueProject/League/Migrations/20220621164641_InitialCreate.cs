using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace League.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cake",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    Prices = table.Column<double>(type: "REAL", nullable: false),
                    ImgURL = table.Column<string>(type: "TEXT", nullable: true),
                    Modal = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cake", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drink",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    Prices = table.Column<double>(type: "REAL", nullable: false),
                    ImgURL = table.Column<string>(type: "TEXT", nullable: true),
                    Modal = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drink", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FastFood",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Ingredients = table.Column<string>(type: "TEXT", nullable: true),
                    Calories = table.Column<int>(type: "INTEGER", nullable: false),
                    Rating = table.Column<double>(type: "REAL", nullable: false),
                    Prices = table.Column<double>(type: "REAL", nullable: false),
                    ImgURL = table.Column<string>(type: "TEXT", nullable: true),
                    Modal = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FastFood", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    cakeID = table.Column<int>(type: "INTEGER", nullable: false),
                    drinkID = table.Column<int>(type: "INTEGER", nullable: false),
                    fastFoodID = table.Column<int>(type: "INTEGER", nullable: false),
                    Price = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Food_Cake_cakeID",
                        column: x => x.cakeID,
                        principalTable: "Cake",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Food_Drink_drinkID",
                        column: x => x.drinkID,
                        principalTable: "Drink",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Food_FastFood_fastFoodID",
                        column: x => x.fastFoodID,
                        principalTable: "FastFood",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_cakeID",
                table: "Food",
                column: "cakeID");

            migrationBuilder.CreateIndex(
                name: "IX_Food_drinkID",
                table: "Food",
                column: "drinkID");

            migrationBuilder.CreateIndex(
                name: "IX_Food_fastFoodID",
                table: "Food",
                column: "fastFoodID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Cake");

            migrationBuilder.DropTable(
                name: "Drink");

            migrationBuilder.DropTable(
                name: "FastFood");
        }
    }
}
