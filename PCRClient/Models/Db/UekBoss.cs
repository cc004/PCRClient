using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UekBoss
    {
        public long Area { get; set; }
        public string QuestName { get; set; } = null!;
        public long LimitTime { get; set; }
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
        public long Background { get; set; }
        public long EnemyId { get; set; }
        public string BgmSheetId { get; set; } = null!;
        public string BgmQueId { get; set; } = null!;
        public long DetailBgId { get; set; }
        public long DetailBgPosition { get; set; }
        public double DetailBossBgSize { get; set; }
        public long DetailBossBgHeight { get; set; }
        public long ResultBossPositionY { get; set; }
        public long ResultMovie { get; set; }
    }
}
