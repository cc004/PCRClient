using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattlePeriod
    {
        public long ClanBattleId { get; set; }
        public long Period { get; set; }
        public string PeriodDetail { get; set; } = null!;
        public long PeriodDetailBg { get; set; }
        public string PeriodDetailS { get; set; } = null!;
        public long PeriodDetailBgS { get; set; }
        public long PeriodDetailBgPosition { get; set; }
        public long PeriodDetailBossPositionX { get; set; }
        public long PeriodDetailBossPositionY { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string IntervalStart { get; set; } = null!;
        public string IntervalEnd { get; set; } = null!;
        public string CalcStart { get; set; } = null!;
        public string ResultStart { get; set; } = null!;
        public string ResultEnd { get; set; } = null!;
        public long LimitTime { get; set; }
        public long ChestId { get; set; }
        public long QuestDetailRehearsalLabelHeight { get; set; }
        public long MinCarryOverTime { get; set; }
    }
}
