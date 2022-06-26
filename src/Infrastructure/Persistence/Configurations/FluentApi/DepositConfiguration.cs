﻿using Domain.Entities;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Persistence.Configurations.FluentApi
{
    public class DepositConfiguration : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> b)
        {
            b.ToTable("Deposits");
            b.HasIndex(d => d.Id)
                .IsUnique();
            b.Property(d => d.DestinationId).IsRequired();
            //b.OwnsOne(typeof(Money), "Amount");
            b.OwnsOne(d => d.Amount);
        }
    }
}