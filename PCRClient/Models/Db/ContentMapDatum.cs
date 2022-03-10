using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ContentMapDatum
    {
        public long ContentMapId { get; set; }
        public string Name { get; set; } = null!;
        public long MapType { get; set; }
        public long AreaId { get; set; }
        public long ConditionQuestId { get; set; }
        public long QuestPositionX { get; set; }
        public long QuestPositionY { get; set; }
        public long IconId { get; set; }
        public long SystemId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
