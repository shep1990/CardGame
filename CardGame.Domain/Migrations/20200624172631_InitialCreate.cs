using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CardGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardGame", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CardGame",
                columns: new[] { "Id", "CardName" },
                values: new object[,]
                {
                    { 1, "Ace of Clubs" },
                    { 29, "Three of hearts" },
                    { 30, "Four of hearts" },
                    { 31, "Five of hearts" },
                    { 32, "Six of hearts" },
                    { 33, "Seven of hearts" },
                    { 34, "Eight of hearts" },
                    { 35, "Nine of hearts" },
                    { 36, "Ten of hearts" },
                    { 37, "Jack of hearts" },
                    { 38, "Queen of hearts" },
                    { 28, "Two of hearts" },
                    { 39, "King of hearts" },
                    { 41, "Two of spades" },
                    { 42, "Three of spades" },
                    { 43, "Four of spades" },
                    { 44, "Five of spades" },
                    { 45, "Six of spades" },
                    { 46, "Seven of spades" },
                    { 47, "Eight of spades" },
                    { 48, "Nine of spades" },
                    { 49, "Ten of spades" },
                    { 50, "Jack of spades" },
                    { 40, "Ace of spades" },
                    { 27, "Ace of hearts" },
                    { 26, "King of diamonds" },
                    { 25, "Queen of diamonds" },
                    { 2, "Two of clubs" },
                    { 3, "Three of clubs" },
                    { 4, "Four of clubs" },
                    { 5, "Five of clubs" },
                    { 6, "Six of clubs" },
                    { 7, "Seven of clubs" },
                    { 8, "Eight of clubs" },
                    { 9, "Nine of clubs" },
                    { 10, "Ten of clubs" },
                    { 11, "Jack of clubs" },
                    { 12, "Queen of clubs" },
                    { 13, "King of clubs" },
                    { 14, "Ace of diamonds" },
                    { 15, "Two of diamonds" },
                    { 16, "Three of diamonds" },
                    { 17, "Four of diamonds" },
                    { 18, "Five of Diamonds" },
                    { 19, "Six of diamonds" },
                    { 20, "Seven of diamonds" },
                    { 21, "Eight of diamonds" },
                    { 22, "Nine of diamonds" },
                    { 23, "Ten of diamonds" },
                    { 24, "Jack of diamonds" },
                    { 51, "Queen of spades" },
                    { 52, "King of spades" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CardGame_Id",
                table: "CardGame",
                column: "Id",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CardGame");
        }
    }
}
