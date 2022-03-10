using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class LoginBonusAdv
    {
        public long Id { get; set; }
        public long LoginBonusId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long CountKey { get; set; }
        public long AdvId { get; set; }
        public long ReadProcessFlag { get; set; }
    }
}
