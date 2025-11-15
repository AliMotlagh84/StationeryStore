using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StationeryStoreDataLayer.Models;

public partial class StationeryStoreContext : DbContext
{
    public StationeryStoreContext()
    {
    }

    public StationeryStoreContext(DbContextOptions<StationeryStoreContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdressTable> AdressTables { get; set; }

    public virtual DbSet<BrandsTable> BrandsTables { get; set; }

    public virtual DbSet<DraftOrdersTable> DraftOrdersTables { get; set; }

    public virtual DbSet<OrdersTable> OrdersTables { get; set; }

    public virtual DbSet<ProductsTable> ProductsTables { get; set; }

    public virtual DbSet<UserTable> UserTables { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.;Database=StationeryStore;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdressTable>(entity =>
        {
            entity.HasKey(e => e.AdressId);

            entity.ToTable("AdressTable");

            entity.Property(e => e.Alley).HasMaxLength(100);
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.HouseNumber).HasMaxLength(100);
            entity.Property(e => e.Street).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.User).WithMany(p => p.AdressTables)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_AdressTable_UserTable");
        });

        modelBuilder.Entity<BrandsTable>(entity =>
        {
            entity.HasKey(e => e.BrandId);

            entity.ToTable("BrandsTable");

            entity.Property(e => e.BrandName).HasMaxLength(100);
        });

        modelBuilder.Entity<DraftOrdersTable>(entity =>
        {
            entity.HasKey(e => e.DraftOrderId);

            entity.ToTable("DraftOrdersTable");

            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.Product).WithMany(p => p.DraftOrdersTables)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DraftOrdersTable_ProductsTable");

            entity.HasOne(d => d.User).WithMany(p => p.DraftOrdersTables)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DraftOrdersTable_UserTable");
        });

        modelBuilder.Entity<OrdersTable>(entity =>
        {
            entity.HasKey(e => e.OrderId);

            entity.ToTable("OrdersTable");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);

            entity.HasOne(d => d.User).WithMany(p => p.OrdersTables)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_OrdersTable_UserTable");
        });

        modelBuilder.Entity<ProductsTable>(entity =>
        {
            entity.HasKey(e => e.ProductId);

            entity.ToTable("ProductsTable");

            entity.Property(e => e.AddTime).HasColumnType("datetime");

            entity.HasOne(d => d.Brand).WithMany(p => p.ProductsTables)
                .HasForeignKey(d => d.BrandId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProductsTable_BrandsTable");
        });

        modelBuilder.Entity<UserTable>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("UserTable");

            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
