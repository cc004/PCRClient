using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class NyxStoryDatum
    {
        public long StoryId { get; set; }
        public long StorySeq { get; set; }
        public long StoryPhase { get; set; }
        public string Title { get; set; } = null!;
        public string SubTitle { get; set; } = null!;
        public string ReadConditionTime { get; set; } = null!;
        public long ConditionQuestId { get; set; }
        public long ConditionBossCount { get; set; }
        public long AdvFlg { get; set; }
        public long AdvId { get; set; }
    }
}
