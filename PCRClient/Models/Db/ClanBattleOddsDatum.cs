using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattleOddsDatum
    {
        public long OddsGroupId { get; set; }
        public long TeamLevelFrom { get; set; }
        public long TeamLevelTo { get; set; }
        public string OddsCsv1 { get; set; } = null!;
        public string OddsCsv2 { get; set; } = null!;
        public string OddsCsv3 { get; set; } = null!;
        public string OddsCsv4 { get; set; } = null!;
        public string OddsCsv5 { get; set; } = null!;
        public string OddsCsv6 { get; set; } = null!;
        public string OddsCsv7 { get; set; } = null!;
        public string OddsCsv8 { get; set; } = null!;
        public string OddsCsv9 { get; set; } = null!;
        public string OddsCsv10 { get; set; } = null!;
    }
}
