using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattle2MapDatum
    {
        public long Id { get; set; }
        public long ClanBattleId { get; set; }
        public long MapBg { get; set; }
        public long Difficulty { get; set; }
        public long LapNumFrom { get; set; }
        public long LapNumTo { get; set; }
        public long BossId1 { get; set; }
        public long BossId2 { get; set; }
        public long BossId3 { get; set; }
        public long BossId4 { get; set; }
        public long BossId5 { get; set; }
        public long AuraEffect { get; set; }
        public long RslUnlockLap { get; set; }
        public long Phase { get; set; }
        public long WaveGroupId1 { get; set; }
        public long WaveGroupId2 { get; set; }
        public long WaveGroupId3 { get; set; }
        public long WaveGroupId4 { get; set; }
        public long WaveGroupId5 { get; set; }
        public long FixRewardId1 { get; set; }
        public long FixRewardId2 { get; set; }
        public long FixRewardId3 { get; set; }
        public long FixRewardId4 { get; set; }
        public long FixRewardId5 { get; set; }
        public long DamageRankId1 { get; set; }
        public long DamageRankId2 { get; set; }
        public long DamageRankId3 { get; set; }
        public long DamageRankId4 { get; set; }
        public long DamageRankId5 { get; set; }
        public double RewardGoldCoefficient { get; set; }
        public long LimitedMana { get; set; }
        public long LastAttackRewardId { get; set; }
        public double ScoreCoefficient1 { get; set; }
        public double ScoreCoefficient2 { get; set; }
        public double ScoreCoefficient3 { get; set; }
        public double ScoreCoefficient4 { get; set; }
        public double ScoreCoefficient5 { get; set; }
        public long ParamAdjustId { get; set; }
        public long ParamAdjustInterval { get; set; }
    }
}
