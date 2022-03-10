using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneBgChangeDatum
    {
        public long Id { get; set; }
        public long AreaId { get; set; }
        public long ConditionType { get; set; }
        public long ConditionId { get; set; }
        public long TargetType { get; set; }
        public long BgAfterChangeId { get; set; }
    }
}
