﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backendproject.DataContext;

namespace backendproject.Migrations
{
    [DbContext(typeof(MediaContext))]
    [Migration("20210501001618_change03")]
    partial class change03
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("backendproject.Models.Actor", b =>
                {
                    b.Property<Guid>("ActorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ActorId");

                    b.ToTable("Actors");

                    b.HasData(
                        new
                        {
                            ActorId = new Guid("5ff1d481-6791-456c-9cab-ac8e35483657"),
                            Name = "Rainn Wilson"
                        });
                });

            modelBuilder.Entity("backendproject.Models.Entry", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EpisodeProgress")
                        .HasColumnType("int");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "MediaId");

                    b.HasIndex("MediaId");

                    b.ToTable("Entries");
                });

            modelBuilder.Entity("backendproject.Models.Media", b =>
                {
                    b.Property<Guid>("MediaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Episodes")
                        .HasColumnType("int");

                    b.Property<double>("Length")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaId");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            MediaId = new Guid("7f6e4ad9-5b4e-4b23-8378-e665533ae308"),
                            Episodes = 1,
                            Length = 90.0,
                            Name = "Shrek",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Movie"
                        },
                        new
                        {
                            MediaId = new Guid("d4f3dc6f-f464-431f-9deb-c18c418db29a"),
                            Episodes = 6,
                            Length = 20.0,
                            Name = "The Office",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Series"
                        });
                });

            modelBuilder.Entity("backendproject.Models.MediaActor", b =>
                {
                    b.Property<Guid>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MediaId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MediaActor");
                });

            modelBuilder.Entity("backendproject.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = new Guid("0273e60b-58fe-4748-a3b3-97290d3b41f0"),
                            Email = "bob@email.com",
                            IsAdmin = false,
                            Name = "Bob",
                            Password = "1234"
                        });
                });

            modelBuilder.Entity("backendproject.Models.Entry", b =>
                {
                    b.HasOne("backendproject.Models.Media", "Media")
                        .WithMany()
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendproject.Models.User", "User")
                        .WithMany("Entries")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Media");

                    b.Navigation("User");
                });

            modelBuilder.Entity("backendproject.Models.MediaActor", b =>
                {
                    b.HasOne("backendproject.Models.Actor", "Actor")
                        .WithMany()
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendproject.Models.Media", null)
                        .WithMany("MediaActors")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");
                });

            modelBuilder.Entity("backendproject.Models.Media", b =>
                {
                    b.Navigation("MediaActors");
                });

            modelBuilder.Entity("backendproject.Models.User", b =>
                {
                    b.Navigation("Entries");
                });
#pragma warning restore 612, 618
        }
    }
}
