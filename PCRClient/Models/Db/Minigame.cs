using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class Minigame
    {
        public long Id { get; set; }
        public long MinigameSchemeId { get; set; }
        public long EventId { get; set; }
        public long ReleaseConditions1 { get; set; }
        public long ConditionsId1 { get; set; }
        public long FirstTimeStoryId { get; set; }
        public long DisplayConditionType { get; set; }
        public long DisplayConditionId { get; set; }
        public long ResultChatConditionId { get; set; }
        public string ScoreUnit { get; set; } = null!;
        public long IsEnabledZeroScore { get; set; }
    }
}
