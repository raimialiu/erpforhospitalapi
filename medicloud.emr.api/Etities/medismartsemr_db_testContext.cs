
﻿//using System;

//﻿//using System;
////using Microsoft.EntityFrameworkCore;
////using Microsoft.EntityFrameworkCore.Metadata;

////namespace medicloud.emr.api.Etities
////{
////    public partial class medismartsemr_db_testContext : DbContext
////    {
////        public medismartsemr_db_testContext()
////        {
////        }

////        public medismartsemr_db_testContext(DbContextOptions<medismartsemr_db_testContext> options)
////            : base(options)
////        {
////        }

////        public virtual DbSet<ImmunizationBrand> ImmunizationBrand { get; set; }

////        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
////        {
////            if (!optionsBuilder.IsConfigured)
////            {
//////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
////                optionsBuilder.UseSqlServer("Data Source=hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_test;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True");
////            }
////        }

////        protected override void OnModelCreating(ModelBuilder modelBuilder)
////        {
////            modelBuilder.Entity<ImmunizationBrand>(entity =>
////            {
////                entity.HasKey(e => e.Brandid)
////                    .HasName("PK_EMRImmunizationBrands");

////                entity.ToTable("Immunization_Brand");

////                entity.Property(e => e.Brandid).HasColumnName("brandid");

////                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

////                entity.Property(e => e.Encodeddate)
////                    .HasColumnName("encodeddate")
////                    .HasColumnType("datetime");

////                entity.Property(e => e.Immunizationid).HasColumnName("immunizationid");

////                entity.Property(e => e.Isactive).HasColumnName("isactive");
////            });

////            OnModelCreatingPartial(modelBuilder);
////        }

////        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
////    }
////}

//﻿using System;

//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace medicloud.emr.api.Etities
//{
//    public partial class medismartsemr_db_testContext : DbContext
//    {
//        public medismartsemr_db_testContext()
//        {
//        }

//        public medismartsemr_db_testContext(DbContextOptions<medismartsemr_db_testContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<ImmunizationBrand> ImmunizationBrand { get; set; }

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
//            modelBuilder.Entity<ImmunizationBrand>(entity =>
//            {
//                entity.HasKey(e => e.Brandid)
//                    .HasName("PK_EMRImmunizationBrands");

//                entity.ToTable("Immunization_Brand");

//                entity.Property(e => e.Brandid).HasColumnName("brandid");

//                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

//                entity.Property(e => e.Encodeddate)
//                    .HasColumnName("encodeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Immunizationid).HasColumnName("immunizationid");

//                entity.Property(e => e.Isactive).HasColumnName("isactive");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}
//﻿using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata;

//namespace medicloud.emr.api.Etities
//{
//    public partial class medismartsemr_db_testContext : DbContext
//    {
//        public medismartsemr_db_testContext()
//        {
//        }

//        public medismartsemr_db_testContext(DbContextOptions<medismartsemr_db_testContext> options)
//            : base(options)
//        {
//        }

//        public virtual DbSet<ImmunizationBrand> ImmunizationBrand { get; set; }

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
//            modelBuilder.Entity<ImmunizationBrand>(entity =>
//            {
//                entity.HasKey(e => e.Brandid)
//                    .HasName("PK_EMRImmunizationBrands");

//                entity.ToTable("Immunization_Brand");

//                entity.Property(e => e.Brandid).HasColumnName("brandid");

//                entity.Property(e => e.Encodedby).HasColumnName("encodedby");

//                entity.Property(e => e.Encodeddate)
//                    .HasColumnName("encodeddate")
//                    .HasColumnType("datetime");

//                entity.Property(e => e.Immunizationid).HasColumnName("immunizationid");

//                entity.Property(e => e.Isactive).HasColumnName("isactive");
//            });

//            OnModelCreatingPartial(modelBuilder);
//        }

//        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
//    }
//}



