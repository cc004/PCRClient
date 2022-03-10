using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ShioriEventList
    {
        public long EventId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long ConditionStoryId { get; set; }
        public long ConditionCharaId { get; set; }
        public long ConditionMainQuestId { get; set; }
        public long ConditionShioriQuestId { get; set; }
        public long OriginalEventId { get; set; }
        public string OriginalStartTime { get; set; } = null!;
        public long GojuonOrder { get; set; }
        public string HelpIndex { get; set; } = null!;
    }
}
