using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class LtoStoryDatum
    {
        public long SubStoryId { get; set; }
        public long EventId { get; set; }
        public string Title { get; set; } = null!;
        public long ConditionStoryId { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardCount { get; set; }
    }
}
