using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class NyxDramaDatum
    {
        public long DramaId { get; set; }
        public long StoryPhase { get; set; }
        public string Title { get; set; } = null!;
        public string SubTitle { get; set; } = null!;
        public long ConditionUnlockedStoryId { get; set; }
        public long ConditionLockedStoryId { get; set; }
    }
}
