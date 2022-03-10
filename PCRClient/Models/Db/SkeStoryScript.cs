using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SkeStoryScript
    {
        public long Id { get; set; }
        public long StoryId { get; set; }
        public long SeqNum { get; set; }
        public long Type { get; set; }
        public long LineNum { get; set; }
        public long StartPos { get; set; }
        public long EndPos { get; set; }
        public double SeekTime { get; set; }
        public string SheetName { get; set; } = null!;
        public string CueName { get; set; } = null!;
        public long Command { get; set; }
        public double CommandParam { get; set; }
    }
}
