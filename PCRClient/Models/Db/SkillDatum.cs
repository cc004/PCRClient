using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SkillDatum
    {
        public long SkillId { get; set; }
        public string? Name { get; set; }
        public long SkillType { get; set; }
        public long SkillAreaWidth { get; set; }
        public double SkillCastTime { get; set; }
        public double BossUbCoolTime { get; set; }
        public long Action1 { get; set; }
        public long Action2 { get; set; }
        public long Action3 { get; set; }
        public long Action4 { get; set; }
        public long Action5 { get; set; }
        public long Action6 { get; set; }
        public long Action7 { get; set; }
        public long DependAction1 { get; set; }
        public long DependAction2 { get; set; }
        public long DependAction3 { get; set; }
        public long DependAction4 { get; set; }
        public long DependAction5 { get; set; }
        public long DependAction6 { get; set; }
        public long DependAction7 { get; set; }
        public string Description { get; set; } = null!;
        public long IconType { get; set; }
    }
}
