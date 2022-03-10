using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PkbBatterCondition
    {
        public long BatterId { get; set; }
        public long PkbScore { get; set; }
        public string Name { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public long Meet { get; set; }
        public long Critical { get; set; }
        public long Power { get; set; }
        public string AbilityName { get; set; } = null!;
        public string AbilityDetail { get; set; } = null!;
        public long IsPlayable { get; set; }
    }
}
