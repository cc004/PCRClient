using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnlockUnitCondition
    {
        public long UnitId { get; set; }
        public string UnitName { get; set; } = null!;
        public long ClassId { get; set; }
        public long PreUnitId { get; set; }
        public long ConditionType1 { get; set; }
        public long ConditionTypeDetail1 { get; set; }
        public long ConditionId1 { get; set; }
        public long Count1 { get; set; }
        public long ConditionType2 { get; set; }
        public long ConditionTypeDetail2 { get; set; }
        public long ConditionId2 { get; set; }
        public long Count2 { get; set; }
        public long ConditionType3 { get; set; }
        public long ConditionTypeDetail3 { get; set; }
        public long ConditionId3 { get; set; }
        public long Count3 { get; set; }
        public long ConditionType4 { get; set; }
        public long ConditionTypeDetail4 { get; set; }
        public long ConditionId4 { get; set; }
        public long Count4 { get; set; }
        public long ConditionType5 { get; set; }
        public long ConditionTypeDetail5 { get; set; }
        public long ConditionId5 { get; set; }
        public long Count5 { get; set; }
        public long ReleaseEffectType { get; set; }
    }
}
