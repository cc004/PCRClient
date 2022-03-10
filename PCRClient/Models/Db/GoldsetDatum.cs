using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GoldsetDatum
    {
        public long Id { get; set; }
        public long BuyCount { get; set; }
        public long UseJewelCount { get; set; }
        public long GetGoldCount { get; set; }
        public long GoldsetOdds1 { get; set; }
        public long GoldsetOdds2 { get; set; }
        public long GoldsetOdds3 { get; set; }
        public long AdditionalGoldMinRate { get; set; }
        public long AdditionalGoldMaxRate { get; set; }
    }
}
