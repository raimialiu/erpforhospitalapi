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

//        public virtual DbSet<DiagnosisProblems> DiagnosisProblems { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Data Source= hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_dev;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True");
//            }
//        }

//        protected override void OnModelCreating(ModelBuilder modelBuilder)
//        {
//            modelBuilder.Entity<DiagnosisProblems>(entity =>
//            {
//                entity.Property(e => e.Id).ValueGeneratedNever();

//                entity.Property(e => e.Description)
//                    .HasColumnName("description")
//                    .HasMaxLength(500)
//                    .IsUnicode(false);

//                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

//                entity.Property(e => e.Encodeddate)
//                    .HasColumnName("encodeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Isactive).HasColumnName("isactive");

//                entity.Property(e => e.Lastchangeby).HasColumnName("lastchangeby");

//                entity.Property(e => e.Lastchangeddate)
//                    .HasColumnName("lastchangeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

//                entity.Property(e => e.Sequenceno).HasColumnName("sequenceno");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
