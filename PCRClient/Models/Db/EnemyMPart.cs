using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EnemyMPart
    {
        public long EnemyId { get; set; }
        public string Name { get; set; } = null!;
        public long ChildEnemyParameter1 { get; set; }
        public long ChildEnemyParameter2 { get; set; }
        public long ChildEnemyParameter3 { get; set; }
        public long ChildEnemyParameter4 { get; set; }
        public long ChildEnemyParameter5 { get; set; }
    }
}
