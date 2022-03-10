using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CampaignLevelDatum
    {
        public long Id { get; set; }
        public long LevelId { get; set; }
        public long LvFrom { get; set; }
        public long LvTo { get; set; }
        public long Value { get; set; }
        public string LabelColor { get; set; } = null!;
        public string FrameColor { get; set; } = null!;
    }
}
