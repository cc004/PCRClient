using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TowerQuestOddsGroup
    {
        public long OddsGroupId { get; set; }
        public long TeamLevelFrom { get; set; }
        public long TeamLevelTo { get; set; }
        public long TreasureType1 { get; set; }
        public string OddsCsv1 { get; set; } = null!;
        public long TreasureType2 { get; set; }
        public string OddsCsv2 { get; set; } = null!;
        public long TreasureType3 { get; set; }
        public string OddsCsv3 { get; set; } = null!;
        public long TreasureType4 { get; set; }
        public string OddsCsv4 { get; set; } = null!;
        public long TreasureType5 { get; set; }
        public string OddsCsv5 { get; set; } = null!;
        public long TreasureType6 { get; set; }
        public string OddsCsv6 { get; set; } = null!;
        public long TreasureType7 { get; set; }
        public string OddsCsv7 { get; set; } = null!;
        public long TreasureType8 { get; set; }
        public string OddsCsv8 { get; set; } = null!;
        public long TreasureType9 { get; set; }
        public string OddsCsv9 { get; set; } = null!;
        public long TreasureType10 { get; set; }
        public string OddsCsv10 { get; set; } = null!;
    }
}
