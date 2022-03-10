using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ActualUnitBackground
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public long BgId { get; set; }
        public long FaceType { get; set; }
    }
}
