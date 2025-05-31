using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LightAndLensCL.Models
{
    public partial class LightAndLensDBContext : DbContext
    {
        public LightAndLensDBContext()
        {
        }

        public LightAndLensDBContext(DbContextOptions<LightAndLensDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AvailabilityStatus> AvailabilityStatuses { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<ConditionStatus> ConditionStatuses { get; set; } = null!;
        public virtual DbSet<Equipment> Equipment { get; set; } = null!;
        public virtual DbSet<EquipmentImage> EquipmentImages { get; set; } = null!;
        public virtual DbSet<Feedback> Feedbacks { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<RentalItem> RentalItems { get; set; } = null!;
        public virtual DbSet<RentalRequest> RentalRequests { get; set; } = null!;
        public virtual DbSet<RentalTransaction> RentalTransactions { get; set; } = null!;
        public virtual DbSet<RequestStatus> RequestStatuses { get; set; } = null!;
        public virtual DbSet<ReturnRecord> ReturnRecords { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDocument> UserDocuments { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=LightAndLens;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

             

            modelBuilder.Entity<AvailabilityStatus>(entity =>
            {
                entity.Property(e => e.AvailabilityId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.HasOne(d => d.Availability)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.AvailabilityId)
                    .HasConstraintName("FK_AvailabilityID_AvailabilityStatuses_Equipment");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryID_Categories_Equipment");

                entity.HasOne(d => d.Condition)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.ConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConditionID_ConditionStatuses_Equipment");
            });

            modelBuilder.Entity<EquipmentImage>(entity =>
            {
                

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.EquipmentImages)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EquipmentID_Equipment_EquipmentImages");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.Property(e => e.FeedbackId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_Equipment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Feedbacks)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserID_Users_Feedback");

                entity.HasOne(d => d.ReturnRecord)
                .WithMany(p => p.Feedbacks)
                .HasForeignKey(d => d.ReturnId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Feedback_ReturnRecords");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserID_Users_Notifications");
            });

            modelBuilder.Entity<RentalItem>(entity =>
            {
                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.RentalItems)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquipmentID_Equipment_RentalItems");

                entity.HasOne(d => d.Rental)
                    .WithMany(p => p.RentalItems)
                    .HasForeignKey(d => d.RentalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalID_RentalTransactions_RentalItems");
            });

            modelBuilder.Entity<RentalRequest>(entity =>
            {
                entity.HasOne(d => d.Equipment)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.EquipmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalRequests_Equipment");

                entity.HasOne(d => d.RequestStatus)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.RequestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalRequests_RequestStatuses");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalRequests)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalRequests_Users");
            });

            modelBuilder.Entity<RentalTransaction>(entity =>
            {
                entity.HasOne(d => d.Request)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.RequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RequestID_RentalRequests_RentalTransactions");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RentalTransactions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserID_Users_RentalTransactions");
            });

            modelBuilder.Entity<ReturnRecord>(entity =>
            {
                entity.Property(e => e.ReturnId).ValueGeneratedOnAdd();

                entity.HasOne(d => d.Rental)
                    .WithMany(p => p.ReturnRecords)
                    .HasForeignKey(d => d.RentalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RentalID_RentalTransactions_ReturnRecords");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleID_Roles_Users");
            });

            modelBuilder.Entity<Log>()
            .HasOne(l => l.User)
            .WithMany()
            .HasForeignKey(l => l.UserId)
            .OnDelete(DeleteBehavior.ClientSetNull)
            .HasConstraintName("FK_UserID_Users_Logs");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
