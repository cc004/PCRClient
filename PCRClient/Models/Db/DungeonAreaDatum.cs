using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DungeonAreaDatum
    {
        public long DungeonAreaId { get; set; }
        public long DungeonType { get; set; }
        public string DungeonName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public long OpenQuestId { get; set; }
        public long ContentReleaseStory { get; set; }
        public long InitialClearStory { get; set; }
        public long WaveGroupId { get; set; }
        public long RewardGroupId { get; set; }
        public long RecommendLevel { get; set; }
        public long QuestPositionX { get; set; }
        public long QuestPositionY { get; set; }
        public long IconId { get; set; }
        public long CoinItemId { get; set; }
        public long EnemyImage1 { get; set; }
        public long EnemyImage2 { get; set; }
        public long EnemyImage3 { get; set; }
        public long EnemyImage4 { get; set; }
        public long EnemyImage5 { get; set; }
        public long ViewRewardId1 { get; set; }
        public long ViewRewardId2 { get; set; }
        public long ViewRewardId3 { get; set; }
        public long ViewRewardId4 { get; set; }
        public long ViewRewardId5 { get; set; }
        public long RecoveryHpRate { get; set; }
        public long RecoveryTpRate { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
