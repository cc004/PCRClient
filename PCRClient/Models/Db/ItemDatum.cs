using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ItemDatum
    {
        public long ItemId { get; set; }
        public string ItemName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long PromotionLevel { get; set; }
        public long ItemType { get; set; }
        public long Value { get; set; }
        public long Price { get; set; }
        public long LimitNum { get; set; }
        public long GojuonOrder { get; set; }
        public long SellCheckDisp { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
