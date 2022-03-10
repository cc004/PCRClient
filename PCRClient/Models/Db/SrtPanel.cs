using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SrtPanel
    {
        public long ReadingId { get; set; }
        public string Reading { get; set; } = null!;
        public long ReadType { get; set; }
        public long PanelId { get; set; }
        public string DetailText { get; set; } = null!;
        public long Version { get; set; }
        public string HeadSymbol { get; set; } = null!;
        public string TailSymbol { get; set; } = null!;
    }
}
