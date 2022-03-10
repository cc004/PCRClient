using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ArcadeList
    {
        public long ArcadeId { get; set; }
        public string Title { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public long Price { get; set; }
        public string SheetId { get; set; } = null!;
        public string CueId { get; set; } = null!;
        public long WhereType { get; set; }
        public string Description { get; set; } = null!;
    }
}
