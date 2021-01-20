using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace medicloud.emr.api.Entities
{
    public partial class medismartsemr_db_testContext : DbContext
    {
        public medismartsemr_db_testContext()
        {
        }

        public medismartsemr_db_testContext(DbContextOptions<medismartsemr_db_testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DrugFormulary> DrugFormulary { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_test;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrugFormulary>(entity =>
            {
                entity.HasKey(e => e.Formularyid)
                    .HasName("PK_Drug_Formulary_1");

                entity.ToTable("Drug_Formulary");

                entity.Property(e => e.Formularyid).HasColumnName("formularyid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Formularyname)
                    .HasColumnName("formularyname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
