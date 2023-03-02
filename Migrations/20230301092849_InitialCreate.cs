using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estate_Expert.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    stateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.stateId);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    cityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.cityID);
                    table.ForeignKey(
                        name: "FK_city_state_StateId",
                        column: x => x.StateId,
                        principalTable: "state",
                        principalColumn: "stateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userDetails",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    userEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userPassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    conformPassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    userPhomeNumber = table.Column<int>(type: "int", nullable: false),
                    userMobileNumber = table.Column<int>(type: "int", nullable: false),
                    userAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    stateId = table.Column<int>(type: "int", nullable: false),
                    userDiscription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDetails", x => x.userId);
                    table.ForeignKey(
                        name: "FK_userDetails_city_cityId",
                        column: x => x.cityId,
                        principalTable: "city",
                        principalColumn: "cityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userDetails_state_stateId",
                        column: x => x.stateId,
                        principalTable: "state",
                        principalColumn: "stateId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "signInLogs",
                columns: table => new
                {
                    logId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signInLogs", x => x.logId);
                    table.ForeignKey(
                        name: "FK_signInLogs_userDetails_userId",
                        column: x => x.userId,
                        principalTable: "userDetails",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_city_StateId",
                table: "city",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_signInLogs_userId",
                table: "signInLogs",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_userDetails_cityId",
                table: "userDetails",
                column: "cityId");

            migrationBuilder.CreateIndex(
                name: "IX_userDetails_stateId",
                table: "userDetails",
                column: "stateId");

            migrationBuilder.CreateIndex(
                name: "IX_userDetails_userName",
                table: "userDetails",
                column: "userName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "signInLogs");

            migrationBuilder.DropTable(
                name: "userDetails");

            migrationBuilder.DropTable(
                name: "city");

            migrationBuilder.DropTable(
                name: "state");
        }
    }
}
