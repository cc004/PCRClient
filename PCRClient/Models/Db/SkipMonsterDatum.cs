using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SkipMonsterDatum
    {
        public long QuestId { get; set; }
        public long AreaId { get; set; }
        public string QuestName { get; set; } = null!;
        public long WaveGroupId1 { get; set; }
        public long BgSkipId { get; set; }
    }
}
