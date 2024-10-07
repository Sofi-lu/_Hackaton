using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackaton.API.Migrations
{
    /// <inheritdoc />
    public partial class fixedFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_assessments_teams_TeamId",
                table: "assessments");

            migrationBuilder.DropIndex(
                name: "IX_assessments_TeamId",
                table: "assessments");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "assessments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "assessments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_assessments_TeamId",
                table: "assessments",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_assessments_teams_TeamId",
                table: "assessments",
                column: "TeamId",
                principalTable: "teams",
                principalColumn: "Id");
        }
    }
}
