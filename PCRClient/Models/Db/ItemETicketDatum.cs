using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ItemETicketDatum
    {
        public long TicketId { get; set; }
        public long ExchangeNumber { get; set; }
        public long UnitId { get; set; }
        public long RewardType1 { get; set; }
        public long RewardId1 { get; set; }
        public long RewardCount1 { get; set; }
        public long RewardType2 { get; set; }
        public long RewardId2 { get; set; }
        public long RewardCount2 { get; set; }
        public long RewardType3 { get; set; }
        public long RewardId3 { get; set; }
        public long RewardCount3 { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
