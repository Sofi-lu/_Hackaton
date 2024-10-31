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
    [Migration("20241031211820_InitialDb")]
    partial class InitialDb
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
                    b.Property<int>("ID_Assessment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Assessment"));

                    b.Property<string>("Feedback")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ID_Mentor")
                        .HasColumnType("int");

                    b.Property<int>("ID_Project")
                        .HasColumnType("int");

                    b.Property<int?>("MentorID_Mentor")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectID_Project")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ID_Assessment");

                    b.HasIndex("MentorID_Mentor");

                    b.HasIndex("ProjectID_Project");

                    b.ToTable("Assessments");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.HackathonEdition", b =>
                {
                    b.Property<int>("ID_Hackathon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Hackathon"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("organizer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("topic")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Hackathon");

                    b.ToTable("HackathonEditions");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Mentor", b =>
                {
                    b.Property<int>("ID_Mentor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Mentor"));

                    b.Property<string>("Experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HackathonEditionID_Hackathon")
                        .HasColumnType("int");

                    b.Property<int>("ID_Hackathon")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Mentor");

                    b.HasIndex("HackathonEditionID_Hackathon");

                    b.ToTable("Mentors");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Participant", b =>
                {
                    b.Property<int>("ID_Participant")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Participant"));

                    b.Property<int>("ID_Team")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID_Team")
                        .HasColumnType("int");

                    b.Property<string>("role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Participant");

                    b.HasIndex("TeamID_Team");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Project", b =>
                {
                    b.Property<int>("ID_Project")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Project"));

                    b.Property<int>("ID_Team")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TeamID_Team")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("state")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Project");

                    b.HasIndex("TeamID_Team");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.ProjectAward", b =>
                {
                    b.Property<int>("ID_Award")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Award"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HackathonEditionID_Hackathon")
                        .HasColumnType("int");

                    b.Property<int>("ID_Hackathon")
                        .HasColumnType("int");

                    b.Property<int>("ID_Project")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID_Project")
                        .HasColumnType("int");

                    b.HasKey("ID_Award");

                    b.HasIndex("HackathonEditionID_Hackathon");

                    b.HasIndex("ProjectID_Project");

                    b.ToTable("ProjectAwards");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Team", b =>
                {
                    b.Property<int>("ID_Team")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Team"));

                    b.Property<int>("HackathonEditionID_Hackathon")
                        .HasColumnType("int");

                    b.Property<int>("IDHackathon")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("experience")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("memberCount")
                        .HasColumnType("int");

                    b.HasKey("ID_Team");

                    b.HasIndex("HackathonEditionID_Hackathon");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Assessment", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Mentor", "Mentor")
                        .WithMany("assessments")
                        .HasForeignKey("MentorID_Mentor");

                    b.HasOne("Hackaton.Shared.Entities.Project", "Project")
                        .WithMany("Assessments")
                        .HasForeignKey("ProjectID_Project");

                    b.Navigation("Mentor");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Mentor", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.HackathonEdition", "HackathonEdition")
                        .WithMany("Mentors")
                        .HasForeignKey("HackathonEditionID_Hackathon");

                    b.Navigation("HackathonEdition");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Participant", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Team", "Team")
                        .WithMany("Participants")
                        .HasForeignKey("TeamID_Team");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Project", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.Team", "Team")
                        .WithMany()
                        .HasForeignKey("TeamID_Team");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.ProjectAward", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.HackathonEdition", "HackathonEdition")
                        .WithMany("Awards")
                        .HasForeignKey("HackathonEditionID_Hackathon");

                    b.HasOne("Hackaton.Shared.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID_Project")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HackathonEdition");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Team", b =>
                {
                    b.HasOne("Hackaton.Shared.Entities.HackathonEdition", "HackathonEdition")
                        .WithMany("Teams")
                        .HasForeignKey("HackathonEditionID_Hackathon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HackathonEdition");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.HackathonEdition", b =>
                {
                    b.Navigation("Awards");

                    b.Navigation("Mentors");

                    b.Navigation("Teams");
                });

            modelBuilder.Entity("Hackaton.Shared.Entities.Mentor", b =>
                {
                    b.Navigation("assessments");
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
