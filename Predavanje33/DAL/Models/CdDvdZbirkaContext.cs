using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models;

public partial class CdDvdZbirkaContext : DbContext
{
    public CdDvdZbirkaContext()
    {
    }

    public CdDvdZbirkaContext(DbContextOptions<CdDvdZbirkaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mediji> Mediji { get; set; }

    public virtual DbSet<Posudbe> Posudbe { get; set; }

    public virtual DbSet<Prijatelji> Prijatelji { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server= DESKTOP-A9HN3IJ\\SQLEXPRESS;Database=CD_DVD_Zbirka;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mediji>(entity =>
        {
            entity.HasKey(e => e.MedijId).HasName("PK__mediji__DBB5C68583D238A8");

            entity.ToTable("mediji");

            entity.Property(e => e.MedijId).HasColumnName("medijID");
            entity.Property(e => e.Naslov)
                .HasMaxLength(75)
                .HasColumnName("naslov");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .HasColumnName("tip");
        });

        modelBuilder.Entity<Posudbe>(entity =>
        {
            entity.HasKey(e => e.PosudbaId).HasName("PK__posudbe__B57FA69B43A2EEB5");

            entity.ToTable("posudbe");

            entity.Property(e => e.PosudbaId).HasColumnName("posudbaID");
            entity.Property(e => e.DatumPosudbe).HasColumnName("datum_posudbe");
            entity.Property(e => e.DatumVracanja).HasColumnName("datum_vracanja");
            entity.Property(e => e.MedijId).HasColumnName("medijID");
            entity.Property(e => e.PrijateljId).HasColumnName("prijateljID");

            entity.HasOne(d => d.Medij).WithMany(p => p.Posudbe)
                .HasForeignKey(d => d.MedijId)
                .HasConstraintName("FK__posudbe__medijID__3C69FB99");

            entity.HasOne(d => d.Prijatelj).WithMany(p => p.Posudbe)
                .HasForeignKey(d => d.PrijateljId)
                .HasConstraintName("FK__posudbe__prijate__3B75D760");
        });

        modelBuilder.Entity<Prijatelji>(entity =>
        {
            entity.HasKey(e => e.PrijateljId).HasName("PK__prijatel__BB47A9A9A684F81F");

            entity.ToTable("prijatelji");

            entity.Property(e => e.PrijateljId).HasColumnName("prijateljID");
            entity.Property(e => e.Ime)
                .HasMaxLength(50)
                .HasColumnName("ime");
            entity.Property(e => e.Prezime)
                .HasMaxLength(50)
                .HasColumnName("prezime");
            entity.Property(e => e.Telefon)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telefon");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
