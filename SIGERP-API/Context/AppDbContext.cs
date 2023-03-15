using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SIGERP_API.Models;

namespace SIGERP_API.Context;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CampoCultivo> CampoCultivos { get; set; }

    public virtual DbSet<CicloCultivo> CicloCultivos { get; set; }

    public virtual DbSet<Cultivo> Cultivos { get; set; }

    public virtual DbSet<CultivoSembrado> CultivoSembrados { get; set; }

    public virtual DbSet<CultivoVariedad> CultivoVariedads { get; set; }

    public virtual DbSet<FactProduccion> FactProduccions { get; set; }

    public virtual DbSet<Sociedad> Sociedads { get; set; }

    public virtual DbSet<UbicacionSector> UbicacionSectors { get; set; }

    public virtual DbSet<UbicacionZona> UbicacionZonas { get; set; }

    public virtual DbSet<UnidadOrganizativa> UnidadOrganizativas { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //=> optionsBuilder.UseSqlServer("Server=DESKTOP-FV37MM9\\SQLEXPRESS;Database=SigerpSAPPrd;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");
        => optionsBuilder.UseSqlServer("Server=localhost;Database=SigerpSAPPrd;Trusted_Connection=SSPI;MultipleActiveResultSets=true;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CampoCultivo>(entity =>
        {
            entity.HasKey(e => e.CampId).HasName("XPKCampo_de_Cultivo");

            entity.ToTable("CampoCultivo");

            entity.Property(e => e.CampId).ValueGeneratedNever();
            entity.Property(e => e.CampCategSuelo)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CampDescripcion)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.CampIdAnterior)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(10)
                .IsUnicode(false);

            entity.HasOne(d => d.UbicZona).WithMany(p => p.CampoCultivos)
                .HasForeignKey(d => d.UbicZonaId)
                .HasConstraintName("FK_CampoCultivo_UbicacionZona");

            entity.HasOne(d => d.UnidOrg).WithMany(p => p.CampoCultivos)
                .HasForeignKey(d => d.UnidOrgId)
                .HasConstraintName("FK_CampoCultivo_UnidadOrganizativa");
        });

        modelBuilder.Entity<CicloCultivo>(entity =>
        {
            entity.HasKey(e => e.CicloCultId).HasName("XPKCampaña_de_cultivo");

            entity.ToTable("CicloCultivo");

            entity.Property(e => e.CicloCultId).ValueGeneratedNever();
            entity.Property(e => e.CampId).HasMaxLength(8);
            entity.Property(e => e.CencCostId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CicloCultAnterior)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultCond)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultCorrCorte).HasMaxLength(12);
            entity.Property(e => e.CicloCultDispAgua)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultDren)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultEstado)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultFnteAgua)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultHasNeta).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CicloCultHasNetaPpto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CicloCultHasbruta).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CicloCultLongSurc).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CicloCultObs)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultPiedra)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultPiedraPorc).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CicloCultProfSuel).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CicloCultSistRiego)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultSituaCont)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultTextura)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultTipCamino)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultTipSuel)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultTipo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CicloCultVaried)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CodTitanium)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("cod_Titanium");
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.FechaAgoste).HasColumnType("datetime");
            entity.Property(e => e.FechaInicioCult).HasColumnType("datetime");
            entity.Property(e => e.FechaSiembra).HasColumnType("datetime");
            entity.Property(e => e.OrdTrabId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ProdId)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("ProdID");
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cultivo>(entity =>
        {
            entity.HasKey(e => e.CultId);

            entity.ToTable("Cultivo");

            entity.Property(e => e.CultId).ValueGeneratedNever();
            entity.Property(e => e.CultDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);

            //entity.HasMany(d => d.CultivoVariedads).WithOne(p => p.Cult)
            //    .HasForeignKey(d => d.CultId);
        });

        modelBuilder.Entity<CultivoSembrado>(entity =>
        {
            entity.HasKey(e => e.CultSembId);

            entity.ToTable("CultivoSembrado");

            entity.Property(e => e.CultSembId).ValueGeneratedNever();
            entity.Property(e => e.CultSembFecFin).HasColumnType("datetime");
            entity.Property(e => e.CultSembFecInic).HasColumnType("datetime");
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Camp).WithMany(p => p.CultivoSembrados)
                .HasForeignKey(d => d.CampId)
                .HasConstraintName("FK_CultivoSembrado_CampoCultivo");

            entity.HasOne(d => d.CultVaried).WithMany(p => p.CultivoSembrados)
                .HasForeignKey(d => d.CultVariedId)
                .HasConstraintName("FK_CultivoSembrado_CultivoVariedad");
        });

        modelBuilder.Entity<CultivoVariedad>(entity =>
        {
            entity.HasKey(e => e.CultVarId);

            entity.ToTable("CultivoVariedad");

            entity.Property(e => e.CultVarId).ValueGeneratedNever();
            entity.Property(e => e.CultVarDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.Cult).WithMany(p => p.CultivoVariedads)
                .HasForeignKey(d => d.CultId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CultivoVariedad_Cultivo");
        });

        modelBuilder.Entity<FactProduccion>(entity =>
        {
            entity.HasKey(e => new { e.CicloCultId, e.NumCosech });

            entity.ToTable("FactProduccion");

            entity.Property(e => e.Administrativo).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.AreaCosechada).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CampId).HasMaxLength(8);
            entity.Property(e => e.Carguio).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Corte).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CostoEstimado)
                .HasMaxLength(18)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CostoPpto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CostoReal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cultivo).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EdadCosecha).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.EdadPpto).HasColumnType("decimal(9, 2)");
            entity.Property(e => e.EstCicloCult)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Extraccion).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.FechaFinCosecha).HasColumnType("datetime");
            entity.Property(e => e.FechaIniCosecha).HasColumnType("datetime");
            entity.Property(e => e.Ingreso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.JavaRatio).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.NumLiq)
                .HasMaxLength(45)
                .IsUnicode(false);
            entity.Property(e => e.ObjId)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PolJp)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("PolJP");
            entity.Property(e => e.PorcImpureza).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.PrecioUnit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Preparacion).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ProdAzucarBls).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ProdAzucarBlsTn)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ProdAzucarBlsTN");
            entity.Property(e => e.ProdAzucarKg).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.ProdAzucarKgTn)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ProdAzucarKgTN");
            entity.Property(e => e.ProdId)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.ProdTchm)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("ProdTCHM");
            entity.Property(e => e.ProdTshm)
                .HasColumnType("decimal(9, 4)")
                .HasColumnName("ProdTSHM");
            entity.Property(e => e.PurezaJp)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("PurezaJP");
            entity.Property(e => e.Recobrado).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Recojo).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RedJp)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("RedJP");
            entity.Property(e => e.RendHaPpto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.RendReal).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.RendTchc)
                .HasColumnType("decimal(12, 4)")
                .HasColumnName("RendTCHC");
            entity.Property(e => e.Retencion).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.Sacarosa).HasColumnType("decimal(12, 4)");
            entity.Property(e => e.SacarosaPpto).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Siembra).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Tchmppto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("TCHMPpto");
            entity.Property(e => e.TonCañaNeta).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.TonCosechada).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TonMateriaExtraña).HasColumnType("decimal(12, 3)");
            entity.Property(e => e.TonPpto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Transporte).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Tshmppto)
                .HasColumnType("decimal(12, 2)")
                .HasColumnName("TSHMPpto");
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Utilidad).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Sociedad>(entity =>
        {
            entity.ToTable("Sociedad");

            entity.Property(e => e.SociedadId).ValueGeneratedNever();
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.SociedadAbrev)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.SociedadCiudad)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SociedadDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SociedadDirecc)
                .HasMaxLength(60)
                .IsUnicode(false);
            entity.Property(e => e.SociedadFax)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SociedadRazSocial)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SociedadRuc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SociedadRUC");
            entity.Property(e => e.SociedadTelef01)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SociedadTelef02)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SociedadTelef03)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UbicacionSector>(entity =>
        {
            entity.HasKey(e => e.UbicSectId);

            entity.ToTable("UbicacionSector");

            entity.Property(e => e.UbicSectId).ValueGeneratedNever();
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UbicSectAbrev)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UbicSectDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UbicacionZona>(entity =>
        {
            entity.HasKey(e => e.UbicZonaId);

            entity.ToTable("UbicacionZona");

            entity.Property(e => e.UbicZonaId).ValueGeneratedNever();
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UbiZonaDescripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.UbicSect).WithMany(p => p.UbicacionZonas)
                .HasForeignKey(d => d.UbicSectId)
                .HasConstraintName("FK_UbicacionZona_UbicacionSector");
        });

        modelBuilder.Entity<UnidadOrganizativa>(entity =>
        {
            entity.HasKey(e => e.UnidOrgId);

            entity.ToTable("UnidadOrganizativa");

            entity.Property(e => e.UnidOrgId).ValueGeneratedNever();
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.UnidOrgDescripcion)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.UnidOrgNivel01)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UnidOrgNivel02)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UnidOrgNivel03)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UnidOrgNivel04)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Usuario");

            entity.Property(e => e.DistGeoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DptoGeoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.FecHrsSistema).HasColumnType("datetime");
            entity.Property(e => e.ProvGeoId)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TrabId)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsrSistema)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UsuaApeMat)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UsuaApePat)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.UsuaDireccion)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UsuaDni)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("UsuaDNI");
            entity.Property(e => e.UsuaId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UsuaNombres)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UsuaParametros)
                .HasMaxLength(250)
                .IsUnicode(false)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
