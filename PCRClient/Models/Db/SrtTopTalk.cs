using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class SrtTopTalk
    {
        public long Id { get; set; }
        public long TalkId { get; set; }
        public long CharaIndex { get; set; }
        public string TalkText { get; set; } = null!;
        public string SheetName { get; set; } = null!;
        public string CueName { get; set; } = null!;
        public long Direction { get; set; }
    }
}
