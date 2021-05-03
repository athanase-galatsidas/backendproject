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
    [Migration("20210503014555_hotfix01")]
    partial class hotfix01
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
                            ActorId = new Guid("a4d5e88f-8c88-4d36-a5d1-42360465e3fe"),
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaId");

                    b.ToTable("Medias");

                    b.HasData(
                        new
                        {
                            MediaId = new Guid("ec73431b-a9a7-42c1-a0fc-531b42b287e1"),
                            Episodes = 1,
                            Length = 90.0,
                            Name = "Shrek",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2001, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Movie"
                        },
                        new
                        {
                            MediaId = new Guid("d19237bb-25e1-4826-8a38-5ed881e8a77c"),
                            Episodes = 6,
                            Length = 20.0,
                            Name = "The Office",
                            Rating = 0.0,
                            ReleaseDate = new DateTime(2005, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = "Series"
                        });
                });

            modelBuilder.Entity("backendproject.Models.MediaActors", b =>
                {
                    b.Property<Guid>("MediaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ActorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MediaId", "ActorId");

                    b.HasIndex("ActorId");

                    b.ToTable("MediaActors");
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
                            UserId = new Guid("a93aee65-b07c-4ba0-a264-60d156cfd162"),
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

            modelBuilder.Entity("backendproject.Models.MediaActors", b =>
                {
                    b.HasOne("backendproject.Models.Actor", "Actor")
                        .WithMany("MediaActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("backendproject.Models.Media", "Media")
                        .WithMany("MediaActors")
                        .HasForeignKey("MediaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Media");
                });

            modelBuilder.Entity("backendproject.Models.Actor", b =>
                {
                    b.Navigation("MediaActors");
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