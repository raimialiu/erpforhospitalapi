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

        public virtual DbSet<ChiefComplain> ChiefComplain { get; set; }

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
            modelBuilder.Entity<ChiefComplain>(entity =>
            {
                entity.Property(e => e.Doctorid).HasColumnName("doctorid");

                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

                entity.Property(e => e.Encodeddate)
                    .HasColumnName("encodeddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.EncounterId).HasColumnName("encounterId");

                entity.Property(e => e.Hospitallocationid).HasColumnName("hospitallocationid");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Lastchangeby).HasColumnName("lastchangeby");

                entity.Property(e => e.Lastchangedate)
                    .HasColumnName("lastchangedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProblemId).HasColumnName("problemId");

                entity.Property(e => e.Problemdescription)
                    .HasColumnName("problemdescription")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
