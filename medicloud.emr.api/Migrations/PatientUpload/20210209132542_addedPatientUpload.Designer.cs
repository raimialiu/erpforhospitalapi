﻿//// <auto-generated />
//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Migrations;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using medicloud.emr.api.Data;

//namespace medicloud.emr.api.Migrations.PatientUpload
//{
//    [DbContext(typeof(PatientUploadContext))]
//    [Migration("20210209132542_addedPatientUpload")]
//    partial class addedPatientUpload
//    {
//        protected override void BuildTargetModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .HasAnnotation("ProductVersion", "3.1.11")
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//            modelBuilder.Entity("medicloud.emr.api.Entities.PatientsUpload", b =>
//                {
//                    b.Property<long>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("bigint")
//                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

//                    b.Property<int?>("adjusterid")
//                        .HasColumnType("int");

//                    b.Property<int?>("encounterId")
//                        .HasColumnType("int");

//                    b.Property<string>("fileitem")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("filename")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("filesize")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("filetype")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int?>("locationId")
//                        .HasColumnType("int");

//                    b.Property<string>("patientid")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int?>("providerId")
//                        .HasColumnType("int");

//                    b.Property<string>("uploadtype")
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("PatientUpload");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
