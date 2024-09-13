using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingApp.Data.Migrations
{
    public partial class AddCreatedOncolumnToTrainingProgramEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("aeef4f4c-0940-415d-a32b-9ded98974de3"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("ca3a7f62-1caf-4193-907e-568ef0b7c3be"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "TrainingPrograms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 28, 10, 49, 41, 248, DateTimeKind.Utc).AddTicks(7368));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("4dd4ac45-7895-4f59-a736-462699af8e61"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("503754be-5518-4f8c-aa02-2d69d29d412d"), 1, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program focused on street workouts and bodyweight training. Designed to build strength, agility, and endurance using minimal equipment, it's perfect for anyone looking to get fit outdoors.", 2, "", "Street Fitness Program", 29.99m, new Guid("84899585-883b-4378-a5fd-c1ac78dd7867") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("4dd4ac45-7895-4f59-a736-462699af8e61"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("503754be-5518-4f8c-aa02-2d69d29d412d"));

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "TrainingPrograms");

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("aeef4f4c-0940-415d-a32b-9ded98974de3"), 1, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program focused on street workouts and bodyweight training. Designed to build strength, agility, and endurance using minimal equipment, it's perfect for anyone looking to get fit outdoors.", 2, "", "Street Fitness Program", 29.99m, new Guid("84899585-883b-4378-a5fd-c1ac78dd7867") });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("ca3a7f62-1caf-4193-907e-568ef0b7c3be"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") });
        }
    }
}
