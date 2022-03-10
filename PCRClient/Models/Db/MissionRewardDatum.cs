using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class MissionRewardDatum
    {
        public long Id { get; set; }
        public long MissionRewardId { get; set; }
        public long RewardType { get; set; }
        public long? RewardId { get; set; }
        public long RewardNum { get; set; }
        public long LvFrom { get; set; }
        public long LvTo { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
