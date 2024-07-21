using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KeypadSystem.Models;

public partial class KeycodesContext : DbContext
{
    public KeycodesContext()
    {
    }

    public KeycodesContext(DbContextOptions<KeycodesContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CodeLog> CodeLogs { get; set; }

    //public virtual DbSet<Company> Companies { get; set; }

    //public virtual DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=tcp:ellement.database.windows.net;Database=Keycodes;User ID=EllementAdmin;Password=AudenshawSch2012!;Trusted_Connection=True; Integrated Security=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CodeLog>(entity =>
        {
            entity.HasKey(e => e.CodeLogId).HasName("PK__CodeLog__65AFA50631C24650");

            entity.ToTable("CodeLog");

            entity.Property(e => e.CodeLogId).HasDefaultValueSql("(newid())");
            entity.Property(e => e.CodeUsedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            //entity.HasOne(d => d.Customer).WithMany(p => p.CodeLogs)
            //    .HasForeignKey(d => d.CustomerId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK__CodeLog__Custome__6C190EBB");
        });

        //modelBuilder.Entity<Company>(entity =>
        //{
        //    entity.HasKey(e => e.CompanyId).HasName("PK__Companie__2D971CACF5D8BC9C");

        //    entity.Property(e => e.CompanyId).HasDefaultValueSql("(newid())");
        //    entity.Property(e => e.CompanyColor)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CompanyDescription)
        //        .HasMaxLength(500)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CompanyLogo)
        //        .HasMaxLength(500)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CompanyName)
        //        .HasMaxLength(100)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CompanyUserName)
        //        .HasMaxLength(100)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CreatedDate).HasColumnType("datetime");
        //    entity.Property(e => e.PasswordHash)
        //        .HasMaxLength(64)
        //        .IsFixedLength();
        //});

        //modelBuilder.Entity<Customer>(entity =>
        //{
        //    entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64D8625A28CA");

        //    entity.Property(e => e.CustomerId).HasDefaultValueSql("(newid())");
        //    entity.Property(e => e.CustomerCode).ValueGeneratedOnAdd();
        //    entity.Property(e => e.CustomerDob).HasColumnName("CustomerDOB");
        //    entity.Property(e => e.CustomerFirstName)
        //        .HasMaxLength(100)
        //        .IsUnicode(false);
        //    entity.Property(e => e.CustomerLastName)
        //        .HasMaxLength(100)
        //        .IsUnicode(false);
        //    entity.Property(e => e.JoinedDate)
        //        .HasDefaultValueSql("(getdate())")
        //        .HasColumnType("datetime");

        //    //entity.HasOne(d => d.Company).WithMany(p => p.Customers)
        //    //    .HasForeignKey(d => d.CompanyId)
        //    //    .OnDelete(DeleteBehavior.ClientSetNull)
        //    //    .HasConstraintName("FK__Customers__Compa__66603565");
        //});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
