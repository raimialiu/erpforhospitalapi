//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace medicloud.emr.api.Entities
//{
//    public partial class medismartsemr_db_devContext : DbContext
//    {
//        public medismartsemr_db_devContext()
//        {
//        }

//        public medismartsemr_db_devContext(DbContextOptions<medismartsemr_db_devContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<ConsultationPrescriptionDetails> ConsultationPrescriptionDetails { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_dev;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<ConsultationPrescriptionDetails>(entity =>
//            {
//                entity.ToTable("Consultation_PrescriptionDetails");

//                entity.Property(e => e.Comments)
//                    .HasColumnName("comments")
//                    .HasMaxLength(1000)
//                    .IsUnicode(false);

//                entity.Property(e => e.Doctorid).HasColumnName("doctorid");

//                entity.Property(e => e.Dose).HasColumnName("dose");

//                entity.Property(e => e.Doseformid).HasColumnName("doseformid");

//                entity.Property(e => e.Dosetime).HasColumnName("dosetime");

//                entity.Property(e => e.Durationtype).HasColumnName("durationtype");

//                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

//                entity.Property(e => e.Encodeddate)
//                    .HasColumnName("encodeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.EncounterId).HasColumnName("encounterId");

//                entity.Property(e => e.Formularyid).HasColumnName("formularyid");

//                entity.Property(e => e.Frequencyid).HasColumnName("frequencyid");

//                entity.Property(e => e.Genericid).HasColumnName("genericid");

//                entity.Property(e => e.Icdcode)
//                    .HasColumnName("ICDCode")
//                    .HasMaxLength(200)
//                    .IsUnicode(false);

//                entity.Property(e => e.Isactive).HasColumnName("isactive");

//                entity.Property(e => e.Isapprovedrequired).HasColumnName("isapprovedrequired");

//                entity.Property(e => e.Iscapitated).HasColumnName("iscapitated");

//                entity.Property(e => e.Isexcluded).HasColumnName("isexcluded");

//                entity.Property(e => e.Issubstitutenotallowed).HasColumnName("issubstitutenotallowed");

//                entity.Property(e => e.Isvariabledose).HasColumnName("isvariabledose");

//                entity.Property(e => e.Isvoid).HasColumnName("isvoid");

//                entity.Property(e => e.ItemId).HasColumnName("itemId");

//                entity.Property(e => e.Lastchangeby).HasColumnName("lastchangeby");

//                entity.Property(e => e.Lastchangedate)
//                    .HasColumnName("lastchangedate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Locationid).HasColumnName("locationid");

//                entity.Property(e => e.Medicationinstructions)
//                    .HasColumnName("medicationinstructions")
//                    .HasMaxLength(1000)
//                    .IsUnicode(false);

//                entity.Property(e => e.Patientid)
//                    .HasColumnName("patientid")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Preauthorizationno)
//                    .HasColumnName("preauthorizationno")
//                    .HasMaxLength(20)
//                    .IsUnicode(false);

//                entity.Property(e => e.PrescriptionDetail)
//                    .HasColumnName("prescriptionDetail")
//                    .HasMaxLength(1000)
//                    .IsUnicode(false);

//                entity.Property(e => e.Prescriptionid).HasColumnName("prescriptionid");

//                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

//                entity.Property(e => e.Qty).HasColumnName("qty");

//                entity.Property(e => e.Refill).HasColumnName("refill");

//                entity.Property(e => e.Routeid).HasColumnName("routeid");

//                entity.Property(e => e.Startdate)
//                    .HasColumnName("startdate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Statusid).HasColumnName("statusid");

//                entity.Property(e => e.Strength)
//                    .HasColumnName("strength")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Strengthvalue)
//                    .HasColumnName("strengthvalue")
//                    .HasMaxLength(100)
//                    .IsUnicode(false);

//                entity.Property(e => e.Unitid).HasColumnName("unitid");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
