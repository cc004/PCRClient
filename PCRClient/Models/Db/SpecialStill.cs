using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SpecialStill
    {
        public long StillId { get; set; }
        public long Type { get; set; }
        public long BackMomoryType { get; set; }
        public long Value { get; set; }
    }
}
