using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SpaceTopDatum
    {
        public long Id { get; set; }
        public long SpaceId { get; set; }
        public long SpaceBattleId { get; set; }
        public long PartFlag { get; set; }
        public long StoryId { get; set; }
        public string TimeFrom { get; set; } = null!;
        public string TimeTo { get; set; } = null!;
        public string SkipBattleTime { get; set; } = null!;
        public string Name { get; set; } = null!;
    }
}
