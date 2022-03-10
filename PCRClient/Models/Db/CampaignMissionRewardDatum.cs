using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignMissionRewardDatum
    {
        public long Id { get; set; }
        public long CampaignMissionRewardId { get; set; }
        public long RewardType { get; set; }
        public long? RewardId { get; set; }
        public long RewardNum { get; set; }
    }
}
