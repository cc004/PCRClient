using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignMissionSchedule
    {
        public long CampaignId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string CloseTime { get; set; } = null!;
    }
}
