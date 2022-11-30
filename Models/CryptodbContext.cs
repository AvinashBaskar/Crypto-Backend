using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace dotnetcrypto.Models;

public partial class CryptodbContext : DbContext
{
    public CryptodbContext()
    {
    }

    public CryptodbContext(DbContextOptions<CryptodbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cryptogallery> Cryptogalleries { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASTLPTWFH118\\SQLEXPRESS;Initial Catalog=Cryptodb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cryptogallery>(entity =>
        {
            entity.HasKey(e => e.Cryptoid).HasName("PK__Cryptoga__4405269532A2BC2C");

            entity.ToTable("Cryptogallery");

            entity.Property(e => e.CryptoImage).HasColumnName("Crypto_image");
            entity.Property(e => e.CryptoName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Crypto_name");
            entity.Property(e => e.CryptoPrice).HasColumnName("Crypto_Price");
            entity.Property(e => e.CryptoPriceAfter24hrs).HasColumnName("Crypto_price_after_24hrs");
            entity.Property(e => e.CryptoRank).HasColumnName("Crypto_Rank");
            entity.Property(e => e.CryptoSharePercentage).HasColumnName("Crypto_share_percentage");
            entity.Property(e => e.CryptoSymbol)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("Crypto_Symbol");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
