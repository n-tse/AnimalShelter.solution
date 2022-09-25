using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(20) CHARACTER SET utf8mb4", maxLength: 20, nullable: false),
                    Species = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Matilda", "Dog" },
                    { 2, 10, "Rexie", "Cat" },
                    { 3, 2, "Matilda", "Rabbit" },
                    { 4, 4, "Pip", "Bird" },
                    { 5, 22, "Bartholomew", "Guinea Pig" },
                    { 6, 12, "Fido", "Cat" },
                    { 7, 8, "Abracadabraalakazam", "Cat" },
                    { 8, 4, "Bigfoot", "Gecko" },
                    { 9, 9, "Casper", "Bird" },
                    { 10, 16, "Leon", "Rabbit" },
                    { 11, 13, "Coco", "Dog" },
                    { 12, 6, "Scout", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
