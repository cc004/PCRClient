using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EmblemMissionDatum
    {
        public long MissionId { get; set; }
        public long DispGroup { get; set; }
        public long CategoryIcon { get; set; }
        public string Description { get; set; } = null!;
        public long MissionCondition { get; set; }
        public long ConditionValue1 { get; set; }
        public long ConditionValue2 { get; set; }
        public long ConditionValue3 { get; set; }
        public long ConditionNum { get; set; }
        public long MissionRewardId { get; set; }
        public long SystemId { get; set; }
        public long VisibleFlag { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
