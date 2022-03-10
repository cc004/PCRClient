﻿using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class KmkReward
    {
        public long Id { get; set; }
        public long KmkScore { get; set; }
        public string MissionDetail { get; set; } = null!;
        public long RewardType1 { get; set; }
        public long RewardId1 { get; set; }
        public long RewardCount1 { get; set; }
        public long RewardType2 { get; set; }
        public long RewardId2 { get; set; }
        public long RewardCount2 { get; set; }
        public long RewardType3 { get; set; }
        public long RewardId3 { get; set; }
        public long RewardCount3 { get; set; }
        public long RewardType4 { get; set; }
        public long RewardId4 { get; set; }
        public long RewardCount4 { get; set; }
        public long RewardType5 { get; set; }
        public long RewardId5 { get; set; }
        public long RewardCount5 { get; set; }
    }
}
