using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneQuest
    {
        public long QuestId { get; set; }
        public long EventId { get; set; }
        public long AreaId { get; set; }
        public long QuestSeq { get; set; }
        public string QuestName { get; set; } = null!;
        public long PositionX { get; set; }
        public long PositionY { get; set; }
        public long IconId { get; set; }
        public double IconOffsetX { get; set; }
        public double IconOffsetY { get; set; }
        public double IconScale { get; set; }
        public long Stamina { get; set; }
        public long StaminaStart { get; set; }
        public long TeamExp { get; set; }
        public long UnitExp { get; set; }
        public long Love { get; set; }
        public long LimitTime { get; set; }
        public long DailyLimit { get; set; }
        public long ClearRewardGroup { get; set; }
        public long RankRewardGroup { get; set; }
        public long DropRewardType { get; set; }
        public long DropRewardId { get; set; }
        public long DropRewardNum { get; set; }
        public long DropRewardOdds { get; set; }
        public long Background1 { get; set; }
        public string WaveBgmSheetId1 { get; set; } = null!;
        public string WaveBgmQueId1 { get; set; } = null!;
        public long StoryIdWavestart1 { get; set; }
        public long StoryIdWaveend1 { get; set; }
        public long Background2 { get; set; }
        public string WaveBgmSheetId2 { get; set; } = null!;
        public string WaveBgmQueId2 { get; set; } = null!;
        public long StoryIdWavestart2 { get; set; }
        public long StoryIdWaveend2 { get; set; }
        public long Background3 { get; set; }
        public string WaveBgmSheetId3 { get; set; } = null!;
        public string WaveBgmQueId3 { get; set; } = null!;
        public long StoryIdWavestart3 { get; set; }
        public long StoryIdWaveend3 { get; set; }
        public long QuestDetailBgId { get; set; }
        public long QuestDetailBgPosition { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
