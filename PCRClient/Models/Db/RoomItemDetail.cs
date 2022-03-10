using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomItemDetail
    {
        public long RoomItemId { get; set; }
        public long Level { get; set; }
        public string ItemDetail { get; set; } = null!;
        public long LvupTriggerType { get; set; }
        public long LvupTriggerId { get; set; }
        public long LvupTriggerValue { get; set; }
        public long LvupTriggerType2 { get; set; }
        public long LvupTriggerId2 { get; set; }
        public long LvupTriggerValue2 { get; set; }
        public long LvupItem1Type { get; set; }
        public long LvupItem1Id { get; set; }
        public long LvupItem1Num { get; set; }
        public long LvupTime { get; set; }
    }
}
