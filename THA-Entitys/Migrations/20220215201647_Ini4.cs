using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace THA_Entitys.Migrations
{
    public partial class Ini4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressDetails = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    companyName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    companyEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    companyWebsite = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    companyLicense = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    role = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    payment = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Message = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfTraining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfTraining", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompaniesRequestForTraining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    trainingPathName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    capacity = table.Column<int>(type: "int", nullable: false),
                    trainingPeriodFrom = table.Column<DateTime>(type: "date", nullable: false),
                    trainingPeriodTo = table.Column<DateTime>(type: "date", nullable: false),
                    note = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createdByUserId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    createdOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompaniesRequestForTraining", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Companies__Compa__2B3F6F97",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainee",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    university = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    birthDate = table.Column<DateTime>(type: "date", nullable: true),
                    genderIsMale = table.Column<bool>(type: "bit", nullable: false),
                    GPA = table.Column<decimal>(type: "decimal(6,3)", nullable: true),
                    nationality = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    major = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    dateOfGraduation = table.Column<DateTime>(type: "date", nullable: true),
                    linkedinUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    jobTitle = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    cvUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    phoneNumber = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TypeOfTrainingId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainee", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Trainee__TypeOfT__3B75D760",
                        column: x => x.TypeOfTrainingId,
                        principalTable: "TypeOfTraining",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedByUserId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: true),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    TraineesId = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Address__UserId__2E1BDC42",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Company__UserId__286302EC",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Trainee__UserId__3C69FB99",
                        column: x => x.TraineesId,
                        principalTable: "Trainee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    TraineeId = table.Column<int>(type: "int", nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Project__Trainee__3F466844",
                        column: x => x.TraineeId,
                        principalTable: "Trainee",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    subject = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    isRead = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    createdOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Notificat__UserI__32E0915F",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__UserRole__AF2760AD09768FB6", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK__UserRoles__RoleI__38996AB5",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__UserRoles__UserI__37A5467C",
                        column: x => x.UserId,
                        principalTable: "ApplicationUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_AddressId",
                table: "ApplicationUsers",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_CompanyId",
                table: "ApplicationUsers",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUsers_TraineesId",
                table: "ApplicationUsers",
                column: "TraineesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CompaniesRequestForTraining_CompanyId",
                table: "CompaniesRequestForTraining",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_TraineeId",
                table: "Project",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainee_TypeOfTrainingId",
                table: "Trainee",
                column: "TypeOfTrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompaniesRequestForTraining");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "ApplicationUsers");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Trainee");

            migrationBuilder.DropTable(
                name: "TypeOfTraining");
        }
    }
}
