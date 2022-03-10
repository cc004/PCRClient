using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignMissionDatum
    {
        public long MissionId { get; set; }
        public long CampaignId { get; set; }
        public long Type { get; set; }
        public long DispGroup { get; set; }
        public long CategoryIcon { get; set; }
        public string Description { get; set; } = null!;
        public long MissionCondition { get; set; }
        public long? ConditionValue1 { get; set; }
        public long? ConditionValue2 { get; set; }
        public long? ConditionValue3 { get; set; }
        public long? ConditionValue4 { get; set; }
        public long? ConditionValue5 { get; set; }
        public long? ConditionValue6 { get; set; }
        public long? ConditionValue7 { get; set; }
        public long? ConditionValue8 { get; set; }
        public long? ConditionValue9 { get; set; }
        public long? ConditionValue10 { get; set; }
        public long ConditionNum { get; set; }
        public long CampaignMissionRewardId { get; set; }
        public long? SystemId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long MinLevel { get; set; }
        public long MaxLevel { get; set; }
        public long TitleColorId { get; set; }
        public long VisibleFlag { get; set; }
        public long MarkFlag { get; set; }
    }
}
