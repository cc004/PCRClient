using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ShioriQuestCondition
    {
        public long QuestId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long ReleaseQuestId { get; set; }
        public long ReleaseBossId { get; set; }
        public long ConditionMainQuestId { get; set; }
    }
}
