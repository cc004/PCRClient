using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TmeMapDatum
    {
        public long TmeObjectId { get; set; }
        public long EventId { get; set; }
        public long ConditionStoryId { get; set; }
        public long AreaDifficultyType { get; set; }
        public long ReleaseEffect { get; set; }
        public long TapEffect { get; set; }
    }
}
