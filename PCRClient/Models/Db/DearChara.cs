using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class DearChara
    {
        public long EventId { get; set; }
        public long CharaIndex { get; set; }
        public string CharaName { get; set; } = null!;
        public long MaxDearPoint { get; set; }
        public long ReferenceType { get; set; }
        public long ReferenceId { get; set; }
        public long EpisodeUnlockOffsetX { get; set; }
        public long EpisodeUnlockOffsetY { get; set; }
        public long DearPointUpOffsetX { get; set; }
        public long DearPointUpOffsetY { get; set; }
        public long ConditionStoryId { get; set; }
    }
}
