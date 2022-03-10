using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class RoomEffectRewardGet
    {
        public long Id { get; set; }
        public long Level { get; set; }
        public long RewardType { get; set; }
        public long RewardId { get; set; }
        public long MaxCount { get; set; }
        public long IncStep { get; set; }
        public long IntervalSecond { get; set; }
    }
}
