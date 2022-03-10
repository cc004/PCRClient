using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SeasonpassFoundation
    {
        public long SeasonId { get; set; }
        public string Name { get; set; } = null!;
        public long KeyJewelId { get; set; }
        public long AdvanceJewelId { get; set; }
        public long FinalJewelId { get; set; }
        public long ExtraLevel { get; set; }
        public long PerLevelPoint { get; set; }
        public long LevelMax { get; set; }
        public long WeeklyPoint { get; set; }
        public long LevelPrice { get; set; }
        public long PointChangeType { get; set; }
        public long RewardId { get; set; }
        public long Proportion { get; set; }
        public string StartTime { get; set; } = null!;
        public string LimitTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
