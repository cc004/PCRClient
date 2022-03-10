using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ClanBattleTrainingDatum
    {
        public long Id { get; set; }
        public long TrainingId { get; set; }
        public long Mode { get; set; }
        public long Phase { get; set; }
        public long MapDataId { get; set; }
    }
}
