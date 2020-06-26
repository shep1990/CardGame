using Microsoft.EntityFrameworkCore.Migrations;

namespace CardGame.Domain.Migrations
{
    public partial class CardGameTable_AddCardImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CardImage",
                table: "CardGame",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 1,
                column: "CardImage",
                value: "Playing_card_club_A.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 2,
                column: "CardImage",
                value: "Playing_card_club_2.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 3,
                column: "CardImage",
                value: "Playing_card_club_3.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 4,
                column: "CardImage",
                value: "Playing_card_club_4.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 5,
                column: "CardImage",
                value: "Playing_card_club_5.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 6,
                column: "CardImage",
                value: "Playing_card_club_6.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 7,
                column: "CardImage",
                value: "Playing_card_club_7.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 8,
                column: "CardImage",
                value: "Playing_card_club_8.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 9,
                column: "CardImage",
                value: "Playing_card_club_9.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 10,
                column: "CardImage",
                value: "Playing_card_club_10.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 11,
                column: "CardImage",
                value: "Playing_card_club_J.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 12,
                column: "CardImage",
                value: "Playing_card_club_Q.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 13,
                column: "CardImage",
                value: "Playing_card_club_K.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 14,
                column: "CardImage",
                value: "Playing_card_diamond_A.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 15,
                column: "CardImage",
                value: "Playing_card_diamond_2.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 16,
                column: "CardImage",
                value: "Playing_card_diamond_3.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 17,
                column: "CardImage",
                value: "Playing_card_diamond_4.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 18,
                column: "CardImage",
                value: "Playing_card_diamond_5.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 19,
                column: "CardImage",
                value: "Playing_card_diamond_6.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 20,
                column: "CardImage",
                value: "Playing_card_diamond_7.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 21,
                column: "CardImage",
                value: "Playing_card_diamond_8.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 22,
                column: "CardImage",
                value: "Playing_card_diamond_9.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 23,
                column: "CardImage",
                value: "Playing_card_diamond_10.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 24,
                column: "CardImage",
                value: "Playing_card_diamond_J.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 25,
                column: "CardImage",
                value: "Playing_card_diamond_Q.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 26,
                column: "CardImage",
                value: "Playing_card_diamond_K.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 27,
                column: "CardImage",
                value: "Playing_card_heart_A.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 28,
                column: "CardImage",
                value: "Playing_card_heart_2.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 29,
                column: "CardImage",
                value: "Playing_card_heart_3.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 30,
                column: "CardImage",
                value: "Playing_card_heart_4.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 31,
                column: "CardImage",
                value: "Playing_card_heart_5.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 32,
                column: "CardImage",
                value: "Playing_card_heart_6.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 33,
                column: "CardImage",
                value: "Playing_card_heart_7.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 34,
                column: "CardImage",
                value: "Playing_card_heart_8.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 35,
                column: "CardImage",
                value: "Playing_card_heart_9.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 36,
                column: "CardImage",
                value: "Playing_card_heart_10.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 37,
                column: "CardImage",
                value: "Playing_card_heart_J.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 38,
                column: "CardImage",
                value: "Playing_card_heart_Q.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 39,
                column: "CardImage",
                value: "Playing_card_heart_K.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 40,
                column: "CardImage",
                value: "Playing_card_spade_A.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 41,
                column: "CardImage",
                value: "Playing_card_spade_2.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 42,
                column: "CardImage",
                value: "Playing_card_spade_3.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 43,
                column: "CardImage",
                value: "Playing_card_spade_4.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 44,
                column: "CardImage",
                value: "Playing_card_spade_5.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 45,
                column: "CardImage",
                value: "Playing_card_spade_6.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 46,
                column: "CardImage",
                value: "Playing_card_spade_7.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 47,
                column: "CardImage",
                value: "Playing_card_spade_8.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 48,
                column: "CardImage",
                value: "Playing_card_spade_9.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 49,
                column: "CardImage",
                value: "Playing_card_spade_10.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 50,
                column: "CardImage",
                value: "Playing_card_spade_J.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 51,
                column: "CardImage",
                value: "Playing_card_spade_Q.svg");

            migrationBuilder.UpdateData(
                table: "CardGame",
                keyColumn: "Id",
                keyValue: 52,
                column: "CardImage",
                value: "Playing_card_spade_K.svg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardImage",
                table: "CardGame");
        }
    }
}
