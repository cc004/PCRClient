using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DungeonSkipDatum
    {
        public long AreaId { get; set; }
        public long SkipMotionId { get; set; }
        public long SkipBgId { get; set; }
        public long SkipPositionX { get; set; }
        public long SkipPositionY { get; set; }
        public double SkipScaleX { get; set; }
        public double SkipScaleY { get; set; }
    }
}
