using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FitnessTrack.Infastructure.Migrations
{
    public partial class ApplyConfigurations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Name_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Height_HeightId",
                table: "Trainees");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_ProfileLocation_LocationId",
                table: "Trainees");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_ProfileSettings_ProfileSettingsId",
                table: "Trainees");

            migrationBuilder.DropForeignKey(
                name: "FK_Trainees_Weight_WeightId",
                table: "Trainees");

            migrationBuilder.DropTable(
                name: "Name");

            migrationBuilder.DropTable(
                name: "ProfileLocation");

            migrationBuilder.DropTable(
                name: "ProfileSettings");

            migrationBuilder.DropTable(
                name: "Weight");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_HeightId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_LocationId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_ProfileSettingsId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_Trainees_WeightId",
                table: "Trainees");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_NameId",
                table: "AspNetUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Height",
                table: "Height");

            migrationBuilder.DropColumn(
                name: "HeightId",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "NameId",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "Height",
                newName: "CyclingWorkouts");

            migrationBuilder.RenameColumn(
                name: "WeightId",
                table: "Trainees",
                newName: "Weight_MeasurementSystem");

            migrationBuilder.RenameColumn(
                name: "ProfileSettingsId",
                table: "Trainees",
                newName: "ProfileSettings_PreferredMeasurementSystem");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Trainees",
                newName: "Height_MeasurementSystem");

            migrationBuilder.RenameColumn(
                name: "Value",
                table: "CyclingWorkouts",
                newName: "TotalElevation_Value");

            migrationBuilder.RenameColumn(
                name: "MeasurementSystem",
                table: "CyclingWorkouts",
                newName: "TotalElevation_MeasurementSystem");

            migrationBuilder.AddColumn<double>(
                name: "Height_Value",
                table: "Trainees",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProfileSettings_TimeZone",
                table: "Trainees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight_Value",
                table: "Trainees",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "TotalElevation_Value",
                table: "CyclingWorkouts",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<int>(
                name: "TotalElevation_MeasurementSystem",
                table: "CyclingWorkouts",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AverageSpeed_MeasurementSystem",
                table: "CyclingWorkouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "AverageSpeed_Value",
                table: "CyclingWorkouts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateCreated",
                table: "CyclingWorkouts",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "DateUpdated",
                table: "CyclingWorkouts",
                type: "datetimeoffset",
                nullable: false,
                defaultValue: new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CyclingWorkouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Distance_MeasurementSystem",
                table: "CyclingWorkouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Distance_Value",
                table: "CyclingWorkouts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Duration",
                table: "CyclingWorkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ElevationGain_MeasurementSystem",
                table: "CyclingWorkouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ElevationGain_Value",
                table: "CyclingWorkouts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ElevationLoss_MeasurementSystem",
                table: "CyclingWorkouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ElevationLoss_Value",
                table: "CyclingWorkouts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MaxSpeed_MeasurementSystem",
                table: "CyclingWorkouts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "MaxSpeed_Value",
                table: "CyclingWorkouts",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "CyclingWorkouts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TraineeId",
                table: "CyclingWorkouts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CyclingWorkouts",
                table: "CyclingWorkouts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "WalkingWorkouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DateUpdated = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    Distance_Value = table.Column<double>(type: "float", nullable: true),
                    Distance_MeasurementSystem = table.Column<int>(type: "int", nullable: true),
                    Steps = table.Column<int>(type: "int", nullable: false),
                    TraineeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WalkingWorkouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WalkingWorkouts_Trainees_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CyclingWorkouts_TraineeId",
                table: "CyclingWorkouts",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_WalkingWorkouts_TraineeId",
                table: "WalkingWorkouts",
                column: "TraineeId");

            migrationBuilder.AddForeignKey(
                name: "FK_CyclingWorkouts_Trainees_TraineeId",
                table: "CyclingWorkouts",
                column: "TraineeId",
                principalTable: "Trainees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CyclingWorkouts_Trainees_TraineeId",
                table: "CyclingWorkouts");

            migrationBuilder.DropTable(
                name: "WalkingWorkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CyclingWorkouts",
                table: "CyclingWorkouts");

            migrationBuilder.DropIndex(
                name: "IX_CyclingWorkouts_TraineeId",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "Height_Value",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "ProfileSettings_TimeZone",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "Weight_Value",
                table: "Trainees");

            migrationBuilder.DropColumn(
                name: "Name_FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name_LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AverageSpeed_MeasurementSystem",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "AverageSpeed_Value",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "DateUpdated",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "Distance_MeasurementSystem",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "Distance_Value",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "ElevationGain_MeasurementSystem",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "ElevationGain_Value",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "ElevationLoss_MeasurementSystem",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "ElevationLoss_Value",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "MaxSpeed_MeasurementSystem",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "MaxSpeed_Value",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "CyclingWorkouts");

            migrationBuilder.DropColumn(
                name: "TraineeId",
                table: "CyclingWorkouts");

            migrationBuilder.RenameTable(
                name: "CyclingWorkouts",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "Weight_MeasurementSystem",
                table: "Trainees",
                newName: "WeightId");

            migrationBuilder.RenameColumn(
                name: "ProfileSettings_PreferredMeasurementSystem",
                table: "Trainees",
                newName: "ProfileSettingsId");

            migrationBuilder.RenameColumn(
                name: "Height_MeasurementSystem",
                table: "Trainees",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "TotalElevation_Value",
                table: "Height",
                newName: "Value");

            migrationBuilder.RenameColumn(
                name: "TotalElevation_MeasurementSystem",
                table: "Height",
                newName: "MeasurementSystem");

            migrationBuilder.AddColumn<int>(
                name: "HeightId",
                table: "Trainees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NameId",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Value",
                table: "Height",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MeasurementSystem",
                table: "Height",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Height",
                table: "Height",
                column: "Id");

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
                    PreferredMeasurementSystem = table.Column<int>(type: "int", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    MeasurementSystem = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weight", x => x.Id);
                });

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
                name: "IX_Trainees_WeightId",
                table: "Trainees",
                column: "WeightId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_NameId",
                table: "AspNetUsers",
                column: "NameId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Name_NameId",
                table: "AspNetUsers",
                column: "NameId",
                principalTable: "Name",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Height_HeightId",
                table: "Trainees",
                column: "HeightId",
                principalTable: "Height",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_ProfileLocation_LocationId",
                table: "Trainees",
                column: "LocationId",
                principalTable: "ProfileLocation",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_ProfileSettings_ProfileSettingsId",
                table: "Trainees",
                column: "ProfileSettingsId",
                principalTable: "ProfileSettings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Trainees_Weight_WeightId",
                table: "Trainees",
                column: "WeightId",
                principalTable: "Weight",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
