using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class NyxPhaseDatum
    {
        public long StoryPhase { get; set; }
        public string PhaseTitle { get; set; } = null!;
        public long ConditionQuestId { get; set; }
        public long ConditionQuestBoss { get; set; }
    }
}
