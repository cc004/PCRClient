using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CharaStoryStatus
    {
        public long StoryId { get; set; }
        public string UnlockStoryName { get; set; } = null!;
        public long StatusType1 { get; set; }
        public long StatusRate1 { get; set; }
        public long StatusType2 { get; set; }
        public long StatusRate2 { get; set; }
        public long StatusType3 { get; set; }
        public long StatusRate3 { get; set; }
        public long StatusType4 { get; set; }
        public long StatusRate4 { get; set; }
        public long StatusType5 { get; set; }
        public long StatusRate5 { get; set; }
        public long CharaId1 { get; set; }
        public long CharaId2 { get; set; }
        public long CharaId3 { get; set; }
        public long CharaId4 { get; set; }
        public long CharaId5 { get; set; }
        public long CharaId6 { get; set; }
        public long CharaId7 { get; set; }
        public long CharaId8 { get; set; }
        public long CharaId9 { get; set; }
        public long CharaId10 { get; set; }
    }
}
