using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace medicloud.emr.api.Etities
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

        public virtual DbSet<ConsultationPrescription> ConsultationPrescription { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
        // To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_test;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ConsultationPrescription>(entity =>
            {
                entity.HasKey(e => e.Prescriptionid);

                entity.ToTable("Consultation_Prescription");

                entity.Property(e => e.Prescriptionid).HasColumnName("prescriptionid");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Doctorid).HasColumnName("doctorid");

                entity.Property(e => e.Durationtype).HasColumnName("durationtype");

                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

                entity.Property(e => e.Encodeddate)
                    .HasColumnName("encodeddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Encounterid).HasColumnName("encounterid");

                entity.Property(e => e.Indentclose).HasColumnName("indentclose");

                entity.Property(e => e.Indentno).HasColumnName("indentno");

                entity.Property(e => e.Indentstoreid).HasColumnName("indentstoreid");

                entity.Property(e => e.Isactive).HasColumnName("isactive");

                entity.Property(e => e.Isconsumable).HasColumnName("isconsumable");

                entity.Property(e => e.Isnocurrentmedications).HasColumnName("isnocurrentmedications");

                entity.Property(e => e.Ispregnant).HasColumnName("ispregnant");

                entity.Property(e => e.Issubstitutenotallowed).HasColumnName("issubstitutenotallowed");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Orderpriorityid).HasColumnName("orderpriorityid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prescriptiondate)
                    .HasColumnName("prescriptiondate")
                    .HasColumnType("datetime");

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
