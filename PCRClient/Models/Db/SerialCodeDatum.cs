using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SerialCodeDatum
    {
        public long SerialCampaignId { get; set; }
        public long SerialGroupId { get; set; }
        public string CampaignName { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long LimitNum { get; set; }
    }
}
