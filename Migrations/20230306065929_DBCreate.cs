using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estate_Expert.Migrations
{
    /// <inheritdoc />
    public partial class DBCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstateStatus",
                columns: table => new
                {
                    EstateStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateStatus", x => x.EstateStatusId);
                });

            migrationBuilder.CreateTable(
                name: "estateTypes",
                columns: table => new
                {
                    EstateTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_estateTypes", x => x.EstateTypeId);
                });

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    StateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.StateId);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    SityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.SityID);
                    table.ForeignKey(
                        name: "FK_Cities_state_StateId",
                        column: x => x.StateId,
                        principalTable: "state",
                        principalColumn: "StateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EstateDetail",
                columns: table => new
                {
                    EstateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    cityId = table.Column<int>(type: "int", nullable: false),
                    EstateTypeId = table.Column<int>(type: "int", nullable: false),
                    FloorSpace = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NumberOfBalconies = table.Column<int>(type: "int", nullable: true),
                    BalconiesSpace = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    NumberOfBedrooms = table.Column<int>(type: "int", nullable: true),
                    NumberOfBathrooms = table.Column<int>(type: "int", nullable: true),
                    NumberOfGarages = table.Column<int>(type: "int", nullable: true),
                    NumberOfParkingSpaces = table.Column<int>(type: "int", nullable: true),
                    PetAllowed = table.Column<bool>(type: "bit", nullable: true),
                    EstateDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstateDetail", x => x.EstateId);
                    table.ForeignKey(
                        name: "FK_EstateDetail_Cities_cityId",
                        column: x => x.cityId,
                        principalTable: "Cities",
                        principalColumn: "SityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstateDetail_EstateStatus_EstateStatusId",
                        column: x => x.EstateStatusId,
                        principalTable: "EstateStatus",
                        principalColumn: "EstateStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EstateDetail_estateTypes_EstateTypeId",
                        column: x => x.EstateTypeId,
                        principalTable: "estateTypes",
                        principalColumn: "EstateTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "userDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserPassword = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserPhomeNumber = table.Column<int>(type: "int", nullable: true),
                    UserMobileNumber = table.Column<int>(type: "int", nullable: false),
                    UserAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    StateId = table.Column<int>(type: "int", nullable: true),
                    UserDiscription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isAdmin = table.Column<bool>(type: "bit", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    isDelete = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userDetails", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_userDetails_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "SityID");
                    table.ForeignKey(
                        name: "FK_userDetails_state_StateId",
                        column: x => x.StateId,
                        principalTable: "state",
                        principalColumn: "StateId");
                });

            migrationBuilder.CreateTable(
                name: "InChargeModel",
                columns: table => new
                {
                    InChargreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateId = table.Column<int>(type: "int", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InChargeModel", x => x.InChargreId);
                    table.ForeignKey(
                        name: "FK_InChargeModel_EstateDetail_EstateId",
                        column: x => x.EstateId,
                        principalTable: "EstateDetail",
                        principalColumn: "EstateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InChargeModel_userDetails_AgentId",
                        column: x => x.AgentId,
                        principalTable: "userDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "signInLogs",
                columns: table => new
                {
                    LogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signInLogs", x => x.LogId);
                    table.ForeignKey(
                        name: "FK_signInLogs_userDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "userDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_StateId",
                table: "Cities",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateDetail_cityId",
                table: "EstateDetail",
                column: "cityId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateDetail_EstateStatusId",
                table: "EstateDetail",
                column: "EstateStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EstateDetail_EstateTypeId",
                table: "EstateDetail",
                column: "EstateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InChargeModel_AgentId",
                table: "InChargeModel",
                column: "AgentId");

            migrationBuilder.CreateIndex(
                name: "IX_InChargeModel_EstateId",
                table: "InChargeModel",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_signInLogs_UserId",
                table: "signInLogs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_userDetails_CityId",
                table: "userDetails",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_userDetails_StateId",
                table: "userDetails",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_userDetails_UserName",
                table: "userDetails",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InChargeModel");

            migrationBuilder.DropTable(
                name: "signInLogs");

            migrationBuilder.DropTable(
                name: "EstateDetail");

            migrationBuilder.DropTable(
                name: "userDetails");

            migrationBuilder.DropTable(
                name: "EstateStatus");

            migrationBuilder.DropTable(
                name: "estateTypes");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "state");
        }
    }
}
