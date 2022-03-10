using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class KaiserQuestDatum
    {
        public long KaiserBossId { get; set; }
        public string Name { get; set; } = null!;
        public long MapType { get; set; }
        public long BattleStartStoryId { get; set; }
        public long BattleFinishStoryId { get; set; }
        public long DisappearanceStoryId { get; set; }
        public long LimitTime { get; set; }
        public long RestrictionGroupId { get; set; }
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
        public long FixRewardGroupId { get; set; }
        public string OddsGroupId { get; set; } = null!;
        public long ChestId { get; set; }
        public long ExterminationRewardGroup { get; set; }
        public long Background { get; set; }
        public long BgPosition { get; set; }
        public long WaveGroupId { get; set; }
        public long EnemyPositionX { get; set; }
        public long EnemyLocalPositionY { get; set; }
        public double EnemySize1 { get; set; }
        public double ResultBossPositionY { get; set; }
        public string WaveBgm { get; set; } = null!;
        public double RewardGoldCoefficient { get; set; }
        public long LimitedMana { get; set; }
        public long ClearStoryId1 { get; set; }
        public long ClearStoryId2 { get; set; }
    }
}
