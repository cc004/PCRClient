using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneSpecialEnemy
    {
        public long EnemyId { get; set; }
        public long EventId { get; set; }
        public long Mode { get; set; }
        public long EnemyPoint { get; set; }
        public long InitialPosition { get; set; }
        public long Order { get; set; }
    }
}
