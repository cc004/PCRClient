using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattleTrainingSchedule
    {
        public long TrainingId { get; set; }
        public long ClanBattleId { get; set; }
        public string BattleStartTime { get; set; } = null!;
        public string BattleEndTime { get; set; } = null!;
        public string IntervalStartTime { get; set; } = null!;
        public string IntervalEndTime { get; set; } = null!;
    }
}
