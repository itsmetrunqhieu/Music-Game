﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Starlight.Backend.Service;

#nullable disable

namespace Starlight.Backend.Migrations
{
    [DbContext(typeof(GameDatabaseService))]
    [Migration("20240920065614_InitialDatabase")]
    partial class InitialDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("AchievementUser", b =>
                {
                    b.Property<ulong>("AchievementsId")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("OwnersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AchievementsId", "OwnersId");

                    b.HasIndex("OwnersId");

                    b.ToTable("AchievementUser");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Achievement", b =>
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

            modelBuilder.Entity("Starlight.Backend.Database.Score", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<double>("Accuracy")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("SubmissionDate")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("TotalPoints")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Scores");
                });

            modelBuilder.Entity("Starlight.Backend.Database.User", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Handle")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(16384)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastSeenTime")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("TotalExp")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("TotalPlayTime")
                        .HasColumnType("INTEGER");

                    b.Property<ulong?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AchievementUser", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Achievement", null)
                        .WithMany()
                        .HasForeignKey("AchievementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Starlight.Backend.Database.User", null)
                        .WithMany()
                        .HasForeignKey("OwnersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Starlight.Backend.Database.Score", b =>
                {
                    b.HasOne("Starlight.Backend.Database.User", "User")
                        .WithMany("BestScores")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Starlight.Backend.Database.User", b =>
                {
                    b.HasOne("Starlight.Backend.Database.User", null)
                        .WithMany("Friends")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Starlight.Backend.Database.User", b =>
                {
                    b.Navigation("BestScores");

                    b.Navigation("Friends");
                });
#pragma warning restore 612, 618
        }
    }
}
