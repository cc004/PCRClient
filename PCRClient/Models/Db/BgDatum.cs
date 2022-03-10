using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class BgDatum
    {
        public string ViewName { get; set; } = null!;
        public long BgId { get; set; }
        public long EventId { get; set; }
    }
}
