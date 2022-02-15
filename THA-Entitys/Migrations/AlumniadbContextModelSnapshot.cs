﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using THA_Entitys.Models;

#nullable disable

namespace THA_Entitys.Migrations
{
    [DbContext(typeof(AlumniadbContext))]
    partial class AlumniadbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("THA_Entitys.Models.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("AddressDetails")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("addressDetails");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Address", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int")
                        .HasColumnName("createdByUserId");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool?>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUser", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.CompaniesRequestForTraining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("capacity");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int?>("CreatedByUserId")
                        .HasColumnType("int")
                        .HasColumnName("createdByUserId");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("note");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("TrainingPathName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("trainingPathName");

                    b.Property<DateTime>("TrainingPeriodFrom")
                        .HasColumnType("date")
                        .HasColumnName("trainingPeriodFrom");

                    b.Property<DateTime>("TrainingPeriodTo")
                        .HasColumnType("date")
                        .HasColumnName("trainingPeriodTo");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompaniesRequestForTraining", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("companyEmail");

                    b.Property<string>("CompanyLicense")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("companyLicense");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("companyName");

                    b.Property<string>("CompanyWebsite")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("companyWebsite");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<string>("Payment")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("payment");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("role");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Company", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("Contact", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit")
                        .HasColumnName("isRead");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("subject");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notification", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<string>("ProjectName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("projectName");

                    b.Property<int?>("TraineeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TraineeId");

                    b.ToTable("Project", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("roleName");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("THA_Entitys.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("date")
                        .HasColumnName("birthDate");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<string>("CvUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("cvUrl");

                    b.Property<DateTime?>("DateOfGraduation")
                        .HasColumnType("date")
                        .HasColumnName("dateOfGraduation");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("email");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("fullName");

                    b.Property<bool>("GenderIsMale")
                        .HasColumnType("bit")
                        .HasColumnName("genderIsMale");

                    b.Property<decimal?>("Gpa")
                        .HasColumnType("decimal(6,3)")
                        .HasColumnName("GPA");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("jobTitle");

                    b.Property<string>("LinkedinUrl")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("linkedinUrl");

                    b.Property<string>("Major")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("major");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("nationality");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("phoneNumber");

                    b.Property<int?>("TypeOfTrainingId")
                        .HasColumnType("int");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)")
                        .HasColumnName("university");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TypeOfTrainingId");

                    b.HasIndex("UserId");

                    b.ToTable("Trainee", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.TypeOfTraining", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("createdOn");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.ToTable("TypeOfTraining", (string)null);
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId")
                        .HasName("PK__UserRole__AF2760AD09768FB6");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", (string)null);
                });

            modelBuilder.Entity("THA_Entitys.Models.Address", b =>
                {
                    b.HasOne("THA_Entitys.Models.ApplicationUser", "User")
                        .WithMany("Addresses")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Address__UserId__2E1BDC42");

                    b.Navigation("User");
                });

            modelBuilder.Entity("THA_Entitys.Models.CompaniesRequestForTraining", b =>
                {
                    b.HasOne("THA_Entitys.Models.Company", "Company")
                        .WithMany("CompaniesRequestForTrainings")
                        .HasForeignKey("CompanyId")
                        .HasConstraintName("FK__Companies__Compa__2B3F6F97");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("THA_Entitys.Models.Company", b =>
                {
                    b.HasOne("THA_Entitys.Models.ApplicationUser", "User")
                        .WithMany("Companies")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Company__UserId__286302EC");

                    b.Navigation("User");
                });

            modelBuilder.Entity("THA_Entitys.Models.Notification", b =>
                {
                    b.HasOne("THA_Entitys.Models.ApplicationUser", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Notificat__UserI__32E0915F");

                    b.Navigation("User");
                });

            modelBuilder.Entity("THA_Entitys.Models.Project", b =>
                {
                    b.HasOne("THA_Entitys.Models.Trainee", "Trainee")
                        .WithMany("Projects")
                        .HasForeignKey("TraineeId")
                        .HasConstraintName("FK__Project__Trainee__3F466844");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("THA_Entitys.Models.Trainee", b =>
                {
                    b.HasOne("THA_Entitys.Models.TypeOfTraining", "TypeOfTraining")
                        .WithMany("Trainees")
                        .HasForeignKey("TypeOfTrainingId")
                        .HasConstraintName("FK__Trainee__TypeOfT__3B75D760");

                    b.HasOne("THA_Entitys.Models.ApplicationUser", "User")
                        .WithMany("Trainees")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__Trainee__UserId__3C69FB99");

                    b.Navigation("TypeOfTraining");

                    b.Navigation("User");
                });

            modelBuilder.Entity("UserRole", b =>
                {
                    b.HasOne("THA_Entitys.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__RoleI__38996AB5");

                    b.HasOne("THA_Entitys.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserRoles__UserI__37A5467C");
                });

            modelBuilder.Entity("THA_Entitys.Models.ApplicationUser", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Companies");

                    b.Navigation("Notifications");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("THA_Entitys.Models.Company", b =>
                {
                    b.Navigation("CompaniesRequestForTrainings");
                });

            modelBuilder.Entity("THA_Entitys.Models.Trainee", b =>
                {
                    b.Navigation("Projects");
                });

            modelBuilder.Entity("THA_Entitys.Models.TypeOfTraining", b =>
                {
                    b.Navigation("Trainees");
                });
#pragma warning restore 612, 618
        }
    }
}