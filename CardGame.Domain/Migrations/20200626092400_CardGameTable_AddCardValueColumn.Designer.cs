﻿// <auto-generated />
using CardGame.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardGame.Domain.Migrations
{
    [DbContext(typeof(CardGameDbContext))]
    [Migration("20200626092400_CardGameTable_AddCardValueColumn")]
    partial class CardGameTable_AddCardValueColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardGame.Domain.Data.CardEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardImage");

                    b.Property<string>("CardName");

                    b.Property<int>("CardValue");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("CardGame");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardImage = "Playing_card_club_A.svg",
                            CardName = "Ace of Clubs",
                            CardValue = 14
                        },
                        new
                        {
                            Id = 2,
                            CardImage = "Playing_card_club_2.svg",
                            CardName = "Two of clubs",
                            CardValue = 2
                        },
                        new
                        {
                            Id = 3,
                            CardImage = "Playing_card_club_3.svg",
                            CardName = "Three of clubs",
                            CardValue = 3
                        },
                        new
                        {
                            Id = 4,
                            CardImage = "Playing_card_club_4.svg",
                            CardName = "Four of clubs",
                            CardValue = 4
                        },
                        new
                        {
                            Id = 5,
                            CardImage = "Playing_card_club_5.svg",
                            CardName = "Five of clubs",
                            CardValue = 5
                        },
                        new
                        {
                            Id = 6,
                            CardImage = "Playing_card_club_6.svg",
                            CardName = "Six of clubs",
                            CardValue = 6
                        },
                        new
                        {
                            Id = 7,
                            CardImage = "Playing_card_club_7.svg",
                            CardName = "Seven of clubs",
                            CardValue = 7
                        },
                        new
                        {
                            Id = 8,
                            CardImage = "Playing_card_club_8.svg",
                            CardName = "Eight of clubs",
                            CardValue = 8
                        },
                        new
                        {
                            Id = 9,
                            CardImage = "Playing_card_club_9.svg",
                            CardName = "Nine of clubs",
                            CardValue = 9
                        },
                        new
                        {
                            Id = 10,
                            CardImage = "Playing_card_club_10.svg",
                            CardName = "Ten of clubs",
                            CardValue = 10
                        },
                        new
                        {
                            Id = 11,
                            CardImage = "Playing_card_club_J.svg",
                            CardName = "Jack of clubs",
                            CardValue = 11
                        },
                        new
                        {
                            Id = 12,
                            CardImage = "Playing_card_club_Q.svg",
                            CardName = "Queen of clubs",
                            CardValue = 12
                        },
                        new
                        {
                            Id = 13,
                            CardImage = "Playing_card_club_K.svg",
                            CardName = "King of clubs",
                            CardValue = 13
                        },
                        new
                        {
                            Id = 14,
                            CardImage = "Playing_card_diamond_A.svg",
                            CardName = "Ace of diamonds",
                            CardValue = 14
                        },
                        new
                        {
                            Id = 15,
                            CardImage = "Playing_card_diamond_2.svg",
                            CardName = "Two of diamonds",
                            CardValue = 2
                        },
                        new
                        {
                            Id = 16,
                            CardImage = "Playing_card_diamond_3.svg",
                            CardName = "Three of diamonds",
                            CardValue = 3
                        },
                        new
                        {
                            Id = 17,
                            CardImage = "Playing_card_diamond_4.svg",
                            CardName = "Four of diamonds",
                            CardValue = 4
                        },
                        new
                        {
                            Id = 18,
                            CardImage = "Playing_card_diamond_5.svg",
                            CardName = "Five of Diamonds",
                            CardValue = 5
                        },
                        new
                        {
                            Id = 19,
                            CardImage = "Playing_card_diamond_6.svg",
                            CardName = "Six of diamonds",
                            CardValue = 6
                        },
                        new
                        {
                            Id = 20,
                            CardImage = "Playing_card_diamond_7.svg",
                            CardName = "Seven of diamonds",
                            CardValue = 7
                        },
                        new
                        {
                            Id = 21,
                            CardImage = "Playing_card_diamond_8.svg",
                            CardName = "Eight of diamonds",
                            CardValue = 8
                        },
                        new
                        {
                            Id = 22,
                            CardImage = "Playing_card_diamond_9.svg",
                            CardName = "Nine of diamonds",
                            CardValue = 9
                        },
                        new
                        {
                            Id = 23,
                            CardImage = "Playing_card_diamond_10.svg",
                            CardName = "Ten of diamonds",
                            CardValue = 10
                        },
                        new
                        {
                            Id = 24,
                            CardImage = "Playing_card_diamond_J.svg",
                            CardName = "Jack of diamonds",
                            CardValue = 11
                        },
                        new
                        {
                            Id = 25,
                            CardImage = "Playing_card_diamond_Q.svg",
                            CardName = "Queen of diamonds",
                            CardValue = 12
                        },
                        new
                        {
                            Id = 26,
                            CardImage = "Playing_card_diamond_K.svg",
                            CardName = "King of diamonds",
                            CardValue = 13
                        },
                        new
                        {
                            Id = 27,
                            CardImage = "Playing_card_heart_A.svg",
                            CardName = "Ace of hearts",
                            CardValue = 14
                        },
                        new
                        {
                            Id = 28,
                            CardImage = "Playing_card_heart_2.svg",
                            CardName = "Two of hearts",
                            CardValue = 2
                        },
                        new
                        {
                            Id = 29,
                            CardImage = "Playing_card_heart_3.svg",
                            CardName = "Three of hearts",
                            CardValue = 3
                        },
                        new
                        {
                            Id = 30,
                            CardImage = "Playing_card_heart_4.svg",
                            CardName = "Four of hearts",
                            CardValue = 4
                        },
                        new
                        {
                            Id = 31,
                            CardImage = "Playing_card_heart_5.svg",
                            CardName = "Five of hearts",
                            CardValue = 5
                        },
                        new
                        {
                            Id = 32,
                            CardImage = "Playing_card_heart_6.svg",
                            CardName = "Six of hearts",
                            CardValue = 6
                        },
                        new
                        {
                            Id = 33,
                            CardImage = "Playing_card_heart_7.svg",
                            CardName = "Seven of hearts",
                            CardValue = 7
                        },
                        new
                        {
                            Id = 34,
                            CardImage = "Playing_card_heart_8.svg",
                            CardName = "Eight of hearts",
                            CardValue = 8
                        },
                        new
                        {
                            Id = 35,
                            CardImage = "Playing_card_heart_9.svg",
                            CardName = "Nine of hearts",
                            CardValue = 9
                        },
                        new
                        {
                            Id = 36,
                            CardImage = "Playing_card_heart_10.svg",
                            CardName = "Ten of hearts",
                            CardValue = 10
                        },
                        new
                        {
                            Id = 37,
                            CardImage = "Playing_card_heart_J.svg",
                            CardName = "Jack of hearts",
                            CardValue = 11
                        },
                        new
                        {
                            Id = 38,
                            CardImage = "Playing_card_heart_Q.svg",
                            CardName = "Queen of hearts",
                            CardValue = 12
                        },
                        new
                        {
                            Id = 39,
                            CardImage = "Playing_card_heart_K.svg",
                            CardName = "King of hearts",
                            CardValue = 13
                        },
                        new
                        {
                            Id = 40,
                            CardImage = "Playing_card_spade_A.svg",
                            CardName = "Ace of spades",
                            CardValue = 14
                        },
                        new
                        {
                            Id = 41,
                            CardImage = "Playing_card_spade_2.svg",
                            CardName = "Two of spades",
                            CardValue = 2
                        },
                        new
                        {
                            Id = 42,
                            CardImage = "Playing_card_spade_3.svg",
                            CardName = "Three of spades",
                            CardValue = 3
                        },
                        new
                        {
                            Id = 43,
                            CardImage = "Playing_card_spade_4.svg",
                            CardName = "Four of spades",
                            CardValue = 4
                        },
                        new
                        {
                            Id = 44,
                            CardImage = "Playing_card_spade_5.svg",
                            CardName = "Five of spades",
                            CardValue = 5
                        },
                        new
                        {
                            Id = 45,
                            CardImage = "Playing_card_spade_6.svg",
                            CardName = "Six of spades",
                            CardValue = 6
                        },
                        new
                        {
                            Id = 46,
                            CardImage = "Playing_card_spade_7.svg",
                            CardName = "Seven of spades",
                            CardValue = 7
                        },
                        new
                        {
                            Id = 47,
                            CardImage = "Playing_card_spade_8.svg",
                            CardName = "Eight of spades",
                            CardValue = 8
                        },
                        new
                        {
                            Id = 48,
                            CardImage = "Playing_card_spade_9.svg",
                            CardName = "Nine of spades",
                            CardValue = 9
                        },
                        new
                        {
                            Id = 49,
                            CardImage = "Playing_card_spade_10.svg",
                            CardName = "Ten of spades",
                            CardValue = 10
                        },
                        new
                        {
                            Id = 50,
                            CardImage = "Playing_card_spade_J.svg",
                            CardName = "Jack of spades",
                            CardValue = 11
                        },
                        new
                        {
                            Id = 51,
                            CardImage = "Playing_card_spade_Q.svg",
                            CardName = "Queen of spades",
                            CardValue = 12
                        },
                        new
                        {
                            Id = 52,
                            CardImage = "Playing_card_spade_K.svg",
                            CardName = "King of spades",
                            CardValue = 13
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
