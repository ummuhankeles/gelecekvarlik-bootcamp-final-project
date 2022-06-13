using System;
using ApartmentManagement.Entity.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ApartmentManagement.Dal.EntityFramework.Context
{
    public partial class ApartmentManagementSystemContext : DbContext
    {
        public ApartmentManagementSystemContext()
        {
        }

        public ApartmentManagementSystemContext(DbContextOptions<ApartmentManagementSystemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Apartment> Apartments { get; set; }
        public virtual DbSet<Block> Blocks { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceType> InvoiceTypes { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<Month> Months { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=UMMUHANKELES\\SQLEXPRESS;Database=ApartmentManagementSystem;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Apartment>(entity =>
            {
                entity.HasKey(e => e.AprtId);

                entity.ToTable("Apartment");

                entity.Property(e => e.AprtId).HasColumnName("aprt_id");

                entity.Property(e => e.AprtFloor).HasColumnName("aprt_floor");

                entity.Property(e => e.AprtIsEmpty).HasColumnName("aprt_isEmpty");

                entity.Property(e => e.AprtRoomNo).HasColumnName("aprt_roomNo");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Apartments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Apartment_User");
            });

            modelBuilder.Entity<Block>(entity =>
            {
                entity.ToTable("Block");

                entity.Property(e => e.BlockId).HasColumnName("block_id");

                entity.Property(e => e.BlockName)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("block_name")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Building>(entity =>
            {
                entity.HasKey(e => e.BuildingsId);

                entity.Property(e => e.BuildingsId).HasColumnName("buildings_id");

                entity.Property(e => e.AprtId).HasColumnName("aprt_id");

                entity.Property(e => e.BlockId).HasColumnName("block_id");

                entity.Property(e => e.BuildingsName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("buildings_name");

                entity.HasOne(d => d.Aprt)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.AprtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buildings_Apartment");

                entity.HasOne(d => d.Block)
                    .WithMany(p => p.Buildings)
                    .HasForeignKey(d => d.BlockId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Buildings_Block");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoice_id");

                entity.Property(e => e.AprtId).HasColumnName("aprt_id");

                entity.Property(e => e.InvoiceAmount).HasColumnName("invoice_amount");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("date")
                    .HasColumnName("invoice_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.InvoiceStatus).HasColumnName("invoice_status");

                entity.Property(e => e.InvoiceTypeId).HasColumnName("invoiceType_id");

                entity.Property(e => e.MonthId).HasColumnName("month_id");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.Aprt)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.AprtId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Apartment");

                entity.HasOne(d => d.InvoiceType)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.InvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_InvoiceType");

                entity.HasOne(d => d.Month)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.MonthId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Month");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_User");
            });

            modelBuilder.Entity<InvoiceType>(entity =>
            {
                entity.ToTable("InvoiceType");

                entity.Property(e => e.InvoiceTypeId).HasColumnName("invoiceType_id");

                entity.Property(e => e.InvoiceTypeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("invoiceType_name");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.MessageId).HasColumnName("message_id");

                entity.Property(e => e.MessageContent)
                    .IsRequired()
                    .HasColumnName("message_content");

                entity.Property(e => e.MessageDate)
                    .HasColumnType("date")
                    .HasColumnName("message_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MessageHeader)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("message_header");

                entity.Property(e => e.MessageIsRead).HasColumnName("message_isRead");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_Message");
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.ToTable("Month");

                entity.Property(e => e.MonthId).HasColumnName("month_id");

                entity.Property(e => e.MonthName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("month_name");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("role_name");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.RoleId).HasColumnName("role_id");

                entity.Property(e => e.UserCarInfo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("user_carInfo");

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("user_email");

                entity.Property(e => e.UserFullName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_fullName");

                entity.Property(e => e.UserPassword)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("user_password");

                entity.Property(e => e.UserPhoneNumber).HasColumnName("user_phoneNumber");

                entity.Property(e => e.UserTcno)
                    .IsRequired()
                    .HasMaxLength(11)
                    .HasColumnName("user_TCNo");

                entity.Property(e => e.UserUsername)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("user_username");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
