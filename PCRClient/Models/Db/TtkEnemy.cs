using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TtkEnemy
    {
        public long EnemyId { get; set; }
        public long Score { get; set; }
        public long Coin { get; set; }
        public long Max { get; set; }
    }
}
