using CardGame.Domain.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CardGame.Domain.EntityConfigurations
{
    public class CardGameEntityConfiguration : IEntityTypeConfiguration<CardNameEntity>
    {
        public void Configure(EntityTypeBuilder<CardNameEntity> builder)
        {
            builder.ToTable("CardGame");

            builder.HasIndex(x => x.Id)
                .IsUnique();

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}
