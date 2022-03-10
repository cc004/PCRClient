using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EmblemDatum
    {
        public long EmblemId { get; set; }
        public long DispOder { get; set; }
        public long Type { get; set; }
        public string EmblemName { get; set; } = null!;
        public long DescriptionMissionId { get; set; }
        public long EventEmblem { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
