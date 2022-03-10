using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ShioriBossCondition
    {
        public long BossId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long ReleaseQuestId { get; set; }
        public long ReleaseBossId { get; set; }
    }
}
