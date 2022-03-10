using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventEffectSetting
    {
        public long EventId { get; set; }
        public long Type { get; set; }
        public long Value { get; set; }
    }
}
