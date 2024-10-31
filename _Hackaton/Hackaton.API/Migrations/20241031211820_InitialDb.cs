using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.API.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HackathonEditions",
                columns: table => new
                {
                    ID_Hackathon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    topic = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    organizer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HackathonEditions", x => x.ID_Hackathon);
                });

            migrationBuilder.CreateTable(
                name: "Mentors",
                columns: table => new
                {
                    ID_Mentor = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HackathonEditionID_Hackathon = table.Column<int>(type: "int", nullable: true),
                    ID_Hackathon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mentors", x => x.ID_Mentor);
                    table.ForeignKey(
                        name: "FK_Mentors_HackathonEditions_HackathonEditionID_Hackathon",
                        column: x => x.HackathonEditionID_Hackathon,
                        principalTable: "HackathonEditions",
                        principalColumn: "ID_Hackathon");
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    ID_Team = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    memberCount = table.Column<int>(type: "int", nullable: false),
                    experience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HackathonEditionID_Hackathon = table.Column<int>(type: "int", nullable: false),
                    IDHackathon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.ID_Team);
                    table.ForeignKey(
                        name: "FK_Teams_HackathonEditions_HackathonEditionID_Hackathon",
                        column: x => x.HackathonEditionID_Hackathon,
                        principalTable: "HackathonEditions",
                        principalColumn: "ID_Hackathon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Participants",
                columns: table => new
                {
                    ID_Participant = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamID_Team = table.Column<int>(type: "int", nullable: true),
                    ID_Team = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participants", x => x.ID_Participant);
                    table.ForeignKey(
                        name: "FK_Participants_Teams_TeamID_Team",
                        column: x => x.TeamID_Team,
                        principalTable: "Teams",
                        principalColumn: "ID_Team");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ID_Project = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TeamID_Team = table.Column<int>(type: "int", nullable: true),
                    ID_Team = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ID_Project);
                    table.ForeignKey(
                        name: "FK_Projects_Teams_TeamID_Team",
                        column: x => x.TeamID_Team,
                        principalTable: "Teams",
                        principalColumn: "ID_Team");
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    ID_Assessment = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Score = table.Column<int>(type: "int", nullable: false),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectID_Project = table.Column<int>(type: "int", nullable: true),
                    ID_Project = table.Column<int>(type: "int", nullable: false),
                    MentorID_Mentor = table.Column<int>(type: "int", nullable: true),
                    ID_Mentor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assessments", x => x.ID_Assessment);
                    table.ForeignKey(
                        name: "FK_Assessments_Mentors_MentorID_Mentor",
                        column: x => x.MentorID_Mentor,
                        principalTable: "Mentors",
                        principalColumn: "ID_Mentor");
                    table.ForeignKey(
                        name: "FK_Assessments_Projects_ProjectID_Project",
                        column: x => x.ProjectID_Project,
                        principalTable: "Projects",
                        principalColumn: "ID_Project");
                });

            migrationBuilder.CreateTable(
                name: "ProjectAwards",
                columns: table => new
                {
                    ID_Award = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectID_Project = table.Column<int>(type: "int", nullable: false),
                    ID_Project = table.Column<int>(type: "int", nullable: false),
                    HackathonEditionID_Hackathon = table.Column<int>(type: "int", nullable: true),
                    ID_Hackathon = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAwards", x => x.ID_Award);
                    table.ForeignKey(
                        name: "FK_ProjectAwards_HackathonEditions_HackathonEditionID_Hackathon",
                        column: x => x.HackathonEditionID_Hackathon,
                        principalTable: "HackathonEditions",
                        principalColumn: "ID_Hackathon");
                    table.ForeignKey(
                        name: "FK_ProjectAwards_Projects_ProjectID_Project",
                        column: x => x.ProjectID_Project,
                        principalTable: "Projects",
                        principalColumn: "ID_Project",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_MentorID_Mentor",
                table: "Assessments",
                column: "MentorID_Mentor");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ProjectID_Project",
                table: "Assessments",
                column: "ProjectID_Project");

            migrationBuilder.CreateIndex(
                name: "IX_Mentors_HackathonEditionID_Hackathon",
                table: "Mentors",
                column: "HackathonEditionID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_Participants_TeamID_Team",
                table: "Participants",
                column: "TeamID_Team");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAwards_HackathonEditionID_Hackathon",
                table: "ProjectAwards",
                column: "HackathonEditionID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAwards_ProjectID_Project",
                table: "ProjectAwards",
                column: "ProjectID_Project");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamID_Team",
                table: "Projects",
                column: "TeamID_Team");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_HackathonEditionID_Hackathon",
                table: "Teams",
                column: "HackathonEditionID_Hackathon");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "Participants");

            migrationBuilder.DropTable(
                name: "ProjectAwards");

            migrationBuilder.DropTable(
                name: "Mentors");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "HackathonEditions");
        }
    }
}
