using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignFreegachaDatum
    {
        public long Id { get; set; }
        public long CampaignId { get; set; }
        public long GachaId { get; set; }
    }
}
