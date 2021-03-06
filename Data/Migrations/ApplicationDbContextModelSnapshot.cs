﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyLeagueDashboard.Data;

namespace MyLeagueDashboard.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

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
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

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
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.MatchDB", b =>
                {
                    b.Property<int>("MatchDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GameDuration")
                        .HasColumnType("bigint");

                    b.Property<long>("GameID")
                        .HasColumnType("bigint");

                    b.Property<string>("GameMode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GameType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MapID")
                        .HasColumnType("int");

                    b.Property<string>("PlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QueueID")
                        .HasColumnType("int");

                    b.Property<int>("SeasonID")
                        .HasColumnType("int");

                    b.HasKey("MatchDBID");

                    b.ToTable("MatchesDB");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.ParticipantDB", b =>
                {
                    b.Property<int>("ParticipantDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<string>("CurrentAccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HighestAchievedSeasonTier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatchDBID")
                        .HasColumnType("int");

                    b.Property<string>("MatchHistoryURI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParticipantID")
                        .HasColumnType("int");

                    b.Property<string>("PlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileIcon")
                        .HasColumnType("int");

                    b.Property<int>("Spell1ID")
                        .HasColumnType("int");

                    b.Property<int>("Spell2ID")
                        .HasColumnType("int");

                    b.Property<int?>("StatsParticipantStatsDBID")
                        .HasColumnType("int");

                    b.Property<string>("SummonerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummonerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.HasKey("ParticipantDBID");

                    b.HasIndex("MatchDBID");

                    b.HasIndex("StatsParticipantStatsDBID");

                    b.ToTable("ParticipantDB");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.ParticipantIdentityDB", b =>
                {
                    b.Property<int>("ParticipantIdentityDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Index")
                        .HasColumnType("int");

                    b.Property<int?>("MatchDBID")
                        .HasColumnType("int");

                    b.Property<int>("PlayerDBID")
                        .HasColumnType("int");

                    b.HasKey("ParticipantIdentityDBID");

                    b.HasIndex("MatchDBID");

                    b.HasIndex("PlayerDBID");

                    b.ToTable("ParticipantIdentityDB");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.ParticipantStatsDB", b =>
                {
                    b.Property<int>("ParticipantStatsDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("ChampLevel")
                        .HasColumnType("int");

                    b.Property<int>("CombatPlayerScore")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<bool>("FirstBloodKill")
                        .HasColumnType("bit");

                    b.Property<int>("GoldEarned")
                        .HasColumnType("int");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("LargestKillingSpree")
                        .HasColumnType("int");

                    b.Property<int>("ObjectivePlayerScore")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantID")
                        .HasColumnType("int");

                    b.Property<long>("TotalDamageDealt")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalDamageDealtToChampions")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalMinionsKilled")
                        .HasColumnType("int");

                    b.Property<int>("TotalPlayerScore")
                        .HasColumnType("int");

                    b.Property<int>("TotalScoreRank")
                        .HasColumnType("int");

                    b.Property<long>("VisionScore")
                        .HasColumnType("bigint");

                    b.Property<int>("WardsPlaced")
                        .HasColumnType("int");

                    b.Property<bool>("Win")
                        .HasColumnType("bit");

                    b.HasKey("ParticipantStatsDBID");

                    b.ToTable("ParticipantStatsDB");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.PlayerDB", b =>
                {
                    b.Property<int>("PlayerDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentAccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatchHistoryURI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileIcon")
                        .HasColumnType("int");

                    b.Property<string>("SummonerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummonerName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PlayerDBID");

                    b.ToTable("PlayerDB");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.PlayerInfoDB", b =>
                {
                    b.Property<int>("PlayerInfoDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("ChampLevel")
                        .HasColumnType("int");

                    b.Property<int>("ChampionID")
                        .HasColumnType("int");

                    b.Property<int>("CombatPlayerScore")
                        .HasColumnType("int");

                    b.Property<string>("CurrentAccountID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurrentPlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<bool>("FirstBloodKill")
                        .HasColumnType("bit");

                    b.Property<long>("GameID")
                        .HasColumnType("bigint");

                    b.Property<int>("GoldEarned")
                        .HasColumnType("int");

                    b.Property<string>("HighestAchievedSeasonTier")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<int>("LargestKillingSpree")
                        .HasColumnType("int");

                    b.Property<int?>("MatchDBID")
                        .HasColumnType("int");

                    b.Property<string>("MatchHistoryURI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ObjectivePlayerScore")
                        .HasColumnType("int");

                    b.Property<int>("ParticipantID")
                        .HasColumnType("int");

                    b.Property<string>("PlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileIcon")
                        .HasColumnType("int");

                    b.Property<int>("Spell1ID")
                        .HasColumnType("int");

                    b.Property<int>("Spell2ID")
                        .HasColumnType("int");

                    b.Property<string>("SummonerID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SummonerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<long>("TotalDamageDealt")
                        .HasColumnType("bigint");

                    b.Property<long>("TotalDamageDealtToChampions")
                        .HasColumnType("bigint");

                    b.Property<int>("TotalMinionsKilled")
                        .HasColumnType("int");

                    b.Property<int>("TotalPlayerScore")
                        .HasColumnType("int");

                    b.Property<int>("TotalScoreRank")
                        .HasColumnType("int");

                    b.Property<long>("VisionScore")
                        .HasColumnType("bigint");

                    b.Property<int>("WardsPlaced")
                        .HasColumnType("int");

                    b.Property<bool>("Win")
                        .HasColumnType("bit");

                    b.HasKey("PlayerInfoDBID");

                    b.HasIndex("MatchDBID");

                    b.ToTable("PlayerInfoDBs");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.TeamStatsDB", b =>
                {
                    b.Property<int>("TeamStatsDBID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BaronKills")
                        .HasColumnType("int");

                    b.Property<int>("DragonKills")
                        .HasColumnType("int");

                    b.Property<bool>("FirstBlood")
                        .HasColumnType("bit");

                    b.Property<long>("GameID")
                        .HasColumnType("bigint");

                    b.Property<int>("InhibitorKills")
                        .HasColumnType("int");

                    b.Property<int?>("MatchDBID")
                        .HasColumnType("int");

                    b.Property<int>("RiftHeraldKills")
                        .HasColumnType("int");

                    b.Property<int>("TeamID")
                        .HasColumnType("int");

                    b.Property<int>("TowerKills")
                        .HasColumnType("int");

                    b.Property<string>("Win")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamStatsDBID");

                    b.HasIndex("MatchDBID");

                    b.ToTable("TeamStatsDBs");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.Matches", b =>
                {
                    b.Property<int>("MatchesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Champion")
                        .HasColumnType("int");

                    b.Property<string>("GameID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lane")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MatchDBID")
                        .HasColumnType("int");

                    b.Property<int>("MatchesResponseID")
                        .HasColumnType("int");

                    b.Property<string>("PlatformID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Queue")
                        .HasColumnType("int");

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Season")
                        .HasColumnType("int");

                    b.Property<long>("Timestamp")
                        .HasColumnType("bigint");

                    b.HasKey("MatchesID");

                    b.HasIndex("MatchDBID");

                    b.HasIndex("MatchesResponseID");

                    b.ToTable("Matches");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.MatchesResponse", b =>
                {
                    b.Property<int>("MatchesResponseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SummonerID")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MatchesResponseID");

                    b.ToTable("MatchesResponses");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.Summoner", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AccountId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Assists")
                        .HasColumnType("int");

                    b.Property<int>("Deaths")
                        .HasColumnType("int");

                    b.Property<float>("KDA")
                        .HasColumnType("real");

                    b.Property<int>("Kills")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileIconId")
                        .HasColumnType("int");

                    b.Property<string>("PuuId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Region")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RevisionDate")
                        .HasColumnType("bigint");

                    b.Property<int>("SummonerLevel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Summoners");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.ParticipantDB", b =>
                {
                    b.HasOne("MyLeagueDashboard.Models.DB.MatchDB", null)
                        .WithMany("Participants")
                        .HasForeignKey("MatchDBID");

                    b.HasOne("MyLeagueDashboard.Models.DB.ParticipantStatsDB", "Stats")
                        .WithMany()
                        .HasForeignKey("StatsParticipantStatsDBID");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.ParticipantIdentityDB", b =>
                {
                    b.HasOne("MyLeagueDashboard.Models.DB.MatchDB", null)
                        .WithMany("ParticipantIdentities")
                        .HasForeignKey("MatchDBID");

                    b.HasOne("MyLeagueDashboard.Models.DB.PlayerDB", "Player")
                        .WithMany()
                        .HasForeignKey("PlayerDBID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.PlayerInfoDB", b =>
                {
                    b.HasOne("MyLeagueDashboard.Models.DB.MatchDB", null)
                        .WithMany("PlayerInfos")
                        .HasForeignKey("MatchDBID");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.DB.TeamStatsDB", b =>
                {
                    b.HasOne("MyLeagueDashboard.Models.DB.MatchDB", null)
                        .WithMany("Teams")
                        .HasForeignKey("MatchDBID");
                });

            modelBuilder.Entity("MyLeagueDashboard.Models.Matches", b =>
                {
                    b.HasOne("MyLeagueDashboard.Models.DB.MatchDB", "MatchDB")
                        .WithMany()
                        .HasForeignKey("MatchDBID");

                    b.HasOne("MyLeagueDashboard.Models.MatchesResponse", null)
                        .WithMany("Matches")
                        .HasForeignKey("MatchesResponseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
