﻿namespace BettingSystem.Infrastructure.Teams.Configurations
{
    using Domain.Teams.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using static Domain.Common.Models.ModelConstants.Common;

    internal class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder
                .HasKey(t => t.Id);

            builder
                .Property(t => t.Name)
                .HasMaxLength(MaxNameLength)
                .IsRequired();

            builder
                .OwnsOne(s => s.Logo, i =>
                {
                    i.WithOwner();

                    i.Property(img => img.OriginalContent).IsRequired();
                    i.Property(img => img.ThumbnailContent).IsRequired();
                });

            builder
                .HasOne(t => t.Coach)
                .WithMany()
                .HasForeignKey("CoachId")
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(t => t.Players)
                .WithOne()
                .IsRequired()
                .Metadata
                .PrincipalToDependent
                .SetField("players");
        }
    }
}
