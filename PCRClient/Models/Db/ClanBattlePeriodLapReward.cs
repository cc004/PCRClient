using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattlePeriodLapReward
    {
        public long Id { get; set; }
        public long ClanBattleId { get; set; }
        public long Period { get; set; }
        public long LapNumFrom { get; set; }
        public long LapNumTo { get; set; }
        public long RankingBonusGroup { get; set; }
        public long RewardType1 { get; set; }
        public long RewardId1 { get; set; }
        public long RewardNum1 { get; set; }
        public long RewardType2 { get; set; }
        public long RewardId2 { get; set; }
        public long RewardNum2 { get; set; }
        public long RewardType3 { get; set; }
        public long RewardId3 { get; set; }
        public long RewardNum3 { get; set; }
        public long RewardType4 { get; set; }
        public long RewardId4 { get; set; }
        public long RewardNum4 { get; set; }
        public long RewardType5 { get; set; }
        public long RewardId5 { get; set; }
        public long RewardNum5 { get; set; }
    }
}
