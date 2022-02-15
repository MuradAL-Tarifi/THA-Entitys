using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace THA_Entitys.Migrations
{
    public partial class Initial3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Address__UserId__2E1BDC42",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK__Companies__Compa__2B3F6F97",
                table: "CompaniesRequestForTraining");

            migrationBuilder.DropForeignKey(
                name: "FK__Company__UserId__286302EC",
                table: "Company");

            migrationBuilder.DropForeignKey(
                name: "FK__Trainee__UserId__3C69FB99",
                table: "Trainee");

            migrationBuilder.DropIndex(
                name: "IX_Trainee_UserId",
                table: "Trainee");

            migrationBuilder.DropIndex(
                name: "IX_Company_UserId",
                table: "Company");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "CompaniesRequestForTraining");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ApplicationUser");

            migrationBuilder.AlterColumn<int>(
                name: "createdByUserId",
                table: "CompaniesRequestForTraining",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CompaniesRequestForTraining",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "CompaniesRequestForTraining",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "ApplicationUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "ApplicationUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TraineesId",
                table: "ApplicationUser",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "state",
                table: "ApplicationUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_AddressId",
                table: "ApplicationUser",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_CompanyId",
                table: "ApplicationUser",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUser_TraineesId",
                table: "ApplicationUser",
                column: "TraineesId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK__Address__UserId__2E1BDC42",
                table: "ApplicationUser",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Company__UserId__286302EC",
                table: "ApplicationUser",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Trainee__UserId__3C69FB99",
                table: "ApplicationUser",
                column: "TraineesId",
                principalTable: "Trainee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Companies__Compa__2B3F6F97",
                table: "CompaniesRequestForTraining",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Address__UserId__2E1BDC42",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK__Company__UserId__286302EC",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK__Trainee__UserId__3C69FB99",
                table: "ApplicationUser");

            migrationBuilder.DropForeignKey(
                name: "FK__Companies__Compa__2B3F6F97",
                table: "CompaniesRequestForTraining");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_AddressId",
                table: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_CompanyId",
                table: "ApplicationUser");

            migrationBuilder.DropIndex(
                name: "IX_ApplicationUser_TraineesId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "state",
                table: "CompaniesRequestForTraining");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "TraineesId",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "state",
                table: "ApplicationUser");

            migrationBuilder.AlterColumn<int>(
                name: "createdByUserId",
                table: "CompaniesRequestForTraining",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyId",
                table: "CompaniesRequestForTraining",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "CompaniesRequestForTraining",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "ApplicationUser",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Trainee_UserId",
                table: "Trainee",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Company_UserId",
                table: "Company",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK__Address__UserId__2E1BDC42",
                table: "Address",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Companies__Compa__2B3F6F97",
                table: "CompaniesRequestForTraining",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Company__UserId__286302EC",
                table: "Company",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Trainee__UserId__3C69FB99",
                table: "Trainee",
                column: "UserId",
                principalTable: "ApplicationUser",
                principalColumn: "Id");
        }
    }
}
