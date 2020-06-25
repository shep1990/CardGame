using CardGame.Domain.Data;
using CardGame.Domain.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Domain
{
    public class CardGameDbContext : DbContext
    {
        public DbSet<CardNameEntity> Cards { get; set; }

        public CardGameDbContext(DbContextOptions<CardGameDbContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CardGameEntityConfiguration());

            builder.Entity<CardNameEntity>().HasData(
                new { Id = 1, CardName = "Ace of Clubs", CardImage = "Playing_card_club_A.svg" },
                new { Id = 2, CardName = "Two of clubs", CardImage = "Playing_card_club_2.svg" },
                new { Id = 3, CardName = "Three of clubs", CardImage = "Playing_card_club_3.svg" },
                new { Id = 4, CardName = "Four of clubs", CardImage = "Playing_card_club_4.svg" },
                new { Id = 5, CardName = "Five of clubs", CardImage = "Playing_card_club_5.svg" },
                new { Id = 6, CardName = "Six of clubs", CardImage = "Playing_card_club_6.svg" },
                new { Id = 7, CardName = "Seven of clubs", CardImage = "Playing_card_club_7.svg" },
                new { Id = 8, CardName = "Eight of clubs", CardImage = "Playing_card_club_8.svg" },
                new { Id = 9, CardName = "Nine of clubs", CardImage = "Playing_card_club_9.svg" },
                new { Id = 10, CardName = "Ten of clubs", CardImage = "Playing_card_club_10.svg" },
                new { Id = 11, CardName = "Jack of clubs", CardImage = "Playing_card_club_J.svg" },
                new { Id = 12, CardName = "Queen of clubs", CardImage = "Playing_card_club_Q.svg" },
                new { Id = 13, CardName = "King of clubs", CardImage = "Playing_card_club_K.svg" },
                new { Id = 14, CardName = "Ace of diamonds", CardImage = "Playing_card_diamond_A.svg" },
                new { Id = 15, CardName = "Two of diamonds", CardImage = "Playing_card_diamond_2.svg" },
                new { Id = 16, CardName = "Three of diamonds", CardImage = "Playing_card_diamond_3.svg" },
                new { Id = 17, CardName = "Four of diamonds", CardImage = "Playing_card_diamond_4.svg" },
                new { Id = 18, CardName = "Five of Diamonds", CardImage = "Playing_card_diamond_5.svg" },
                new { Id = 19, CardName = "Six of diamonds", CardImage = "Playing_card_diamond_6.svg" },
                new { Id = 20, CardName = "Seven of diamonds", CardImage = "Playing_card_diamond_7.svg" },
                new { Id = 21, CardName = "Eight of diamonds", CardImage = "Playing_card_diamond_8.svg" },
                new { Id = 22, CardName = "Nine of diamonds", CardImage = "Playing_card_diamond_9.svg" },
                new { Id = 23, CardName = "Ten of diamonds", CardImage = "Playing_card_diamond_10.svg" },
                new { Id = 24, CardName = "Jack of diamonds", CardImage = "Playing_card_diamond_J.svg" },
                new { Id = 25, CardName = "Queen of diamonds", CardImage = "Playing_card_diamond_Q.svg" },
                new { Id = 26, CardName = "King of diamonds", CardImage = "Playing_card_diamond_K.svg" },
                new { Id = 27, CardName = "Ace of hearts", CardImage = "Playing_card_heart_A.svg" },
                new { Id = 28, CardName = "Two of hearts", CardImage = "Playing_card_heart_2.svg" },
                new { Id = 29, CardName = "Three of hearts", CardImage = "Playing_card_heart_3.svg" },
                new { Id = 30, CardName = "Four of hearts", CardImage = "Playing_card_heart_4.svg" },
                new { Id = 31, CardName = "Five of hearts", CardImage = "Playing_card_heart_5.svg" },
                new { Id = 32, CardName = "Six of hearts", CardImage = "Playing_card_heart_6.svg" },
                new { Id = 33, CardName = "Seven of hearts", CardImage = "Playing_card_heart_7.svg" },
                new { Id = 34, CardName = "Eight of hearts", CardImage = "Playing_card_heart_8.svg" },
                new { Id = 35, CardName = "Nine of hearts", CardImage = "Playing_card_heart_9.svg" },
                new { Id = 36, CardName = "Ten of hearts", CardImage = "Playing_card_heart_10.svg" },
                new { Id = 37, CardName = "Jack of hearts", CardImage = "Playing_card_heart_J.svg" },
                new { Id = 38, CardName = "Queen of hearts", CardImage = "Playing_card_heart_Q.svg" },
                new { Id = 39, CardName = "King of hearts", CardImage = "Playing_card_heart_K.svg" },
                new { Id = 40, CardName = "Ace of spades", CardImage= "Playing_card_spade_A.svg" },
                new { Id = 41, CardName = "Two of spades", CardImage = "Playing_card_spade_2.svg" },
                new { Id = 42, CardName = "Three of spades", CardImage = "Playing_card_spade_3.svg" },
                new { Id = 43, CardName = "Four of spades", CardImage = "Playing_card_spade_4.svg" },
                new { Id = 44, CardName = "Five of spades", CardImage = "Playing_card_spade_5.svg" },
                new { Id = 45, CardName = "Six of spades", CardImage = "Playing_card_spade_6.svg" },
                new { Id = 46, CardName = "Seven of spades", CardImage = "Playing_card_spade_7.svg" },
                new { Id = 47, CardName = "Eight of spades", CardImage = "Playing_card_spade_8.svg" },
                new { Id = 48, CardName = "Nine of spades", CardImage = "Playing_card_spade_9.svg" },
                new { Id = 49, CardName = "Ten of spades", CardImage = "Playing_card_spade_10.svg" },
                new { Id = 50, CardName = "Jack of spades", CardImage = "Playing_card_spade_J.svg" },
                new { Id = 51, CardName = "Queen of spades", CardImage = "Playing_card_spade_Q.svg" },
                new { Id = 52, CardName = "King of spades", CardImage = "Playing_card_spade_K.svg" }
            );
        }
    }
}
