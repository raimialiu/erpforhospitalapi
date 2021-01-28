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

//        public virtual DbSet<ImmunizationDetails> ImmunizationDetails { get; set; }

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
//            modelBuilder.Entity<ImmunizationDetails>(entity =>
//            {
//                entity.ToTable("immunization_details");

//                entity.Property(e => e.Adversereaction).HasColumnName("adversereaction");

//                entity.Property(e => e.Batchno).HasColumnName("batchno");

//                entity.Property(e => e.Brandid).HasColumnName("brandid");

//                entity.Property(e => e.Cancellationremarks)
//                    .HasColumnName("cancellationremarks")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Duedate)
//                    .HasColumnName("duedate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

//                entity.Property(e => e.Encodeddate)
//                    .HasColumnName("encodeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Encounterid).HasColumnName("encounterid");

//                entity.Property(e => e.Givenby).HasColumnName("givenby");

//                entity.Property(e => e.Givendatetime)
//                    .HasColumnName("givendatetime")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Immunizationid).HasColumnName("immunizationid");

//                entity.Property(e => e.Impression)
//                    .HasColumnName("impression")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Isactive).HasColumnName("isactive");

//                entity.Property(e => e.Isbillable).HasColumnName("isbillable");

//                entity.Property(e => e.Lastchangeby).HasColumnName("lastchangeby");

//                entity.Property(e => e.Lastchangeddate)
//                    .HasColumnName("lastchangeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Locationid).HasColumnName("locationid");

//                entity.Property(e => e.LotNo)
//                    .HasColumnName("lotNo")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.Patientid)
//                    .HasColumnName("patientid")
//                    .HasMaxLength(50)
//                    .IsUnicode(false);

//                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

//                entity.Property(e => e.Qtygiven).HasColumnName("qtygiven");

//                entity.Property(e => e.Rejectedbypatient).HasColumnName("rejectedbypatient");

//                entity.Property(e => e.Remarks)
//                    .HasColumnName("remarks")
//                    .HasMaxLength(1000)
//                    .IsUnicode(false);

//                entity.Property(e => e.Scheduleid).HasColumnName("scheduleid");

//                entity.Property(e => e.Vaccinegivenbyoutsider).HasColumnName("vaccinegivenbyoutsider");

//                entity.Property(e => e.VisinfoGiven).HasColumnName("VISInfoGiven");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
