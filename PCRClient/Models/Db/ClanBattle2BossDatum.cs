using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattle2BossDatum
    {
        public long BossId { get; set; }
        public long ClanBattleId { get; set; }
        public long Difficulty { get; set; }
        public long OrderNum { get; set; }
        public long BossThumbId { get; set; }
        public long PositionX { get; set; }
        public long PositionY { get; set; }
        public double ScaleRatio { get; set; }
        public double TapWidthRatio { get; set; }
        public double TapHeightRatio { get; set; }
        public long MapPositionX { get; set; }
        public long MapPositionY { get; set; }
        public long CursorPosition { get; set; }
        public long ResultBossPositionY { get; set; }
        public long QuestDetailBgId { get; set; }
        public long QuestDetailBgPosition { get; set; }
        public double QuestDetailMonsterSize { get; set; }
        public long QuestDetailMonsterHeight { get; set; }
        public double BattleReportMonsterSize { get; set; }
        public long BattleReportMonsterHeight { get; set; }
        public long Background { get; set; }
        public string WaveBgm { get; set; } = null!;
    }
}
