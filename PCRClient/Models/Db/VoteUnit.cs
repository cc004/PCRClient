using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class VoteUnit
    {
        public long VoteId { get; set; }
        public long UnitId { get; set; }
        public long UnitRarity { get; set; }
    }
}
