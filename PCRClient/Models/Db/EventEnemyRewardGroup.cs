using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventEnemyRewardGroup
    {
        public long Id { get; set; }
        public long RewardGroupId { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long RewardNum { get; set; }
        public long Odds { get; set; }
    }
}
