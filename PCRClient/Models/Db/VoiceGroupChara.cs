using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class VoiceGroupChara
    {
        public long GroupUnitId { get; set; }
        public string GroupUnitIdComment { get; set; } = null!;
        public long UnitId01 { get; set; }
        public long UnitId02 { get; set; }
        public long UnitId03 { get; set; }
        public long UnitId04 { get; set; }
        public long UnitId05 { get; set; }
        public long UnitId06 { get; set; }
        public long UnitId07 { get; set; }
        public long UnitId08 { get; set; }
        public long UnitId09 { get; set; }
        public long UnitId10 { get; set; }
    }
}
