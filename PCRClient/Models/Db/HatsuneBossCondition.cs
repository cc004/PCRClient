using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneBossCondition
    {
        public long BossId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId1 { get; set; }
        public long ConditionQuestId2 { get; set; }
        public long ConditionBossId1 { get; set; }
        public long ConditionBossId2 { get; set; }
        public long ConditionGachaStep { get; set; }
        public string ForceUnlockTime { get; set; } = null!;
        public long ReleaseQuestId1 { get; set; }
        public long ReleaseQuestId2 { get; set; }
        public long ReleaseBossId1 { get; set; }
        public long ReleaseBossId2 { get; set; }
    }
}
