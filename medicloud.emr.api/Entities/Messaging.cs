using System;
using System.Collections.Generic;

namespace medicloud.emr.api.Entities
{
    public partial class Messaging
    {
        public int MsgId { get; set; }
        public int? SenderId { get; set; }
        public int? RecieverId { get; set; }
        public DateTime? Datesent { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public bool? IsRead { get; set; }
        public int? ProviderId { get; set; }

        public virtual AccountManager Provider { get; set; }
        public virtual Personnel Reciever { get; set; }
        public virtual Personnel Sender { get; set; }
    }
}
