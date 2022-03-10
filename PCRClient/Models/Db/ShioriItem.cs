using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ShioriItem
    {
        public long EventId { get; set; }
        public long UnitMaterialId1 { get; set; }
        public long UnitMaterialId2 { get; set; }
    }
}
