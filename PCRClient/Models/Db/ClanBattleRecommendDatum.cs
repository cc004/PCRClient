using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattleRecommendDatum
    {
        public long LevelId { get; set; }
        public long RecommendGroup { get; set; }
        public long LevelFrom { get; set; }
        public long LevelTo { get; set; }
        public long AtackPartyCount { get; set; }
        public long MagicPartyCount { get; set; }
    }
}
