using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitPromotionStatus
    {
        public long UnitId { get; set; }
        public long PromotionLevel { get; set; }
        public double Hp { get; set; }
        public double Atk { get; set; }
        public double MagicStr { get; set; }
        public double Def { get; set; }
        public double MagicDef { get; set; }
        public double PhysicalCritical { get; set; }
        public double MagicCritical { get; set; }
        public double WaveHpRecovery { get; set; }
        public double WaveEnergyRecovery { get; set; }
        public double Dodge { get; set; }
        public double PhysicalPenetrate { get; set; }
        public double MagicPenetrate { get; set; }
        public double LifeSteal { get; set; }
        public double HpRecoveryRate { get; set; }
        public double EnergyRecoveryRate { get; set; }
        public double EnergyReduceRate { get; set; }
        public double Accuracy { get; set; }
    }
}
