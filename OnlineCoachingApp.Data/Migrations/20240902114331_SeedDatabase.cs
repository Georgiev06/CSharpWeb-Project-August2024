using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineCoachingApp.Data.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("553d52b8-c217-4055-acc2-1e8ce1bf0341"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("e14656a3-c2f7-4500-943b-75a36bc01d7c"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("e58106e3-02f4-4415-aa97-6c78d389dcb7"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("f18f34a5-a655-4f2c-956a-5e605d278d29"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("f596d0cb-0d33-43ec-b44f-7efcc8b51c7b"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TrainingPrograms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 2, 11, 43, 31, 447, DateTimeKind.Utc).AddTicks(3287),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 2, 11, 41, 31, 215, DateTimeKind.Utc).AddTicks(4460));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("c9c45f13-54c4-4f9d-8d36-0e7dc506bf45"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") });

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[] { new Guid("f7ada361-e78f-405e-9e53-7e0188ea3511"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", "Fitness Program", 39.99m, new Guid("84899585-883b-4378-a5fd-c1ac78dd7867") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("c9c45f13-54c4-4f9d-8d36-0e7dc506bf45"));

            migrationBuilder.DeleteData(
                table: "TrainingPrograms",
                keyColumn: "Id",
                keyValue: new Guid("f7ada361-e78f-405e-9e53-7e0188ea3511"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TrainingPrograms",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 9, 2, 11, 41, 31, 215, DateTimeKind.Utc).AddTicks(4460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 9, 2, 11, 43, 31, 447, DateTimeKind.Utc).AddTicks(3287));

            migrationBuilder.InsertData(
                table: "TrainingPrograms",
                columns: new[] { "Id", "CategoryId", "CoachId", "CreatedOn", "Description", "DurationInWeeks", "ImageUrl", "Name", "Price", "UserId" },
                values: new object[,]
                {
                    { new Guid("553d52b8-c217-4055-acc2-1e8ce1bf0341"), 1, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program focused on street workouts and bodyweight training. Designed to build strength, agility, and endurance using minimal equipment, it's perfect for anyone looking to get fit outdoors.", 2, "", "Street Fitness Program", 29.99m, new Guid("84899585-883b-4378-a5fd-c1ac78dd7867") },
                    { new Guid("e14656a3-c2f7-4500-943b-75a36bc01d7c"), 4, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A comprehensive strength training program designed to build muscle and improve overall fitness. Includes daily workout routines with video instructions.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/b9205c59-f0ed-438f-ab45-3f29f957282d/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_2.jpg", "Fitness Program", 39.99m, new Guid("84899585-883b-4378-a5fd-c1ac78dd7867") },
                    { new Guid("e58106e3-02f4-4415-aa97-6c78d389dcb7"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") },
                    { new Guid("f18f34a5-a655-4f2c-956a-5e605d278d29"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "https://cdn.leonardo.ai/users/71abb3b9-56dd-47ca-af2e-bf983837b78e/generations/d3c619ec-0f28-4e96-96ba-7b5f926c4d02/Leonardo_Phoenix_i_want_you_to_generate_me_a_bodybuilder_reali_3.jpg?w=512", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") },
                    { new Guid("f596d0cb-0d33-43ec-b44f-7efcc8b51c7b"), 2, new Guid("d857d2eb-3aa9-42b8-8e29-0d939d36d12c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Program designed to build muscle and increase strength. Ideal for all levels, it focuses on progressive resistance training to help you achieve powerful, lasting results.", 4, "", "Fitness Program", 49.99m, new Guid("c85ca7cf-4f7d-4239-528c-08dcbeac59ab") }
                });
        }
    }
}
