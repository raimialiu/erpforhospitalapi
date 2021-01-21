//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace medicloud.emr.api.Entities
//{
//    public partial class DataContext : DbContext
//    {
//        public DataContext()
//        {
//        }

//        public DataContext(DbContextOptions<DataContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<DiagnosisFreeForm> DiagnosisFreeForm { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source=hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_test;Persist Security Info=True;User ID=!lagadmin!; Password=8mT@92EFQi0x");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<DiagnosisFreeForm>(entity =>
//            {
//                entity.HasKey(e => e.Freeformid);

//                entity.ToTable("Diagnosis_FreeForm");

//                entity.Property(e => e.Freeformid).HasColumnName("freeformid");

//                entity.Property(e => e.Bodyarea)
//                    .HasColumnName("bodyarea")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Dateadded)
//                    .HasColumnName("dateadded")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Encounterid).HasColumnName("encounterid");

//                entity.Property(e => e.Locationid).HasColumnName("locationid");

//                entity.Property(e => e.Patientid)
//                    .HasColumnName("patientid")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Providerid).HasColumnName("providerid");

//                entity.Property(e => e.Textvalue)
//                    .HasColumnName("textvalue")
//                    .HasMaxLength(5000)
//                    .IsUnicode(false);
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
