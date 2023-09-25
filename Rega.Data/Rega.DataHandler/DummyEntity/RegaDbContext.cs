using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Rega.DataHandler.Entities;

namespace Rega.DataHandler.DummyEntity;

public partial class RegaDbContext : DbContext
{
    public RegaDbContext()
    {
    }

    public RegaDbContext(DbContextOptions<RegaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-C5C8ML9;Initial Catalog=RegaDB;Connection Timeout=240;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=True;Integrated Security=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.ToTable("Product");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateModified).HasColumnType("datetime");
            entity.Property(e => e.ProductDescription).HasMaxLength(500);
            entity.Property(e => e.ProductName).HasMaxLength(250);
            entity.Property(e => e.UserCreated).HasMaxLength(250);
            entity.Property(e => e.UserModified).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
