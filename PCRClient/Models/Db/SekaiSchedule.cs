using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiSchedule
    {
        public long SekaiId { get; set; }
        public long LastSekaiId { get; set; }
        public long FixRewardGroupId { get; set; }
        public long DamageRankId { get; set; }
        public string TeaserTime { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string CountStartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string EndLosstime { get; set; } = null!;
        public string ResultEnd { get; set; } = null!;
    }
}
