using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SkeStoryDatum
    {
        public long SubStoryId { get; set; }
        public long OriginalEventId { get; set; }
        public string Title { get; set; } = null!;
        public long UnlockConditionQuestId { get; set; }
        public long UnlockConditionBossId { get; set; }
        public long ReadConditionEventStoryId { get; set; }
    }
}
