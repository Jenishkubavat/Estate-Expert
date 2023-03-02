using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Estate_Expert.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userDetails_city_cityId",
                table: "userDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_userDetails_state_stateId",
                table: "userDetails");

            migrationBuilder.AlterColumn<int>(
                name: "userPhomeNumber",
                table: "userDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "userEmail",
                table: "userDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "userDiscription",
                table: "userDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "userAddress",
                table: "userDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "stateId",
                table: "userDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "cityId",
                table: "userDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_userDetails_city_cityId",
                table: "userDetails",
                column: "cityId",
                principalTable: "city",
                principalColumn: "cityID");

            migrationBuilder.AddForeignKey(
                name: "FK_userDetails_state_stateId",
                table: "userDetails",
                column: "stateId",
                principalTable: "state",
                principalColumn: "stateId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userDetails_city_cityId",
                table: "userDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_userDetails_state_stateId",
                table: "userDetails");

            migrationBuilder.AlterColumn<int>(
                name: "userPhomeNumber",
                table: "userDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "userEmail",
                table: "userDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "userDiscription",
                table: "userDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "userAddress",
                table: "userDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "stateId",
                table: "userDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "cityId",
                table: "userDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_userDetails_city_cityId",
                table: "userDetails",
                column: "cityId",
                principalTable: "city",
                principalColumn: "cityID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userDetails_state_stateId",
                table: "userDetails",
                column: "stateId",
                principalTable: "state",
                principalColumn: "stateId",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
