using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ProfileFrame
    {
        public long Id { get; set; }
        public string Name { get; set; } = null!;
        public long Type { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long DispOrder { get; set; }
    }
}
