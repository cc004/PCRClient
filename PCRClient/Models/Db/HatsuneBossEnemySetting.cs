using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneBossEnemySetting
    {
        public long BossId { get; set; }
        public long EnemyIdentify { get; set; }
        public long EventId { get; set; }
        public long MustKillFlag { get; set; }
        public long EventBossTreasureBoxId { get; set; }
        public double RewardGoldCoefficient { get; set; }
        public long RewardGoldLimit { get; set; }
        public long DetailOffsetX { get; set; }
        public long DetailOffsetY { get; set; }
        public double DetailScale { get; set; }
        public long MapOffsetX { get; set; }
        public long MapOffsetY { get; set; }
        public double MapScale { get; set; }
        public long MapDepth { get; set; }
    }
}
