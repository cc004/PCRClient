using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventIntroduction
    {
        public long Id { get; set; }
        public long EventId { get; set; }
        public long IntroductionNumber { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public long MaximumChunkSize1 { get; set; }
        public long MaximumChunkSizeLoop1 { get; set; }
        public long MaximumChunkSize2 { get; set; }
        public long MaximumChunkSizeLoop2 { get; set; }
        public long MaximumChunkSize3 { get; set; }
        public long MaximumChunkSizeLoop3 { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
    }
}
