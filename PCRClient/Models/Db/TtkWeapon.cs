using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class TtkWeapon
    {
        public long TtkWeaponId { get; set; }
        public long TtkScore { get; set; }
        public string Name { get; set; } = null!;
    }
}
