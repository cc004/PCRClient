using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventBgDatum
    {
        public long EventId { get; set; }
        public long BgId { get; set; }
        public string StartDate { get; set; } = null!;
        public string EndDate { get; set; } = null!;
    }
}
