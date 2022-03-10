using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitBackground
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public long BgId { get; set; }
        public string BgName { get; set; } = null!;
        public double Position { get; set; }
        public long FaceType { get; set; }
    }
}
