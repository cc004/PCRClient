using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DungeonQuestDatum
    {
        public long QuestId { get; set; }
        public long DungeonAreaId { get; set; }
        public long FloorNum { get; set; }
        public long LimitTime { get; set; }
        public double MatchingCoefficient { get; set; }
        public long PartsHpSaveFlag { get; set; }
        public long EnergyResetFlag { get; set; }
        public long RewardImage1 { get; set; }
        public long RewardImage2 { get; set; }
        public long RewardImage3 { get; set; }
        public long RewardCoin { get; set; }
        public long ChestId { get; set; }
        public long OddsGroupId { get; set; }
        public long Background { get; set; }
        public long DungeonQuestDetailBgId { get; set; }
        public long DungeonQuestDetailBgPosition { get; set; }
        public double DungeonQuestDetailMonsterSize { get; set; }
        public double DungeonQuestDetailMonsterPositionX1 { get; set; }
        public double DungeonQuestDetailMonsterPositionX2 { get; set; }
        public double DungeonQuestDetailMonsterHeight { get; set; }
        public double MultiTargetEffectTime { get; set; }
        public string WaveBgmSheetId1 { get; set; } = null!;
        public string WaveBgmQueId1 { get; set; } = null!;
    }
}
