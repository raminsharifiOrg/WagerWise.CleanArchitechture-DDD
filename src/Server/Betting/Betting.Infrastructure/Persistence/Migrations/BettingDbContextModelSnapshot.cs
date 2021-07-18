﻿// <auto-generated />
using System;
using BettingSystem.Infrastructure.Betting.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BettingSystem.Infrastructure.Betting.Persistence.Migrations
{
    [DbContext(typeof(BettingDbContext))]
    partial class BettingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BettingSystem.Domain.Betting.Models.Bets.Bet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Amount")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.Property<int>("GamblerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsProfitable")
                        .HasColumnType("bit");

                    b.Property<int>("MatchId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GamblerId");

                    b.HasIndex("MatchId");

                    b.ToTable("Bets");
                });

            modelBuilder.Entity("BettingSystem.Domain.Betting.Models.Gamblers.Gambler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Balance")
                        .HasPrecision(19, 4)
                        .HasColumnType("decimal(19,4)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Gamblers");
                });

            modelBuilder.Entity("BettingSystem.Domain.Betting.Models.Matches.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("BettingSystem.Domain.Betting.Models.Bets.Bet", b =>
                {
                    b.HasOne("BettingSystem.Domain.Betting.Models.Gamblers.Gambler", null)
                        .WithMany("Bets")
                        .HasForeignKey("GamblerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BettingSystem.Domain.Betting.Models.Matches.Match", "Match")
                        .WithMany()
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("BettingSystem.Domain.Betting.Models.Bets.Prediction", "Prediction", b1 =>
                        {
                            b1.Property<int>("BetId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("BetId");

                            b1.ToTable("Bets");

                            b1.WithOwner()
                                .HasForeignKey("BetId");
                        });

                    b.Navigation("Match");

                    b.Navigation("Prediction")
                        .IsRequired();
                });

            modelBuilder.Entity("BettingSystem.Domain.Betting.Models.Matches.Match", b =>
                {
                    b.OwnsOne("BettingSystem.Domain.Betting.Models.Matches.Statistics", "Statistics", b1 =>
                        {
                            b1.Property<int>("MatchId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int?>("AwayScore")
                                .HasColumnType("int");

                            b1.Property<int?>("HalfTimeAwayScore")
                                .HasColumnType("int");

                            b1.Property<int?>("HalfTimeHomeScore")
                                .HasColumnType("int");

                            b1.Property<int?>("HomeScore")
                                .HasColumnType("int");

                            b1.HasKey("MatchId");

                            b1.ToTable("Matches");

                            b1.WithOwner()
                                .HasForeignKey("MatchId");
                        });

                    b.OwnsOne("BettingSystem.Domain.Betting.Models.Matches.Status", "Status", b1 =>
                        {
                            b1.Property<int>("MatchId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("MatchId");

                            b1.ToTable("Matches");

                            b1.WithOwner()
                                .HasForeignKey("MatchId");
                        });

                    b.Navigation("Statistics")
                        .IsRequired();

                    b.Navigation("Status")
                        .IsRequired();
                });

            modelBuilder.Entity("BettingSystem.Domain.Betting.Models.Gamblers.Gambler", b =>
                {
                    b.Navigation("Bets");
                });
#pragma warning restore 612, 618
        }
    }
}
