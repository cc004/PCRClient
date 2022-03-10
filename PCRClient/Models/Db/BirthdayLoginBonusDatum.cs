using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class BirthdayLoginBonusDatum
    {
        public long LoginBonusId { get; set; }
        public string Name { get; set; } = null!;
        public long LoginBonusType { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long AdvId { get; set; }
    }
}
