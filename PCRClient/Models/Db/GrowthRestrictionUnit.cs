using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class GrowthRestrictionUnit
    {
        public long Id { get; set; }
        public long GrowthId { get; set; }
        public long UnitId { get; set; }
    }
}
