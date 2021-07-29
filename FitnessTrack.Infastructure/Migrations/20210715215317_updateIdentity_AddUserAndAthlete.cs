using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTrack.Infastructure.Migrations
{
    public partial class updateIdentity_AddUserAndAthlete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Height",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    MeasurementSystem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Height", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Name",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Name", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileLocation",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileLocation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProfileSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreferredMeasurementSystem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weight",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<double>(type: "float", nullable: false),
                    MeasurementSystem = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weight", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfilePhotoUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    ProfileSettingsId = table.Column<int>(type: "int", nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    HeightId = table.Column<int>(type: "int", nullable: true),
                    WeightId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainees_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainees_Height_HeightId",
                        column: x => x.HeightId,
                        principalTable: "Height",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainees_ProfileLocation_LocationId",
                        column: x => x.LocationId,
                        principalTable: "ProfileLocation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainees_ProfileSettings_ProfileSettingsId",
                        column: x => x.ProfileSettingsId,
                        principalTable: "ProfileSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Trainees_Weight_WeightId",
                        column: x => x.WeightId,
                        principalTable: "Weight",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NameId",
                table: "AspNetUsers",
                column: "NameId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_HeightId",
                table: "Trainees",
                column: "HeightId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_LocationId",
                table: "Trainees",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_ProfileSettingsId",
                table: "Trainees",
                column: "ProfileSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_UserId",
                table: "Trainees",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainees_WeightId",
                table: "Trainees",
                column: "WeightId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Name_NameId",
                table: "AspNetUsers",
                column: "NameId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Name_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Height");

            migrationBuilder.DropTable(
                name: "ProfileLocation");

            migrationBuilder.DropTable(
                name: "ProfileSettings");

            migrationBuilder.DropTable(
                name: "Weight");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "AspNetUsers");
        }
    }
}
