using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class LoginBonusDatum
    {
        public long LoginBonusId { get; set; }
        public string Name { get; set; } = null!;
        public long LoginBonusType { get; set; }
        public long CountNum { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long BgId { get; set; }
        public long StampId { get; set; }
        public long OddsGroupId { get; set; }
        public long AdvPlayType { get; set; }
        public long CountType { get; set; }
    }
}
