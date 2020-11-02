using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class AppSetting
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
        public string User { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
