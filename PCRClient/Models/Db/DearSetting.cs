using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DearSetting
    {
        public long EventId { get; set; }
        public string SystemName { get; set; } = null!;
        public long TutorialQuestId { get; set; }
        public long TutorialCharaIndex { get; set; }
        public long TutorialStoryId { get; set; }
    }
}
