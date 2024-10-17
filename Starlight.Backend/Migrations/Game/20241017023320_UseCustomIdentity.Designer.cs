﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Starlight.Backend.Service;

#nullable disable

namespace Starlight.Backend.Migrations.Game
{
    [DbContext(typeof(GameDatabaseService))]
    [Migration("20241017023320_UseCustomIdentity")]
    partial class UseCustomIdentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("AchievementPlayer", b =>
                {
                    b.Property<ulong>("AchievementsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("OwnersId")
                        .HasColumnType("TEXT");

                    b.HasKey("AchievementsId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("AchievementPlayer");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.Achievement", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<string>("FavorText")
                        .IsRequired()
                        .HasMaxLength(512)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.LoginTracking", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasMaxLength(16384)
                        .HasColumnType("TEXT");

                    b.HasKey("Email");

                    b.ToTable("LoginSessions");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.Player", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<ulong>("CurrentLevel")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("LastSeenTime")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("SequenceNumber")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TotalExp")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TotalPlayTime")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex("PlayerId");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.Score", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Accuracy")
                        .HasColumnType("REAL");

                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("TotalPoints")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TrackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.UserSetting", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeyCode1")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeyCode2")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeyCode3")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KeyCode4")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MasterVolume")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MusicVolume")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Offset")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PlayerId")
                        .HasColumnType("TEXT");

                    b.Property<int>("SoundEffectVolume")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PlayerId")
                        .IsUnique();

                    b.ToTable("Settings");
                });

            modelBuilder.Entity("AchievementPlayer", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Game.Achievement", null)
                        .WithMany()
                        .HasForeignKey("AchievementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Starlight.Backend.Database.Game.Player", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
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
                    b.HasOne("Starlight.Backend.Database.Game.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Game.Player", null)
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

                    b.HasOne("Starlight.Backend.Database.Game.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Game.Player", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.Player", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Game.Player", null)
                        .WithMany("Friends")
                        .HasForeignKey("PlayerId");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.Score", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Game.Player", "Player")
                        .WithMany("BestScores")
                        .HasForeignKey("PlayerId");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.UserSetting", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Game.Player", "Player")
                        .WithOne("Setting")
                        .HasForeignKey("Starlight.Backend.Database.Game.UserSetting", "PlayerId");

                    b.Navigation("Player");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Game.Player", b =>
                {
                    b.Navigation("BestScores");

                    b.Navigation("Friends");

                    b.Navigation("Setting")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}