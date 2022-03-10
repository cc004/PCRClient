using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TowerWaveGroupDatum
    {
        public long Id { get; set; }
        public long WaveGroupId { get; set; }
        public long Odds { get; set; }
        public long EnemyId1 { get; set; }
        public long EnemyId2 { get; set; }
        public long EnemyId3 { get; set; }
        public long EnemyId4 { get; set; }
        public long EnemyId5 { get; set; }
    }
}
