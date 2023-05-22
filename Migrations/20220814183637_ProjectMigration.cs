using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeCademyCapstone.Migrations
{
    public partial class ProjectMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    LeagueId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.LeagueId);
                });

            migrationBuilder.CreateTable(
                name: "Conference",
                columns: table => new
                {
                    ConferenceId = table.Column<string>(nullable: false),
                    LeagueId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conference", x => x.ConferenceId);
                    table.ForeignKey(
                        name: "FK_Conference_League_LeagueId",
                        column: x => x.LeagueId,
                        principalTable: "League",
                        principalColumn: "LeagueId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Division",
                columns: table => new
                {
                    DivisionId = table.Column<string>(nullable: false),
                    ConferenceId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division", x => x.DivisionId);
                    table.ForeignKey(
                        name: "FK_Division_Conference_ConferenceId",
                        column: x => x.ConferenceId,
                        principalTable: "Conference",
                        principalColumn: "ConferenceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    TeamId = table.Column<string>(nullable: false),
                    DivisionId = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Win = table.Column<int>(nullable: false),
                    Loss = table.Column<int>(nullable: false),
                    Tie = table.Column<int>(nullable: false),
                    PointsFor = table.Column<int>(nullable: false),
                    PointsAgainst = table.Column<int>(nullable: false),
                    Stadium = table.Column<string>(nullable: true),
                    Capacity = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    Latitude = table.Column<double>(nullable: false),
                    Longitude = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.TeamId);
                    table.ForeignKey(
                        name: "FK_Team_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "Division",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Player",
                columns: table => new
                {
                    PlayerId = table.Column<string>(nullable: false),
                    TeamId = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    Position = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Height = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    DraftYear = table.Column<int>(nullable: true),
                    DraftRound = table.Column<int>(nullable: true),
                    DraftPick = table.Column<int>(nullable: true),
                    College = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Rank = table.Column<int>(nullable: true),
                    Rating = table.Column<int>(nullable: true),
                    Depth = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Player", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_Player_Team_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Team",
                        principalColumn: "TeamId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Conference_LeagueId",
                table: "Conference",
                column: "LeagueId");

            migrationBuilder.CreateIndex(
                name: "IX_Division_ConferenceId",
                table: "Division",
                column: "ConferenceId");

            migrationBuilder.CreateIndex(
                name: "IX_Player_TeamId",
                table: "Player",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Team_DivisionId",
                table: "Team",
                column: "DivisionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Player");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Division");

            migrationBuilder.DropTable(
                name: "Conference");

            migrationBuilder.DropTable(
                name: "League");
        }
    }
}
