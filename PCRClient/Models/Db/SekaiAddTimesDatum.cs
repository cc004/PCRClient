using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SekaiAddTimesDatum
    {
        public long Id { get; set; }
        public long SekaiId { get; set; }
        public long AddTimes { get; set; }
        public long AddTimesLimit { get; set; }
        public string AddTimesTime { get; set; } = null!;
        public long Duration { get; set; }
    }
}
