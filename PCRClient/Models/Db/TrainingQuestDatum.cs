using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TrainingQuestDatum
    {
        public long QuestId { get; set; }
        public long AreaId { get; set; }
        public string QuestName { get; set; } = null!;
        public long LimitTeamLevel { get; set; }
        public long UnlockQuestId1 { get; set; }
        public long UnlockQuestId2 { get; set; }
        public long Stamina { get; set; }
        public long StaminaStart { get; set; }
        public long TeamExp { get; set; }
        public long UnitExp { get; set; }
        public long LimitTime { get; set; }
        public long RankRewardGroup { get; set; }
        public long Background1 { get; set; }
        public long WaveGroupId1 { get; set; }
        public string WaveBgmSheetId1 { get; set; } = null!;
        public string WaveBgmQueId1 { get; set; } = null!;
        public long Background2 { get; set; }
        public long WaveGroupId2 { get; set; }
        public string WaveBgmSheetId2 { get; set; } = null!;
        public string WaveBgmQueId2 { get; set; } = null!;
        public long Background3 { get; set; }
        public long WaveGroupId3 { get; set; }
        public string WaveBgmSheetId3 { get; set; } = null!;
        public string WaveBgmQueId3 { get; set; } = null!;
        public long EnemyImage1 { get; set; }
        public long EnemyImage2 { get; set; }
        public long EnemyImage3 { get; set; }
        public long EnemyImage4 { get; set; }
        public long EnemyImage5 { get; set; }
        public long RewardImage1 { get; set; }
        public long RewardImage2 { get; set; }
        public long RewardImage3 { get; set; }
        public long RewardImage4 { get; set; }
        public long RewardImage5 { get; set; }
        public long TrainingQuestDetailBgId { get; set; }
        public long TrainingQuestDetailBgPosition { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
