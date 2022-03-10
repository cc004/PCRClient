using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class LoveChara
    {
        public long LoveLevel { get; set; }
        public long TotalLove { get; set; }
        public long UnlockedClass { get; set; }
        public long Rarity { get; set; }
    }
}
