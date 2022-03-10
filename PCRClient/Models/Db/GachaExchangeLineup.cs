using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GachaExchangeLineup
    {
        public long Id { get; set; }
        public long ExchangeId { get; set; }
        public long UnitId { get; set; }
        public long Rarity { get; set; }
        public long GachaBonusId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
