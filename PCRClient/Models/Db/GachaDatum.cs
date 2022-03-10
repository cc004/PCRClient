using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GachaDatum
    {
        public long GachaId { get; set; }
        public string GachaName { get; set; } = null!;
        public string PickUpCharaText { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Description2 { get; set; } = null!;
        public string DescriptionSp { get; set; } = null!;
        public long ParallelId { get; set; }
        public long PickupBadge { get; set; }
        public long GachaDetail { get; set; }
        public long GachaCostType { get; set; }
        public long Price { get; set; }
        public long FreeGachaType { get; set; }
        public long FreeGachaIntervalTime { get; set; }
        public long FreeGachaCount { get; set; }
        public long DiscountPrice { get; set; }
        public string GachaOdds { get; set; } = null!;
        public string GachaOddsStar2 { get; set; } = null!;
        public long GachaType { get; set; }
        public long MovieId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long TicketId { get; set; }
        public long SpecialId { get; set; }
        public long ExchangeId { get; set; }
        public long TicketId10 { get; set; }
        public string RarityOdds { get; set; } = null!;
        public string CharaOddsStar1 { get; set; } = null!;
        public string CharaOddsStar2 { get; set; } = null!;
        public string CharaOddsStar3 { get; set; } = null!;
        public string Gacha10SpecialOddsStar1 { get; set; } = null!;
        public string Gacha10SpecialOddsStar2 { get; set; } = null!;
        public string Gacha10SpecialOddsStar3 { get; set; } = null!;
        public long PrizegachaId { get; set; }
        public long GachaBonusId { get; set; }
        public long GachaTimesLimit10 { get; set; }
    }
}
