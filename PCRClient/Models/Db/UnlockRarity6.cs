using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnlockRarity6
    {
        public long UnitId { get; set; }
        public long SlotId { get; set; }
        public long UnlockLevel { get; set; }
        public long UnlockFlag { get; set; }
        public long ConsumeGold { get; set; }
        public long MaterialType { get; set; }
        public long MaterialId { get; set; }
        public long MaterialCount { get; set; }
        public long Hp { get; set; }
        public long Atk { get; set; }
        public long MagicStr { get; set; }
        public long Def { get; set; }
        public long MagicDef { get; set; }
        public long PhysicalCritical { get; set; }
        public long MagicCritical { get; set; }
        public long WaveHpRecovery { get; set; }
        public long WaveEnergyRecovery { get; set; }
        public long Dodge { get; set; }
        public long PhysicalPenetrate { get; set; }
        public long MagicPenetrate { get; set; }
        public long LifeSteal { get; set; }
        public long HpRecoveryRate { get; set; }
        public long EnergyRecoveryRate { get; set; }
        public long EnergyReduceRate { get; set; }
        public long Accuracy { get; set; }
    }
}
