using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiBossDamageRankReward
    {
        public long Id { get; set; }
        public long DamageRankId { get; set; }
        public long RankingFrom { get; set; }
        public long RankingTo { get; set; }
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
