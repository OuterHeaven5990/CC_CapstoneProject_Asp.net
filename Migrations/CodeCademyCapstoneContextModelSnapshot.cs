﻿// <auto-generated />
using System;
using CodeCademyCapstone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CodeCademyCapstone.Migrations
{
    [DbContext(typeof(CodeCademyCapstoneContext))]
    partial class CodeCademyCapstoneContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CodeCademyCapstone.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Conference", b =>
                {
                    b.Property<string>("ConferenceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LeagueId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ConferenceId");

                    b.HasIndex("LeagueId");

                    b.ToTable("Conference");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Division", b =>
                {
                    b.Property<string>("DivisionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConferenceId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DivisionId");

                    b.HasIndex("ConferenceId");

                    b.ToTable("Division");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.League", b =>
                {
                    b.Property<string>("LeagueId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LeagueId");

                    b.ToTable("League");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Player", b =>
                {
                    b.Property<string>("PlayerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("College")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Depth")
                        .HasColumnType("int");

                    b.Property<int?>("DraftPick")
                        .HasColumnType("int");

                    b.Property<int?>("DraftRound")
                        .HasColumnType("int");

                    b.Property<int?>("DraftYear")
                        .HasColumnType("int");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Height")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Rank")
                        .HasColumnType("int");

                    b.Property<int?>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("Weight")
                        .HasColumnType("int");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamId");

                    b.ToTable("Player");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Team", b =>
                {
                    b.Property<string>("TeamId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DivisionId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Longitude")
                        .HasColumnType("float");

                    b.Property<int>("Loss")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PointsAgainst")
                        .HasColumnType("int");

                    b.Property<int>("PointsFor")
                        .HasColumnType("int");

                    b.Property<string>("Stadium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Tie")
                        .HasColumnType("int");

                    b.Property<int>("Win")
                        .HasColumnType("int");

                    b.Property<string>("Zip")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeamId");

                    b.HasIndex("DivisionId");

                    b.ToTable("Team");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Conference", b =>
                {
                    b.HasOne("CodeCademyCapstone.Models.League", "League")
                        .WithMany()
                        .HasForeignKey("LeagueId");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Division", b =>
                {
                    b.HasOne("CodeCademyCapstone.Models.Conference", "Conference")
                        .WithMany()
                        .HasForeignKey("ConferenceId");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Player", b =>
                {
                    b.HasOne("CodeCademyCapstone.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("CodeCademyCapstone.Models.Team", b =>
                {
                    b.HasOne("CodeCademyCapstone.Models.Division", "Division")
                        .WithMany()
                        .HasForeignKey("DivisionId");
                });
#pragma warning restore 612, 618
        }
    }
}
