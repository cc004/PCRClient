using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GrowthParameter
    {
        public long GrowthId { get; set; }
        public long GrowthType { get; set; }
        public long IsRestriction { get; set; }
        public long UnitRarity { get; set; }
        public long UnitLevel { get; set; }
        public long SkillLevel { get; set; }
        public long PromotionLevel { get; set; }
        public long Equipment1 { get; set; }
        public long Equipment2 { get; set; }
        public long Equipment3 { get; set; }
        public long Equipment4 { get; set; }
        public long Equipment5 { get; set; }
        public long Equipment6 { get; set; }
        public long LoveLevel { get; set; }
    }
}
