using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneUnlockUnitCondition
    {
        public long Id { get; set; }
        public long UnitId { get; set; }
        public long EventId { get; set; }
        public long ConditionMissionId { get; set; }
        public string TopDescription { get; set; } = null!;
        public string Description1 { get; set; } = null!;
        public string Description2 { get; set; } = null!;
    }
}
