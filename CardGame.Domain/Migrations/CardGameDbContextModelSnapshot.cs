﻿// <auto-generated />
using CardGame.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CardGame.Domain.Migrations
{
    [DbContext(typeof(CardGameDbContext))]
    partial class CardGameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CardGame.Domain.Data.CardNameEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardName");

                    b.HasKey("Id");

                    b.HasIndex("Id")
                        .IsUnique();

                    b.ToTable("CardGame");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CardName = "Ace of Clubs"
                        },
                        new
                        {
                            Id = 2,
                            CardName = "Two of clubs"
                        },
                        new
                        {
                            Id = 3,
                            CardName = "Three of clubs"
                        },
                        new
                        {
                            Id = 4,
                            CardName = "Four of clubs"
                        },
                        new
                        {
                            Id = 5,
                            CardName = "Five of clubs"
                        },
                        new
                        {
                            Id = 6,
                            CardName = "Six of clubs"
                        },
                        new
                        {
                            Id = 7,
                            CardName = "Seven of clubs"
                        },
                        new
                        {
                            Id = 8,
                            CardName = "Eight of clubs"
                        },
                        new
                        {
                            Id = 9,
                            CardName = "Nine of clubs"
                        },
                        new
                        {
                            Id = 10,
                            CardName = "Ten of clubs"
                        },
                        new
                        {
                            Id = 11,
                            CardName = "Jack of clubs"
                        },
                        new
                        {
                            Id = 12,
                            CardName = "Queen of clubs"
                        },
                        new
                        {
                            Id = 13,
                            CardName = "King of clubs"
                        },
                        new
                        {
                            Id = 14,
                            CardName = "Ace of diamonds"
                        },
                        new
                        {
                            Id = 15,
                            CardName = "Two of diamonds"
                        },
                        new
                        {
                            Id = 16,
                            CardName = "Three of diamonds"
                        },
                        new
                        {
                            Id = 17,
                            CardName = "Four of diamonds"
                        },
                        new
                        {
                            Id = 18,
                            CardName = "Five of Diamonds"
                        },
                        new
                        {
                            Id = 19,
                            CardName = "Six of diamonds"
                        },
                        new
                        {
                            Id = 20,
                            CardName = "Seven of diamonds"
                        },
                        new
                        {
                            Id = 21,
                            CardName = "Eight of diamonds"
                        },
                        new
                        {
                            Id = 22,
                            CardName = "Nine of diamonds"
                        },
                        new
                        {
                            Id = 23,
                            CardName = "Ten of diamonds"
                        },
                        new
                        {
                            Id = 24,
                            CardName = "Jack of diamonds"
                        },
                        new
                        {
                            Id = 25,
                            CardName = "Queen of diamonds"
                        },
                        new
                        {
                            Id = 26,
                            CardName = "King of diamonds"
                        },
                        new
                        {
                            Id = 27,
                            CardName = "Ace of hearts"
                        },
                        new
                        {
                            Id = 28,
                            CardName = "Two of hearts"
                        },
                        new
                        {
                            Id = 29,
                            CardName = "Three of hearts"
                        },
                        new
                        {
                            Id = 30,
                            CardName = "Four of hearts"
                        },
                        new
                        {
                            Id = 31,
                            CardName = "Five of hearts"
                        },
                        new
                        {
                            Id = 32,
                            CardName = "Six of hearts"
                        },
                        new
                        {
                            Id = 33,
                            CardName = "Seven of hearts"
                        },
                        new
                        {
                            Id = 34,
                            CardName = "Eight of hearts"
                        },
                        new
                        {
                            Id = 35,
                            CardName = "Nine of hearts"
                        },
                        new
                        {
                            Id = 36,
                            CardName = "Ten of hearts"
                        },
                        new
                        {
                            Id = 37,
                            CardName = "Jack of hearts"
                        },
                        new
                        {
                            Id = 38,
                            CardName = "Queen of hearts"
                        },
                        new
                        {
                            Id = 39,
                            CardName = "King of hearts"
                        },
                        new
                        {
                            Id = 40,
                            CardName = "Ace of spades"
                        },
                        new
                        {
                            Id = 41,
                            CardName = "Two of spades"
                        },
                        new
                        {
                            Id = 42,
                            CardName = "Three of spades"
                        },
                        new
                        {
                            Id = 43,
                            CardName = "Four of spades"
                        },
                        new
                        {
                            Id = 44,
                            CardName = "Five of spades"
                        },
                        new
                        {
                            Id = 45,
                            CardName = "Six of spades"
                        },
                        new
                        {
                            Id = 46,
                            CardName = "Seven of spades"
                        },
                        new
                        {
                            Id = 47,
                            CardName = "Eight of spades"
                        },
                        new
                        {
                            Id = 48,
                            CardName = "Nine of spades"
                        },
                        new
                        {
                            Id = 49,
                            CardName = "Ten of spades"
                        },
                        new
                        {
                            Id = 50,
                            CardName = "Jack of spades"
                        },
                        new
                        {
                            Id = 51,
                            CardName = "Queen of spades"
                        },
                        new
                        {
                            Id = 52,
                            CardName = "King of spades"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
