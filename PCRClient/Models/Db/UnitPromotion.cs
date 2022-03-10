using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class UnitPromotion
    {
        public long UnitId { get; set; }
        public long PromotionLevel { get; set; }
        public long EquipSlot1 { get; set; }
        public long EquipSlot2 { get; set; }
        public long EquipSlot3 { get; set; }
        public long EquipSlot4 { get; set; }
        public long EquipSlot5 { get; set; }
        public long EquipSlot6 { get; set; }
    }
}
