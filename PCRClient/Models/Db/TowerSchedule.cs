using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TowerSchedule
    {
        public long TowerScheduleId { get; set; }
        public long MaxTowerAreaId { get; set; }
        public long OpeningStoryId { get; set; }
        public string CountStartTime { get; set; } = null!;
        public string RecoveryDisableTime { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
