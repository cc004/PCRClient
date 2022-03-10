using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiBossMode
    {
        public long SekaiBossModeId { get; set; }
        public long SekaiEnemyId { get; set; }
        public string SekaiEnemyLevel { get; set; } = null!;
        public long QuestDetailBgId { get; set; }
        public long QuestDetailBgPosition { get; set; }
        public double QuestDetailMonsterSize { get; set; }
        public long QuestDetailMonsterHeight { get; set; }
        public long LimitTime { get; set; }
        public long Background { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public long ResultBossPositionY { get; set; }
        public long RewardGoldCoefficient { get; set; }
        public long LimitedMana { get; set; }
        public long ScoreCoefficient { get; set; }
    }
}
