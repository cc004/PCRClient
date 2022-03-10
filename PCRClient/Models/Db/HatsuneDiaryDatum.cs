using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneDiaryDatum
    {
        public long DiaryId { get; set; }
        public long ContentsType { get; set; }
        public long DiaryDate { get; set; }
        public string SubTitle { get; set; } = null!;
        public string ForcedReleaseTime { get; set; } = null!;
        public string ConditionTime { get; set; } = null!;
        public long ConditionStoryId { get; set; }
        public long ConditionBossCount { get; set; }
    }
}
