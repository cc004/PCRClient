using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignFreegacha
    {
        public long Id { get; set; }
        public long CampaignId { get; set; }
        public long Freegacha1 { get; set; }
        public long Freegacha10 { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long Stock10Flag { get; set; }
        public long RelationId { get; set; }
        public long RelationCount { get; set; }
    }
}
