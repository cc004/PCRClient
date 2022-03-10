using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CombinedResultMotion
    {
        public long ResultId { get; set; }
        public long UnitId1 { get; set; }
        public long DispOrder1 { get; set; }
        public long UnitId2 { get; set; }
        public long DispOrder2 { get; set; }
        public long UnitId3 { get; set; }
        public long DispOrder3 { get; set; }
        public long UnitId4 { get; set; }
        public long DispOrder4 { get; set; }
        public long UnitId5 { get; set; }
        public long DispOrder5 { get; set; }
    }
}
