﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UnitOfWorkDemo.Infrastructure;

#nullable disable

namespace UnitOfWorkDemo.Infrastructure.Migrations
{
    [DbContext(typeof(DbContextClass))]
    [Migration("20231031110443_v1")]
    partial class v1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UnitOfWorkDemo.Core.Models.FootballLeagueDetails", b =>
                {
                    b.Property<int>("LeagueId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LeagueId"));

                    b.Property<int>("LeagueCapacity")
                        .HasColumnType("integer");

                    b.Property<string>("LeagueCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LeagueName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LeagueNumberOfPlayers")
                        .HasColumnType("integer");

                    b.HasKey("LeagueId");

                    b.ToTable("Leagues");
                });

            modelBuilder.Entity("UnitOfWorkDemo.Core.Models.FootballTeamDetails", b =>
                {
                    b.Property<int>("TeamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeamId"));

                    b.Property<string>("TeamCountry")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeamLeagueId")
                        .HasColumnType("integer");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TeamPriceInMillions")
                        .HasColumnType("integer");

                    b.HasKey("TeamId");

                    b.HasIndex("TeamLeagueId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("UnitOfWorkDemo.Core.Models.FootballTeamDetails", b =>
                {
                    b.HasOne("UnitOfWorkDemo.Core.Models.FootballLeagueDetails", "TeamLeague")
                        .WithMany("Teams")
                        .HasForeignKey("TeamLeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TeamLeague");
                });

            modelBuilder.Entity("UnitOfWorkDemo.Core.Models.FootballLeagueDetails", b =>
                {
                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
