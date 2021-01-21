﻿using System;
using medicloud.emr.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace medicloud.emr.api.Data
{
    public partial class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<PlanType> PlanType { get; set; }

        public virtual DbSet<AccessControl> AccessControl { get; set; }
        public virtual DbSet<TemplateCategoryB> TemplateCategoryB { get; set; }
        public virtual DbSet<TemplateCategoryC> TemplateCategoryC { get; set; }
        public virtual DbSet<AccesscontrolUser> AccesscontrolUser { get; set; }
        public virtual DbSet<AccountCategory> AccountCategory { get; set; }
        public virtual DbSet<AccountManager> AccountManager { get; set; }
        public virtual DbSet<AccountType> AccountType { get; set; }
        public virtual DbSet<Admission> Admission { get; set; }
        public virtual DbSet<AdmissionDiagnosis> AdmissionDiagnosis { get; set; }
        public virtual DbSet<AntenatalRecord> AntenatalRecord { get; set; }
        public virtual DbSet<AppSetting> AppSetting { get; set; }
        public virtual DbSet<AppUser> AppUser { get; set; }
        public virtual DbSet<Payer> Payer { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUser { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentStatus> AppointmentStatus { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<AssignedAsset> AssignedAsset { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<Authorisation> Authorisation { get; set; }
        public virtual DbSet<Bed> Bed { get; set; }
        public virtual DbSet<BenefitPackage> BenefitPackage { get; set; }
        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<BillDetail> BillDetail { get; set; }
        public virtual DbSet<HospitalUnit> HospitalUnit { get; set; }
        public virtual DbSet<PatientQueue> PatientQueue { get; set; }
        public virtual DbSet<AppointmentSchedule> AppointmentSchedule { get; set; }
        public virtual DbSet<BillPayable> BillPayable { get; set; }
        public virtual DbSet<Biometric> Biometric { get; set; }
        public virtual DbSet<BirthRegister> BirthRegister { get; set; }
        public virtual DbSet<BloodGroup> BloodGroup { get; set; }
        public virtual DbSet<CaseNote> CaseNote { get; set; }
        public virtual DbSet<CentralStore> CentralStore { get; set; }
        public virtual DbSet<Claims> Claims { get; set; }
        public virtual DbSet<Clinic> Clinic { get; set; }
        public virtual DbSet<CheckIn> CheckIn { get; set; }
        public virtual DbSet<PaRequest> PaRequest { get; set; }
        //public virtual DbSet<PatientQueue> PatientQueue { get; set; }
        public virtual DbSet<Consultation> Consultation { get; set; }
        public virtual DbSet<ConsultationCheck> ConsultationCheck { get; set; }
        public virtual DbSet<ConsultationChecks> ConsultationChecks { get; set; }
        public virtual DbSet<ConsultationCheckslist> ConsultationCheckslist { get; set; }
        public virtual DbSet<ConsultationComplaints> ConsultationComplaints { get; set; }
        public virtual DbSet<ConsultationDental> ConsultationDental { get; set; }
        public virtual DbSet<ConsultationDentalProcedure> ConsultationDentalProcedure { get; set; }
        public virtual DbSet<ConsultationDiagnosis> ConsultationDiagnosis { get; set; }
        public virtual DbSet<ConsultationImpression> ConsultationImpression { get; set; }
        public virtual DbSet<ConsultationLaboratory> ConsultationLaboratory { get; set; }
        public virtual DbSet<ConsultationOtherDiagnosis> ConsultationOtherDiagnosis { get; set; }
        public virtual DbSet<ConsultationPrescription> ConsultationPrescription { get; set; }
        public virtual DbSet<ConsultationProblem> ConsultationProblem { get; set; }
        public virtual DbSet<ConsultationProcedure> ConsultationProcedure { get; set; }
        public virtual DbSet<ConsultationRadiology> ConsultationRadiology { get; set; }
        public virtual DbSet<ConsultationUtilization> ConsultationUtilization { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Cptcategory> Cptcategory { get; set; }
        public virtual DbSet<Cptprocedure> Cptprocedure { get; set; }
        public virtual DbSet<CptsubCategory> CptsubCategory { get; set; }
        public virtual DbSet<DataSynchronization> DataSynchronization { get; set; }
        public virtual DbSet<DentalProcedure> DentalProcedure { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DependantInfo> DependantInfo { get; set; }
        public virtual DbSet<Designation> Designation { get; set; }
        public virtual DbSet<Diagnosis> Diagnosis { get; set; }
        public virtual DbSet<DiagnosisUtilization> DiagnosisUtilization { get; set; }
        public virtual DbSet<DispensingStore> DispensingStore { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Drug> Drug { get; set; }
        public virtual DbSet<DrugCategory> DrugCategory { get; set; }
        public virtual DbSet<DrugDispense> DrugDispense { get; set; }
        public virtual DbSet<DrugOrders> DrugOrders { get; set; }
        public virtual DbSet<DrugPricelist> DrugPricelist { get; set; }
        public virtual DbSet<DrugTherapeuticClass> DrugTherapeuticClass { get; set; }
        public virtual DbSet<DrugUtilization> DrugUtilization { get; set; }
        public virtual DbSet<Enrollee> Enrollee { get; set; }
        public virtual DbSet<EnrolleeType> EnrolleeType { get; set; }
        public virtual DbSet<Fingerprint> Fingerprint { get; set; }
        public virtual DbSet<Formdirect2> Formdirect2 { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GeneralExamination> GeneralExamination { get; set; }
        public virtual DbSet<GeneralSchedule> GeneralSchedule { get; set; }
        public virtual DbSet<GenoType> GenoType { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<HealthCareFacilitator> HealthCareFacilitator { get; set; }
        public virtual DbSet<Hmo> Hmo { get; set; }
        public virtual DbSet<HmoMonthlyList> HmoMonthlyList { get; set; }
        public virtual DbSet<HmoType> HmoType { get; set; }
        public virtual DbSet<Hshhs> Hshhs { get; set; }
        public virtual DbSet<Icd10diagnosis> Icd10diagnosis { get; set; }
        public virtual DbSet<Icdcategory> Icdcategory { get; set; }
        public virtual DbSet<IdGeneration> IdGeneration { get; set; }
        public virtual DbSet<IdentificationMode> IdentificationMode { get; set; }
        public virtual DbSet<InjectionTaken> InjectionTaken { get; set; }
        public virtual DbSet<Insurance> Insurance { get; set; }
        public virtual DbSet<LeadSource> LeadSource { get; set; }
        public virtual DbSet<LicenseManager> LicenseManager { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<Maritalstatus> Maritalstatus { get; set; }
        public virtual DbSet<MeasureUnit> MeasureUnit { get; set; }
        public virtual DbSet<MedicalProblemCategory> MedicalProblemCategory { get; set; }
        public virtual DbSet<MedicalProblemItem> MedicalProblemItem { get; set; }
        public virtual DbSet<Messaging> Messaging { get; set; }
        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Network> Network { get; set; }
        public virtual DbSet<NextOfKinRelationship> NextOfKinRelationship { get; set; }
        public virtual DbSet<NursingRecord> NursingRecord { get; set; }
        public virtual DbSet<OrderCategory> OrderCategory { get; set; }
        public virtual DbSet<OrderListing> OrderListing { get; set; }
        public virtual DbSet<OrderStatus> OrderStatus { get; set; }
        public virtual DbSet<OrderType> OrderType { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        public virtual DbSet<PatientOrder> PatientOrder { get; set; }
        public virtual DbSet<PatientOrderDetails> PatientOrderDetails { get; set; }
        public virtual DbSet<PatientQuestionnaire> PatientQuestionnaire { get; set; }
        public virtual DbSet<PatientType> PatientType { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<Plan> Plan { get; set; }
        public virtual DbSet<Problem> Problem { get; set; }
        public virtual DbSet<Procedure> Procedure { get; set; }
        public virtual DbSet<PatientPayorTypes> PatientPayorTypes { get; set; }
        public virtual DbSet<ProcedurePricelist> ProcedurePricelist { get; set; }
        public virtual DbSet<ProcedureUtilization> ProcedureUtilization { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<ProviderChange> ProviderChange { get; set; }
        public virtual DbSet<ProviderNetwork> ProviderNetwork { get; set; }
        public virtual DbSet<ProviderSchedule> ProviderSchedule { get; set; }
        public virtual DbSet<QuestionCategory> QuestionCategory { get; set; }
        public virtual DbSet<Questionnaire> Questionnaire { get; set; }
        public virtual DbSet<QueueManager> QueueManager { get; set; }
        public virtual DbSet<ReceivingStore> ReceivingStore { get; set; }
        public virtual DbSet<ReferenceMaterial> ReferenceMaterial { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<Renewal> Renewal { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<ServiceTariff> ServiceTariff { get; set; }
        public virtual DbSet<ServiceType> ServiceType { get; set; }
        public virtual DbSet<Specialization> Specialization { get; set; }
        public virtual DbSet<SpecializationSchedule> SpecializationSchedule { get; set; }
        public virtual DbSet<Sponsor> Sponsor { get; set; }
        public virtual DbSet<State> State { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<SupplierType> SupplierType { get; set; }
        public virtual DbSet<Tariff> Tariff { get; set; }
        public virtual DbSet<Temp> Temp { get; set; }
        public virtual DbSet<TemplateAllergies> TemplateAllergies { get; set; }
        public virtual DbSet<TemplateArvdrugs> TemplateArvdrugs { get; set; }
        public virtual DbSet<TemplateBiodata> TemplateBiodata { get; set; }
        public virtual DbSet<TemplateBloodgasanalysisform> TemplateBloodgasanalysisform { get; set; }
        public virtual DbSet<TemplateBloodsugar> TemplateBloodsugar { get; set; }
        public virtual DbSet<TemplateCapturevitals> TemplateCapturevitals { get; set; }
        public virtual DbSet<TemplateCategory> TemplateCategory { get; set; }
        public virtual DbSet<TemplateChromeform> TemplateChromeform { get; set; }
        public virtual DbSet<TemplateChromiumform> TemplateChromiumform { get; set; }
        public virtual DbSet<TemplateConsultantincharge> TemplateConsultantincharge { get; set; }
        public virtual DbSet<TemplateCotrimoxazole> TemplateCotrimoxazole { get; set; }
        public virtual DbSet<TemplateDiagnosisanddifferentials> TemplateDiagnosisanddifferentials { get; set; }
        public virtual DbSet<TemplateDietorder> TemplateDietorder { get; set; }
        public virtual DbSet<TemplateDischargeplanning> TemplateDischargeplanning { get; set; }
        public virtual DbSet<TemplateExpectedoutcomesofcare> TemplateExpectedoutcomesofcare { get; set; }
        public virtual DbSet<TemplateInn> TemplateInn { get; set; }
        public virtual DbSet<TemplateInpatientform> TemplateInpatientform { get; set; }
        public virtual DbSet<TemplateInvestigation> TemplateInvestigation { get; set; }
        public virtual DbSet<TemplateLaboratory> TemplateLaboratory { get; set; }
        public virtual DbSet<TemplateLaboratory1> TemplateLaboratory1 { get; set; }
        public virtual DbSet<TemplateMaster> TemplateMaster { get; set; }
        public virtual DbSet<TemplateMedicalofficerandcarecoordinator> TemplateMedicalofficerandcarecoordinator { get; set; }
        public virtual DbSet<TemplateMinivitals> TemplateMinivitals { get; set; }
        public virtual DbSet<TemplateNeuro> TemplateNeuro { get; set; }
        public virtual DbSet<TemplateNeurologic> TemplateNeurologic { get; set; }
        public virtual DbSet<TemplateOtherdetails> TemplateOtherdetails { get; set; }
        public virtual DbSet<TemplateOthermodification> TemplateOthermodification { get; set; }
        public virtual DbSet<TemplatePainassestmentscale> TemplatePainassestmentscale { get; set; }
        public virtual DbSet<TemplatePastobstericform> TemplatePastobstericform { get; set; }
        public virtual DbSet<TemplatePatientdetails> TemplatePatientdetails { get; set; }
        public virtual DbSet<TemplatePatientinformation> TemplatePatientinformation { get; set; }
        public virtual DbSet<TemplatePresentingcomplaintsandhistoryofpresentillness> TemplatePresentingcomplaintsandhistoryofpresentillness { get; set; }
        public virtual DbSet<TemplatePrimaryexaminationdetails> TemplatePrimaryexaminationdetails { get; set; }
        public virtual DbSet<TemplatePsychological> TemplatePsychological { get; set; }
        public virtual DbSet<TemplateResultsofpreviousinvestigationdone> TemplateResultsofpreviousinvestigationdone { get; set; }
        public virtual DbSet<TemplateSurgeryform> TemplateSurgeryform { get; set; }
        public virtual DbSet<TemplateTreatmentmanagementplan> TemplateTreatmentmanagementplan { get; set; }
        public virtual DbSet<TemplateUrinalysis> TemplateUrinalysis { get; set; }
        public virtual DbSet<TemplateVitals> TemplateVitals { get; set; }
        public virtual DbSet<Title> Title { get; set; }
        public virtual DbSet<Transportation> Transportation { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserLocation> UserLocation { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Utilization> Utilization { get; set; }
        public virtual DbSet<VerificationLog> VerificationLog { get; set; }
        public virtual DbSet<Ward> Ward { get; set; }
        public virtual DbSet<Reminder> Reminder { get; set; }
        public virtual DbSet<VisitType> VisitType { get; set; }
        public virtual DbSet<ReferringPhysician> ReferringPhysician { get; set; }
        public virtual DbSet<BreakBlockSchedule> BreakBlockSchedule { get; set; }
        public virtual DbSet<ApplicationUserLocation> ApplicationUserLocation { get; set; }
        public virtual DbSet<Diagnosisgroup> Diagnosisgroup { get; set; }
        public virtual DbSet<Diagnosissubgroup> Diagnosissubgroup { get; set; }
        public virtual DbSet<DiagnosisLocation> DiagnosisLocation { get; set; }
        public virtual DbSet<DiagnosisType> DiagnosisType { get; set; }
        public virtual DbSet<DiagnosisProblems> DiagnosisProblems { get; set; }
        public virtual DbSet<ConsultationDiagnosisFavourites> ConsultationDiagnosisFavourites { get; set; }
        public virtual DbSet<ConsultationOrders> ConsultationOrders { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
        public virtual DbSet<ConsultationOrderFavorites> ConsultationOrderFavorites { get; set; }
        public virtual DbSet<ConsultationOrderDetails> ConsultationOrderDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.

               // optionsBuilder.UseSqlServer("Data Source= hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_test;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True");
             // optionsBuilder.UseSqlServer("Data Source=FCMB-IT-L16582\\TUNDE;Initial Catalog=medismartsemr_db;Persist Security Info=True;User ID=olatunde;Password=DVorak@23000;MultipleActiveResultSets=True");

              // optionsBuilder.UseSqlServer("Data Source=52.251.49.79;Initial Catalog=medismartsemr_db;Persist Security Info=True;User ID=medismarts;Password=md2015@tech");
             optionsBuilder.UseSqlServer("Data Source=hnltestuatlhis.database.windows.net;Initial Catalog=medismartsemr_db_test;Persist Security Info=True;User ID=!lagadmin!;Password=8mT@92EFQi0x;MultipleActiveResultSets=True",
                 builder=>builder.EnableRetryOnFailure());

                // "Data Source=FCMB-IT-L16582\\TUNDE;Initial Catalog=medismartsemr_db;Persist Security Info=True;User ID=olatunde;Password=DVorak@23000;MultipleActiveResultSets=True"
                //optionsBuilder.UseSqlServer("Data Source=DESKTOP-RV56AB0;Database=medismartsemr_db;Trusted_Connection=True;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccessControl>(entity =>
            {
                entity.ToTable("access_control");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Modules).HasColumnName("modules");

                entity.Property(e => e.Roles).HasColumnName("roles");
            });
            
            modelBuilder.Entity<ApplicationUserLocation>(entity =>
            {
                entity.ToTable("ApplicationUser_Location");

                entity.HasKey(e => e.appuserlocationid);

                entity.Property(e => e.appuserlocationid).HasColumnName("appuserlocationid");

                entity.Property(e => e.appuserid).HasColumnName("appuserid");
                entity.Property(e => e.locationid).HasColumnName("locationid");
                entity.Property(e => e.specid).HasColumnName("specid");
            });
            
            modelBuilder.Entity<Diagnosisgroup>(entity =>
            {
                entity.ToTable("Diagnosisgroup");

                entity.HasKey(e => e.groupid);

                entity.Property(e => e.groupid).HasColumnName("groupid");

                entity.Property(e => e.groupname).HasColumnName("groupname");
                entity.Property(e => e.grouptype).HasColumnName("grouptype");
                entity.Property(e => e.isactive).HasColumnName("isactive");
            });
            
            modelBuilder.Entity<ConsultationOrderFavorites>(entity =>
            {
                entity.ToTable("Consultation_order_favorites");

                entity.HasKey(e => e.FavoriteId);

                entity.Property(e => e.FavoriteId).HasColumnName("FavoriteId");

                entity.Property(e => e.DateAdded).HasColumnName("DateAdded");
                entity.Property(e => e.DoctorId).HasColumnName("DoctorId");
                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");
                entity.Property(e => e.LocationId).HasColumnName("LocationId");
                entity.Property(e => e.serviceid).HasColumnName("serviceid");
            });
            
            modelBuilder.Entity<DiagnosisType>(entity =>
            {
                entity.ToTable("DiagnosisType");

                entity.HasKey(e => e.typeid);

                entity.Property(e => e.description).HasColumnName("description");

                entity.Property(e => e.encodedby).HasColumnName("encodedby");
                entity.Property(e => e.encodeddate).HasColumnName("encodeddate");
                entity.Property(e => e.isactive).HasColumnName("isactive");
                entity.Property(e => e.ProviderId).HasColumnName("ProviderId");
            });
            
            modelBuilder.Entity<DiagnosisProblems>(entity =>
            {
                entity.ToTable("DiagnosisProblems");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");

                entity.Property(e => e.encodedby).HasColumnName("encodedby");
                entity.Property(e => e.encodeddate).HasColumnName("encodeddate");
                entity.Property(e => e.sequenceno).HasColumnName("sequenceno");
                entity.Property(e => e.lastchangeddate).HasColumnName("lastchangeddate");
                entity.Property(e => e.lastchangeby).HasColumnName("lastchangeby");
                entity.Property(e => e.description).HasColumnName("description");
            });

            modelBuilder.Entity<OrderDetails>(entity =>
            {
                entity.HasKey(e => e.serviceid);

                entity.ToTable("OrderDetails");

                entity.Property(e => e.serviceid).HasColumnName("serviceid");

                entity.Property(e => e.servicename)
                    .HasColumnName("servicename");

                entity.Property(e => e.providerId).HasColumnName("providerid");

                entity.Property(e => e.doctorrequired).HasColumnName("doctorrequired");
                entity.Property(e => e.priceeditable).HasColumnName("priceeditable");
                entity.Property(e => e.isactive).HasColumnName("isactive");
                entity.Property(e => e.differbybedcategory).HasColumnName("differbybedcategory");
                entity.Property(e => e.differbypercentage).HasColumnName("differbypercentage");
                entity.Property(e => e.encodedby).HasColumnName("encodedby");
                entity.Property(e => e.ordercategoryid).HasColumnName("ordercategoryid");
                entity.Property(e => e.encodeddate).HasColumnName("encodeddate");
                entity.Property(e => e.ordercategoryid).HasColumnName("ordercategoryid");
            });
            
            modelBuilder.Entity<ConsultationOrders>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("consultation_orders");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderId");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterId");
                entity.Property(e => e.Locationid).HasColumnName("locationid");
                entity.Property(e => e.EncodedBy).HasColumnName("EncodedBy");
                entity.Property(e => e.EncodedDate).HasColumnName("EncodedDate");
                entity.Property(e => e.IsActive).HasColumnName("IsActive");
                entity.Property(e => e.ordertypeid).HasColumnName("ordertypeid");
                entity.Property(e => e.ordercategoryid).HasColumnName("ordercategoryid");
                entity.Property(e => e.Remarks).HasColumnName("Remarks");
                entity.Property(e => e.BillCategoryId).HasColumnName("BillCategoryId");
                entity.Property(e => e.BedCategoryId).HasColumnName("BedCategoryId");
                entity.Property(e => e.orderno).HasColumnName("orderno");
                entity.Property(e => e.orderDate).HasColumnName("orderDate");
            });


            modelBuilder.Entity<ConsultationOrderDetails>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("consultation_order_details");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.ApprovalCode).HasColumnName("ApprovalCode");

                entity.Property(e => e.orderId).HasColumnName("orderId");
                entity.Property(e => e.serviceId).HasColumnName("serviceId");
                entity.Property(e => e.encounterid).HasColumnName("encounterid");
                entity.Property(e => e.patientid).HasColumnName("patientid");
                entity.Property(e => e.serviceType).HasColumnName("serviceType");
                entity.Property(e => e.DoctorId).HasColumnName("DoctorId");
                entity.Property(e => e.UnderPackage).HasColumnName("UnderPackage");
                entity.Property(e => e.investigationdate).HasColumnName("investigationdate");
                entity.Property(e => e.ToDate).HasColumnName("ToDate");
                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceId");
                entity.Property(e => e.DiagnosisId).HasColumnName("DiagnosisId");
                entity.Property(e => e.IsApprovalRequest).HasColumnName("IsApprovalRequest");
                entity.Property(e => e.IsExcluded).HasColumnName("IsExcluded");
                entity.Property(e => e.Isactive).HasColumnName("Isactive");
                entity.Property(e => e.LastChangedBy).HasColumnName("LastChangedBy");
                entity.Property(e => e.LastChangedDate).HasColumnName("LastChangedDate");
                entity.Property(e => e.EncodedBy).HasColumnName("EncodedBy");
                entity.Property(e => e.IsSupplementary).HasColumnName("IsSupplementary");
                entity.Property(e => e.Remark).HasColumnName("Remark");
                entity.Property(e => e.LocationId).HasColumnName("LocationId");
                entity.Property(e => e.PreAuthorizeNo).HasColumnName("PreAuthorizeNo");
                entity.Property(e => e.ApprovalCode).HasColumnName("ApprovalCode");
                entity.Property(e => e.IsCapitatedService).HasColumnName("IsCapitatedService");
                entity.Property(e => e.unit).HasColumnName("unit");
                entity.Property(e => e.chargeamount).HasColumnName("chargeamount");
                entity.Property(e => e.tariffid).HasColumnName("tariffid");
                entity.Property(e => e.plantypeid).HasColumnName("plantypeid");
                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");
                entity.Property(e => e.ordertypeid).HasColumnName("ordertypeid");
                entity.Property(e => e.ordercategoryid).HasColumnName("ordercategoryid");
            });


            modelBuilder.Entity<ConsultationDiagnosisFavourites>(entity =>
            {
                entity.ToTable("Consultation_Diagnosis_Favourites");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");
                entity.Property(e => e.doctorid).HasColumnName("doctorid");

                entity.Property(e => e.encodedby).HasColumnName("encodedby");
                entity.Property(e => e.encodeddate).HasColumnName("encodeddate");
                entity.Property(e => e.isactive).HasColumnName("isactive");
                entity.Property(e => e.lastchangedate).HasColumnName("lastchangedate");
                entity.Property(e => e.lastchangeby).HasColumnName("lastchangeby");
                entity.Property(e => e.ICDID).HasColumnName("ICDID");
            });
            
            modelBuilder.Entity<Diagnosissubgroup>(entity =>
            {
                entity.ToTable("Diagnosissubgroup");

                entity.HasKey(e => e.subgroupid);

                entity.Property(e => e.subgroupid).HasColumnName("subgroupid");
                entity.Property(e => e.groupid).HasColumnName("groupid");

                entity.Property(e => e.subgroupname).HasColumnName("subgroupname");
                entity.Property(e => e.range).HasColumnName("range");
                entity.Property(e => e.rangeend).HasColumnName("rangeend");
                entity.Property(e => e.rangestart).HasColumnName("rangestart");
                entity.Property(e => e.isactive).HasColumnName("isactive");
            });
            
            modelBuilder.Entity<DiagnosisLocation>(entity =>
            {
                entity.ToTable("DiagnosisLocation");

                entity.HasKey(e => e.diagnosislocationid);

                entity.Property(e => e.diagnosislocationname).HasColumnName("diagnosislocationname");
                entity.Property(e => e.dateadded).HasColumnName("dateadded");
            });
            
            modelBuilder.Entity<RegistrationType>(entity =>
            {
                entity.ToTable("RegistrationType");

                entity.HasKey(e => e.regtypeId);

                entity.Property(e => e.regtypeId).HasColumnName("regtypeId");

                entity.Property(e => e.regtypeName).HasColumnName("regtypeName");
            });

            modelBuilder.Entity<AccesscontrolUser>(entity =>
            {
                entity.HasKey(e => new { e.AccessControlId, e.UserId });

                entity.ToTable("accesscontrol_user");

                entity.Property(e => e.AccessControlId).HasColumnName("access_controlID");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.HasOne(d => d.AccessControl)
                    .WithMany(p => p.AccesscontrolUser)
                    .HasForeignKey(d => d.AccessControlId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_accesscontrol_user_access_control");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AccesscontrolUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_accesscontrol_user_user");
            });

            modelBuilder.Entity<AccountCategory>(entity =>
            {
                entity.HasKey(e => e.Accountcatid);

                entity.Property(e => e.Accountcatid).HasColumnName("accountcatid");

                entity.Property(e => e.Accountcattype)
                    .HasColumnName("accountcattype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<AccountManager>(entity =>
            {
                entity.HasKey(e => e.ProviderId);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.AccountId)
                    .HasColumnName("AccountID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AdminEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.HospitalAddress).IsUnicode(false);

                entity.Property(e => e.HospitalName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK_AccountManager_country");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.AccountManager)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("FK_AccountManager_State");
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.Accttypeid);

                entity.Property(e => e.Accttypeid).HasColumnName("accttypeid");

                entity.Property(e => e.Accttypedesc)
                    .HasColumnName("accttypedesc")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Admission>(entity =>
            {
                entity.Property(e => e.AdmissionId).HasColumnName("admissionID");

                entity.Property(e => e.Admissiontime)
                    .HasColumnName("admissiontime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bedid).HasColumnName("bedid");

                entity.Property(e => e.ClinicalSummary).HasColumnName("clinicalSummary");

                entity.Property(e => e.Complaints).HasColumnName("complaints");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadmitted)
                    .HasColumnName("dateadmitted")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.DischargedBy).HasColumnName("dischargedBy");

                entity.Property(e => e.Dischargedate)
                    .HasColumnName("dischargedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dischargetime)
                    .HasColumnName("dischargetime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estimateddischarge)
                    .HasColumnName("estimateddischarge")
                    .HasColumnType("datetime");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.HasOne(d => d.Bed)
                    .WithMany(p => p.Admission)
                    .HasForeignKey(d => d.Bedid)
                    .HasConstraintName("FK_Admission_Bed");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Admission)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Admission_Department");

                entity.HasOne(d => d.DischargedByNavigation)
                    .WithMany(p => p.AdmissionDischargedByNavigation)
                    .HasForeignKey(d => d.DischargedBy)
                    .HasConstraintName("FK_Admission_Personnel1");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Admission)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Admission_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Admission)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_admission_accountmanager");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.AdmissionStaff)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_Admission_Personnel");
            });

            modelBuilder.Entity<AdmissionDiagnosis>(entity =>
            {
                entity.ToTable("Admission_Diagnosis");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Admissionid).HasColumnName("admissionid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Diagnosiscode)
                    .HasColumnName("diagnosiscode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Admission)
                    .WithMany(p => p.AdmissionDiagnosis)
                    .HasForeignKey(d => d.Admissionid)
                    .HasConstraintName("FK_Admission_Diagnosis_Admission");
            });

            modelBuilder.Entity<AntenatalRecord>(entity =>
            {
                entity.ToTable("Antenatal_Record");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Record).HasColumnName("record");

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.AntenatalRecord)
                    .HasForeignKey(d => d.Consultationid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Antenatal_Record_Patient");
            });

            modelBuilder.Entity<PlanType>(x => {
                x.HasKey(x => x.planid);
            });

            modelBuilder.Entity<AppSetting>(entity =>
            {
                entity.ToTable("app_setting");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.User)
                    .HasColumnName("user")
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AppUser>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.HasIndex(e => e.IdentificationModeid);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Secretanswer)
                    .HasColumnName("secretanswer")
                    .IsUnicode(false);

                entity.Property(e => e.Secretquestion)
                    .HasColumnName("secretquestion")
                    .IsUnicode(false);

                entity.Property(e => e.Titleid).HasColumnName("titleid");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdentificationMode)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.IdentificationModeid);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_appuser_accountmanager");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.AppUser)
                    .HasForeignKey(d => d.Titleid)
                    .HasConstraintName("Title_AppUser");
            });

            modelBuilder.Entity<ApplicationUser>(entity =>
            {
                entity.HasKey(e => e.Appuserid)
                    .HasName("PK__Applicat__CF5F694F2AAD88F5");

                entity.Property(e => e.Appuserid).HasColumnName("appuserid");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Passwordhash)
                    .IsRequired()
                    .HasColumnName("passwordhash")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .IsRequired()
                    .HasColumnName("phone1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ApplicationUser)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__Applicati__locat__5C0D8F7B");
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.Property(e => e.Appointmentid).HasColumnName("appointmentid");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Appointmentdate)
                    .HasColumnName("appointmentdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appointmentenddate)
                    .HasColumnName("appointmentenddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Appointmenttime)
                    .HasColumnName("appointmenttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.HasKey(x => x.Appointmentid);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Reasonforvisit)
                    .HasColumnName("reasonforvisit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Department_Appointment");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_Department_Staff");
            });

            modelBuilder.Entity<AppointmentSchedule>(entity =>
            {
                entity.HasOne(d => d.PatientNumberNavigation)
                    .WithMany(p => p.AppointmentSchedule)
                    .HasForeignKey(d => d.PatientNumber)
                    .HasConstraintName("FK_Patient_AppointmentSchedule");
            });

            modelBuilder.Entity<AppointmentStatus>(entity =>
            {
                entity.HasKey(e => e.Statusid)
                    .HasName("PK__Appointm__36247E305B0C5D02");

                entity.Property(e => e.Statusid).HasColumnName("statusid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Statuscolor)
                    .IsRequired()
                    .HasColumnName("statuscolor")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Statusname)
                    .IsRequired()
                    .HasColumnName("statusname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Rate)
                    .HasColumnName("rate")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReceiptNum).HasColumnName("receiptNum");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Typeid).HasColumnName("typeid");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK_Asset_Location");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_Asset_Provider");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.Supplierid)
                    .HasConstraintName("FK_Asset_Supplier");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Asset)
                    .HasForeignKey(d => d.Typeid)
                    .HasConstraintName("FK_Asset_AssetType");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AssetType)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_AssetType_Provider");
            });

            modelBuilder.Entity<AssignedAsset>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Approverid).HasColumnName("approverid");

                entity.Property(e => e.Assetid).HasColumnName("assetid");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateAssigned)
                    .HasColumnName("dateAssigned")
                    .HasColumnType("datetime");

                entity.Property(e => e.DateReturned)
                    .HasColumnName("dateReturned")
                    .HasColumnType("datetime");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.HasOne(d => d.Approver)
                    .WithMany(p => p.AssignedAssetApprover)
                    .HasForeignKey(d => d.Approverid)
                    .HasConstraintName("FK_AssignedAsset_Personnel2");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.AssignedAsset)
                    .HasForeignKey(d => d.Assetid)
                    .HasConstraintName("FK_AssignedAsset_Asset");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AssignedAsset)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_AssignedAsset_AccountManager");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.AssignedAssetStaff)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_AssignedAsset_Personnel1");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("audit_log");

                entity.Property(e => e.Auditlogid).HasColumnName("auditlogid");

                entity.Property(e => e.Actionperformed)
                    .HasColumnName("actionperformed")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formaccessed)
                    .HasColumnName("formaccessed")
                    .IsUnicode(false);

                entity.Property(e => e.Modulename)
                    .HasColumnName("modulename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Systemid)
                    .HasColumnName("systemid")
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.AuditLog)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_auditlog_accountmanager");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuditLog)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_audit_log_user");
            });

            modelBuilder.Entity<Authorisation>(entity =>
            {
                entity.Property(e => e.Authorisationid).HasColumnName("authorisationid");

                entity.Property(e => e.Approvallist)
                    .HasColumnName("approvallist")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Authorisationcode)
                    .HasColumnName("authorisationcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Nameofapprover)
                    .HasColumnName("nameofapprover")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Procedurecodes)
                    .HasColumnName("procedurecodes")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Treatmentoption)
                    .HasColumnName("treatmentoption")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Hmo)
                    .WithMany(p => p.Authorisation)
                    .HasForeignKey(d => d.Hmoid)
                    .HasConstraintName("fk_hmo");
            });

            modelBuilder.Entity<Bed>(entity =>
            {
                entity.Property(e => e.Bedid).HasColumnName("bedid");

                entity.Property(e => e.Bedname)
                    .HasColumnName("bedname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bednumber)
                    .HasColumnName("bednumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Wardid).HasColumnName("wardid");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Bed)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_bed_accountmanager");

                entity.HasOne(d => d.Ward)
                    .WithMany(p => p.Bed)
                    .HasForeignKey(d => d.Wardid)
                    .HasConstraintName("FK_Bed_Ward");
            });

            modelBuilder.Entity<BenefitPackage>(entity =>
            {
                entity.HasKey(e => e.Benpackageid)
                    .HasName("pk_benefit_package");

                entity.Property(e => e.Benpackageid).HasColumnName("benpackageid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Packagedesc)
                    .HasColumnName("packagedesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Packagename)
                    .HasColumnName("packagename")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Accounttypeid).HasColumnName("accounttypeid");

                entity.Property(e => e.Batchno)
                    .HasColumnName("batchno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Billclosedate)
                    .HasColumnName("billclosedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Billdate)
                    .HasColumnName("billdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Consultationfee).HasColumnName("consultationfee");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.IsHmopayment).HasColumnName("isHMOPayment");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Paymentconfirmed).HasColumnName("paymentconfirmed");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Tariffid).HasColumnName("tariffid");

                entity.HasOne(d => d.Accounttype)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Accounttypeid)
                    .HasConstraintName("FK_Bill_AccountType");

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Bill_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Bill_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_bill_accountmanager");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_Bill_Personnel");

                entity.HasOne(d => d.Tariff)
                    .WithMany(p => p.Bill)
                    .HasForeignKey(d => d.Tariffid)
                    .HasConstraintName("FK_Bill_Tariff");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.ToTable("Bill_Detail");

                entity.Property(e => e.Billdetailid).HasColumnName("billdetailid");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Billtype)
                    .HasColumnName("billtype")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Dateofservice)
                    .HasColumnName("dateofservice")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Servicedesc)
                    .HasColumnName("servicedesc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Serviceid)
                    .HasColumnName("serviceid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.BillDetail)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Bill_Detail_Department");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.BillDetail)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_billdetail_accountmanager");
            });

            modelBuilder.Entity<BillPayable>(entity =>
            {
                entity.Property(e => e.Billpayableid).HasColumnName("billpayableid");

                entity.Property(e => e.Amountinwords)
                    .HasColumnName("amountinwords")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Amountpaid).HasColumnName("amountpaid");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.Billamount).HasColumnName("billamount");

                entity.Property(e => e.Billid).HasColumnName("billid");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Trfno)
                    .HasColumnName("trfno")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Txndate)
                    .HasColumnName("txndate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Bill)
                    .WithMany(p => p.BillPayable)
                    .HasForeignKey(d => d.Billid)
                    .HasConstraintName("FK_BillPayable_Bill");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BillPayable)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_BillPayable_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.BillPayable)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_billpayable_accountmanager");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.BillPayable)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_BillPayable_Personnel");
            });

            modelBuilder.Entity<Biometric>(entity =>
            {
                entity.Property(e => e.Biometricid)
                    .HasColumnName("biometricid")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fingerindex)
                    .HasColumnName("fingerindex")
                    .IsUnicode(false);

                entity.Property(e => e.Fingername)
                    .HasColumnName("fingername")
                    .IsUnicode(false);

                entity.Property(e => e.Fingertemplate)
                    .HasColumnName("fingertemplate")
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wsqformat)
                    .HasColumnName("wsqformat")
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Biometric)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("Patient_Biometric");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Biometric)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_biometric_accountmanager");
            });

            modelBuilder.Entity<BirthRegister>(entity =>
            {
                entity.HasKey(e => e.Babyid);

                entity.Property(e => e.Babyid).HasColumnName("babyid");

                entity.Property(e => e.Babycount).HasColumnName("babycount");

                entity.Property(e => e.Birthweight)
                    .HasColumnName("birthweight")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deliverydate)
                    .HasColumnName("deliverydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deliverytype)
                    .HasColumnName("deliverytype")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Familyname)
                    .HasColumnName("familyname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasColumnName("notes")
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.BirthRegister)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_BirthRegister_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.BirthRegister)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_birthregister_accountmanager");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.BirthRegister)
                    .HasForeignKey(d => d.Staffid)
                    .HasConstraintName("FK_BirthRegister_Personnel");
            });

            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.Property(e => e.Bloodgroupid).HasColumnName("bloodgroupid");

                entity.Property(e => e.Bloodgroupname)
                    .HasColumnName("bloodgroupname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CaseNote>(entity =>
            {
                entity.ToTable("case_note");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cardiovascular).HasColumnType("text");

                entity.Property(e => e.CentralNervousSystem).HasColumnType("text");

                entity.Property(e => e.Complaints).HasColumnType("text");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FamilyAndSocialHistory).HasColumnType("text");

                entity.Property(e => e.GastroIntestinal).HasColumnType("text");

                entity.Property(e => e.General).HasColumnType("text");

                entity.Property(e => e.HistoryOfPresentingComplaints).HasColumnType("text");

                entity.Property(e => e.MusculoSkeletal).HasColumnType("text");

                entity.Property(e => e.PastMedicalAndDrugHistory).HasColumnType("text");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Reproductive).HasColumnType("text");

                entity.Property(e => e.Respiratory).HasColumnType("text");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UtilizationId).HasColumnName("utilizationID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.CaseNote)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_casenote_accountmanager");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CaseNote)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_case_note_user");

                entity.HasOne(d => d.Utilization)
                    .WithMany(p => p.CaseNote)
                    .HasForeignKey(d => d.UtilizationId)
                    .HasConstraintName("FK_case_note_utilization");
            });

            modelBuilder.Entity<CentralStore>(entity =>
            {
                entity.Property(e => e.Centralstoreid).HasColumnName("centralstoreid");

                entity.Property(e => e.Costprice).HasColumnName("costprice");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Drugcode)
                    .HasColumnName("drugcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drugid).HasColumnName("drugid");

                entity.Property(e => e.Extqty).HasColumnName("extqty");

                entity.Property(e => e.Manufacturedate)
                    .HasColumnName("manufacturedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Packetno).HasColumnName("packetno");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Reorderlevel).HasColumnName("reorderlevel");

                entity.Property(e => e.Unitofstorage)
                    .HasColumnName("unitofstorage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units).HasColumnName("units");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.CentralStore)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_centralstore_accountmanager");
            });

            modelBuilder.Entity<Claims>(entity =>
            {
                entity.ToTable("claims");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amountbilled)
                    .HasColumnName("amountbilled")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Claimtype).HasColumnName("claimtype");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiagnosisId).HasColumnName("diagnosisID");

                entity.Property(e => e.Diagnosiscode).HasColumnName("diagnosiscode");

                entity.Property(e => e.Enrolleeid).HasColumnName("enrolleeid");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .IsUnicode(false);

                entity.Property(e => e.Hmonumber).HasColumnName("hmonumber");

                entity.Property(e => e.IsClaimExported)
                    .HasColumnName("isClaimExported")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issynced)
                    .HasColumnName("issynced")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Panumber).HasColumnName("PANumber");

                entity.Property(e => e.Patienttype).HasColumnName("patienttype");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.SyncedAt)
                    .HasColumnName("synced_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Syncid)
                    .HasColumnName("syncid")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Treatmentenddate)
                    .HasColumnName("treatmentenddate")
                    .HasColumnType("date");

                entity.Property(e => e.Treatmentstartdate)
                    .HasColumnName("treatmentstartdate")
                    .HasColumnType("date");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.DiagnosisId)
                    .HasConstraintName("FK_claims_diagnosis_utilization");

                entity.HasOne(d => d.Enrollee)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.Enrolleeid)
                    .HasConstraintName("FK_claims_enrollee");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_claims_accountmanager");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Claims)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_claims_user");
            });

            modelBuilder.Entity<Clinic>(entity =>
            {
                entity.Property(e => e.Clinicid).HasColumnName("clinicid");

                entity.Property(e => e.Clinicname).HasColumnName("clinicname");

                entity.Property(e => e.Contactperson).HasColumnName("contactperson");

                entity.Property(e => e.Contactphone).HasColumnName("contactphone");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Consultation>(entity =>
            {
                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Advice)
                    .HasColumnName("advice")
                    .IsUnicode(false);

                entity.Property(e => e.Arrivaltime)
                    .HasColumnName("arrivaltime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Assessment)
                    .HasColumnName("assessment")
                    .IsUnicode(false);

                entity.Property(e => e.Casenotes)
                    .HasColumnName("casenotes")
                    .IsUnicode(false);

                entity.Property(e => e.Chronicdisease)
                    .HasColumnName("chronicdisease")
                    .IsUnicode(false);

                entity.Property(e => e.Complainthistory)
                    .HasColumnName("complainthistory")
                    .HasColumnType("text");

                entity.Property(e => e.Complaints)
                    .HasColumnName("complaints")
                    .IsUnicode(false);

                entity.Property(e => e.Consultationdate)
                    .HasColumnName("consultationdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Departuretime)
                    .HasColumnName("departuretime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Docname)
                    .HasColumnName("docname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Docpath)
                    .HasColumnName("docpath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Findings)
                    .HasColumnName("findings")
                    .IsUnicode(false);

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Isbillgenerated).HasColumnName("isbillgenerated");

                entity.Property(e => e.Isdocattached).HasColumnName("isdocattached");

                entity.Property(e => e.Notenote)
                    .HasColumnName("notenote")
                    .HasColumnType("text");

                entity.Property(e => e.Objective)
                    .HasColumnName("objective")
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patienttype)
                    .HasColumnName("patienttype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Plan)
                    .HasColumnName("plan")
                    .IsUnicode(false);

                entity.Property(e => e.Proceduredone)
                    .HasColumnName("proceduredone")
                    .HasColumnType("text");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subjective)
                    .HasColumnName("subjective")
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Consultation)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultation_accountmanager");
            });

            modelBuilder.Entity<ConsultationCheck>(entity =>
            {
                entity.HasKey(e => e.Txnkey)
                    .HasName("PK_Consultation_Check_1");

                entity.ToTable("Consultation_Check");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Checkid).HasColumnName("checkid");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationCheck)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_Check_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationCheck)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Check_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationCheck)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultationcheck_accountmanager");
            });

            modelBuilder.Entity<ConsultationChecks>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Ccname).HasColumnName("CCname");

                entity.Property(e => e.Datecreated)
                    .HasColumnName("datecreated")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.FilterCategory)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsultationCheckslist>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cclname).HasColumnName("CCLname");

                entity.Property(e => e.Ccltypeid).HasColumnName("CCLtypeid");

                entity.HasOne(d => d.Ccltype)
                    .WithMany(p => p.ConsultationCheckslist)
                    .HasForeignKey(d => d.Ccltypeid)
                    .HasConstraintName("FK_ConsultationCheckslist_ConsultationCheckslist");
            });

            modelBuilder.Entity<ConsultationComplaints>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_Complaints");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Complaints)
                    .HasColumnName("complaints")
                    .HasMaxLength(250);

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasMaxLength(50);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationComplaints)
                    .HasForeignKey(d => d.Consultationid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Consultation_Complaints_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationComplaints)
                    .HasForeignKey(d => d.Patientid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Consultation_Complaints_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationComplaints)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Consultation_Complaints_AccountManager");
            });

            modelBuilder.Entity<ConsultationDental>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_Dental");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Ct).HasColumnName("ct");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Displacement).HasColumnName("displacement");

                entity.Property(e => e.Dt).HasColumnName("dt");

                entity.Property(e => e.Extraoralexamfa)
                    .HasColumnName("extraoralexamfa")
                    .HasMaxLength(50);

                entity.Property(e => e.Extraoralexamlav)
                    .HasColumnName("extraoralexamlav")
                    .HasMaxLength(50);

                entity.Property(e => e.Extraoralexamswe)
                    .HasColumnName("extraoralexamswe")
                    .HasMaxLength(50);

                entity.Property(e => e.Extraoralexamtmj)
                    .HasColumnName("extraoralexamtmj")
                    .HasMaxLength(50);

                entity.Property(e => e.Ft).HasColumnName("ft");

                entity.Property(e => e.Intraoralexamgingivae)
                    .HasColumnName("intraoralexamgingivae")
                    .HasMaxLength(50);

                entity.Property(e => e.Intraoralexamoralhyj)
                    .HasColumnName("intraoralexamoralhyj")
                    .HasMaxLength(50);

                entity.Property(e => e.Intraoralexamtris)
                    .HasColumnName("intraoralexamtris")
                    .HasMaxLength(50);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Tp).HasColumnName("tp");

                entity.Property(e => e.Treatmentdone).HasColumnName("treatmentdone");

                entity.Property(e => e.Treatmentplan).HasColumnName("treatmentplan");

                entity.Property(e => e.Ttp).HasColumnName("ttp");

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationDental)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_Dental_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationDental)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Dental_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationDental)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_Consultation_Dental_AccountManager");
            });

            modelBuilder.Entity<ConsultationDentalProcedure>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_DentalProcedure");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Toothno)
                    .HasColumnName("toothno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Treatmentplan).HasColumnName("treatmentplan");

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationDentalProcedure)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_DentalProcedure_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationDentalProcedure)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_DentalProcedure_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationDentalProcedure)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_Consultation_DentalProcedure_AccountManager");
            });

            modelBuilder.Entity<ConsultationDiagnosis>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Consultation_Diagnosis");

                entity.Property(e => e.Id).HasColumnName("Id");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.diagnosiscode)
                    .HasColumnName("diagnosiscode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationDiagnosis)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_Diagnosis_Consultation");

                entity.Property(e => e.diagnosisdesc).HasColumnName("diagnosisdesc");
                entity.Property(e => e.genderconstraint).HasColumnName("genderconstraint");
                entity.Property(e => e.encounterId).HasColumnName("encounterId");
                entity.Property(e => e.primarydiagnosis).HasColumnName("primarydiagnosis");
                entity.Property(e => e.locationid).HasColumnName("locationid");
                entity.Property(e => e.ischronic).HasColumnName("ischronic");
                entity.Property(e => e.isresolved).HasColumnName("isresolved");
                entity.Property(e => e.doctorid).HasColumnName("doctorid");
                entity.Property(e => e.remarks).HasColumnName("remarks");
                entity.Property(e => e.isactive).HasColumnName("isactive");
                entity.Property(e => e.encodedby).HasColumnName("encodedby");
                entity.Property(e => e.encodeddate).HasColumnName("encodeddate");
                entity.Property(e => e.MRDCode).HasColumnName("MRDCode");
                entity.Property(e => e.IsOTDiagnosis).HasColumnName("IsOTDiagnosis");
                entity.Property(e => e.diagnosisid).HasColumnName("diagnosisid");
                entity.Property(e => e.Onsetdate).HasColumnName("Onsetdate");
                entity.Property(e => e.Typeid).HasColumnName("Typeid");
                entity.Property(e => e.conditionid1).HasColumnName("conditionid1");
                entity.Property(e => e.conditionid2).HasColumnName("conditionid2");
                entity.Property(e => e.conditionid3).HasColumnName("conditionid3");
                entity.Property(e => e.isprovisional).HasColumnName("isprovisional");
                entity.Property(e => e.diagnosislocationid).HasColumnName("diagnosislocationid");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationDiagnosis)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Diagnosis_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationDiagnosis)
                    .HasForeignKey(d => d.ProviderID)
                    .HasConstraintName("fk_consultationdiagnosis_accountmanager");
            });

            modelBuilder.Entity<ConsultationImpression>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_Impression");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Impressioncode)
                    .HasColumnName("impressioncode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");
            });

            modelBuilder.Entity<ConsultationLaboratory>(entity =>
            {
                entity.HasKey(e => e.Labkey);

                entity.ToTable("Consultation_Laboratory");

                entity.Property(e => e.Labkey).HasColumnName("labkey");

                entity.Property(e => e.Arrivaltime)
                    .HasColumnName("arrivaltime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Departuretime)
                    .HasColumnName("departuretime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Docname)
                    .HasColumnName("docname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Docpath)
                    .HasColumnName("docpath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocattached).HasColumnName("isdocattached");

                entity.Property(e => e.Isexternal).HasColumnName("isexternal");

                entity.Property(e => e.Labdate)
                    .HasColumnName("labdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Labnotes)
                    .HasColumnName("labnotes")
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patientorderid).HasColumnName("patientorderid");

                entity.Property(e => e.Patienttype)
                    .HasColumnName("patienttype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.ConsultationLaboratory)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Consultation_Laboratory_Department");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationLaboratory)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Laboratory_Patient");

                entity.HasOne(d => d.Patientorder)
                    .WithMany(p => p.ConsultationLaboratory)
                    .HasForeignKey(d => d.Patientorderid)
                    .HasConstraintName("FK_Consultation_Laboratory_Patient_Order");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationLaboratory)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultationlab_accountmanager");
            });

            modelBuilder.Entity<ConsultationOtherDiagnosis>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_OtherDiagnosis");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Otherdiagnosis)
                    .HasColumnName("otherdiagnosis")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationOtherDiagnosis)
                    .HasForeignKey(d => d.Consultationid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Consultation_OtherDiagnosis_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationOtherDiagnosis)
                    .HasForeignKey(d => d.Patientid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Consultation_OtherDiagnosis_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationOtherDiagnosis)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Consultation_OtherDiagnosis_AccountManager");
            });

            modelBuilder.Entity<ConsultationPrescription>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_Prescription");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dispensedate)
                    .HasColumnName("dispensedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Dispensenotes)
                    .HasColumnName("dispensenotes")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Docname)
                    .HasColumnName("docname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Docpath)
                    .HasColumnName("docpath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dosage)
                    .HasColumnName("dosage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drugcode)
                    .HasColumnName("drugcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drugstrength)
                    .HasColumnName("drugstrength")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drugtype)
                    .HasColumnName("drugtype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Injectionflow).HasColumnName("injectionflow");

                entity.Property(e => e.Isdispensed).HasColumnName("isdispensed");

                entity.Property(e => e.Isdocattached).HasColumnName("isdocattached");

                entity.Property(e => e.Isundispensed).HasColumnName("isundispensed");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Prescriptionnotes)
                    .HasColumnName("prescriptionnotes")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Quantity)
                    .HasColumnName("quantity")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Units)
                    .HasColumnName("units")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationPrescription)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_Prescription_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationPrescription)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Prescription_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationPrescription)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultationprescription_accountmanager");
            });

            modelBuilder.Entity<ConsultationProblem>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_Problem");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Problem)
                    .HasColumnName("problem")
                    .HasMaxLength(250);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationProblem)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_Problem_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationProblem)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Problem_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationProblem)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("FK_Consultation_Problem_AccountManager");
            });

            modelBuilder.Entity<ConsultationProcedure>(entity =>
            {
                entity.HasKey(e => e.Txnkey);

                entity.ToTable("Consultation_Procedure");

                entity.Property(e => e.Txnkey).HasColumnName("txnkey");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Panumber)
                    .HasColumnName("panumber")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Procedurecode)
                    .HasColumnName("procedurecode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Consultation)
                    .WithMany(p => p.ConsultationProcedure)
                    .HasForeignKey(d => d.Consultationid)
                    .HasConstraintName("FK_Consultation_Procedure_Consultation");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ConsultationProcedure)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Consultation_Procedure_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationProcedure)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultationprocedure_accountmanager");
            });

            modelBuilder.Entity<ConsultationRadiology>(entity =>
            {
                entity.HasKey(e => e.Labkey);

                entity.ToTable("Consultation_Radiology");

                entity.Property(e => e.Labkey).HasColumnName("labkey");

                entity.Property(e => e.Arrivaltime)
                    .HasColumnName("arrivaltime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Departuretime)
                    .HasColumnName("departuretime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Docname)
                    .HasColumnName("docname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Docpath)
                    .HasColumnName("docpath")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Endtime)
                    .HasColumnName("endtime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdocattached).HasColumnName("isdocattached");

                entity.Property(e => e.Labdate)
                    .HasColumnName("labdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Labnotes)
                    .HasColumnName("labnotes")
                    .IsUnicode(false);

                entity.Property(e => e.Labserviceid)
                    .HasColumnName("labserviceid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patienttype)
                    .HasColumnName("patienttype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Starttime)
                    .HasColumnName("starttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationRadiology)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultationrad_accountmanager");
            });

            modelBuilder.Entity<ConsultationUtilization>(entity =>
            {
                entity.ToTable("consultation_utilization");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ConsultationId).HasColumnName("consultationID");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiagnosisId).HasColumnName("diagnosisID");

                entity.Property(e => e.Isclaimsgenerated)
                    .HasColumnName("isclaimsgenerated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.ConsultationUtilization)
                    .HasForeignKey(d => d.DiagnosisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_consultation_utilization_diagnosis_utilization");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ConsultationUtilization)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_consultationutilization_accountmanager");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("country");

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.Countryname)
                    .HasColumnName("countryname")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cptcategory>(entity =>
            {
                entity.ToTable("CPTCategory");

                entity.Property(e => e.Cptcategoryid).HasColumnName("cptcategoryid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcategorydesc)
                    .HasColumnName("cptcategorydesc")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcategoryname)
                    .HasColumnName("cptcategoryname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Cptprocedure>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("CPTProcedure");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcategoryid).HasColumnName("cptcategoryid");

                entity.Property(e => e.Cptcode)
                    .HasColumnName("CPTCode")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cptdescription)
                    .HasColumnName("CPTDescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Cptsubcategoryid).HasColumnName("cptsubcategoryid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Cptcategory)
                    .WithMany(p => p.Cptprocedure)
                    .HasForeignKey(d => d.Cptcategoryid)
                    .HasConstraintName("FK_CPTProcedure_CPTCategory");

                entity.HasOne(d => d.Cptsubcategory)
                    .WithMany(p => p.Cptprocedure)
                    .HasForeignKey(d => d.Cptsubcategoryid)
                    .HasConstraintName("FK_CPTProcedure_CPTSubCategory");
            });

            modelBuilder.Entity<CptsubCategory>(entity =>
            {
                entity.ToTable("CPTSubCategory");

                entity.Property(e => e.Cptsubcategoryid).HasColumnName("cptsubcategoryid");

                entity.Property(e => e.Cptcategorydesc)
                    .HasColumnName("cptcategorydesc")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Cptcategoryid).HasColumnName("cptcategoryid");

                entity.Property(e => e.Cptsubcategoryname)
                    .HasColumnName("cptsubcategoryname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Cptcategory)
                    .WithMany(p => p.CptsubCategory)
                    .HasForeignKey(d => d.Cptcategoryid)
                    .HasConstraintName("FK_CPTSubCategory_CPTCategory");
            });

            modelBuilder.Entity<DataSynchronization>(entity =>
            {
                entity.ToTable("data_synchronization");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DataSynchronization)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_data_synchronization_user");
            });

            modelBuilder.Entity<DentalProcedure>(entity =>
            {
                entity.ToTable("Dental_Procedure");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.Deptid);

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deptname)
                    .HasColumnName("deptname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Department)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_dept_accountmanager");
            });

            modelBuilder.Entity<DependantInfo>(entity =>
            {
                entity.ToTable("dependant_info");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enrolleeid).HasColumnName("enrolleeid");

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .IsUnicode(false);

                entity.HasOne(d => d.Enrollee)
                    .WithMany(p => p.DependantInfo)
                    .HasForeignKey(d => d.Enrolleeid)
                    .HasConstraintName("FK_dependant_info_enrollee");
            });

            modelBuilder.Entity<Designation>(entity =>
            {
                entity.HasKey(e => e.Desigid);

                entity.Property(e => e.Desigid).HasColumnName("desigid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Designation1)
                    .HasColumnName("designation")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.ToTable("diagnosis");

                entity.Property(e => e.diagnosisid).HasColumnName("diagnosisid");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.Code).HasColumnName("code");

                entity.Property(e => e.diseaseid).HasColumnName("diseaseid");
                entity.Property(e => e.diseasecode).HasColumnName("diseasecode");
                entity.Property(e => e.subgroupid).HasColumnName("subgroupid");
                entity.Property(e => e.groupid).HasColumnName("groupid");
                entity.Property(e => e.locationid).HasColumnName("locationid");
                entity.Property(e => e.isactive).HasColumnName("isactive");
                entity.Property(e => e.encodedby).HasColumnName("encodedby");
                entity.Property(e => e.encodeddate).HasColumnName("encodeddate");
                entity.Property(e => e.ICDCode).HasColumnName("ICDCode");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Diagnosis)
                    .HasForeignKey(d => d.ProviderID)
                    .HasConstraintName("fk_diagnosis_accountmanager");
            });

            modelBuilder.Entity<DiagnosisUtilization>(entity =>
            {
                entity.ToTable("diagnosis_utilization");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiagnosisId).HasColumnName("diagnosisID");

                entity.Property(e => e.Diagsequence).HasColumnName("diagsequence");

                entity.Property(e => e.UtilizationId).HasColumnName("utilizationID");

                entity.Property(e => e.VisiType).HasColumnName("visiType");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.DiagnosisUtilization)
                    .HasForeignKey(d => d.DiagnosisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_diagnosis_utilization_diagnosis");

                entity.HasOne(d => d.Utilization)
                    .WithMany(p => p.DiagnosisUtilization)
                    .HasForeignKey(d => d.UtilizationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_diagnosis_utilization_utilization");
            });

            modelBuilder.Entity<DispensingStore>(entity =>
            {
                entity.Property(e => e.Dispensingstoreid).HasColumnName("dispensingstoreid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Drugid).HasColumnName("drugid");

                entity.Property(e => e.Expirydate)
                    .HasColumnName("expirydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Manufacturedate)
                    .HasColumnName("manufacturedate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Stockdate).HasColumnType("datetime");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.DispensingStore)
                    .HasForeignKey(d => d.Drugid)
                    .HasConstraintName("FK_DispensingStore_Drug");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.DispensingStore)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_dispensing_accountmanager");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("division");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Shortname).HasColumnName("shortname");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("FK_division_group");
            });

            modelBuilder.Entity<Drug>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Adverseeffect).HasColumnName("adverseeffect");

                entity.Property(e => e.Brandname).HasColumnName("brandname");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.Contrindications).HasColumnName("contrindications");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Dispensingrate).HasColumnName("dispensingrate");

                entity.Property(e => e.Dosage).HasColumnName("dosage");

                entity.Property(e => e.Drugcategoryid).HasColumnName("drugcategoryid");

                entity.Property(e => e.Drugcode)
                    .HasColumnName("drugcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Drugtype)
                    .HasColumnName("drugtype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Expirydate)
                    .HasColumnName("expirydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Indication).HasColumnName("indication");

                entity.Property(e => e.LastNotificationId).HasColumnName("lastNotificationID");

                entity.Property(e => e.Manufacturer).HasColumnName("manufacturer");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Productiondate)
                    .HasColumnName("productiondate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.ReorderQuantity).HasColumnName("reorder_quantity");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Unitofstorage)
                    .HasColumnName("unitofstorage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unitprice)
                    .HasColumnName("unitprice")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.UploadedAt)
                    .HasColumnName("uploaded_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Drugcategory)
                    .WithMany(p => p.Drug)
                    .HasForeignKey(d => d.Drugcategoryid)
                    .HasConstraintName("FK_Drug_DrugCategory");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Drug)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_Drug_Provider");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Drug)
                    .HasForeignKey(d => d.Supplierid)
                    .HasConstraintName("FK_Drug_Supplier");
            });

            modelBuilder.Entity<DrugCategory>(entity =>
            {
                entity.Property(e => e.Drugcategoryid).HasColumnName("drugcategoryid");

                entity.Property(e => e.Categorydesc)
                    .HasColumnName("categorydesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Drugcategory1)
                    .HasColumnName("drugcategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrugDispense>(entity =>
            {
                entity.ToTable("drug_dispense");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Unit).HasColumnName("unit");

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.UtilizationId).HasColumnName("utilizationID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DrugDispense)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_drug_dispense_user");

                entity.HasOne(d => d.Utilization)
                    .WithMany(p => p.DrugDispense)
                    .HasForeignKey(d => d.UtilizationId)
                    .HasConstraintName("FK_drug_dispense_utilization");
            });

            modelBuilder.Entity<DrugOrders>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdminTime).HasColumnType("datetime");

                entity.Property(e => e.CreatedAt).HasColumnName("created_at");

                entity.Property(e => e.DrugId).HasColumnName("drugID");

                entity.Property(e => e.IsAdminApproved).HasColumnName("isAdminApproved");

                entity.Property(e => e.IsAdminHandled).HasColumnName("isAdminHandled");

                entity.Property(e => e.IsPharmacyConcluded).HasColumnName("isPharmacyConcluded");

                entity.Property(e => e.IsPharmayHandled).HasColumnName("isPharmayHandled");

                entity.Property(e => e.OrderSupplierId).HasColumnName("OrderSupplierID");

                entity.Property(e => e.PharmacyTime).HasColumnType("datetime");

                entity.Property(e => e.RequisitionNumber).HasMaxLength(50);

                entity.HasOne(d => d.AdminHandlerNavigation)
                    .WithMany(p => p.DrugOrdersAdminHandlerNavigation)
                    .HasForeignKey(d => d.AdminHandler)
                    .HasConstraintName("FK_DrugOrders_Personnel2");

                entity.HasOne(d => d.Drug)
                    .WithMany(p => p.DrugOrders)
                    .HasForeignKey(d => d.DrugId)
                    .HasConstraintName("FK_DrugOrders_Drug");

                entity.HasOne(d => d.OrderSupplier)
                    .WithMany(p => p.DrugOrders)
                    .HasForeignKey(d => d.OrderSupplierId)
                    .HasConstraintName("FK_DrugOrders_Supplier");

                entity.HasOne(d => d.PharmacyHandlerNavigation)
                    .WithMany(p => p.DrugOrdersPharmacyHandlerNavigation)
                    .HasForeignKey(d => d.PharmacyHandler)
                    .HasConstraintName("FK_DrugOrders_Personnel");
            });

            modelBuilder.Entity<DrugPricelist>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Datetadded)
                    .HasColumnName("datetadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Drugname)
                    .IsRequired()
                    .HasColumnName("drugname");

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DrugTherapeuticClass>(entity =>
            {
                entity.HasKey(e => e.Classid);

                entity.Property(e => e.Classid).HasColumnName("classid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Therapeuticdesc)
                    .HasColumnName("therapeuticdesc")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DrugUtilization>(entity =>
            {
                entity.ToTable("drug_utilization");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deseunit)
                    .HasColumnName("deseunit")
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosisId).HasColumnName("diagnosisID");

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .IsUnicode(false);

                entity.Property(e => e.DrugId).HasColumnName("DrugID");

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .IsUnicode(false);

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .IsUnicode(false);

                entity.Property(e => e.Isclaimsgenerated)
                    .HasColumnName("isclaimsgenerated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdispensed)
                    .HasColumnName("isdispensed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paymenttype).HasColumnName("paymenttype");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.DrugUtilization)
                    .HasForeignKey(d => d.DiagnosisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_drug_utilization_diagnosis_utilization");
            });

            modelBuilder.Entity<Enrollee>(entity =>
            {
                entity.HasKey(e => e.IdE);

                entity.ToTable("enrollee");

                entity.Property(e => e.IdE).HasColumnName("ID_e");

                entity.Property(e => e.Addressline1E).HasColumnName("addressline1_e");

                entity.Property(e => e.Addressline2E).HasColumnName("addressline2_e");

                entity.Property(e => e.Cardnumber).HasColumnName("cardnumber");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.Coverageenddate)
                    .HasColumnName("coverageenddate")
                    .HasColumnType("date");

                entity.Property(e => e.Coveragestartdate)
                    .HasColumnName("coveragestartdate")
                    .HasColumnType("date");

                entity.Property(e => e.Dateenrolleed)
                    .HasColumnName("dateenrolleed")
                    .HasColumnType("date");

                entity.Property(e => e.Divisionid).HasColumnName("divisionid");

                entity.Property(e => e.DobE)
                    .HasColumnName("dob_e")
                    .HasColumnType("date");

                entity.Property(e => e.Effectivedate)
                    .HasColumnName("effectivedate")
                    .HasColumnType("date");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Enrolleetypeid).HasColumnName("enrolleetypeid");

                entity.Property(e => e.FirstnameE)
                    .HasColumnName("firstname_e")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Formprocesseddate)
                    .HasColumnName("formprocesseddate")
                    .HasColumnType("date");

                entity.Property(e => e.Formreceiveddate)
                    .HasColumnName("formreceiveddate")
                    .HasColumnType("date");

                entity.Property(e => e.GenderE)
                    .HasColumnName("gender_e")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Hmocode1).HasColumnName("hmocode1");

                entity.Property(e => e.Hmocode2).HasColumnName("hmocode2");

                entity.Property(e => e.Hmocode3).HasColumnName("hmocode3");

                entity.Property(e => e.Issynced).HasColumnName("issynced");

                entity.Property(e => e.LastnameE)
                    .HasColumnName("lastname_e")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Maritalstatus).HasColumnName("maritalstatus");

                entity.Property(e => e.Market).HasColumnName("market");

                entity.Property(e => e.Networkid).HasColumnName("networkid");

                entity.Property(e => e.Nextofkin).HasColumnName("nextofkin");

                entity.Property(e => e.Nextofkinaddress).HasColumnName("nextofkinaddress");

                entity.Property(e => e.Nextofkinphone).HasColumnName("nextofkinphone");

                entity.Property(e => e.Occupation).HasColumnName("occupation");

                entity.Property(e => e.OfficeLga)
                    .HasColumnName("officeLGA")
                    .HasMaxLength(250);

                entity.Property(e => e.Officeaddress).HasColumnName("officeaddress");

                entity.Property(e => e.Officecity)
                    .HasColumnName("officecity")
                    .HasMaxLength(500);

                entity.Property(e => e.Officestate)
                    .HasColumnName("officestate")
                    .HasMaxLength(250);

                entity.Property(e => e.OthernameE)
                    .HasColumnName("othername_e")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneE).HasColumnName("phone_e");

                entity.Property(e => e.Plainid).HasColumnName("plainid");

                entity.Property(e => e.Planeffectivedate)
                    .HasColumnName("planeffectivedate")
                    .HasColumnType("date");

                entity.Property(e => e.Planterminationdate)
                    .HasColumnName("planterminationdate")
                    .HasColumnType("date");

                entity.Property(e => e.PrincipalCode).HasColumnName("principalCode");

                entity.Property(e => e.ProviderReason).HasColumnName("providerReason");

                entity.Property(e => e.Providereffectivedate)
                    .HasColumnName("providereffectivedate")
                    .HasColumnType("date");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.Providerterminationdate)
                    .HasColumnName("providerterminationdate")
                    .HasColumnType("date");

                entity.Property(e => e.Receiptnum).HasColumnName("receiptnum");

                entity.Property(e => e.State).HasColumnName("state");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.SyncAt)
                    .HasColumnName("sync_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Syncid).HasColumnName("syncid");

                entity.Property(e => e.Terminationdate)
                    .HasColumnName("terminationdate")
                    .HasColumnType("date");

                entity.Property(e => e.TitleE)
                    .HasColumnName("title_e")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Zip).HasColumnName("zip");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Divisionid)
                    .HasConstraintName("FK_enrollee_division");

                entity.HasOne(d => d.Enrolleetype)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Enrolleetypeid)
                    .HasConstraintName("FK_enrollee_enrollee_type");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Groupid)
                    .HasConstraintName("FK_enrollee_group");

                entity.HasOne(d => d.Network)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Networkid)
                    .HasConstraintName("FK_enrollee_network");

                entity.HasOne(d => d.Plain)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Plainid)
                    .HasConstraintName("FK_enrollee_plan");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_enrollee_provider");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Enrollee)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_enrollee_user");
            });

            modelBuilder.Entity<EnrolleeType>(entity =>
            {
                entity.ToTable("enrollee_type");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.EnrolleeType)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_enrolleetype_accountmanager");
            });

            modelBuilder.Entity<Fingerprint>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fingername)
                    .HasColumnName("fingername")
                    .IsUnicode(false);

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Index)
                    .HasColumnName("index")
                    .IsUnicode(false);

                entity.Property(e => e.Issynced).HasColumnName("issynced");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.SyncAt)
                    .HasColumnName("sync_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wsqformat).HasColumnName("wsqformat");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Fingerprint)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_fingerprint_enrollee");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Fingerprint)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_fingerprint_accountmanager");
            });

            modelBuilder.Entity<Formdirect2>(entity =>
            {
                entity.ToTable("formdirect2");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Textfield)
                    .HasColumnName("textfield")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Textfield2)
                    .HasColumnName("textfield2")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.Property(e => e.Genderid).HasColumnName("genderid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Gendername)
                    .HasColumnName("gendername")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GeneralExamination>(entity =>
            {
                entity.HasKey(e => e.Examid);

                entity.ToTable("General_Examination");

                entity.Property(e => e.Examid).HasColumnName("examid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Examdescription).HasColumnName("examdescription");
            });

            modelBuilder.Entity<GeneralSchedule>(entity =>
            {
                entity.HasKey(e => e.Genschid)
                    .HasName("PK__GeneralS__370A00B8E685F8EB");

                entity.Property(e => e.Genschid).HasColumnName("genschid");

                entity.Property(e => e.Adjuster)
                    .IsRequired()
                    .HasColumnName("adjuster")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Endtime)
                    .IsRequired()
                    .HasColumnName("endtime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Starttime)
                    .IsRequired()
                    .HasColumnName("starttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Timeinterval).HasColumnName("timeinterval");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.GeneralSchedule)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__GeneralSc__locat__1451E89E");
            });

            modelBuilder.Entity<GenoType>(entity =>
            {
                entity.Property(e => e.Genotypeid).HasColumnName("genotypeid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Genotypename)
                    .HasColumnName("genotypename")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.ToTable("group");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasColumnName("comment")
                    .HasColumnType("text");

                entity.Property(e => e.Contractend)
                    .HasColumnName("contractend")
                    .HasColumnType("date");

                entity.Property(e => e.Contractstart)
                    .HasColumnName("contractstart")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Scheme).HasColumnName("scheme");

                entity.Property(e => e.Shortname).HasColumnName("shortname");
            });

            modelBuilder.Entity<HealthCareFacilitator>(entity =>
            {
                entity.HasKey(e => e.Facilitatorid);

                entity.Property(e => e.Facilitatorid).HasColumnName("facilitatorid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Facilitatorname)
                    .HasColumnName("facilitatorname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Hmo>(entity =>
            {
                entity.ToTable("HMO");

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100);

                entity.Property(e => e.Hmoaddress)
                    .HasColumnName("hmoaddress")
                    .IsUnicode(false);

                entity.Property(e => e.Hmocontact)
                    .HasColumnName("hmocontact")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hmocountry)
                    .HasColumnName("hmocountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoname)
                    .HasColumnName("hmoname")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hmonumber)
                    .HasColumnName("hmonumber")
                    .HasMaxLength(100);

                entity.Property(e => e.Hmophone1)
                    .HasColumnName("hmophone1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hmophone2)
                    .HasColumnName("hmophone2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.Property(e => e.Typeid).HasColumnName("typeid");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Hmo)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("State_HMO");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Hmo)
                    .HasForeignKey(d => d.Typeid)
                    .HasConstraintName("FK_HMO_HmoType");
            });

            modelBuilder.Entity<HmoMonthlyList>(entity =>
            {
                entity.ToTable("hmoMonthlyList");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Companyname).HasColumnName("companyname");

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasMaxLength(50);

                entity.Property(e => e.Firstname).HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Hmoname).HasColumnName("hmoname");

                entity.Property(e => e.IsResolved).HasColumnName("isResolved");

                entity.Property(e => e.Lastname).HasColumnName("lastname");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Othernames).HasColumnName("othernames");

                entity.Property(e => e.PatientHmoNumber).HasColumnName("patientHmoNumber");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.Plancode).HasColumnName("plancode");

                entity.Property(e => e.Planname).HasColumnName("planname");

                entity.Property(e => e.Servicetype)
                    .HasColumnName("servicetype")
                    .HasMaxLength(50);

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasMaxLength(50);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Uploaddate)
                    .HasColumnName("uploaddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Year)
                    .HasColumnName("year")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Hmo)
                    .WithMany(p => p.HmoMonthlyList)
                    .HasForeignKey(d => d.Hmoid)
                    .HasConstraintName("FK_hmoMonthlyList_HMO");
            });

            modelBuilder.Entity<HmoType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.HmoType)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_HmoType_Provider");
            });

            modelBuilder.Entity<Hshhs>(entity =>
            {
                entity.ToTable("hshhs");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Textfield1)
                    .HasColumnName("textfield1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Textfield12)
                    .HasColumnName("textfield12")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Icd10diagnosis>(entity =>
            {
                entity.HasKey(e => e.Serial)
                    .HasName("PK_ICD10Diagnosis_1");

                entity.ToTable("ICD10Diagnosis");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.Comments).HasColumnName("comments");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Diagnosiscode)
                    .IsRequired()
                    .HasColumnName("diagnosiscode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Icdcategoryid).HasColumnName("icdcategoryid");

                entity.Property(e => e.Longdescription).HasColumnName("longdescription");

                entity.HasOne(d => d.Icdcategory)
                    .WithMany(p => p.Icd10diagnosis)
                    .HasForeignKey(d => d.Icdcategoryid)
                    .HasConstraintName("FK_ICD10Diagnosis_ICDCategory");
            });

            modelBuilder.Entity<Icdcategory>(entity =>
            {
                entity.ToTable("ICDCategory");

                entity.Property(e => e.Icdcategoryid).HasColumnName("icdcategoryid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Icdcategorydesc)
                    .HasColumnName("icdcategorydesc")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Icdcategoryname)
                    .HasColumnName("icdcategoryname")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IdGeneration>(entity =>
            {
                entity.ToTable("id_generation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active).HasColumnName("active");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Endvalue).HasColumnName("endvalue");

                entity.Property(e => e.Lastcode).HasColumnName("lastcode");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.Startvalue).HasColumnName("startvalue");
            });

            modelBuilder.Entity<InjectionTaken>(entity =>
            {
                entity.HasKey(e => e.Injid);

                entity.ToTable("Injection_Taken");

                entity.Property(e => e.Injid).HasColumnName("injid");

                entity.Property(e => e.Administeredby)
                    .IsRequired()
                    .HasColumnName("administeredby");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.Datetaken)
                    .HasColumnName("datetaken")
                    .HasColumnType("datetime");

                entity.Property(e => e.Injname)
                    .IsRequired()
                    .HasColumnName("injname")
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .IsRequired()
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.QtyLeft).HasColumnName("qty_left");

                entity.Property(e => e.QtyTaken).HasColumnName("qty_taken");
            });

            modelBuilder.Entity<Insurance>(entity =>
            {
                entity.Property(e => e.Insuranceid).HasColumnName("insuranceid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Effectivedate)
                    .HasColumnName("effectivedate")
                    .HasColumnType("date");

                entity.Property(e => e.Employeraddress)
                    .HasColumnName("employeraddress")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Employercountry)
                    .HasColumnName("employercountry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Employername)
                    .HasColumnName("employername")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Hmonumber)
                    .HasColumnName("hmonumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Insurancetype)
                    .HasColumnName("insurancetype")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Planname)
                    .HasColumnName("planname")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.HasOne(d => d.Hmo)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.Hmoid)
                    .HasConstraintName("HMO_Insurance");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("Patient_Insurance");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Insurance)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("State_Insurance");
            });

            modelBuilder.Entity<LeadSource>(entity =>
            {
                entity.HasKey(e => e.Leadid);

                entity.Property(e => e.Leadid).HasColumnName("leadid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Leadname)
                    .HasColumnName("leadname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LicenseManager>(entity =>
            {
                entity.HasKey(e => e.LicenseKey);

                entity.Property(e => e.LicenseKey).ValueGeneratedNever();

                entity.Property(e => e.LicenseEnd).HasColumnType("datetime");

                entity.Property(e => e.LicenseStart).HasColumnType("datetime");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.LicenseManager)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_license_accountmanager");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationadmin)
                    .HasColumnName("locationadmin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Locationdescription)
                    .HasColumnName("locationdescription")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Locationname)
                    .HasColumnName("locationname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasColumnName("state")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zipcode)
                    .HasColumnName("zipcode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Login>(entity =>
            {
                entity.Property(e => e.LoginId).HasColumnName("LoginID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Login)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_login_accountmanager");
            });

            modelBuilder.Entity<Maritalstatus>(entity =>
            {
                entity.HasKey(x => x.Maritalstatusid);
                entity.ToTable("maritalstatus");

                entity.Property(e => e.Maritalstatusid)
                    .HasColumnName("maritalstatusid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Maritalstatusname)
                    .HasColumnName("maritalstatusname")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeasureUnit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Freqvalue).HasColumnName("freqvalue");

                entity.Property(e => e.Unit)
                    .HasColumnName("unit")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalProblemCategory>(entity =>
            {
                entity.HasKey(e => e.Medid)
                    .HasName("PK_MedicalProblem");

                entity.Property(e => e.Medid).HasColumnName("medid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Problemtype)
                    .HasColumnName("problemtype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MedicalProblemItem>(entity =>
            {
                entity.HasKey(e => e.Itemid);

                entity.Property(e => e.Itemid).HasColumnName("itemid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Medid).HasColumnName("medid");

                entity.HasOne(d => d.Med)
                    .WithMany(p => p.MedicalProblemItem)
                    .HasForeignKey(d => d.Medid)
                    .HasConstraintName("FK_MedicalProblemItem_MedicalProblemCategory");
            });

            modelBuilder.Entity<Messaging>(entity =>
            {
                entity.HasKey(e => e.MsgId);

                entity.Property(e => e.MsgId).HasColumnName("msgID");

                entity.Property(e => e.Content)
                    .IsRequired()
                    .HasColumnName("content");

                entity.Property(e => e.Datesent)
                    .HasColumnName("datesent")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsRead).HasColumnName("isRead");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.RecieverId).HasColumnName("recieverID");

                entity.Property(e => e.SenderId).HasColumnName("senderID");

                entity.Property(e => e.Subject).HasColumnName("subject");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Messaging)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_messaging_accountmanager");

                entity.HasOne(d => d.Reciever)
                    .WithMany(p => p.MessagingReciever)
                    .HasForeignKey(d => d.RecieverId)
                    .HasConstraintName("FK_Messaging_Personnel1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessagingSender)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK_Messaging_Personnel");
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.Property(e => e.Nationalityid).HasColumnName("nationalityid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nationalityname)
                    .HasColumnName("nationalityname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Network>(entity =>
            {
                entity.ToTable("network");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enddate)
                    .HasColumnName("enddate")
                    .HasColumnType("date");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Startdate)
                    .HasColumnName("startdate")
                    .HasColumnType("date");

                entity.Property(e => e.Status).HasColumnName("status");
            });

            modelBuilder.Entity<NextOfKinRelationship>(entity =>
            {
                entity.HasKey(e => e.Nokid);

                entity.Property(e => e.Nokid).HasColumnName("nokid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Noktype)
                    .HasColumnName("noktype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NursingRecord>(entity =>
            {
                entity.ToTable("Nursing_Record");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categoryid).HasColumnName("categoryid");

                entity.Property(e => e.Consultationid).HasColumnName("consultationid");

                entity.Property(e => e.DateCreated)
                    .HasColumnName("dateCreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Details).HasColumnName("details");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Record).HasColumnName("record");
            });

            modelBuilder.Entity<OrderCategory>(entity =>
            {
                entity.Property(e => e.Ordercategoryid).HasColumnName("ordercategoryid");

                entity.Property(e => e.Categorycomment)
                    .HasColumnName("categorycomment")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ordercategory1)
                    .HasColumnName("ordercategory")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.HasOne(d => d.Ordertype)
                    .WithMany(p => p.OrderCategory)
                    .HasForeignKey(d => d.Ordertypeid)
                    .HasConstraintName("fk_ordercategory_ordertype");
            });

            modelBuilder.Entity<OrderListing>(entity =>
            {
                entity.HasKey(e => e.Orderlistid)
                    .HasName("pk_orderlisting");

                entity.Property(e => e.Orderlistid).HasColumnName("orderlistid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ordercategoryid).HasColumnName("ordercategoryid");

                entity.Property(e => e.Orderthreshold)
                    .HasColumnName("orderthreshold")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ordertype)
                    .HasColumnName("ordertype")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.HasOne(d => d.Ordercategory)
                    .WithMany(p => p.OrderListing)
                    .HasForeignKey(d => d.Ordercategoryid)
                    .HasConstraintName("fk_ordercat_orderlisting");

                entity.HasOne(d => d.OrdertypeNavigation)
                    .WithMany(p => p.OrderListing)
                    .HasForeignKey(d => d.Ordertypeid)
                    .HasConstraintName("fk_ordertype_orderlisting");
            });

            modelBuilder.Entity<OrderStatus>(entity =>
            {
                entity.Property(e => e.Orderstatusid).HasColumnName("orderstatusid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Orderstatus1)
                    .HasColumnName("orderstatus")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrderType>(entity =>
            {
                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ordername)
                    .HasColumnName("ordername")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.Property(x => x.locationid).IsRequired(false);
                //entity.Property(x => x.hospitallocationid).IsRequired(false);
                //entity.Property(x => x.encodedby).IsRequired(false);

                entity.Property(e => e.Accountcategory)
                    .HasColumnName("accountcategory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateId1)
                    .HasColumnName("alternateID1")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.AlternateId2)
                    .HasColumnName("alternateID2")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                //entity.Property(e => e.Autoid)
                //    .HasColumnName("autoid")
                    
                //    //.IsRequired(false)
                //    .ValueGeneratedOnAdd();

                entity.Property(e => e.Bloodgroupid).HasColumnName("bloodgroupid");

                entity.Property(e => e.Cardtypeid).HasColumnName("cardtypeid");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datedeactivated)
                    .HasColumnName("datedeactivated")
                    .IsRequired(false)
                    .HasColumnType("datetime");

                entity.Property(e => e.Dateofdeath)
                    .HasColumnName("dateofdeath")
                    .IsRequired(false)
                    .HasColumnType("date");

                entity.Property(e => e.Deathcause)
                    .HasColumnName("deathcause")
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasColumnName("dob")
                    .IsRequired(false)
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencycontact)
                    .HasColumnName("emergencycontact")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencyphone)
                    .HasColumnName("emergencyphone")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Employeraddress)
                    .HasColumnName("employeraddress")
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Employercity)
                    .HasColumnName("employercity")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Employercountry)
                    .HasColumnName("employercountry")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Employername)
                    .HasColumnName("employername")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Employerstateid).HasColumnName("employerstateid").IsRequired(false);

                entity.Property(e => e.Facilitatorid).HasColumnName("facilitatorid").IsRequired(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Genderid).HasColumnName("genderid");

                entity.Property(e => e.Genotype)
                    .HasColumnName("genotype")
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Genotypeid).HasColumnName("genotypeid");

                entity.Property(e => e.Guardianname)
                    .HasColumnName("guardianname")
                    .IsRequired(false)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoclass1)
                    .HasColumnName("hmoclass1")
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoclass2)
                    .HasColumnName("hmoclass2")
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoclass3)
                    .HasColumnName("hmoclass3")
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoname1)
                    .HasColumnName("hmoname1")
                    .HasMaxLength(250)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoname2)
                    .HasColumnName("hmoname2")
                    .HasMaxLength(250)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Hmoname3)
                    .HasColumnName("hmoname3")
                    .HasMaxLength(250)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Hmonumber)
                    .HasColumnName("HMONumber")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Homephone)
                    .HasColumnName("homephone")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Inactive).HasColumnName("inactive").IsRequired(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Leadid).HasColumnName("leadid");

                entity.Property(e => e.Maritalstatusid).HasColumnName("maritalstatusid");

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("mobilephone")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Mothername)
                    .HasColumnName("mothername")
                    .HasMaxLength(100)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Nokinname)
                    .HasColumnName("nokinname")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Nokoccupation)
                    .HasColumnName("nokoccupation")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Nokphonenumber)
                    .HasColumnName("nokphonenumber")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Nokrelationship)
                    .HasColumnName("nokrelationship")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Nokworkaddress)
                    .HasColumnName("nokworkaddress")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Othername)
                    .HasColumnName("othername")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Photopath)
                    .HasColumnName("photopath")
                    .HasMaxLength(500)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Plantype).HasColumnName("plantype").IsRequired(false);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Principalcode)
                    .HasColumnName("principalcode")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID").IsRequired(false);

                entity.Property(e => e.Refid).HasColumnName("refid").IsRequired(false);

                entity.Property(e => e.Relationship)
                    .HasColumnName("relationship")
                    .IsRequired(false)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Securityid)
                    .HasColumnName("securityid")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Securitynumber)
                    .HasColumnName("securitynumber")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);
                entity.Property(e => e.Payor)
                    .HasColumnName("payor")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Servicetype).HasColumnName("servicetype");
                entity.Property(e => e.Servicetype).HasColumnName("servicetype").IsRequired(false);

                entity.Property(e => e.Sponsid).HasColumnName("sponsid").IsRequired(false);

                entity.Property(e => e.Stateid).HasColumnName("stateid").IsRequired(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);

                entity.Property(e => e.Workphone)
                    .HasColumnName("workphone")
                    .HasMaxLength(50)
                    .IsRequired(false)
                    .IsUnicode(false);


                entity.HasOne(d => d.Bloodgroup)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Bloodgroupid)
                    .HasConstraintName("FK_BloodGroup_Patient");

                entity.HasOne(d => d.Cardtype)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Cardtypeid)
                    .HasConstraintName("FK_Patient_enrollee_type");

                entity.HasOne(d => d.Facilitator)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Facilitatorid)
                    .HasConstraintName("FK_HealthCareFacilitator_Patient");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Genderid)
                    .HasConstraintName("Gender_Patient");

                entity.HasOne(d => d.GenotypeNavigation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Genotypeid)
                    .HasConstraintName("FK_Genotype_Patient");

                entity.HasOne(d => d.Lead)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Leadid)
                    .HasConstraintName("FK_Leadsource_Patient").IsRequired(false);

                entity.HasOne(d => d.Maritalstatus)
                    .WithMany(p => p.Patient)
                //    .IsRequired(false)
                    .HasForeignKey(d => d.Maritalstatusid)
                    .HasConstraintName("FK_Marital_Patient").IsRequired(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_patient_accountmanager").IsRequired(false);

                entity.HasOne(d => d.Ref)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Refid)
                    .HasConstraintName("FK_Referral_Patient").IsRequired(false);

                entity.HasOne(d => d.Spons)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Sponsid)
                    .HasConstraintName("FK_Sponsor_Patient").IsRequired(false);

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.Stateid)
                    .HasConstraintName("State_Patient").IsRequired(false);
            });

            modelBuilder.Entity<PatientMedicalHistory>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("Patient_MedicalHistory");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date");

                entity.Property(e => e.Dateend)
                    .HasColumnName("dateend")
                    .HasColumnType("date");

                entity.Property(e => e.Datestart)
                    .HasColumnName("datestart")
                    .HasColumnType("date");

                entity.Property(e => e.Diagnosiscode)
                    .HasColumnName("diagnosiscode")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Occurence)
                    .HasColumnName("occurence")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Problemdesc)
                    .HasColumnName("problemdesc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Problemid).HasColumnName("problemid");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Reaction)
                    .HasColumnName("reaction")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Patient_MedicalHistory_Patient");

                entity.HasOne(d => d.Problem)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.Problemid)
                    .HasConstraintName("FK_Patient_MedicalHistory_MedicalProblemItem");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PatientMedicalHistory)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_patientmh_accountmanager");
            });

            modelBuilder.Entity<PatientOrder>(entity =>
            {
                entity.ToTable("Patient_Order");

                entity.Property(e => e.Patientorderid).HasColumnName("patientorderid");

                entity.Property(e => e.Completedby).HasColumnName("completedby");

                entity.Property(e => e.Docimage)
                    .HasColumnName("docimage")
                    .HasColumnType("image");

                entity.Property(e => e.Docpath)
                    .HasColumnName("docpath")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ordercategoryid).HasColumnName("ordercategoryid");

                entity.Property(e => e.Ordercomment)
                    .HasColumnName("ordercomment")
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Orderlistid).HasColumnName("orderlistid");

                entity.Property(e => e.Orderstatusid).HasColumnName("orderstatusid");

                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Raisedby).HasColumnName("raisedby");

                entity.HasOne(d => d.CompletedbyNavigation)
                    .WithMany(p => p.PatientOrderCompletedbyNavigation)
                    .HasForeignKey(d => d.Completedby)
                    .HasConstraintName("fk_patient_order_personnel");

                entity.HasOne(d => d.Ordercategory)
                    .WithMany(p => p.PatientOrder)
                    .HasForeignKey(d => d.Ordercategoryid)
                    .HasConstraintName("fk_ordercat_patient_order");

                entity.HasOne(d => d.Orderlist)
                    .WithMany(p => p.PatientOrder)
                    .HasForeignKey(d => d.Orderlistid)
                    .HasConstraintName("fk_orderlisting_patient_order");

                entity.HasOne(d => d.Orderstatus)
                    .WithMany(p => p.PatientOrder)
                    .HasForeignKey(d => d.Orderstatusid)
                    .HasConstraintName("fk_orderstatus_patient_order");

                entity.HasOne(d => d.Ordertype)
                    .WithMany(p => p.PatientOrder)
                    .HasForeignKey(d => d.Ordertypeid)
                    .HasConstraintName("fk_ordertype_patient_order");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientOrder)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("fk_patient_patient_order");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PatientOrder)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_patientorder_accountmanager");

                entity.HasOne(d => d.RaisedbyNavigation)
                    .WithMany(p => p.PatientOrderRaisedbyNavigation)
                    .HasForeignKey(d => d.Raisedby)
                    .HasConstraintName("fk_patient_doctor_personnel");
            });

            modelBuilder.Entity<PatientOrderDetails>(entity =>
            {
                entity.ToTable("Patient_Order_Details");

                entity.Property(e => e.Patientorderdetailsid).HasColumnName("patientorderdetailsid");

                entity.Property(e => e.Completedby).HasColumnName("completedby");

                entity.Property(e => e.Docimage)
                    .HasColumnName("docimage")
                    .HasColumnType("image");

                entity.Property(e => e.Docpath)
                    .HasColumnName("docpath")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Ordercategoryid).HasColumnName("ordercategoryid");

                entity.Property(e => e.Ordercomment)
                    .HasColumnName("ordercomment")
                    .IsUnicode(false);

                entity.Property(e => e.Orderdate)
                    .HasColumnName("orderdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Orderlistid).HasColumnName("orderlistid");

                entity.Property(e => e.Orderstatusid).HasColumnName("orderstatusid");

                entity.Property(e => e.Ordertypeid).HasColumnName("ordertypeid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Patientorderid).HasColumnName("patientorderid");

                entity.Property(e => e.ProviderID).HasColumnName("ProviderID");

                entity.Property(e => e.Raisedby).HasColumnName("raisedby");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .IsUnicode(false);

                entity.HasOne(d => d.Patientorder)
                    .WithMany(p => p.PatientOrderDetails)
                    .HasForeignKey(d => d.Patientorderid)
                    .HasConstraintName("FK_Patient_Order_Details_Patient_Order");
            });

            modelBuilder.Entity<PatientQuestionnaire>(entity =>
            {
                entity.HasKey(e => e.Pqid);

                entity.ToTable("Patient_Questionnaire");

                entity.Property(e => e.Pqid)
                    .HasColumnName("pqid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Patientanswer)
                    .HasColumnName("patientanswer")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Qcatid).HasColumnName("qcatid");

                entity.Property(e => e.Qid).HasColumnName("qid");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientQuestionnaire)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Patient_Questionnaire_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.PatientQuestionnaire)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_patientques_accountmanager");

                entity.HasOne(d => d.Qcat)
                    .WithMany(p => p.PatientQuestionnaire)
                    .HasForeignKey(d => d.Qcatid)
                    .HasConstraintName("FK_Patient_Questionnaire_QuestionCategory");

                entity.HasOne(d => d.Q)
                    .WithMany(p => p.PatientQuestionnaire)
                    .HasForeignKey(d => d.Qid)
                    .HasConstraintName("FK_Patient_Questionnaire_Questionnaire");
            });

            modelBuilder.Entity<PatientType>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.HasKey(e => e.Staffid);

                entity.HasIndex(e => e.IdentificationModeid);

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.Designationid).HasColumnName("designationid");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencycontact)
                    .HasColumnName("emergencycontact")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Emergencyphone)
                    .HasColumnName("emergencyphone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Homephone)
                    .HasColumnName("homephone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobilephone)
                    .HasColumnName("mobilephone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasColumnName("password");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Titleid).HasColumnName("titleid");

                entity.Property(e => e.Username).HasColumnName("username");

                entity.Property(e => e.Workphone)
                    .HasColumnName("workphone")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Personnel_Department");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.Designationid)
                    .HasConstraintName("FK_Personnel_Designation");

                entity.HasOne(d => d.IdentificationMode)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.IdentificationModeid);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_personnel_accountmanager");

                entity.HasOne(d => d.Title)
                    .WithMany(p => p.Personnel)
                    .HasForeignKey(d => d.Titleid)
                    .HasConstraintName("FK_Personnel_Title");
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Image).HasColumnName("image");

                entity.Property(e => e.Issynced).HasColumnName("issynced");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SyncAt)
                    .HasColumnName("sync_at")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_photo_enrollee");
            });

            modelBuilder.Entity<Plan>(entity =>
            {
                entity.ToTable("plan");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Problem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Problem1)
                    .HasColumnName("problem")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Procedure>(entity =>
            {
                entity.ToTable("procedure");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.Genderconstraint).HasColumnName("genderconstraint");

                entity.Property(e => e.Procedurecatid).HasColumnName("procedurecatid");

                entity.Property(e => e.Procedurecode).HasColumnName("procedurecode");

                entity.Property(e => e.Procedurename).HasColumnName("procedurename");

                entity.Property(e => e.Procedurepa).HasColumnName("procedurepa");

                entity.Property(e => e.Procedurepp).HasColumnName("procedurepp");

                entity.Property(e => e.Procedurepr).HasColumnName("procedurepr");

                entity.Property(e => e.Procedurereferral).HasColumnName("procedurereferral");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Procedure)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_procedure_accountmanager");
            });

            modelBuilder.Entity<ProcedurePricelist>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Hmoid).HasColumnName("hmoid");

                entity.Property(e => e.Price)
                    .IsRequired()
                    .HasColumnName("price")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Procedurename)
                    .IsRequired()
                    .HasColumnName("procedurename");
            });

            modelBuilder.Entity<ProcedureUtilization>(entity =>
            {
                entity.ToTable("procedure_utilization");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiagnosisId).HasColumnName("DiagnosisID");

                entity.Property(e => e.Isclaimsgenerated)
                    .HasColumnName("isclaimsgenerated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paymenttype).HasColumnName("paymenttype");

                entity.Property(e => e.ProcedureId).HasColumnName("ProcedureID");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.ProcedureUtilization)
                    .HasForeignKey(d => d.DiagnosisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_procedure_utilization_diagnosis_utilization");

                entity.HasOne(d => d.Procedure)
                    .WithMany(p => p.ProcedureUtilization)
                    .HasForeignKey(d => d.ProcedureId)
                    .HasConstraintName("FK_procedure_utilization_procedure");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.ToTable("provider");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accountnumber).HasColumnName("accountnumber");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Contactemail).HasColumnName("contactemail");

                entity.Property(e => e.Contactname).HasColumnName("contactname");

                entity.Property(e => e.Contactphone).HasColumnName("contactphone");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hmoproviderid).HasColumnName("hmoproviderid");

                entity.Property(e => e.Isreferral).HasColumnName("isreferral");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Network).HasColumnName("network");

                entity.Property(e => e.Tin).HasColumnName("tin");
            });

            modelBuilder.Entity<ProviderChange>(entity =>
            {
                entity.ToTable("provider_change");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EnrolleeId).HasColumnName("enrolleeID");

                entity.Property(e => e.Issynced).HasColumnName("issynced");

                entity.Property(e => e.Oldprovider).HasColumnName("oldprovider");

                entity.Property(e => e.Providereffectivedate)
                    .HasColumnName("providereffectivedate")
                    .HasColumnType("date");

                entity.Property(e => e.Providerterminationdate)
                    .HasColumnName("providerterminationdate")
                    .HasColumnType("date");

                entity.Property(e => e.Reason).HasColumnName("reason");

                entity.Property(e => e.Sequence).HasColumnName("sequence");

                entity.Property(e => e.SyncedAt)
                    .HasColumnName("synced_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Enrollee)
                    .WithMany(p => p.ProviderChange)
                    .HasForeignKey(d => d.EnrolleeId)
                    .HasConstraintName("FK_provider_change_enrollee");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProviderChange)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_provider_change_user");
            });

            modelBuilder.Entity<ProviderNetwork>(entity =>
            {
                entity.HasKey(e => new { e.Providerid, e.Networkid });

                entity.ToTable("provider_network");

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.Networkid).HasColumnName("networkid");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ProviderNetwork)
                    .HasForeignKey(d => d.Providerid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_provider_network_provider");
            });

            modelBuilder.Entity<ProviderSchedule>(entity =>
            {
                entity.HasKey(e => e.Provschid)
                    .HasName("PK__Provider__0EF5CA8BD8860088");

                entity.Property(e => e.Provschid).HasColumnName("provschid");

                entity.Property(e => e.Adjuster)
                    .IsRequired()
                    .HasColumnName("adjuster")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasColumnName("days")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Endtime)
                    .IsRequired()
                    .HasColumnName("endtime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Provid).HasColumnName("provid");

                entity.Property(e => e.Specid).HasColumnName("specid");

                entity.Property(e => e.Starttime)
                    .IsRequired()
                    .HasColumnName("starttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProviderSchedule)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__ProviderS__locat__24885067");

                entity.HasOne(d => d.Prov)
                    .WithMany(p => p.ProviderSchedule)
                    .HasForeignKey(d => d.Provid)
                    .HasConstraintName("FK__ProviderS__provi__267098D9");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.ProviderSchedule)
                    .HasForeignKey(d => d.Specid)
                    .HasConstraintName("FK__ProviderS__speci__257C74A0");
            });

            modelBuilder.Entity<QuestionCategory>(entity =>
            {
                entity.HasKey(e => e.Qcatid);

                entity.Property(e => e.Qcatid).HasColumnName("qcatid");

                entity.Property(e => e.Categoryname)
                    .HasColumnName("categoryname")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Questionnaire>(entity =>
            {
                entity.HasKey(e => e.Qid);

                entity.Property(e => e.Qid).HasColumnName("qid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Question)
                    .HasColumnName("question")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Questioncategoryid).HasColumnName("questioncategoryid");

                entity.HasOne(d => d.Questioncategory)
                    .WithMany(p => p.Questionnaire)
                    .HasForeignKey(d => d.Questioncategoryid)
                    .HasConstraintName("FK_Questionnaire_QuestionCategory");
            });

            modelBuilder.Entity<QueueManager>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.Property(e => e.ListId).HasColumnName("listID");

                entity.Property(e => e.Benpackageid).HasColumnName("benpackageid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.FromPersonnelid).HasColumnName("fromPersonnelid");

                entity.Property(e => e.IsRemoved).HasColumnName("isRemoved");

                entity.Property(e => e.IsSeen).HasColumnName("isSeen");

                entity.Property(e => e.Isflagged).HasColumnName("isflagged");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.RemovedBy).HasColumnName("removedBy");

                entity.Property(e => e.ToPersonnelid).HasColumnName("toPersonnelid");

                entity.HasOne(d => d.Benpackage)
                    .WithMany(p => p.QueueManager)
                    .HasForeignKey(d => d.Benpackageid)
                    .HasConstraintName("FK_QueueManager_BenefitPackage");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.QueueManager)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_QueueManager_Department");

                entity.HasOne(d => d.FromPersonnel)
                    .WithMany(p => p.QueueManagerFromPersonnel)
                    .HasForeignKey(d => d.FromPersonnelid)
                    .HasConstraintName("FK_QueueManager_Personnel");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.QueueManager)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_QueueManager_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.QueueManager)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_queuemgr_accountmanager");

                entity.HasOne(d => d.RemovedByNavigation)
                    .WithMany(p => p.QueueManagerRemovedByNavigation)
                    .HasForeignKey(d => d.RemovedBy)
                    .HasConstraintName("FK_QueueManager_Personnel1");

                entity.HasOne(d => d.ToPersonnel)
                    .WithMany(p => p.QueueManagerToPersonnel)
                    .HasForeignKey(d => d.ToPersonnelid)
                    .HasConstraintName("FK_QueueManager_Personnel2");
            });

            modelBuilder.Entity<ReceivingStore>(entity =>
            {
                entity.Property(e => e.Receivingstoreid)
                    .HasColumnName("receivingstoreid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Storedescription)
                    .HasColumnName("storedescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Storename)
                    .HasColumnName("storename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ReceivingStore)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_recvstore_accountmanager");
            });

            modelBuilder.Entity<ReferenceMaterial>(entity =>
            {
                entity.ToTable("Reference_Material");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Filepath)
                    .IsRequired()
                    .HasColumnName("filepath");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Title).HasColumnName("title");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.ReferenceMaterial)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_Reference_Material_Patient");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ReferenceMaterial)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_Material_AccountManager");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.HasKey(e => e.Refid);

                entity.Property(e => e.Refid).HasColumnName("refid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reftype)
                    .HasColumnName("reftype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Renewal>(entity =>
            {
                entity.ToTable("renewal");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amountdue)
                    .HasColumnName("amountdue")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Amountpaid)
                    .HasColumnName("amountpaid")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Contractnum).HasColumnName("contractnum");

                entity.Property(e => e.Coverageenddate)
                    .HasColumnName("coverageenddate")
                    .HasColumnType("date");

                entity.Property(e => e.Coveragestatedate)
                    .HasColumnName("coveragestatedate")
                    .HasColumnType("date");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Enrolleeid).HasColumnName("enrolleeid");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Isexpires).HasColumnName("isexpires");

                entity.Property(e => e.Issynced).HasColumnName("issynced");

                entity.Property(e => e.Mutation).HasColumnName("mutation");

                entity.Property(e => e.Paymentstatus).HasColumnName("paymentstatus");

                entity.Property(e => e.Reasonfortermination).HasColumnName("reasonfortermination");

                entity.Property(e => e.Receiptnum).HasColumnName("receiptnum");

                entity.Property(e => e.SyncedAt)
                    .HasColumnName("synced_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Syncid)
                    .HasColumnName("syncid")
                    .HasMaxLength(50);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Enrollee)
                    .WithMany(p => p.Renewal)
                    .HasForeignKey(d => d.Enrolleeid)
                    .HasConstraintName("FK_renewal_enrollee");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Renewal)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_renewal_user");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Roledescription)
                    .HasColumnName("roledescription")
                    .IsUnicode(false);

                entity.Property(e => e.Rolename)
                    .HasColumnName("rolename")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Role)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_role_accountmanager");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Deptid).HasColumnName("deptid");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Servicecode)
                    .HasColumnName("servicecode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Servicedesc)
                    .HasColumnName("servicedesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.Deptid)
                    .HasConstraintName("FK_Service_Department");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_service_accountmanager");

                entity.HasOne(d => d.Servicetype)
                    .WithMany(p => p.Service)
                    .HasForeignKey(d => d.Servicetypeid)
                    .HasConstraintName("FK_Service_ServiceType");
            });

            modelBuilder.Entity<ServiceTariff>(entity =>
            {
                entity.HasKey(e => e.Servtariffid);

                entity.ToTable("Service_Tariff");

                entity.Property(e => e.Servtariffid).HasColumnName("servtariffid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Serviceid).HasColumnName("serviceid");

                entity.Property(e => e.Tariffamount).HasColumnName("tariffamount");

                entity.Property(e => e.Tariffid).HasColumnName("tariffid");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.ServiceTariff)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_servicetariff_accountmanager");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.ServiceTariff)
                    .HasForeignKey(d => d.Serviceid)
                    .HasConstraintName("FK_Service_Tariff_Service");

                entity.HasOne(d => d.Tariff)
                    .WithMany(p => p.ServiceTariff)
                    .HasForeignKey(d => d.Tariffid)
                    .HasConstraintName("FK_Service_Tariff_Tariff");
            });

            modelBuilder.Entity<ServiceType>(entity =>
            {
                entity.Property(e => e.Servicetypeid).HasColumnName("servicetypeid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Servicetypedesc)
                    .HasColumnName("servicetypedesc")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Specialization>(entity =>
            {
                entity.HasKey(e => e.Specid)
                    .HasName("PK__Speciali__72C1C97BF664F5C7");

                entity.Property(e => e.Specid).HasColumnName("specid");
                entity.Property(e => e.alternatecode).HasColumnName("alternatecode");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Specname)
                    .IsRequired()
                    .HasColumnName("specname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Specialization)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__Specializ__locat__172E5549");
            });

            modelBuilder.Entity<SpecializationSchedule>(entity =>
            {
                entity.HasKey(e => e.Specschid)
                    .HasName("PK__Speciali__3A71E2D82A4295DC");

                entity.Property(e => e.Specschid).HasColumnName("specschid");

                entity.Property(e => e.Adjuster)
                    .IsRequired()
                    .HasColumnName("adjuster")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Days)
                    .IsRequired()
                    .HasColumnName("days")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Endtime)
                    .IsRequired()
                    .HasColumnName("endtime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Specid).HasColumnName("specid");

                entity.Property(e => e.Starttime)
                    .IsRequired()
                    .HasColumnName("starttime")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SpecializationSchedule)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("FK__Specializ__locat__1A0AC1F4");

                entity.HasOne(d => d.Spec)
                    .WithMany(p => p.SpecializationSchedule)
                    .HasForeignKey(d => d.Specid)
                    .HasConstraintName("FK__Specializ__speci__1AFEE62D");
            });

            modelBuilder.Entity<Sponsor>(entity =>
            {
                entity.HasKey(e => e.Sponsid);

                entity.Property(e => e.Sponsid).HasColumnName("sponsid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Sponsortype)
                    .HasColumnName("sponsortype")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.Property(e => e.Stateid).HasColumnName("stateid");

                entity.Property(e => e.Countryid).HasColumnName("countryid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Statename)
                    .HasColumnName("statename")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.State)
                    .HasForeignKey(d => d.Countryid)
                    .HasConstraintName("FK_State_country");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.Property(e => e.Supplierid).HasColumnName("supplierid");

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.Bankaccountno)
                    .HasColumnName("bankaccountno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Bankname)
                    .HasColumnName("bankname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Contactname)
                    .HasColumnName("contactname")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Phone1)
                    .HasColumnName("phone1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone2)
                    .HasColumnName("phone2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.Specialty)
                    .HasColumnName("specialty")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Suppliername)
                    .HasColumnName("suppliername")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Suppliertypeid).HasColumnName("suppliertypeid");

                entity.Property(e => e.Website)
                    .HasColumnName("website")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.Providerid)
                    .HasConstraintName("FK_Supplier_provider");

                entity.HasOne(d => d.Suppliertype)
                    .WithMany(p => p.Supplier)
                    .HasForeignKey(d => d.Suppliertypeid)
                    .HasConstraintName("fk_supplier_type");
            });

            modelBuilder.Entity<SupplierType>(entity =>
            {
                entity.Property(e => e.Suppliertypeid).HasColumnName("suppliertypeid");

                entity.Property(e => e.Comments)
                    .HasColumnName("comments")
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Supplierdesc)
                    .HasColumnName("supplierdesc")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<CheckIn>(entity =>
            {
                entity.HasKey(e => e.Encounterid)
                    .HasName("PK__Checke__3A71E2D82A4295FC");

                entity.Property(e => e.Encounterid).HasColumnName("encounterId");

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("checkindate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("checkoutdate")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Patient)
                   .WithMany(p => p.CheckIn)
                   .HasForeignKey(d => d.Patientid)
                   .HasConstraintName("FK_CheckIn_Patient");

                entity.HasOne(d => d.Location)
                   .WithMany(p => p.CheckIn)
                   .HasForeignKey(d => d.Locationid)
                   .HasConstraintName("FK_CheckIn_Location");

                entity.HasOne(d => d.AccountManager)
                   .WithMany(p => p.CheckIn)
                   .HasForeignKey(d => d.ProviderId)
                   .HasConstraintName("FK_CheckIn_Patient_Account");

                entity.Property(e => e.IsCheckedIn)
                    .HasColumnName("ischeckedin")
                    .HasColumnType("bit");
                
                entity.Property(e => e.IsCheckedOut)
                    .HasColumnName("ischeckedout")
                    .HasColumnType("bit");

            });

            modelBuilder.Entity<PatientQueue>(entity =>
            {
                entity.HasKey(e => e.PatientQueueId);
                
                entity.HasOne(d => d.Patient)
                   .WithMany(p => p.PatientQueue)
                   .HasForeignKey(d => d.PatientId)
                   .HasConstraintName("FK_PatientQueue_Patient");
                
                entity.HasOne(d => d.HospitalUnit)
                   .WithMany(p => p.PatientQueue)
                   .HasForeignKey(d => d.HospitalUnitId)
                   .HasConstraintName("FK_PatientQueue_HospitalUnit");

                entity.HasOne(d => d.Location)
                   .WithMany(p => p.PatientQueue)
                   .HasForeignKey(d => d.LocationId)
                   .HasConstraintName("FK_PatientQueue_Location");

                entity.HasOne(d => d.AccountManager)
                   .WithMany(p => p.PatientQueue)
                   .HasForeignKey(d => d.AccountId)
                   .HasConstraintName("FK_PatientQueue_Account");
            });
            
            modelBuilder.Entity<HospitalUnit>(entity =>
            {
                entity.HasKey(e => e.HospitalUnitId);
            });
            
            modelBuilder.Entity<PaRequest>(entity =>
            {
                entity.HasKey(e => e.PARequestId);

                entity.HasOne(d => d.Patient)
                   .WithMany(p => p.PaRequest)
                   .HasForeignKey(d => d.PatientId)
                   .HasConstraintName("FK_PaRequest_Patient");

                entity.HasOne(d => d.Location)
                   .WithMany(p => p.PaRequest)
                   .HasForeignKey(d => d.LocationId)
                   .HasConstraintName("FK_PaRequest_Location");

                entity.HasOne(d => d.AccountManager)
                   .WithMany(p => p.PaRequest)
                   .HasForeignKey(d => d.AccountId)
                   .HasConstraintName("FK_PaRequest_Account");
            });

            modelBuilder.Entity<Tariff>(entity =>
            {
                entity.Property(e => e.Tariffid).HasColumnName("tariffid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expirydate)
                    .HasColumnName("expirydate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.Tariffdesc)
                    .HasColumnName("tariffdesc")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Tariffname)
                    .HasColumnName("tariffname")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Tariff)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_tariff_accountmanager");
            });

            modelBuilder.Entity<Temp>(entity =>
            {
                entity.HasKey(e => e.DiagnosisCode);

                entity.ToTable("temp");

                entity.Property(e => e.DiagnosisCode)
                    .HasColumnName("DIAGNOSIS CODE")
                    .HasMaxLength(255);

                entity.Property(e => e.LongDescription)
                    .HasColumnName("LONG DESCRIPTION")
                    .HasMaxLength(255);

                entity.Property(e => e.NfExcl)
                    .HasColumnName("NF EXCL")
                    .HasMaxLength(255);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("SHORT DESCRIPTION")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TemplateAllergies>(entity =>
            {
                entity.ToTable("template_allergies");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Allergies)
                    .HasColumnName("allergies")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateArvdrugs>(entity =>
            {
                entity.ToTable("template_arvdrugs");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Adherence)
                    .HasColumnName("adherence")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Otherspleasespecify)
                    .HasColumnName("otherspleasespecify")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Regimen)
                    .HasColumnName("regimen")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Whypoorfairadherence1)
                    .HasColumnName("whypoorfairadherence1")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateBiodata>(entity =>
            {
                entity.ToTable("template_biodata");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Columns)
                    .HasColumnName("columns")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Columns1)
                    .HasColumnName("columns1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dateofbirth)
                    .HasColumnName("dateofbirth")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hospitalnumber)
                    .HasColumnName("hospitalnumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientname)
                    .HasColumnName("patientname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateBloodgasanalysisform>(entity =>
            {
                entity.ToTable("template_bloodgasanalysisform");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Angap)
                    .HasColumnName("angap")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Beecf)
                    .HasColumnName("beecf")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Bun)
                    .HasColumnName("bun")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cl)
                    .HasColumnName("cl")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Glu)
                    .HasColumnName("glu")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hb)
                    .HasColumnName("hb")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hco3)
                    .HasColumnName("hco3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Hct)
                    .HasColumnName("hct")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.K)
                    .HasColumnName("k")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lac)
                    .HasColumnName("lac")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Na)
                    .HasColumnName("na")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pco2)
                    .HasColumnName("pco2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ph)
                    .HasColumnName("ph")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Po2)
                    .HasColumnName("po2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Po2fio2)
                    .HasColumnName("po2fio2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Sampletype)
                    .HasColumnName("sampletype")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.So2)
                    .HasColumnName("so2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tco2)
                    .HasColumnName("tco2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateBloodsugar>(entity =>
            {
                entity.ToTable("template_bloodsugar");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Bloodsugar)
                    .HasColumnName("bloodsugar")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateCapturevitals>(entity =>
            {
                entity.ToTable("template_capturevitals");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientnumber)
                    .HasColumnName("patientnumber")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateCategory>(entity =>
            {
                entity.HasKey(e => e.Tempcatid);

                entity.Property(e => e.Tempcatid).HasColumnName("tempcatid");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Categoryname)
                    .HasColumnName("categoryname")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Specializationid).HasColumnName("specializationid");
            });

            modelBuilder.Entity<TemplateChromeform>(entity =>
            {
                entity.ToTable("template_chromeform");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateChromiumform>(entity =>
            {
                entity.ToTable("template_chromiumform");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateConsultantincharge>(entity =>
            {
                entity.ToTable("template_consultantincharge");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Consultantincharge)
                    .HasColumnName("consultantincharge")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateCotrimoxazole>(entity =>
            {
                entity.ToTable("template_cotrimoxazole");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Adherence)
                    .HasColumnName("adherence")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Afraidaffectedbysideeffect)
                    .HasColumnName("afraidaffectedbysideeffect")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Busyworkingathome)
                    .HasColumnName("busyworkingathome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Changeinroutineawayfromhome)
                    .HasColumnName("changeinroutineawayfromhome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Didnotunderstandhowtotakemedications)
                    .HasColumnName("didnotunderstandhowtotakemedications")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Didnotwantotherstoknow)
                    .HasColumnName("didnotwantotherstoknow")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Didnotwanttotakemedications)
                    .HasColumnName("didnotwanttotakemedications")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Drugstockout)
                    .HasColumnName("drugstockout")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fellasleepsleptthroughdose)
                    .HasColumnName("fellasleepsleptthroughdose")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Feltoverwhelmeddepressed)
                    .HasColumnName("feltoverwhelmeddepressed")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Feltsickwell)
                    .HasColumnName("feltsickwell")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Feltwell)
                    .HasColumnName("feltwell")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Forgot)
                    .HasColumnName("forgot")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gotpregnancy)
                    .HasColumnName("gotpregnancy")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Notabletopay)
                    .HasColumnName("notabletopay")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Others)
                    .HasColumnName("others")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otherspleasespecify)
                    .HasColumnName("otherspleasespecify")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientmoved)
                    .HasColumnName("patientmoved")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ranoutofmedication)
                    .HasColumnName("ranoutofmedication")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Toomanypills)
                    .HasColumnName("toomanypills")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateDiagnosisanddifferentials>(entity =>
            {
                entity.ToTable("template_diagnosisanddifferentials");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Diagnosisanddifferentials)
                    .HasColumnName("diagnosisanddifferentials")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateDietorder>(entity =>
            {
                entity.ToTable("template_dietorder");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Whatdietshouldthepatientbeplacedonkindlyinformthenurses)
                    .HasColumnName("whatdietshouldthepatientbeplacedonkindlyinformthenurses")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateDischargeplanning>(entity =>
            {
                entity.ToTable("template_dischargeplanning");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Columns)
                    .HasColumnName("columns")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Otherproblemsidentifiedassessmentandplandischargeplanning)
                    .HasColumnName("otherproblemsidentifiedassessmentandplandischargeplanning")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Socialsupportneededathome)
                    .HasColumnName("socialsupportneededathome")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateExpectedoutcomesofcare>(entity =>
            {
                entity.ToTable("template_expectedoutcomesofcare");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Expectedoutcomeofcare)
                    .HasColumnName("expectedoutcomeofcare")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateInn>(entity =>
            {
                entity.ToTable("template_inn");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Adherence)
                    .HasColumnName("adherence")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Afraidaffectedbysideeffect)
                    .HasColumnName("afraidaffectedbysideeffect")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Busyworkingatschool)
                    .HasColumnName("busyworkingatschool")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Changeinroutineawayfromhome)
                    .HasColumnName("changeinroutineawayfromhome")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Didnotunderstandhowtotakemedication)
                    .HasColumnName("didnotunderstandhowtotakemedication")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Didnotwantotherstoknow)
                    .HasColumnName("didnotwantotherstoknow")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Didnotwanttotakemedications)
                    .HasColumnName("didnotwanttotakemedications")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dose)
                    .HasColumnName("dose")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Drugstockout)
                    .HasColumnName("drugstockout")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fellasleepsleptthroughdose)
                    .HasColumnName("fellasleepsleptthroughdose")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Feltoverwhelmeddepressed)
                    .HasColumnName("feltoverwhelmeddepressed")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Feltsickbad)
                    .HasColumnName("feltsickbad")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Feltwell)
                    .HasColumnName("feltwell")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gotpregnant)
                    .HasColumnName("gotpregnant")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iforgot)
                    .HasColumnName("iforgot")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Notabletopay)
                    .HasColumnName("notabletopay")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otherspleasespecify)
                    .HasColumnName("otherspleasespecify")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientmoved)
                    .HasColumnName("patientmoved")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ranoutofmedication)
                    .HasColumnName("ranoutofmedication")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Toomanypills)
                    .HasColumnName("toomanypills")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateInpatientform>(entity =>
            {
                entity.ToTable("template_inpatientform");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Columns)
                    .HasColumnName("columns")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientno)
                    .HasColumnName("patientno")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Payertype)
                    .HasColumnName("payertype")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateInvestigation>(entity =>
            {
                entity.ToTable("template_investigation");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Investigation)
                    .HasColumnName("investigation")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateLaboratory>(entity =>
            {
                entity.ToTable("template_laboratory");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Biochemicaldatalaboratorytestandprocedure)
                    .HasColumnName("biochemicaldatalaboratorytestandprocedure")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Foodnutritionrelatedhistory2472hoursdietaryrecall)
                    .HasColumnName("foodnutritionrelatedhistory2472hoursdietaryrecall")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Glands)
                    .HasColumnName("glands")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Nutritiondiagnosis)
                    .HasColumnName("nutritiondiagnosis")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nutritionintervention)
                    .HasColumnName("nutritionintervention")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tongue)
                    .HasColumnName("tongue")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateLaboratory1>(entity =>
            {
                entity.ToTable("template_laboratory1");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Columns)
                    .HasColumnName("columns")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Coordinationofnutritioncare)
                    .HasColumnName("coordinationofnutritioncare")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Nutritioncounselling)
                    .HasColumnName("nutritioncounselling")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nutritioneducaion)
                    .HasColumnName("nutritioneducaion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateMaster>(entity =>
            {
                entity.HasKey(e => e.Masterid);

                entity.Property(e => e.Masterid).HasColumnName("masterid");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Adjusterid).HasColumnName("adjusterid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Formcomments)
                    .HasColumnName("formcomments")
                    .HasColumnType("text");

                entity.Property(e => e.Formdescription)
                    .HasColumnName("formdescription")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Formname)
                    .HasColumnName("formname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Iscurrent).HasColumnName("iscurrent");

                entity.Property(e => e.Jsonform)
                    .HasColumnName("jsonform")
                    .HasColumnType("text");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Tempcatid).HasColumnName("tempcatid");
            });

            modelBuilder.Entity<TemplateMedicalofficerandcarecoordinator>(entity =>
            {
                entity.ToTable("template_medicalofficerandcarecoordinator");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Datetime)
                    .HasColumnName("datetime")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Signature)
                    .HasColumnName("signature")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Time)
                    .HasColumnName("time")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateMinivitals>(entity =>
            {
                entity.ToTable("template_minivitals");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Pulse)
                    .HasColumnName("pulse")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Temperature)
                    .HasColumnName("temperature")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateNeuro>(entity =>
            {
                entity.ToTable("template_neuro");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Findings)
                    .HasColumnName("findings")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateNeurologic>(entity =>
            {
                entity.ToTable("template_neurologic");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Examinationfindings)
                    .HasColumnName("examinationfindings")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateOtherdetails>(entity =>
            {
                entity.ToTable("template_otherdetails");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Consulthospitalizereferlink)
                    .HasColumnName("consulthospitalizereferlink")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Nextappointmentdata)
                    .HasColumnName("nextappointmentdata")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otherdrugsprescribed)
                    .HasColumnName("otherdrugsprescribed")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Othertestdone)
                    .HasColumnName("othertestdone")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateOthermodification>(entity =>
            {
                entity.ToTable("template_othermodification");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Othermodification)
                    .HasColumnName("othermodification")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePainassestmentscale>(entity =>
            {
                entity.ToTable("template_painassestmentscale");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Painscore)
                    .HasColumnName("painscore")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePastobstericform>(entity =>
            {
                entity.ToTable("template_pastobstericform");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Alive)
                    .HasColumnName("alive")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Gravidity)
                    .HasColumnName("gravidity")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Miscarriage)
                    .HasColumnName("miscarriage")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Para)
                    .HasColumnName("para")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePatientdetails>(entity =>
            {
                entity.ToTable("template_patientdetails");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Edd)
                    .HasColumnName("edd")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Familyplanningwritecode)
                    .HasColumnName("familyplanningwritecode")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Functionalstatus)
                    .HasColumnName("functionalstatus")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Otheroisproblem)
                    .HasColumnName("otheroisproblem")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pregnancybreastfeedingstatus)
                    .HasColumnName("pregnancybreastfeedingstatus")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tbstatus)
                    .HasColumnName("tbstatus")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Whoclinicalstage)
                    .HasColumnName("whoclinicalstage")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePatientinformation>(entity =>
            {
                entity.ToTable("template_patientinformation");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePresentingcomplaintsandhistoryofpresentillness>(entity =>
            {
                entity.ToTable("template_presentingcomplaintsandhistoryofpresentillness");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Presentingcomplaintsandhistoryofpresentillness)
                    .HasColumnName("presentingcomplaintsandhistoryofpresentillness")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePrimaryexaminationdetails>(entity =>
            {
                entity.ToTable("template_primaryexaminationdetails");

                entity.Property(e => e.Abdomen)
                    .HasColumnName("abdomen")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Breasts)
                    .HasColumnName("breasts")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Chest)
                    .HasColumnName("chest")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cns)
                    .HasColumnName("cns")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cvs)
                    .HasColumnName("cvs")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Generalcondition)
                    .HasColumnName("generalcondition")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Mss)
                    .HasColumnName("mss")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Otherrelevantabnormalities)
                    .HasColumnName("otherrelevantabnormalities")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pelvis)
                    .HasColumnName("pelvis")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplatePsychological>(entity =>
            {
                entity.ToTable("template_psychological");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Angry)
                    .HasColumnName("angry")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Anxious)
                    .HasColumnName("anxious")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Columns)
                    .HasColumnName("columns")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Columns1)
                    .HasColumnName("columns1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Homicidal)
                    .HasColumnName("homicidal")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Normal)
                    .HasColumnName("normal")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Other)
                    .HasColumnName("other")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Radio1)
                    .HasColumnName("radio1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Suicidal)
                    .HasColumnName("suicidal")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateResultsofpreviousinvestigationdone>(entity =>
            {
                entity.ToTable("template_resultsofpreviousinvestigationdone");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Results)
                    .HasColumnName("results")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateSurgeryform>(entity =>
            {
                entity.ToTable("template_surgeryform");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Locationid).HasColumnName("locationid");
            });

            modelBuilder.Entity<TemplateTreatmentmanagementplan>(entity =>
            {
                entity.ToTable("template_treatmentmanagementplan");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Treatmentmanagementplan)
                    .HasColumnName("treatmentmanagementplan")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateUrinalysis>(entity =>
            {
                entity.ToTable("template_urinalysis");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Urinalysis)
                    .HasColumnName("urinalysis")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TemplateVitals>(entity =>
            {
                entity.ToTable("template_vitals");

                entity.Property(e => e.Accountid).HasColumnName("accountid");

                entity.Property(e => e.Dateadded)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Submit)
                    .HasColumnName("submit")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vitals)
                    .HasColumnName("vitals")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Title>(entity =>
            {
                entity.Property(e => e.Titleid).HasColumnName("titleid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Titlename)
                    .HasColumnName("titlename")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Transportation>(entity =>
            {
                entity.ToTable("transportation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cost)
                    .HasColumnName("cost")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DiagnosisId).HasColumnName("diagnosisID");

                entity.Property(e => e.Isclaimsgenerated)
                    .HasColumnName("isclaimsgenerated")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Preauth).HasColumnName("preauth");

                entity.HasOne(d => d.Diagnosis)
                    .WithMany(p => p.Transportation)
                    .HasForeignKey(d => d.DiagnosisId)
                    .HasConstraintName("FK_transportation_diagnosis_utilization");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdU);

                entity.ToTable("user");

                entity.Property(e => e.IdU).HasColumnName("ID_u");

                entity.Property(e => e.Addressline1U)
                    .HasColumnName("addressline1_u")
                    .IsUnicode(false);

                entity.Property(e => e.Addressline2U)
                    .HasColumnName("addressline2_u")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Departmetid).HasColumnName("departmetid");

                entity.Property(e => e.DobU)
                    .HasColumnName("dob_u")
                    .HasColumnType("date");

                entity.Property(e => e.EmailU)
                    .HasColumnName("email_u")
                    .IsUnicode(false);

                entity.Property(e => e.FirstnameU)
                    .HasColumnName("firstname_u")
                    .IsUnicode(false);

                entity.Property(e => e.GenderU)
                    .HasColumnName("gender_u")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastnameU)
                    .HasColumnName("lastname_u")
                    .IsUnicode(false);

                entity.Property(e => e.OthernameU)
                    .HasColumnName("othername_u")
                    .IsUnicode(false);

                entity.Property(e => e.PasswordU)
                    .HasColumnName("password_u")
                    .IsUnicode(false);

                entity.Property(e => e.PhoneU)
                    .HasColumnName("phone_u")
                    .IsUnicode(false);

                entity.Property(e => e.Providerid).HasColumnName("providerid");

                entity.Property(e => e.TitleU).HasColumnName("title_u");

                entity.Property(e => e.UsernameU)
                    .HasColumnName("username_u")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserLocation>(entity =>
            {
                entity.ToTable("User_Location");

                entity.Property(e => e.Userlocationid).HasColumnName("userlocationid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Locationid).HasColumnName("locationid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.UserLocation)
                    .HasForeignKey(d => d.Locationid)
                    .HasConstraintName("Location_User_Location");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLocation)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("AppUser_User_Location");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("User_Role");

                entity.Property(e => e.Userroleid).HasColumnName("userroleid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Permission)
                    .HasColumnName("permission")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.Roleid)
                    .HasConstraintName("Role_User_Role");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRole)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("AppUser_User_Role");
            });

            modelBuilder.Entity<Utilization>(entity =>
            {
                entity.ToTable("utilization");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bloodpressure).HasColumnName("bloodpressure");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateDied)
                    .HasColumnName("dateDied")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiagnosisId).HasColumnName("diagnosisID");

                entity.Property(e => e.Dischargeddate)
                    .HasColumnName("dischargeddate")
                    .HasColumnType("date");

                entity.Property(e => e.Encounterdate)
                    .HasColumnName("encounterdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Enrolleeid).HasColumnName("enrolleeid");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.IsNewBorn)
                    .HasColumnName("isNewBorn")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsReferred).HasColumnName("isReferred");

                entity.Property(e => e.Isinpatient).HasColumnName("isinpatient");

                entity.Property(e => e.Issynced)
                    .HasColumnName("issynced")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Isvisitscheduled)
                    .HasColumnName("isvisitscheduled")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Note)
                    .HasColumnName("note")
                    .HasColumnType("text");

                entity.Property(e => e.Pulse).HasColumnName("pulse");

                entity.Property(e => e.ReferredFrom).HasColumnName("referredFrom");

                entity.Property(e => e.ReferredTo).HasColumnName("referredTo");

                entity.Property(e => e.Respiration).HasColumnName("respiration");

                entity.Property(e => e.SyncAt)
                    .HasColumnName("sync_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Temprature).HasColumnName("temprature");

                entity.Property(e => e.TestingDoctor).HasColumnName("testingDoctor");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.VisiType).HasColumnName("visiType");

                entity.Property(e => e.VisitInfoEncounterDate)
                    .HasColumnName("visitInfoEncounterDate")
                    .HasColumnType("date");

                entity.Property(e => e.Visitoutcome).HasColumnName("visitoutcome");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Enrollee)
                    .WithMany(p => p.Utilization)
                    .HasForeignKey(d => d.Enrolleeid)
                    .HasConstraintName("FK_utilization_enrollee");

                entity.HasOne(d => d.ReferredFromNavigation)
                    .WithMany(p => p.UtilizationReferredFromNavigation)
                    .HasForeignKey(d => d.ReferredFrom)
                    .HasConstraintName("FK_utilization_provider");

                entity.HasOne(d => d.ReferredToNavigation)
                    .WithMany(p => p.UtilizationReferredToNavigation)
                    .HasForeignKey(d => d.ReferredTo)
                    .HasConstraintName("FK_utilization_provider1");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Utilization)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_utilization_user");
            });

            modelBuilder.Entity<VerificationLog>(entity =>
            {
                entity.ToTable("Verification_Log");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Isseen)
                    .HasColumnName("isseen")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Issynced)
                    .HasColumnName("issynced")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mode)
                    .HasColumnName("mode")
                    .HasMaxLength(50);

                entity.Property(e => e.Patientid)
                    .HasColumnName("patientid")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.SyncAt)
                    .HasColumnName("sync_at")
                    .HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.VerificationLog)
                    .HasForeignKey(d => d.Patientid)
                    .HasConstraintName("FK_verification_log_enrollee");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.VerificationLog)
                    .HasForeignKey(d => d.ProviderId)
                    .HasConstraintName("fk_verificationlog_accountmanager");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.VerificationLog)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_verification_log_user");
            });

            modelBuilder.Entity<Ward>(entity =>
            {
                entity.Property(e => e.Wardid).HasColumnName("wardid");

                entity.Property(e => e.Dateadded)
                    .HasColumnName("dateadded")
                    .HasColumnType("datetime");

                entity.Property(e => e.Wardname)
                    .HasColumnName("wardname")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
