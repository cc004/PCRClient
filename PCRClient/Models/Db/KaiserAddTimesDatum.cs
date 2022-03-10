using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class KaiserAddTimesDatum
    {
        public long Id { get; set; }
        public long AddTimes { get; set; }
        public string AddTimesTime { get; set; } = null!;
        public long Duration { get; set; }
    }
}
