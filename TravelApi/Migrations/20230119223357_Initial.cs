using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Location = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Country = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    State = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Review = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Destinations",
                columns: new[] { "DestinationId", "Country", "Location", "Rating", "Review", "State" },
                values: new object[,]
                {
                    { 1, "Canada", "Montreal", 4, "Lovely city, great architecture and food, best to visit in summer (winter is cold).", "Quebec" },
                    { 2, "Canada", "Vancouver", 5, "Great place, especially if you love a mix of outdoors and urban life. Delicious food and shopping, mild weather in the winter.", "B.C." },
                    { 3, "Australia", "Sydney", 5, "Such a fun city. All the usual tourist destinations a must, but head north too. Manly is beautiful. Or East to the Blue Mountains for the coolest caves.", "NSW" },
                    { 4, "USA", "Honolulu", 3, "Love Hawaii, and a Honolulu is a must stop, but don't spend all your time here. Visit other islands first, then a couple nights here. Plan a trip to Pearl Harbor, hike Diamond Head, and head out to North Shore.", "Hawaii" },
                    { 5, "Mexico", "Bucerias", 4, "Great little town. Personally like the pace better than Puerto Vallarta. And the food is excellent. Try the burrito wherever you go. Relaxing vacation.", "Nayarit" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
