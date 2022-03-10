using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SspStoryDatum
    {
        public long SubStoryId { get; set; }
        public long OriginalEventId { get; set; }
        public string Title { get; set; } = null!;
        public long ContentsType { get; set; }
        public long ConditionQuestId { get; set; }
        public long ConditionBossId { get; set; }
        public long ReadCondition { get; set; }
    }
}
