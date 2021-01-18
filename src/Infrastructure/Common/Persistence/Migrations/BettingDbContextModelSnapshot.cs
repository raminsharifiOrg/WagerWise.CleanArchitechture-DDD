﻿// <auto-generated />
using System;
using BettingSystem.Infrastructure.Common.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BettingSystem.Infrastructure.Common.Persistence.Migrations
{
    [DbContext(typeof(BettingDbContext))]
    partial class BettingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("BettingSystem.Domain.Teams.Models.Player", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Players");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.BetData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

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

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.GamblerData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Gamblers");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.GroupData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TournamentId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TournamentId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.MatchData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("AwayTeamId")
                        .HasColumnType("int");

                    b.Property<int?>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<int>("StadiumId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AwayTeamId");

                    b.HasIndex("GroupId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("StadiumId");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.StadiumData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(2048)
                        .HasColumnType("nvarchar(2048)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Stadiums");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.TeamData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Points")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.TournamentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Tournaments");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Identity.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BettingSystem.Domain.Teams.Models.Player", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.TeamData", null)
                        .WithMany("Players")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("BettingSystem.Domain.Teams.Models.Position", "Position", b1 =>
                        {
                            b1.Property<int>("PlayerId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("PlayerId");

                            b1.ToTable("Players");

                            b1.WithOwner()
                                .HasForeignKey("PlayerId");
                        });

                    b.Navigation("Position")
                        .IsRequired();
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.BetData", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.GamblerData", "Gambler")
                        .WithMany("Bets")
                        .HasForeignKey("GamblerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.MatchData", "Match")
                        .WithMany("Bets")
                        .HasForeignKey("MatchId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("BettingSystem.Domain.Betting.Models.Bets.Prediction", "Prediction", b1 =>
                        {
                            b1.Property<int>("BetDataId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("BetDataId");

                            b1.ToTable("Bets");

                            b1.WithOwner()
                                .HasForeignKey("BetDataId");
                        });

                    b.Navigation("Gambler");

                    b.Navigation("Match");

                    b.Navigation("Prediction")
                        .IsRequired();
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.GamblerData", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Identity.User", null)
                        .WithOne()
                        .HasForeignKey("BettingSystem.Infrastructure.Common.Persistence.Models.GamblerData", "UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.GroupData", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.TournamentData", "Tournament")
                        .WithMany("Groups")
                        .HasForeignKey("TournamentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Tournament");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.MatchData", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.TeamData", "AwayTeam")
                        .WithMany()
                        .HasForeignKey("AwayTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.GroupData", "Group")
                        .WithMany("Matches")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.TeamData", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BettingSystem.Infrastructure.Common.Persistence.Models.StadiumData", "Stadium")
                        .WithMany("Matches")
                        .HasForeignKey("StadiumId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.OwnsOne("BettingSystem.Infrastructure.Common.Persistence.Models.StatisticsData", "Statistics", b1 =>
                        {
                            b1.Property<int>("MatchDataId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int?>("AwayScore")
                                .HasColumnType("int");

                            b1.Property<int?>("HalfTimeAwayScore")
                                .HasColumnType("int");

                            b1.Property<int?>("HalfTimeHomeScore")
                                .HasColumnType("int");

                            b1.Property<int?>("HomeScore")
                                .HasColumnType("int");

                            b1.HasKey("MatchDataId");

                            b1.ToTable("Matches");

                            b1.WithOwner()
                                .HasForeignKey("MatchDataId");
                        });

                    b.OwnsOne("BettingSystem.Infrastructure.Common.Persistence.Models.StatusData", "Status", b1 =>
                        {
                            b1.Property<int>("MatchDataId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<int>("Value")
                                .HasColumnType("int");

                            b1.HasKey("MatchDataId");

                            b1.ToTable("Matches");

                            b1.WithOwner()
                                .HasForeignKey("MatchDataId");
                        });

                    b.Navigation("AwayTeam");

                    b.Navigation("Group");

                    b.Navigation("HomeTeam");

                    b.Navigation("Stadium");

                    b.Navigation("Statistics")
                        .IsRequired();

                    b.Navigation("Status")
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BettingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BettingSystem.Infrastructure.Identity.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.GamblerData", b =>
                {
                    b.Navigation("Bets");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.GroupData", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.MatchData", b =>
                {
                    b.Navigation("Bets");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.StadiumData", b =>
                {
                    b.Navigation("Matches");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.TeamData", b =>
                {
                    b.Navigation("Players");
                });

            modelBuilder.Entity("BettingSystem.Infrastructure.Common.Persistence.Models.TournamentData", b =>
                {
                    b.Navigation("Groups");
                });
#pragma warning restore 612, 618
        }
    }
}
