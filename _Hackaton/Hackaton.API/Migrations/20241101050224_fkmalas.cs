using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.API.Migrations
{
    /// <inheritdoc />
    public partial class fkmalas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Mentors_ID_Mentor",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Projects_ID_Project",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentors_HackathonEditions_ID_Hackathon",
                table: "Mentors");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Teams_ID_Team",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAwards_HackathonEditions_ID_Hackathon",
                table: "ProjectAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAwards_Projects_ID_Project",
                table: "ProjectAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_ID_Team",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_HackathonEditions_ID_Hackathon",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_ID_Hackathon",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Projects_ID_Team",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_ProjectAwards_ID_Hackathon",
                table: "ProjectAwards");

            migrationBuilder.DropIndex(
                name: "IX_ProjectAwards_ID_Project",
                table: "ProjectAwards");

            migrationBuilder.DropIndex(
                name: "IX_Participants_ID_Team",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Mentors_ID_Hackathon",
                table: "Mentors");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_ID_Mentor",
                table: "Assessments");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_ID_Project",
                table: "Assessments");

            migrationBuilder.AlterColumn<int>(
                name: "ID_Hackathon",
                table: "Teams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "HackathonEditionID_Hackathon",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamID_Team",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HackathonEditionID_Hackathon",
                table: "ProjectAwards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectID_Project",
                table: "ProjectAwards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamID_Team",
                table: "Participants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HackathonEditionID_Hackathon",
                table: "Mentors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MentorID_Mentor",
                table: "Assessments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProjectID_Project",
                table: "Assessments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_HackathonEditionID_Hackathon",
                table: "Teams",
                column: "HackathonEditionID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamID_Team",
                table: "Projects",
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
                name: "IX_Participants_TeamID_Team",
                table: "Participants",
                column: "TeamID_Team");

            migrationBuilder.CreateIndex(
                name: "IX_Mentors_HackathonEditionID_Hackathon",
                table: "Mentors",
                column: "HackathonEditionID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_MentorID_Mentor",
                table: "Assessments",
                column: "MentorID_Mentor");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ProjectID_Project",
                table: "Assessments",
                column: "ProjectID_Project");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Mentors_MentorID_Mentor",
                table: "Assessments",
                column: "MentorID_Mentor",
                principalTable: "Mentors",
                principalColumn: "ID_Mentor");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Projects_ProjectID_Project",
                table: "Assessments",
                column: "ProjectID_Project",
                principalTable: "Projects",
                principalColumn: "ID_Project");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentors_HackathonEditions_HackathonEditionID_Hackathon",
                table: "Mentors",
                column: "HackathonEditionID_Hackathon",
                principalTable: "HackathonEditions",
                principalColumn: "ID_Hackathon");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Teams_TeamID_Team",
                table: "Participants",
                column: "TeamID_Team",
                principalTable: "Teams",
                principalColumn: "ID_Team");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAwards_HackathonEditions_HackathonEditionID_Hackathon",
                table: "ProjectAwards",
                column: "HackathonEditionID_Hackathon",
                principalTable: "HackathonEditions",
                principalColumn: "ID_Hackathon");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAwards_Projects_ProjectID_Project",
                table: "ProjectAwards",
                column: "ProjectID_Project",
                principalTable: "Projects",
                principalColumn: "ID_Project");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamID_Team",
                table: "Projects",
                column: "TeamID_Team",
                principalTable: "Teams",
                principalColumn: "ID_Team");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_HackathonEditions_HackathonEditionID_Hackathon",
                table: "Teams",
                column: "HackathonEditionID_Hackathon",
                principalTable: "HackathonEditions",
                principalColumn: "ID_Hackathon",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Mentors_MentorID_Mentor",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Assessments_Projects_ProjectID_Project",
                table: "Assessments");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentors_HackathonEditions_HackathonEditionID_Hackathon",
                table: "Mentors");

            migrationBuilder.DropForeignKey(
                name: "FK_Participants_Teams_TeamID_Team",
                table: "Participants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAwards_HackathonEditions_HackathonEditionID_Hackathon",
                table: "ProjectAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_ProjectAwards_Projects_ProjectID_Project",
                table: "ProjectAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamID_Team",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_HackathonEditions_HackathonEditionID_Hackathon",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_HackathonEditionID_Hackathon",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamID_Team",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_ProjectAwards_HackathonEditionID_Hackathon",
                table: "ProjectAwards");

            migrationBuilder.DropIndex(
                name: "IX_ProjectAwards_ProjectID_Project",
                table: "ProjectAwards");

            migrationBuilder.DropIndex(
                name: "IX_Participants_TeamID_Team",
                table: "Participants");

            migrationBuilder.DropIndex(
                name: "IX_Mentors_HackathonEditionID_Hackathon",
                table: "Mentors");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_MentorID_Mentor",
                table: "Assessments");

            migrationBuilder.DropIndex(
                name: "IX_Assessments_ProjectID_Project",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "HackathonEditionID_Hackathon",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "TeamID_Team",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "HackathonEditionID_Hackathon",
                table: "ProjectAwards");

            migrationBuilder.DropColumn(
                name: "ProjectID_Project",
                table: "ProjectAwards");

            migrationBuilder.DropColumn(
                name: "TeamID_Team",
                table: "Participants");

            migrationBuilder.DropColumn(
                name: "HackathonEditionID_Hackathon",
                table: "Mentors");

            migrationBuilder.DropColumn(
                name: "MentorID_Mentor",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "ProjectID_Project",
                table: "Assessments");

            migrationBuilder.AlterColumn<int>(
                name: "ID_Hackathon",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_ID_Hackathon",
                table: "Teams",
                column: "ID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_ID_Team",
                table: "Projects",
                column: "ID_Team");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAwards_ID_Hackathon",
                table: "ProjectAwards",
                column: "ID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAwards_ID_Project",
                table: "ProjectAwards",
                column: "ID_Project",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Participants_ID_Team",
                table: "Participants",
                column: "ID_Team");

            migrationBuilder.CreateIndex(
                name: "IX_Mentors_ID_Hackathon",
                table: "Mentors",
                column: "ID_Hackathon");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ID_Mentor",
                table: "Assessments",
                column: "ID_Mentor");

            migrationBuilder.CreateIndex(
                name: "IX_Assessments_ID_Project",
                table: "Assessments",
                column: "ID_Project");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Mentors_ID_Mentor",
                table: "Assessments",
                column: "ID_Mentor",
                principalTable: "Mentors",
                principalColumn: "ID_Mentor");

            migrationBuilder.AddForeignKey(
                name: "FK_Assessments_Projects_ID_Project",
                table: "Assessments",
                column: "ID_Project",
                principalTable: "Projects",
                principalColumn: "ID_Project");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentors_HackathonEditions_ID_Hackathon",
                table: "Mentors",
                column: "ID_Hackathon",
                principalTable: "HackathonEditions",
                principalColumn: "ID_Hackathon");

            migrationBuilder.AddForeignKey(
                name: "FK_Participants_Teams_ID_Team",
                table: "Participants",
                column: "ID_Team",
                principalTable: "Teams",
                principalColumn: "ID_Team");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAwards_HackathonEditions_ID_Hackathon",
                table: "ProjectAwards",
                column: "ID_Hackathon",
                principalTable: "HackathonEditions",
                principalColumn: "ID_Hackathon");

            migrationBuilder.AddForeignKey(
                name: "FK_ProjectAwards_Projects_ID_Project",
                table: "ProjectAwards",
                column: "ID_Project",
                principalTable: "Projects",
                principalColumn: "ID_Project",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_ID_Team",
                table: "Projects",
                column: "ID_Team",
                principalTable: "Teams",
                principalColumn: "ID_Team");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_HackathonEditions_ID_Hackathon",
                table: "Teams",
                column: "ID_Hackathon",
                principalTable: "HackathonEditions",
                principalColumn: "ID_Hackathon",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
