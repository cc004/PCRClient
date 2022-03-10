using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Rarity6QuestDatum
    {
        public long Rarity6QuestId { get; set; }
        public long UnitId { get; set; }
        public string QuestName { get; set; } = null!;
        public long LimitTime { get; set; }
        public long RecommendedLevel { get; set; }
        public long RewardGroupId { get; set; }
        public long TreasureType { get; set; }
        public long RewardImage1 { get; set; }
        public long RewardCount1 { get; set; }
        public long RewardImage2 { get; set; }
        public long RewardCount2 { get; set; }
        public long RewardImage3 { get; set; }
        public long RewardCount3 { get; set; }
        public long RewardImage4 { get; set; }
        public long RewardCount4 { get; set; }
        public long RewardImage5 { get; set; }
        public long RewardCount5 { get; set; }
        public long Background { get; set; }
        public long BgPosition { get; set; }
        public long WaveGroupId { get; set; }
        public long EnemyPositionX1 { get; set; }
        public long EnemyLocalPositionY1 { get; set; }
        public double EnemySize1 { get; set; }
        public long EnemyPositionX2 { get; set; }
        public long EnemyLocalPositionY2 { get; set; }
        public double EnemySize2 { get; set; }
        public long EnemyPositionX3 { get; set; }
        public long EnemyLocalPositionY3 { get; set; }
        public double EnemySize3 { get; set; }
        public long EnemyPositionX4 { get; set; }
        public long EnemyLocalPositionY4 { get; set; }
        public double EnemySize4 { get; set; }
        public long EnemyPositionX5 { get; set; }
        public long EnemyLocalPositionY5 { get; set; }
        public double EnemySize5 { get; set; }
        public string WaveBgm { get; set; } = null!;
    }
}
