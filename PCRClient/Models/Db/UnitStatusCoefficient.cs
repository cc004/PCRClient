using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitStatusCoefficient
    {
        public long CoefficientId { get; set; }
        public double HpCoefficient { get; set; }
        public double AtkCoefficient { get; set; }
        public double MagicStrCoefficient { get; set; }
        public double DefCoefficient { get; set; }
        public double MagicDefCoefficient { get; set; }
        public double PhysicalCriticalCoefficient { get; set; }
        public double MagicCriticalCoefficient { get; set; }
        public double WaveHpRecoveryCoefficient { get; set; }
        public double WaveEnergyRecoveryCoefficient { get; set; }
        public double DodgeCoefficient { get; set; }
        public double PhysicalPenetrateCoefficient { get; set; }
        public double MagicPenetrateCoefficient { get; set; }
        public double LifeStealCoefficient { get; set; }
        public double HpRecoveryRateCoefficient { get; set; }
        public double EnergyRecoveryRateCoefficient { get; set; }
        public double EnergyReduceRateCoefficient { get; set; }
        public double SkillLvCoefficient { get; set; }
        public long ExskillEvolutionCoefficient { get; set; }
        public double OverallCoefficient { get; set; }
        public double AccuracyCoefficient { get; set; }
        public long Skill1EvolutionCoefficient { get; set; }
        public double Skill1EvolutionSlvCoefficient { get; set; }
        public long UbEvolutionCoefficient { get; set; }
        public double UbEvolutionSlvCoefficient { get; set; }
    }
}
