using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignMissionCategory
    {
        public long Id { get; set; }
        public long CampaignId { get; set; }
        public long Type { get; set; }
        public long LvFrom { get; set; }
        public long LvTo { get; set; }
    }
}
