using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingApp.Data.Migrations
{
    public partial class SeedTrainingPrograms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("1502b65d-f582-4e77-9b59-dcd81d7e5f8f"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("ecf2777e-fa5b-4d61-825b-b6f96c30dc19"));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("aeef4f4c-0940-415d-a32b-9ded98974de3"), 1, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program focused on street workouts and bodyweight training. Designed to build strength, agility, and endurance using minimal equipment, it's perfect for anyone looking to get fit outdoors.", 2, "", "Street Fitness Program", 29.99m, new Guid("84899585-883b-4378-a5fd-c1ac78dd7867") });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("ca3a7f62-1caf-4193-907e-568ef0b7c3be"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("aeef4f4c-0940-415d-a32b-9ded98974de3"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("ca3a7f62-1caf-4193-907e-568ef0b7c3be"));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("1502b65d-f582-4e77-9b59-dcd81d7e5f8f"), 1, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program focused on street workouts and bodyweight training. Designed to build strength, agility, and endurance using minimal equipment, it's perfect for anyone looking to get fit outdoors.", 2, "", "Street Fitness Program", 29.99m, new Guid("00000000-0000-0000-0000-000000000000") });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("ecf2777e-fa5b-4d61-825b-b6f96c30dc19"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") });
        }
    }
}
