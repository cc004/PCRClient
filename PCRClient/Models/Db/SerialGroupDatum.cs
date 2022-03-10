using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SerialGroupDatum
    {
        public long SerialGroupId { get; set; }
        public string CampaignName { get; set; } = null!;
        public long SerialCampaignId1 { get; set; }
        public long SerialCampaignId2 { get; set; }
        public long SerialCampaignId3 { get; set; }
        public long SerialCampaignId4 { get; set; }
        public long SerialCampaignId5 { get; set; }
        public long SerialCampaignId6 { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
