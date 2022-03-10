using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class ShioriQuestArea
    {
        public long AreaId { get; set; }
        public long EventId { get; set; }
        public string AreaName { get; set; } = null!;
        public long MapType { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public long AreaDisp { get; set; }
        public long MapId { get; set; }
        public long ScrollWidth { get; set; }
        public long ScrollHeight { get; set; }
        public long OpenTutorialId { get; set; }
        public string TutorialParam1 { get; set; } = null!;
        public string TutorialParam2 { get; set; } = null!;
        public long AdditionalEffect { get; set; }
    }
}
