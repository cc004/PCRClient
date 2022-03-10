using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CooperationQuestDatum
    {
        public long QuestId { get; set; }
        public string QuestName { get; set; } = null!;
        public long DifficultyLevel { get; set; }
        public long LimitTeamLevel { get; set; }
        public long TeamExp { get; set; }
        public long Exp { get; set; }
        public long LimitTime { get; set; }
        public long ClearRewardGroupId { get; set; }
        public long OddsGroupId { get; set; }
        public long LobbyBackground { get; set; }
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
        public long FirstRewardImage1 { get; set; }
        public long FirstRewardImage2 { get; set; }
        public long FirstRewardImage3 { get; set; }
        public long FirstRewardImage4 { get; set; }
        public long FirstRewardImage5 { get; set; }
        public long RepeatRewardImage1 { get; set; }
        public long RepeatRewardImage2 { get; set; }
        public long RepeatRewardImage3 { get; set; }
        public long CooperationQuestDetailBgId { get; set; }
        public long CooperationQuestDetailBgPosition { get; set; }
        public long MainEnemyImageWave1 { get; set; }
        public long SubEnemyImageWave11 { get; set; }
        public long SubEnemyImageWave12 { get; set; }
        public long SubEnemyImageWave13 { get; set; }
        public long SubEnemyImageWave14 { get; set; }
        public long MainEnemyImageWave2 { get; set; }
        public long SubEnemyImageWave21 { get; set; }
        public long SubEnemyImageWave22 { get; set; }
        public long SubEnemyImageWave23 { get; set; }
        public long SubEnemyImageWave24 { get; set; }
        public long MainEnemyImageWave3 { get; set; }
        public long SubEnemyImageWave31 { get; set; }
        public long SubEnemyImageWave32 { get; set; }
        public long SubEnemyImageWave33 { get; set; }
        public long SubEnemyImageWave34 { get; set; }
        public string QuestComment { get; set; } = null!;
        public long UnlockQuestId1 { get; set; }
        public long UnlockQuestId2 { get; set; }
    }
}
