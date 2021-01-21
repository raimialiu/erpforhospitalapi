﻿using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Location
    {
        public Location()
        {
            ApplicationUser = new HashSet<ApplicationUser>();
            Asset = new HashSet<Asset>();
            BreakBlockSchedule = new HashSet<BreakBlockSchedule>();
            GeneralSchedule = new HashSet<GeneralSchedule>();
            ProviderSchedule = new HashSet<ProviderSchedule>();
            Specialization = new HashSet<Specialization>();
            SpecializationSchedule = new HashSet<SpecializationSchedule>();
            UserLocation = new HashSet<UserLocation>();
            CheckIn = new HashSet<CheckIn>();
            PaRequest = new HashSet<PaRequest>();
            PatientQueue = new HashSet<PatientQueue>();
            Store = new HashSet<Store>();
            OrderPriority = new HashSet<OrderPriority>();
            DrugFoodrelation = new HashSet<DrugFoodrelation>();
        }

        public int Locationid { get; set; }
        public string Locationname { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Comments { get; set; }
        public string Locationadmin { get; set; }
        public DateTime? Dateadded { get; set; }
        public int? AccountID { get; set; }
        public string Locationdescription { get; set; }
        public bool ispremium { get; set; }

        public virtual ICollection<ApplicationUser> ApplicationUser { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<BreakBlockSchedule> BreakBlockSchedule { get; set; }
        public virtual ICollection<GeneralSchedule> GeneralSchedule { get; set; }
        public virtual ICollection<ProviderSchedule> ProviderSchedule { get; set; }
        public virtual ICollection<Specialization> Specialization { get; set; }
        public virtual ICollection<SpecializationSchedule> SpecializationSchedule { get; set; }
        public virtual ICollection<UserLocation> UserLocation { get; set; }
        public virtual ICollection<CheckIn> CheckIn { get; set; }
        public virtual ICollection<PaRequest> PaRequest { get; set; }
        public virtual ICollection<PatientQueue> PatientQueue { get; set; }

        public virtual ICollection<Store> Store { get; set; }

        public virtual ICollection<OrderPriority> OrderPriority { get; set; }


        public virtual ICollection<DrugFoodrelation> DrugFoodrelation { get; set; }
    }
}
