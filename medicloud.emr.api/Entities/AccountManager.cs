using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AccountManager
    {
        public AccountManager()
        {
            Admission = new HashSet<Admission>();
            AppUser = new HashSet<AppUser>();
            Asset = new HashSet<Asset>();
            AssetType = new HashSet<AssetType>();
            AssignedAsset = new HashSet<AssignedAsset>();
            AuditLog = new HashSet<AuditLog>();
            Bed = new HashSet<Bed>();
            Bill = new HashSet<Bill>();
            BillDetail = new HashSet<BillDetail>();
            BillPayable = new HashSet<BillPayable>();
            Biometric = new HashSet<Biometric>();
            BirthRegister = new HashSet<BirthRegister>();
            CaseNote = new HashSet<CaseNote>();
            CentralStore = new HashSet<CentralStore>();
            Claims = new HashSet<Claims>();
            Consultation = new HashSet<Consultation>();
            ConsultationCheck = new HashSet<ConsultationCheck>();
            ConsultationComplaints = new HashSet<ConsultationComplaints>();
            ConsultationDental = new HashSet<ConsultationDental>();
            ConsultationDentalProcedure = new HashSet<ConsultationDentalProcedure>();
            ConsultationDiagnosis = new HashSet<ConsultationDiagnosis>();
            ConsultationLaboratory = new HashSet<ConsultationLaboratory>();
            ConsultationOtherDiagnosis = new HashSet<ConsultationOtherDiagnosis>();
            ConsultationPrescription = new HashSet<ConsultationPrescription>();
            ConsultationProblem = new HashSet<ConsultationProblem>();
            ConsultationProcedure = new HashSet<ConsultationProcedure>();
            ConsultationRadiology = new HashSet<ConsultationRadiology>();
            ConsultationUtilization = new HashSet<ConsultationUtilization>();
            Department = new HashSet<Department>();
            Diagnosis = new HashSet<Diagnosis>();
            DispensingStore = new HashSet<DispensingStore>();
            Drug = new HashSet<Drug>();
            Enrollee = new HashSet<Enrollee>();
            EnrolleeType = new HashSet<EnrolleeType>();
            Fingerprint = new HashSet<Fingerprint>();
            HmoType = new HashSet<HmoType>();
            LicenseManager = new HashSet<LicenseManager>();
            Login = new HashSet<Login>();
            Messaging = new HashSet<Messaging>();
            Patient = new HashSet<Patient>();
            PatientMedicalHistory = new HashSet<PatientMedicalHistory>();
            PatientOrder = new HashSet<PatientOrder>();
            PatientQuestionnaire = new HashSet<PatientQuestionnaire>();
            Personnel = new HashSet<Personnel>();
            Procedure = new HashSet<Procedure>();
            QueueManager = new HashSet<QueueManager>();
            ReceivingStore = new HashSet<ReceivingStore>();
            ReferenceMaterial = new HashSet<ReferenceMaterial>();
            Role = new HashSet<Role>();
            Service = new HashSet<Service>();
            ServiceTariff = new HashSet<ServiceTariff>();
            Supplier = new HashSet<Supplier>();
            Tariff = new HashSet<Tariff>();
            VerificationLog = new HashSet<VerificationLog>();
            PatientQueue = new HashSet<PatientQueue>();
            CheckIn = new HashSet<CheckIn>();
            PaRequest = new HashSet<PaRequest>();
             DepartmentSub = new HashSet<DepartmentSub>();
            OrderPriority = new HashSet<OrderPriority>();
            DrugFormulary = new HashSet<DrugFormulary>();

        }


        public int ProviderId { get; set; }
        public Guid AccountId { get; set; }
        public string HospitalName { get; set; }
        public string HospitalAddress { get; set; }
        public string AdminEmail { get; set; }
        public string Password { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public int? Stateid { get; set; }
        public int? Countryid { get; set; }
        public DateTime? LogDate { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<Admission> Admission { get; set; }
        public virtual ICollection<AppUser> AppUser { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<AssetType> AssetType { get; set; }
        public virtual ICollection<AssignedAsset> AssignedAsset { get; set; }
        public virtual ICollection<AuditLog> AuditLog { get; set; }
        public virtual ICollection<Bed> Bed { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual ICollection<BillDetail> BillDetail { get; set; }
        public virtual ICollection<BillPayable> BillPayable { get; set; }
        public virtual ICollection<Biometric> Biometric { get; set; }
        public virtual ICollection<BirthRegister> BirthRegister { get; set; }
        public virtual ICollection<CaseNote> CaseNote { get; set; }
        public virtual ICollection<CentralStore> CentralStore { get; set; }
        public virtual ICollection<Claims> Claims { get; set; }
        public virtual ICollection<Consultation> Consultation { get; set; }
        public virtual ICollection<ConsultationCheck> ConsultationCheck { get; set; }
        public virtual ICollection<ConsultationComplaints> ConsultationComplaints { get; set; }
        public virtual ICollection<ConsultationDental> ConsultationDental { get; set; }
        public virtual ICollection<ConsultationDentalProcedure> ConsultationDentalProcedure { get; set; }
        public virtual ICollection<ConsultationDiagnosis> ConsultationDiagnosis { get; set; }
        public virtual ICollection<ConsultationLaboratory> ConsultationLaboratory { get; set; }
        public virtual ICollection<ConsultationOtherDiagnosis> ConsultationOtherDiagnosis { get; set; }
        public virtual ICollection<ConsultationPrescription> ConsultationPrescription { get; set; }
        public virtual ICollection<ConsultationProblem> ConsultationProblem { get; set; }
        public virtual ICollection<ConsultationProcedure> ConsultationProcedure { get; set; }
        public virtual ICollection<ConsultationRadiology> ConsultationRadiology { get; set; }
        public virtual ICollection<ConsultationUtilization> ConsultationUtilization { get; set; }
        public virtual ICollection<Department> Department { get; set; }
        public virtual ICollection<Diagnosis> Diagnosis { get; set; }
        public virtual ICollection<DispensingStore> DispensingStore { get; set; }
        public virtual ICollection<Drug> Drug { get; set; }
        public virtual ICollection<Enrollee> Enrollee { get; set; }
        public virtual ICollection<EnrolleeType> EnrolleeType { get; set; }
        public virtual ICollection<Fingerprint> Fingerprint { get; set; }
        public virtual ICollection<HmoType> HmoType { get; set; }
        public virtual ICollection<LicenseManager> LicenseManager { get; set; }
        public virtual ICollection<Login> Login { get; set; }
        public virtual ICollection<Messaging> Messaging { get; set; }
        public virtual ICollection<Patient> Patient { get; set; }
        public virtual ICollection<PatientMedicalHistory> PatientMedicalHistory { get; set; }
        public virtual ICollection<PatientOrder> PatientOrder { get; set; }
        public virtual ICollection<PatientQuestionnaire> PatientQuestionnaire { get; set; }
        public virtual ICollection<Personnel> Personnel { get; set; }
        public virtual ICollection<Procedure> Procedure { get; set; }
        public virtual ICollection<QueueManager> QueueManager { get; set; }
        public virtual ICollection<ReceivingStore> ReceivingStore { get; set; }
        public virtual ICollection<ReferenceMaterial> ReferenceMaterial { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public virtual ICollection<Service> Service { get; set; }
        public virtual ICollection<ServiceTariff> ServiceTariff { get; set; }
        public virtual ICollection<Supplier> Supplier { get; set; }
        public virtual ICollection<Tariff> Tariff { get; set; }
        public virtual ICollection<VerificationLog> VerificationLog { get; set; }
        public virtual ICollection<PatientQueue> PatientQueue { get; set; }
        public virtual ICollection<CheckIn> CheckIn { get; set; }
        public virtual ICollection<PaRequest> PaRequest { get; set; }

        public virtual ICollection<Store> Store { get; set; }
               public virtual ICollection<DepartmentSub> DepartmentSub { get; set; }
        public virtual ICollection<OrderPriority> OrderPriority { get; set; }

        public virtual ICollection<DrugFormulary> DrugFormulary { get; set; }
    }
}
