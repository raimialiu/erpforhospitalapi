using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Personnel
    {
        public Personnel()
        {
            AdmissionDischargedByNavigation = new HashSet<Admission>();
            AdmissionStaff = new HashSet<Admission>();
            Appointment = new HashSet<Appointment>();
            AssignedAssetApprover = new HashSet<AssignedAsset>();
            AssignedAssetStaff = new HashSet<AssignedAsset>();
            AuditLog = new HashSet<AuditLog>();
            Bill = new HashSet<Bill>();
            BillPayable = new HashSet<BillPayable>();
            BirthRegister = new HashSet<BirthRegister>();
            DrugOrdersAdminHandlerNavigation = new HashSet<DrugOrders>();
            DrugOrdersPharmacyHandlerNavigation = new HashSet<DrugOrders>();
            MessagingReciever = new HashSet<Messaging>();
            MessagingSender = new HashSet<Messaging>();
            PatientOrderCompletedbyNavigation = new HashSet<PatientOrder>();
            PatientOrderRaisedbyNavigation = new HashSet<PatientOrder>();
            QueueManagerFromPersonnel = new HashSet<QueueManager>();
            QueueManagerRemovedByNavigation = new HashSet<QueueManager>();
            QueueManagerToPersonnel = new HashSet<QueueManager>();
            VitalSigns = new HashSet<VitalSigns>();
        }

        public int Staffid { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public int? Titleid { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Mobilephone { get; set; }
        public string Homephone { get; set; }
        public string Workphone { get; set; }
        public string Emergencycontact { get; set; }
        public string Emergencyphone { get; set; }
        public int? Designationid { get; set; }
        public int? Deptid { get; set; }
        public DateTime? Dateadded { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? ProviderId { get; set; }
        public int? IdentificationModeid { get; set; }

        public virtual Department Dept { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual IdentificationMode IdentificationMode { get; set; }
        public virtual AccountManager Provider { get; set; }
        public virtual Title Title { get; set; }
        public virtual ICollection<Admission> AdmissionDischargedByNavigation { get; set; }
        public virtual ICollection<Admission> AdmissionStaff { get; set; }
        public virtual ICollection<Appointment> Appointment { get; set; }
        public virtual ICollection<AssignedAsset> AssignedAssetApprover { get; set; }
        public virtual ICollection<AssignedAsset> AssignedAssetStaff { get; set; }
        public virtual ICollection<AuditLog> AuditLog { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual ICollection<BillPayable> BillPayable { get; set; }
        public virtual ICollection<BirthRegister> BirthRegister { get; set; }
        public virtual ICollection<DrugOrders> DrugOrdersAdminHandlerNavigation { get; set; }
        public virtual ICollection<DrugOrders> DrugOrdersPharmacyHandlerNavigation { get; set; }
        public virtual ICollection<Messaging> MessagingReciever { get; set; }
        public virtual ICollection<Messaging> MessagingSender { get; set; }
        public virtual ICollection<PatientOrder> PatientOrderCompletedbyNavigation { get; set; }
        public virtual ICollection<PatientOrder> PatientOrderRaisedbyNavigation { get; set; }
        public virtual ICollection<QueueManager> QueueManagerFromPersonnel { get; set; }
        public virtual ICollection<QueueManager> QueueManagerRemovedByNavigation { get; set; }
        public virtual ICollection<QueueManager> QueueManagerToPersonnel { get; set; }
        public virtual ICollection<VitalSigns> VitalSigns { get; set; }
    }
}
