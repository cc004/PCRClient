using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignShioriGroup
    {
        public long Id { get; set; }
        public long ShioriGroupId { get; set; }
        public long EventId { get; set; }
    }
}
