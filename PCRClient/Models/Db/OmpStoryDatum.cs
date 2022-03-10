using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class OmpStoryDatum
    {
        public long OmpStoryId { get; set; }
        public long EventId { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long StorySeq { get; set; }
        public long IsReadableOnResult { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardCount { get; set; }
        public string SubTitle { get; set; } = null!;
    }
}
