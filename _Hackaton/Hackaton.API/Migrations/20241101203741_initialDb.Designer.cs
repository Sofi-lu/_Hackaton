﻿// <auto-generated />
using System;
using Hackaton.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hackaton.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241101203741_initialDb")]
    partial class initialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hackaton.Shared.Entities.Assessment", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MentorID")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("MentorID");

                    b.HasIndex("ProjectID");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Hackathon", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("EndDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StartDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("organizer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("HackathonEditions");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Mentor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HackathonID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("HackathonID");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Participant", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TeamID");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Project", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("dueDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("TeamID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.ProjectAward", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HackathonID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HackathonID");

                    b.HasIndex("ProjectID");

                    b.ToTable("ProjectAwards");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Team", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int?>("HackathonID")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("memberCount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("HackathonID");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Assessment", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Mentor", "Mentor")
                        .WithMany("Assessments")
                        .HasForeignKey("MentorID");

                    b.HasOne("Hackaton.Shared.Entities.Project", "Project")
                        .WithMany("Assessments")
                        .HasForeignKey("ProjectID");

                    b.Navigation("Mentor");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Mentor", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Hackathon", "Hackathon")
                        .WithMany("Mentors")
                        .HasForeignKey("HackathonID");

                    b.Navigation("Hackathon");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Participant", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Team", "Team")
                        .WithMany("Participants")
                        .HasForeignKey("TeamID");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Project", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.ProjectAward", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Hackathon", "Hackathon")
                        .WithMany("Awards")
                        .HasForeignKey("HackathonID");

                    b.HasOne("Hackaton.Shared.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hackathon");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Team", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Hackathon", "Hackathon")
                        .WithMany("Teams")
                        .HasForeignKey("HackathonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hackathon");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Hackathon", b =>
                {
                    b.Navigation("Awards");

                    b.Navigation("Mentors");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Mentor", b =>
                {
                    b.Navigation("Assessments");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Project", b =>
                {
                    b.Navigation("Assessments");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Team", b =>
                {
                    b.Navigation("Participants");
                });
#pragma warning restore 612, 618
        }
    }
}