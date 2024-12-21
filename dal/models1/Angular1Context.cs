using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dal.models1;

public partial class Angular1Context : DbContext
{
    public Angular1Context()
    {
    }

    public Angular1Context(DbContextOptions<Angular1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Company> Companies { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<Purchase> Purchases { get; set; }

    public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=.;database=angular1 ;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryCode).HasName("PK__Categori__371BA954E3612942");

            entity.Property(e => e.CategoryCode).ValueGeneratedNever();
            entity.Property(e => e.CategoryName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Company>(entity =>
        {
            entity.HasKey(e => e.CompanyCode).HasName("PK__Companie__11A0134A6802D2D7");

            entity.Property(e => e.CompanyCode).ValueGeneratedNever();
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerCode).HasName("PK__Customer__0667852075605DCA");

            entity.Property(e => e.CustomerCode).ValueGeneratedNever();
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductCode).HasName("PK__Products__2F4E024EF33C8535");

            entity.Property(e => e.ProductCode).ValueGeneratedNever();
            entity.Property(e => e.LastUpdated)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Price).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.ProductDescription).HasColumnType("text");
            entity.Property(e => e.ProductName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.CategoryCodeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.CategoryCode)
                .HasConstraintName("FK__Products__Catego__3C69FB99");

            entity.HasOne(d => d.CompanyCodeNavigation).WithMany(p => p.Products)
                .HasForeignKey(d => d.CompanyCode)
                .HasConstraintName("FK__Products__Compan__3D5E1FD2");
        });

        modelBuilder.Entity<Purchase>(entity =>
        {
            entity.HasKey(e => e.PurchaseCode).HasName("PK__Purchase__5F6119E9BAB1CF92");

            entity.ToTable(tb => tb.HasTrigger("CalculatePurchaseTotal"));

            entity.Property(e => e.PurchaseCode).ValueGeneratedNever();
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.PurchaseDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.CustomerCodeNavigation).WithMany(p => p.Purchases)
                .HasForeignKey(d => d.CustomerCode)
                .HasConstraintName("FK__Purchases__Custo__4316F928");
        });

        modelBuilder.Entity<PurchaseDetail>(entity =>
        {
            entity.HasKey(e => e.PurchaseDetailCode).HasName("PK__Purchase__2E268E7965294BB5");

            entity.Property(e => e.PurchaseDetailCode).ValueGeneratedNever();

            entity.HasOne(d => d.ProductCodeNavigation).WithMany(p => p.PurchaseDetails)
                .HasForeignKey(d => d.ProductCode)
                .HasConstraintName("FK__PurchaseD__Produ__46E78A0C");

            entity.HasOne(d => d.PurchaseCodeNavigation).WithMany(p => p.PurchaseDetails)
                .HasForeignKey(d => d.PurchaseCode)
                .HasConstraintName("FK__PurchaseD__Purch__45F365D3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
