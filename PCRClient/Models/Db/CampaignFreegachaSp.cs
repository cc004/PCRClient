using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignFreegachaSp
    {
        public long CampaignId { get; set; }
        public long MaxExecCount { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
