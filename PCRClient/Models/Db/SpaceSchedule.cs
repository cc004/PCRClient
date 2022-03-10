using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SpaceSchedule
    {
        public long SpaceId { get; set; }
        public string TeaserTime { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string CountStartTime { get; set; } = null!;
        public string CountEndTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long Sid { get; set; }
        public long PreStoryId { get; set; }
    }
}
