using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace THA_Entitys.Models
{
    public partial class AlumniadbContext : IdentityDbContext<ApplicationUser,IdentityRole,string>
    {
        public AlumniadbContext()
        {
        }

        public AlumniadbContext(DbContextOptions options)
            : base(options)
        {
        }

        public  DbSet<Address> Addresses { get; set; } = null!;
        public  DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
        public  DbSet<CompaniesRequestForTraining> CompaniesRequestForTrainings { get; set; } = null!;
        public  DbSet<Company> Companies { get; set; } = null!;
        public  DbSet<Contact> Contacts { get; set; } = null!;
        public  DbSet<Notification> Notifications { get; set; } = null!;
        public  DbSet<Project> Projects { get; set; } = null!;
        public  DbSet<Trainee> Trainees { get; set; } = null!;
        public  DbSet<TypeOfTraining> TypeOfTrainings { get; set; } = null!;
        public  DbSet<Address> Address { get; set; } = null!;


//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Server=TAH-LAP-JOR289;Database=Alumniadb;Trusted_Connection=True;");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<Address>(entity =>
//            {
//                entity.ToTable("Address");

//                entity.Property(e => e.AddressDetails)
//                    .HasMaxLength(256)
//                    .HasColumnName("addressDetails");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Addresses)
//                    .HasForeignKey(d => d.UserId)
//                    .HasConstraintName("FK__Address__UserId__2E1BDC42");
//            });

//            modelBuilder.Entity<ApplicationUser>(entity =>
//            {
//                entity.ToTable("ApplicationUser");

//                entity.Property(e => e.CreatedByUserId).HasColumnName("createdByUserId");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.Email).HasMaxLength(256);

//                entity.Property(e => e.Status).HasMaxLength(50);

//                entity.Property(e => e.UserName).HasMaxLength(256);

//                entity.HasMany(d => d.Roles)
//                    .WithMany(p => p.Users)
//                    .UsingEntity<Dictionary<string, object>>(
//                        "UserRole",
//                        l => l.HasOne<Role>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__UserRoles__RoleI__38996AB5"),
//                        r => r.HasOne<ApplicationUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__UserRoles__UserI__37A5467C"),
//                        j =>
//                        {
//                            j.HasKey("UserId", "RoleId").HasName("PK__UserRole__AF2760AD09768FB6");

//                            j.ToTable("UserRoles");
//                        });
//            });

//            modelBuilder.Entity<CompaniesRequestForTraining>(entity =>
//            {
//                entity.ToTable("CompaniesRequestForTraining");

//                entity.Property(e => e.Capacity).HasColumnName("capacity");

//                entity.Property(e => e.CreatedByUserId).HasColumnName("createdByUserId");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.Note)
//                    .HasMaxLength(256)
//                    .HasColumnName("note");

//                entity.Property(e => e.Status)
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.TrainingPathName)
//                    .HasMaxLength(256)
//                    .HasColumnName("trainingPathName");

//                entity.Property(e => e.TrainingPeriodFrom)
//                    .HasColumnType("date")
//                    .HasColumnName("trainingPeriodFrom");

//                entity.Property(e => e.TrainingPeriodTo)
//                    .HasColumnType("date")
//                    .HasColumnName("trainingPeriodTo");

//                entity.HasOne(d => d.Company)
//                    .WithMany(p => p.CompaniesRequestForTrainings)
//                    .HasForeignKey(d => d.CompanyId)
//                    .HasConstraintName("FK__Companies__Compa__2B3F6F97");
//            });

//            modelBuilder.Entity<Company>(entity =>
//            {
//                entity.ToTable("Company");

//                entity.Property(e => e.CompanyEmail)
//                    .HasMaxLength(256)
//                    .HasColumnName("companyEmail");

//                entity.Property(e => e.CompanyLicense)
//                    .HasMaxLength(256)
//                    .HasColumnName("companyLicense");

//                entity.Property(e => e.CompanyName)
//                    .HasMaxLength(256)
//                    .HasColumnName("companyName");

//                entity.Property(e => e.CompanyWebsite)
//                    .HasMaxLength(256)
//                    .HasColumnName("companyWebsite");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.Payment)
//                    .HasMaxLength(256)
//                    .HasColumnName("payment");

//                entity.Property(e => e.Role)
//                    .HasMaxLength(256)
//                    .HasColumnName("role");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Companies)
//                    .HasForeignKey(d => d.UserId)
//                    .HasConstraintName("FK__Company__UserId__286302EC");
//            });

//            modelBuilder.Entity<Contact>(entity =>
//            {
//                entity.ToTable("Contact");

//                entity.Property(e => e.Email).HasMaxLength(256);

//                entity.Property(e => e.Message).HasMaxLength(256);

//                entity.Property(e => e.Name).HasMaxLength(256);
//            });

//            modelBuilder.Entity<Notification>(entity =>
//            {
//                entity.ToTable("Notification");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.IsRead).HasColumnName("isRead");

//                entity.Property(e => e.Subject)
//                    .HasMaxLength(256)
//                    .HasColumnName("subject");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Notifications)
//                    .HasForeignKey(d => d.UserId)
//                    .HasConstraintName("FK__Notificat__UserI__32E0915F");
//            });

//            modelBuilder.Entity<Project>(entity =>
//            {
//                entity.ToTable("Project");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.ProjectName)
//                    .HasMaxLength(256)
//                    .HasColumnName("projectName");

//                entity.HasOne(d => d.Trainee)
//                    .WithMany(p => p.Projects)
//                    .HasForeignKey(d => d.TraineeId)
//                    .HasConstraintName("FK__Project__Trainee__3F466844");
//            });

//            modelBuilder.Entity<Role>(entity =>
//            {
//                entity.Property(e => e.RoleName)
//                    .HasMaxLength(256)
//                    .HasColumnName("roleName");
//            });

//            modelBuilder.Entity<Trainee>(entity =>
//            {
//                entity.ToTable("Trainee");

//                entity.Property(e => e.BirthDate)
//                    .HasColumnType("date")
//                    .HasColumnName("birthDate");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.CvUrl)
//                    .HasMaxLength(256)
//                    .HasColumnName("cvUrl");

//                entity.Property(e => e.DateOfGraduation)
//                    .HasColumnType("date")
//                    .HasColumnName("dateOfGraduation");

//                entity.Property(e => e.Email)
//                    .HasMaxLength(256)
//                    .HasColumnName("email");

//                entity.Property(e => e.FullName)
//                    .HasMaxLength(256)
//                    .HasColumnName("fullName");

//                entity.Property(e => e.GenderIsMale).HasColumnName("genderIsMale");

//                entity.Property(e => e.Gpa)
//                    .HasColumnType("decimal(6, 3)")
//                    .HasColumnName("GPA");

//                entity.Property(e => e.ImageUrl).HasMaxLength(256);

//                entity.Property(e => e.JobTitle)
//                    .HasMaxLength(256)
//                    .HasColumnName("jobTitle");

//                entity.Property(e => e.LinkedinUrl)
//                    .HasMaxLength(256)
//                    .HasColumnName("linkedinUrl");

//                entity.Property(e => e.Major)
//                    .HasMaxLength(256)
//                    .HasColumnName("major");

//                entity.Property(e => e.Nationality)
//                    .HasMaxLength(256)
//                    .HasColumnName("nationality");

//                entity.Property(e => e.PhoneNumber)
//                    .HasMaxLength(256)
//                    .HasColumnName("phoneNumber");

//                entity.Property(e => e.University)
//                    .HasMaxLength(256)
//                    .HasColumnName("university");

//                entity.HasOne(d => d.TypeOfTraining)
//                    .WithMany(p => p.Trainees)
//                    .HasForeignKey(d => d.TypeOfTrainingId)
//                    .HasConstraintName("FK__Trainee__TypeOfT__3B75D760");

//                entity.HasOne(d => d.User)
//                    .WithMany(p => p.Trainees)
//                    .HasForeignKey(d => d.UserId)
//                    .HasConstraintName("FK__Trainee__UserId__3C69FB99");
//            });

//            modelBuilder.Entity<TypeOfTraining>(entity =>
//            {
//                entity.ToTable("TypeOfTraining");

//                entity.Property(e => e.CreatedOn)
//                    .HasColumnType("datetime")
//                    .HasColumnName("createdOn");

//                entity.Property(e => e.Type).HasMaxLength(256);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
