using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class MusicContent
    {
        public long MusicId { get; set; }
        public string Name { get; set; } = null!;
        public string TotalPlayingTime { get; set; } = null!;
        public string ListenStartTime { get; set; } = null!;
        public string Detail { get; set; } = null!;
        public string SheetId { get; set; } = null!;
        public string CueId { get; set; } = null!;
    }
}
