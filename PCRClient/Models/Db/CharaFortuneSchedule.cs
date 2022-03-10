using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class CharaFortuneSchedule
    {
        public long FortuneId { get; set; }
        public string Name { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
