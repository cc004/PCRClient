using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UniqueEquipmentEnhanceDatum
    {
        public long EquipSlot { get; set; }
        public long EnhanceLevel { get; set; }
        public long NeededPoint { get; set; }
        public long TotalPoint { get; set; }
        public long NeededMana { get; set; }
        public long Rank { get; set; }
    }
}
