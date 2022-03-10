using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneQuestCondition
    {
        public long QuestId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId1 { get; set; }
        public long ConditionQuestId2 { get; set; }
        public long ConditionBossId1 { get; set; }
        public long ConditionBossId2 { get; set; }
        public long ReleaseQuestId1 { get; set; }
        public long ReleaseQuestId2 { get; set; }
        public long ReleaseBossId1 { get; set; }
        public long ReleaseBossId2 { get; set; }
        public long ConditionMainQuestId { get; set; }
    }
}
