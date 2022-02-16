using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace THA_Entitys.Migrations
{
    public partial class Ini5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfTraining",
                table: "TypeOfTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainee",
                table: "Trainee");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notification",
                table: "Notification");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contact",
                table: "Contact");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Company",
                table: "Company");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompaniesRequestForTraining",
                table: "CompaniesRequestForTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser");

            migrationBuilder.RenameTable(
                name: "TypeOfTraining",
                newName: "TypeOfTrainings");

            migrationBuilder.RenameTable(
                name: "Trainee",
                newName: "Trainees");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Notification",
                newName: "Notifications");

            migrationBuilder.RenameTable(
                name: "Contact",
                newName: "Contacts");

            migrationBuilder.RenameTable(
                name: "Company",
                newName: "Companies");

            migrationBuilder.RenameTable(
                name: "CompaniesRequestForTraining",
                newName: "CompanyRequests");

            migrationBuilder.RenameTable(
                name: "ApplicationUser",
                newName: "ApplicationUsers");

            migrationBuilder.RenameColumn(
                name: "roleName",
                table: "Roles",
                newName: "RoleName");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "Address",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "addressDetails",
                table: "Address",
                newName: "AddressDetails");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "TypeOfTrainings",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "university",
                table: "Trainees",
                newName: "University");

            migrationBuilder.RenameColumn(
                name: "phoneNumber",
                table: "Trainees",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "nationality",
                table: "Trainees",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "major",
                table: "Trainees",
                newName: "Major");

            migrationBuilder.RenameColumn(
                name: "linkedinUrl",
                table: "Trainees",
                newName: "LinkedinUrl");

            migrationBuilder.RenameColumn(
                name: "jobTitle",
                table: "Trainees",
                newName: "JobTitle");

            migrationBuilder.RenameColumn(
                name: "genderIsMale",
                table: "Trainees",
                newName: "GenderIsMale");

            migrationBuilder.RenameColumn(
                name: "fullName",
                table: "Trainees",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "email",
                table: "Trainees",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "dateOfGraduation",
                table: "Trainees",
                newName: "DateOfGraduation");

            migrationBuilder.RenameColumn(
                name: "cvUrl",
                table: "Trainees",
                newName: "CvUrl");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "Trainees",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Trainees",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "GPA",
                table: "Trainees",
                newName: "Gpa");

            migrationBuilder.RenameIndex(
                name: "IX_Trainee_TypeOfTrainingId",
                table: "Trainees",
                newName: "IX_Trainees_TypeOfTrainingId");

            migrationBuilder.RenameColumn(
                name: "projectName",
                table: "Projects",
                newName: "ProjectName");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "Projects",
                newName: "CreatedOn");

            migrationBuilder.RenameIndex(
                name: "IX_Project_TraineeId",
                table: "Projects",
                newName: "IX_Projects_TraineeId");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Notifications",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "isRead",
                table: "Notifications",
                newName: "IsRead");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "Notifications",
                newName: "CreatedOn");

            migrationBuilder.RenameIndex(
                name: "IX_Notification_UserId",
                table: "Notifications",
                newName: "IX_Notifications_UserId");

            migrationBuilder.RenameColumn(
                name: "role",
                table: "Companies",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "payment",
                table: "Companies",
                newName: "Payment");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "Companies",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "companyWebsite",
                table: "Companies",
                newName: "CompanyWebsite");

            migrationBuilder.RenameColumn(
                name: "companyName",
                table: "Companies",
                newName: "CompanyName");

            migrationBuilder.RenameColumn(
                name: "companyLicense",
                table: "Companies",
                newName: "CompanyLicense");

            migrationBuilder.RenameColumn(
                name: "companyEmail",
                table: "Companies",
                newName: "CompanyEmail");

            migrationBuilder.RenameColumn(
                name: "trainingPeriodTo",
                table: "CompanyRequests",
                newName: "TrainingPeriodTo");

            migrationBuilder.RenameColumn(
                name: "trainingPeriodFrom",
                table: "CompanyRequests",
                newName: "TrainingPeriodFrom");

            migrationBuilder.RenameColumn(
                name: "trainingPathName",
                table: "CompanyRequests",
                newName: "TrainingPathName");

            migrationBuilder.RenameColumn(
                name: "note",
                table: "CompanyRequests",
                newName: "Note");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "CompanyRequests",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "createdByUserId",
                table: "CompanyRequests",
                newName: "CreatedByUserId");

            migrationBuilder.RenameColumn(
                name: "capacity",
                table: "CompanyRequests",
                newName: "Capacity");

            migrationBuilder.RenameIndex(
                name: "IX_CompaniesRequestForTraining_CompanyId",
                table: "CompanyRequests",
                newName: "IX_CompanyRequests_CompanyId");

            migrationBuilder.RenameColumn(
                name: "createdOn",
                table: "ApplicationUsers",
                newName: "CreatedOn");

            migrationBuilder.RenameColumn(
                name: "createdByUserId",
                table: "ApplicationUsers",
                newName: "CreatedByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_TraineesId",
                table: "ApplicationUsers",
                newName: "IX_ApplicationUsers_TraineesId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_CompanyId",
                table: "ApplicationUsers",
                newName: "IX_ApplicationUsers_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUser_AddressId",
                table: "ApplicationUsers",
                newName: "IX_ApplicationUsers_AddressId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Address",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "TypeOfTrainings",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "Major",
                table: "Trainees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfGraduation",
                table: "Trainees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Trainees",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BirthDate",
                table: "Trainees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Gpa",
                table: "Trainees",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Projects",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Notifications",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Companies",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TrainingPeriodTo",
                table: "CompanyRequests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "TrainingPeriodFrom",
                table: "CompanyRequests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "date");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "CompanyRequests",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "ApplicationUsers",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "ApplicationUsers",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfTrainings",
                table: "TypeOfTrainings",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainees",
                table: "Trainees",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Companies",
                table: "Companies",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompanyRequests",
                table: "CompanyRequests",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeOfTrainings",
                table: "TypeOfTrainings");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainees",
                table: "Trainees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Notifications",
                table: "Notifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contacts",
                table: "Contacts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CompanyRequests",
                table: "CompanyRequests");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Companies",
                table: "Companies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "TypeOfTrainings",
                newName: "TypeOfTraining");

            migrationBuilder.RenameTable(
                name: "Trainees",
                newName: "Trainee");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Notifications",
                newName: "Notification");

            migrationBuilder.RenameTable(
                name: "Contacts",
                newName: "Contact");

            migrationBuilder.RenameTable(
                name: "CompanyRequests",
                newName: "CompaniesRequestForTraining");

            migrationBuilder.RenameTable(
                name: "Companies",
                newName: "Company");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "ApplicationUser");

            migrationBuilder.RenameColumn(
                name: "RoleName",
                table: "Roles",
                newName: "roleName");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Address",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "AddressDetails",
                table: "Address",
                newName: "addressDetails");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "TypeOfTraining",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "University",
                table: "Trainee",
                newName: "university");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Trainee",
                newName: "phoneNumber");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "Trainee",
                newName: "nationality");

            migrationBuilder.RenameColumn(
                name: "Major",
                table: "Trainee",
                newName: "major");

            migrationBuilder.RenameColumn(
                name: "LinkedinUrl",
                table: "Trainee",
                newName: "linkedinUrl");

            migrationBuilder.RenameColumn(
                name: "JobTitle",
                table: "Trainee",
                newName: "jobTitle");

            migrationBuilder.RenameColumn(
                name: "Gpa",
                table: "Trainee",
                newName: "GPA");

            migrationBuilder.RenameColumn(
                name: "GenderIsMale",
                table: "Trainee",
                newName: "genderIsMale");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Trainee",
                newName: "fullName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Trainee",
                newName: "email");

            migrationBuilder.RenameColumn(
                name: "DateOfGraduation",
                table: "Trainee",
                newName: "dateOfGraduation");

            migrationBuilder.RenameColumn(
                name: "CvUrl",
                table: "Trainee",
                newName: "cvUrl");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Trainee",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Trainee",
                newName: "birthDate");

            migrationBuilder.RenameIndex(
                name: "IX_Trainees_TypeOfTrainingId",
                table: "Trainee",
                newName: "IX_Trainee_TypeOfTrainingId");

            migrationBuilder.RenameColumn(
                name: "ProjectName",
                table: "Project",
                newName: "projectName");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Project",
                newName: "createdOn");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_TraineeId",
                table: "Project",
                newName: "IX_Project_TraineeId");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Notification",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "IsRead",
                table: "Notification",
                newName: "isRead");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Notification",
                newName: "createdOn");

            migrationBuilder.RenameIndex(
                name: "IX_Notifications_UserId",
                table: "Notification",
                newName: "IX_Notification_UserId");

            migrationBuilder.RenameColumn(
                name: "TrainingPeriodTo",
                table: "CompaniesRequestForTraining",
                newName: "trainingPeriodTo");

            migrationBuilder.RenameColumn(
                name: "TrainingPeriodFrom",
                table: "CompaniesRequestForTraining",
                newName: "trainingPeriodFrom");

            migrationBuilder.RenameColumn(
                name: "TrainingPathName",
                table: "CompaniesRequestForTraining",
                newName: "trainingPathName");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "CompaniesRequestForTraining",
                newName: "note");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "CompaniesRequestForTraining",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "CompaniesRequestForTraining",
                newName: "createdByUserId");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "CompaniesRequestForTraining",
                newName: "capacity");

            migrationBuilder.RenameIndex(
                name: "IX_CompanyRequests_CompanyId",
                table: "CompaniesRequestForTraining",
                newName: "IX_CompaniesRequestForTraining_CompanyId");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "Company",
                newName: "role");

            migrationBuilder.RenameColumn(
                name: "Payment",
                table: "Company",
                newName: "payment");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "Company",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "CompanyWebsite",
                table: "Company",
                newName: "companyWebsite");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                table: "Company",
                newName: "companyName");

            migrationBuilder.RenameColumn(
                name: "CompanyLicense",
                table: "Company",
                newName: "companyLicense");

            migrationBuilder.RenameColumn(
                name: "CompanyEmail",
                table: "Company",
                newName: "companyEmail");

            migrationBuilder.RenameColumn(
                name: "CreatedOn",
                table: "ApplicationUser",
                newName: "createdOn");

            migrationBuilder.RenameColumn(
                name: "CreatedByUserId",
                table: "ApplicationUser",
                newName: "createdByUserId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUsers_TraineesId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_TraineesId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUsers_CompanyId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_CompanyId");

            migrationBuilder.RenameIndex(
                name: "IX_ApplicationUsers_AddressId",
                table: "ApplicationUser",
                newName: "IX_ApplicationUser_AddressId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "Address",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "TypeOfTraining",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "major",
                table: "Trainee",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "GPA",
                table: "Trainee",
                type: "decimal(6,3)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "dateOfGraduation",
                table: "Trainee",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "Trainee",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "birthDate",
                table: "Trainee",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "Project",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "Notification",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "trainingPeriodTo",
                table: "CompaniesRequestForTraining",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "trainingPeriodFrom",
                table: "CompaniesRequestForTraining",
                type: "date",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "CompaniesRequestForTraining",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "Company",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "PasswordHash",
                table: "ApplicationUser",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(256)",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<DateTime>(
                name: "createdOn",
                table: "ApplicationUser",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeOfTraining",
                table: "TypeOfTraining",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainee",
                table: "Trainee",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Notification",
                table: "Notification",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contact",
                table: "Contact",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CompaniesRequestForTraining",
                table: "CompaniesRequestForTraining",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Company",
                table: "Company",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser",
                column: "Id");
        }
    }
}
