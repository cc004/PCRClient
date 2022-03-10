using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattleSParamAdjust
    {
        public long ParamAdjustId { get; set; }
        public long Level { get; set; }
        public long Hp { get; set; }
        public long Atk { get; set; }
        public long MagicStr { get; set; }
        public long Def { get; set; }
        public long MagicDef { get; set; }
        public long PhysicalCritical { get; set; }
        public long MagicCritical { get; set; }
        public long EnergyRecoveryRate { get; set; }
        public long UnionBurstLevel { get; set; }
        public long MainSkillLv1 { get; set; }
        public long MainSkillLv2 { get; set; }
        public long MainSkillLv3 { get; set; }
        public long MainSkillLv4 { get; set; }
        public long MainSkillLv5 { get; set; }
        public long MainSkillLv6 { get; set; }
        public long MainSkillLv7 { get; set; }
        public long MainSkillLv8 { get; set; }
        public long MainSkillLv9 { get; set; }
        public long MainSkillLv10 { get; set; }
        public long Accuracy { get; set; }
        public long NormalAtkCastTime { get; set; }
        public long ScoreCoefficient { get; set; }
    }
}
