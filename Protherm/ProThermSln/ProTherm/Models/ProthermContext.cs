using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProTherm
{
    public partial class ProthermContext : DbContext
    {
        public ProthermContext()
        {
        }

        public ProthermContext(DbContextOptions<ProthermContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Protherm> Protherm { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-QB7QVKM\\SQLEXPRESS;Initial Catalog=Protherm;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Protherm>(entity =>
            {
                entity.HasKey(e => e.EntryId);

                entity.Property(e => e.EntryId)
                    .HasColumnName("EntryID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chain).HasMaxLength(50);

                entity.Property(e => e.DG).HasColumnName("dG");

                entity.Property(e => e.DGH2o).HasColumnName("dG_H2O");

                entity.Property(e => e.DTM).HasColumnName("dT_m");

                entity.Property(e => e.DdG).HasColumnName("ddG");

                entity.Property(e => e.DdGH2o).HasColumnName("ddG_H2O");

                entity.Property(e => e.EcNum)
                    .HasColumnName("EC_Num")
                    .HasMaxLength(50);

                entity.Property(e => e.MolecularWt).HasColumnName("Molecular_Wt");

                entity.Property(e => e.MutPdb)
                    .HasColumnName("Mut_PDB")
                    .HasMaxLength(50);

                entity.Property(e => e.MutPdbUrl)
                    .HasColumnName("Mut_PDB_URL")
                    .HasMaxLength(50);

                entity.Property(e => e.Mutation).HasMaxLength(50);

                entity.Property(e => e.PirId)
                    .HasColumnName("PIR_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.PmdNum)
                    .HasColumnName("PMD_Num")
                    .HasMaxLength(50);

                entity.Property(e => e.ProteinName).HasMaxLength(50);

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.SwissProtId)
                    .HasColumnName("Swiss_Prot_ID")
                    .HasMaxLength(50);

                entity.Property(e => e.TM).HasColumnName("T_m");

                entity.Property(e => e.WtPdb)
                    .HasColumnName("WT_PDB")
                    .HasMaxLength(50);

                entity.Property(e => e.WtPdbUrl)
                    .HasColumnName("WT_PDB_URL")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
