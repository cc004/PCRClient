using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class PkbDramaDatum
    {
        public long DramaId { get; set; }
        public long ConditionPitcherId1 { get; set; }
        public long ConditionPitcherId2 { get; set; }
        public long ConditionBatterId1 { get; set; }
        public long ConditionBatterId2 { get; set; }
    }
}
