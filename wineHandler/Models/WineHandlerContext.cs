using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace wineHandler.Models;

public partial class WineHandlerContext : DbContext
{
    public WineHandlerContext()
    {
    }

    public WineHandlerContext(DbContextOptions<WineHandlerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appellation> Appellations { get; set; }

    public virtual DbSet<Bouteille> Bouteilles { get; set; }

    public virtual DbSet<Cave> Caves { get; set; }

    public virtual DbSet<Vin> Vins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=2a03:5840:111:1024:508f:fc67:4795:f4d3;User ID=sa;Password=erty64%;Database=WineHandler;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appellation>(entity =>
        {
            entity.HasKey(e => e.IdAppellation).HasName("PK__Appellat__AD76CFD339F128DB");

            entity.ToTable("Appellation");

            entity.HasIndex(e => e.Nom, "UQ__Appellat__C7D1C61E90F30145").IsUnique();

            entity.Property(e => e.Nom).HasMaxLength(100);
        });

        modelBuilder.Entity<Bouteille>(entity =>
        {
            entity.HasKey(e => e.IdBouteille).HasName("PK__Bouteill__30737FC6798F8BBA");

            entity.ToTable("Bouteille", tb =>
                {
                    tb.HasTrigger("TR_Bouteille_RespecterCapaciteTiroir");
                    tb.HasTrigger("TR_Bouteille_ValiderEmplacement");
                });

            entity.HasIndex(e => new { e.IdCave, e.NoTiroir, e.NoEmplacement }, "IXU_Bouteille_Emplacement_Stock")
                .IsUnique()
                .HasFilter("([NoEmplacement] IS NOT NULL AND [Statut]='S')");

            entity.Property(e => e.Note).HasMaxLength(500);
            entity.Property(e => e.Statut)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValue("S")
                .IsFixedLength();

            entity.HasOne(d => d.IdCaveNavigation).WithMany(p => p.Bouteilles)
                .HasForeignKey(d => d.IdCave)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bouteille__IdCav__4AB81AF0");

            entity.HasOne(d => d.IdVinNavigation).WithMany(p => p.Bouteilles)
                .HasForeignKey(d => d.IdVin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Bouteille__IdVin__49C3F6B7");
        });

        modelBuilder.Entity<Cave>(entity =>
        {
            entity.HasKey(e => e.IdCave).HasName("PK__Cave__3B7B544063B854ED");

            entity.ToTable("Cave");

            entity.HasIndex(e => e.Nom, "UQ__Cave__C7D1C61E3BF79C42").IsUnique();

            entity.Property(e => e.Capacite).HasComputedColumnSql("([NbTiroirs]*[BouteillesParTiroir])", true);
            entity.Property(e => e.Fabricant).HasMaxLength(100);
            entity.Property(e => e.Famille).HasMaxLength(100);
            entity.Property(e => e.Nom).HasMaxLength(100);
            entity.Property(e => e.TemperatureC).HasColumnType("decimal(4, 1)");
        });


        modelBuilder.Entity<Vin>(entity =>
        {
            entity.HasKey(e => e.IdVin).HasName("PK__Vin__2B423C08ACF0AFCF");

            entity.ToTable("Vin");

            entity.HasIndex(e => new { e.IdAppellation, e.AnneeMillesime }, "IX_Vin_Appellation_Annee");

            entity.Property(e => e.Couleur).HasMaxLength(10);
            entity.Property(e => e.Nom).HasMaxLength(200);

            entity.HasOne(d => d.IdAppellationNavigation).WithMany(p => p.Vins)
                .HasForeignKey(d => d.IdAppellation)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Vin__IdAppellati__440B1D61");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
