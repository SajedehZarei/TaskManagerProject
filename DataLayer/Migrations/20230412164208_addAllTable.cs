using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class addAllTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "task");

            migrationBuilder.CreateTable(
                name: "StepTypes",
                schema: "task",
                columns: table => new
                {
                    PkStepTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepTypes", x => x.PkStepTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                schema: "task",
                columns: table => new
                {
                    PkUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Family = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhonNumber = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IsPhonNumberConfig = table.Column<bool>(type: "bit", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsEmailConfig = table.Column<bool>(type: "bit", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.PkUserId);
                });

            migrationBuilder.CreateTable(
                name: "TaskInformation",
                schema: "task",
                columns: table => new
                {
                    PkTaskInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    FkTaskStepId = table.Column<int>(type: "int", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskInformation", x => x.PkTaskInformationId);
                    table.ForeignKey(
                        name: "FK_TaskInformation_StepTypes_FkTaskStepId",
                        column: x => x.FkTaskStepId,
                        principalSchema: "task",
                        principalTable: "StepTypes",
                        principalColumn: "PkStepTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskInformation_Users_CreateUserId",
                        column: x => x.CreateUserId,
                        principalSchema: "task",
                        principalTable: "Users",
                        principalColumn: "PkUserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "task",
                table: "StepTypes",
                columns: new[] { "PkStepTypeId", "CreatedDate", "IsActive", "IsDeleted", "ModifiedDate", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "New" },
                    { 2, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Active" },
                    { 3, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Resolved" },
                    { 4, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Done" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskInformation_CreateUserId",
                schema: "task",
                table: "TaskInformation",
                column: "CreateUserId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskInformation_FkTaskStepId",
                schema: "task",
                table: "TaskInformation",
                column: "FkTaskStepId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskInformation",
                schema: "task");

            migrationBuilder.DropTable(
                name: "StepTypes",
                schema: "task");

            migrationBuilder.DropTable(
                name: "Users",
                schema: "task");
        }
    }
}
