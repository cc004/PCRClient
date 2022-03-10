using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TicketGachaDatum
    {
        public long GachaId { get; set; }
        public string GachaName { get; set; } = null!;
        public long GachaType { get; set; }
        public long TicketId { get; set; }
        public long GachaTimes { get; set; }
        public long GachaDetail { get; set; }
        public string GuaranteeRarity { get; set; } = null!;
        public string RarityOdds { get; set; } = null!;
        public string CharaOddsStar1 { get; set; } = null!;
        public string CharaOddsStar2 { get; set; } = null!;
        public string CharaOddsStar3 { get; set; } = null!;
        public long StagingType { get; set; }
    }
}
