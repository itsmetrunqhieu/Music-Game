﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Starlight.Backend.Service;

#nullable disable

namespace Starlight.Backend.Migrations.Track
{
    [DbContext(typeof(TrackDatabaseService))]
    partial class TrackDatabaseServiceModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("Starlight.Backend.Database.Track.Track", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<double>("Difficulty")
                        .HasColumnType("REAL");

                    b.Property<string>("NoteDesigner")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("TEXT");

                    b.Property<ulong>("TrackSetId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TrackSetId");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Track.TrackSet", b =>
                {
                    b.Property<ulong>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("TrackSets");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Track.Track", b =>
                {
                    b.HasOne("Starlight.Backend.Database.Track.TrackSet", "TrackSet")
                        .WithMany("Tracks")
                        .HasForeignKey("TrackSetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TrackSet");
                });

            modelBuilder.Entity("Starlight.Backend.Database.Track.TrackSet", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}