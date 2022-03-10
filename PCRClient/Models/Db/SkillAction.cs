using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SkillAction
    {
        public long ActionId { get; set; }
        public long ClassId { get; set; }
        public long ActionType { get; set; }
        public long ActionDetail1 { get; set; }
        public long ActionDetail2 { get; set; }
        public long ActionDetail3 { get; set; }
        public double ActionValue1 { get; set; }
        public double ActionValue2 { get; set; }
        public double ActionValue3 { get; set; }
        public double ActionValue4 { get; set; }
        public double ActionValue5 { get; set; }
        public double ActionValue6 { get; set; }
        public double ActionValue7 { get; set; }
        public long TargetAssignment { get; set; }
        public long TargetArea { get; set; }
        public long TargetRange { get; set; }
        public long TargetType { get; set; }
        public long TargetNumber { get; set; }
        public long TargetCount { get; set; }
        public string Description { get; set; } = null!;
        public string LevelUpDisp { get; set; } = null!;
    }
}
