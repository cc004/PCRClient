using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SeasonpassLevelReward
    {
        public long LevelId { get; set; }
        public long Degree { get; set; }
        public long FreeRewardType { get; set; }
        public long FreeRewardId { get; set; }
        public long FreeRewardNum { get; set; }
        public long ChargeRewardType1 { get; set; }
        public long ChargeRewardId1 { get; set; }
        public long ChargeRewardNum1 { get; set; }
        public long ChargeRewardType2 { get; set; }
        public long ChargeRewardId2 { get; set; }
        public long ChargeRewardNum2 { get; set; }
        public long EventId { get; set; }
    }
}
