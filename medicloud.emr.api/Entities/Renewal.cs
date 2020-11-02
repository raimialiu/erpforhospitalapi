using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Renewal
    {
        public int Id { get; set; }
        public DateTime? Coveragestatedate { get; set; }
        public DateTime? Coverageenddate { get; set; }
        public decimal? Amountpaid { get; set; }
        public string Paymentstatus { get; set; }
        public decimal? Amountdue { get; set; }
        public string Receiptnum { get; set; }
        public string Reasonfortermination { get; set; }
        public bool? Isexpires { get; set; }
        public bool? Mutation { get; set; }
        public int? Contractnum { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int? Userid { get; set; }
        public string Syncid { get; set; }
        public string Flag { get; set; }
        public bool? Issynced { get; set; }
        public DateTime? SyncedAt { get; set; }
        public int? Enrolleeid { get; set; }

        public virtual Enrollee Enrollee { get; set; }
        public virtual User User { get; set; }
    }
}
