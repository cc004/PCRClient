using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignSchedule
    {
        public long Id { get; set; }
        public long CampaignCategory { get; set; }
        public double Value { get; set; }
        public long SystemId { get; set; }
        public long IconImage { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long LevelId { get; set; }
        public long ShioriGroupId { get; set; }
        public long DuplicationOrder { get; set; }
    }
}
