using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class QuestConditionDatum
    {
        public long QuestId { get; set; }
        public long ConditionQuestId1 { get; set; }
        public long ConditionQuestId2 { get; set; }
        public long ConditionQuestId3 { get; set; }
        public long ConditionQuestId4 { get; set; }
        public long ConditionQuestId5 { get; set; }
        public long ReleaseQuestId1 { get; set; }
        public long ReleaseQuestId2 { get; set; }
        public long ReleaseQuestId3 { get; set; }
        public long ReleaseQuestId4 { get; set; }
        public long ReleaseQuestId5 { get; set; }
    }
}
