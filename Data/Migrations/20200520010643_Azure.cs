using Microsoft.EntityFrameworkCore.Migrations;

namespace MyLeagueDashboard.Data.Migrations
{
    public partial class Azure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MatchesDB",
                columns: table => new
                {
                    MatchDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<long>(nullable: false),
                    QueueID = table.Column<int>(nullable: false),
                    GameType = table.Column<string>(nullable: true),
                    GameDuration = table.Column<long>(nullable: false),
                    PlatformID = table.Column<string>(nullable: true),
                    SeasonID = table.Column<int>(nullable: false),
                    MapID = table.Column<int>(nullable: false),
                    GameMode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesDB", x => x.MatchDBID);
                });

            migrationBuilder.CreateTable(
                name: "MatchesResponses",
                columns: table => new
                {
                    MatchesResponseID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SummonerID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchesResponses", x => x.MatchesResponseID);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantStatsDB",
                columns: table => new
                {
                    ParticipantStatsDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GoldEarned = table.Column<int>(nullable: false),
                    TotalPlayerScore = table.Column<int>(nullable: false),
                    ChampLevel = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    TotalScoreRank = table.Column<int>(nullable: false),
                    WardsPlaced = table.Column<int>(nullable: false),
                    TotalDamageDealt = table.Column<long>(nullable: false),
                    LargestKillingSpree = table.Column<int>(nullable: false),
                    TotalDamageDealtToChampions = table.Column<long>(nullable: false),
                    TotalMinionsKilled = table.Column<int>(nullable: false),
                    ObjectivePlayerScore = table.Column<int>(nullable: false),
                    Kills = table.Column<int>(nullable: false),
                    CombatPlayerScore = table.Column<int>(nullable: false),
                    ParticipantID = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    Win = table.Column<bool>(nullable: false),
                    VisionScore = table.Column<long>(nullable: false),
                    FirstBloodKill = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantStatsDB", x => x.ParticipantStatsDBID);
                });

            migrationBuilder.CreateTable(
                name: "PlayerDB",
                columns: table => new
                {
                    PlayerDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileIcon = table.Column<int>(nullable: false),
                    AccountID = table.Column<string>(nullable: true),
                    MatchHistoryURI = table.Column<string>(nullable: true),
                    CurrentAccountID = table.Column<string>(nullable: true),
                    CurrentPlatformID = table.Column<string>(nullable: true),
                    SummonerName = table.Column<string>(nullable: true),
                    SummonerID = table.Column<string>(nullable: true),
                    PlatformID = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerDB", x => x.PlayerDBID);
                });

            migrationBuilder.CreateTable(
                name: "Summoners",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    AccountId = table.Column<string>(nullable: true),
                    PuuId = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    ProfileIconId = table.Column<int>(nullable: false),
                    RevisionDate = table.Column<long>(nullable: false),
                    SummonerLevel = table.Column<int>(nullable: false),
                    KDA = table.Column<float>(nullable: false),
                    Region = table.Column<string>(nullable: true),
                    Kills = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summoners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerInfoDBs",
                columns: table => new
                {
                    PlayerInfoDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<long>(nullable: false),
                    ProfileIcon = table.Column<int>(nullable: false),
                    AccountID = table.Column<string>(nullable: true),
                    MatchHistoryURI = table.Column<string>(nullable: true),
                    CurrentAccountID = table.Column<string>(nullable: true),
                    CurrentPlatformID = table.Column<string>(nullable: true),
                    SummonerName = table.Column<string>(nullable: true),
                    SummonerID = table.Column<string>(nullable: true),
                    PlatformID = table.Column<string>(nullable: true),
                    ParticipantID = table.Column<int>(nullable: false),
                    ChampionID = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false),
                    Spell1ID = table.Column<int>(nullable: false),
                    Spell2ID = table.Column<int>(nullable: false),
                    HighestAchievedSeasonTier = table.Column<string>(nullable: true),
                    GoldEarned = table.Column<int>(nullable: false),
                    TotalPlayerScore = table.Column<int>(nullable: false),
                    ChampLevel = table.Column<int>(nullable: false),
                    Deaths = table.Column<int>(nullable: false),
                    TotalScoreRank = table.Column<int>(nullable: false),
                    WardsPlaced = table.Column<int>(nullable: false),
                    TotalDamageDealt = table.Column<long>(nullable: false),
                    LargestKillingSpree = table.Column<int>(nullable: false),
                    TotalDamageDealtToChampions = table.Column<long>(nullable: false),
                    TotalMinionsKilled = table.Column<int>(nullable: false),
                    ObjectivePlayerScore = table.Column<int>(nullable: false),
                    Kills = table.Column<int>(nullable: false),
                    CombatPlayerScore = table.Column<int>(nullable: false),
                    Assists = table.Column<int>(nullable: false),
                    Win = table.Column<bool>(nullable: false),
                    VisionScore = table.Column<long>(nullable: false),
                    FirstBloodKill = table.Column<bool>(nullable: false),
                    MatchDBID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerInfoDBs", x => x.PlayerInfoDBID);
                    table.ForeignKey(
                        name: "FK_PlayerInfoDBs_MatchesDB_MatchDBID",
                        column: x => x.MatchDBID,
                        principalTable: "MatchesDB",
                        principalColumn: "MatchDBID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamStatsDBs",
                columns: table => new
                {
                    TeamStatsDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameID = table.Column<long>(nullable: false),
                    TowerKills = table.Column<int>(nullable: false),
                    RiftHeraldKills = table.Column<int>(nullable: false),
                    FirstBlood = table.Column<bool>(nullable: false),
                    InhibitorKills = table.Column<int>(nullable: false),
                    DragonKills = table.Column<int>(nullable: false),
                    BaronKills = table.Column<int>(nullable: false),
                    TeamID = table.Column<int>(nullable: false),
                    Win = table.Column<string>(nullable: true),
                    MatchDBID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamStatsDBs", x => x.TeamStatsDBID);
                    table.ForeignKey(
                        name: "FK_TeamStatsDBs_MatchesDB_MatchDBID",
                        column: x => x.MatchDBID,
                        principalTable: "MatchesDB",
                        principalColumn: "MatchDBID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchesResponseID = table.Column<int>(nullable: false),
                    PlatformID = table.Column<string>(nullable: true),
                    GameID = table.Column<string>(nullable: true),
                    Champion = table.Column<int>(nullable: false),
                    Queue = table.Column<int>(nullable: false),
                    Season = table.Column<int>(nullable: false),
                    Timestamp = table.Column<long>(nullable: false),
                    Role = table.Column<string>(nullable: true),
                    Lane = table.Column<string>(nullable: true),
                    MatchDBID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchesID);
                    table.ForeignKey(
                        name: "FK_Matches_MatchesDB_MatchDBID",
                        column: x => x.MatchDBID,
                        principalTable: "MatchesDB",
                        principalColumn: "MatchDBID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_MatchesResponses_MatchesResponseID",
                        column: x => x.MatchesResponseID,
                        principalTable: "MatchesResponses",
                        principalColumn: "MatchesResponseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantDB",
                columns: table => new
                {
                    ParticipantDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParticipantID = table.Column<int>(nullable: false),
                    ChampionID = table.Column<int>(nullable: false),
                    StatsParticipantStatsDBID = table.Column<int>(nullable: true),
                    TeamID = table.Column<int>(nullable: false),
                    Spell1ID = table.Column<int>(nullable: false),
                    Spell2ID = table.Column<int>(nullable: false),
                    HighestAchievedSeasonTier = table.Column<string>(nullable: true),
                    ProfileIcon = table.Column<int>(nullable: false),
                    AccountID = table.Column<string>(nullable: true),
                    MatchHistoryURI = table.Column<string>(nullable: true),
                    CurrentAccountID = table.Column<string>(nullable: true),
                    CurrentPlatformID = table.Column<string>(nullable: true),
                    SummonerName = table.Column<string>(nullable: true),
                    SummonerID = table.Column<string>(nullable: true),
                    PlatformID = table.Column<string>(nullable: true),
                    MatchDBID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantDB", x => x.ParticipantDBID);
                    table.ForeignKey(
                        name: "FK_ParticipantDB_MatchesDB_MatchDBID",
                        column: x => x.MatchDBID,
                        principalTable: "MatchesDB",
                        principalColumn: "MatchDBID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParticipantDB_ParticipantStatsDB_StatsParticipantStatsDBID",
                        column: x => x.StatsParticipantStatsDBID,
                        principalTable: "ParticipantStatsDB",
                        principalColumn: "ParticipantStatsDBID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantIdentityDB",
                columns: table => new
                {
                    ParticipantIdentityDBID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerDBID = table.Column<int>(nullable: false),
                    Index = table.Column<int>(nullable: false),
                    MatchDBID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantIdentityDB", x => x.ParticipantIdentityDBID);
                    table.ForeignKey(
                        name: "FK_ParticipantIdentityDB_MatchesDB_MatchDBID",
                        column: x => x.MatchDBID,
                        principalTable: "MatchesDB",
                        principalColumn: "MatchDBID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ParticipantIdentityDB_PlayerDB_PlayerDBID",
                        column: x => x.PlayerDBID,
                        principalTable: "PlayerDB",
                        principalColumn: "PlayerDBID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MatchDBID",
                table: "Matches",
                column: "MatchDBID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_MatchesResponseID",
                table: "Matches",
                column: "MatchesResponseID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantDB_MatchDBID",
                table: "ParticipantDB",
                column: "MatchDBID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantDB_StatsParticipantStatsDBID",
                table: "ParticipantDB",
                column: "StatsParticipantStatsDBID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantIdentityDB_MatchDBID",
                table: "ParticipantIdentityDB",
                column: "MatchDBID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantIdentityDB_PlayerDBID",
                table: "ParticipantIdentityDB",
                column: "PlayerDBID");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerInfoDBs_MatchDBID",
                table: "PlayerInfoDBs",
                column: "MatchDBID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamStatsDBs_MatchDBID",
                table: "TeamStatsDBs",
                column: "MatchDBID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "ParticipantDB");

            migrationBuilder.DropTable(
                name: "ParticipantIdentityDB");

            migrationBuilder.DropTable(
                name: "PlayerInfoDBs");

            migrationBuilder.DropTable(
                name: "Summoners");

            migrationBuilder.DropTable(
                name: "TeamStatsDBs");

            migrationBuilder.DropTable(
                name: "MatchesResponses");

            migrationBuilder.DropTable(
                name: "ParticipantStatsDB");

            migrationBuilder.DropTable(
                name: "PlayerDB");

            migrationBuilder.DropTable(
                name: "MatchesDB");
        }
    }
}
