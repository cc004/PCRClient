using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiUnlockStoryCondition
    {
        public long StoryId { get; set; }
        public long SekaiId { get; set; }
        public long ConditionEntry { get; set; }
        public long ConditionFixRewardId { get; set; }
        public string ConditionTime { get; set; } = null!;
    }
}
