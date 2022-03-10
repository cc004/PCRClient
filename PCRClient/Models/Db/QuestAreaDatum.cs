using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class QuestAreaDatum
    {
        public long AreaId { get; set; }
        public string AreaName { get; set; } = null!;
        public string AreaDisplayName { get; set; } = null!;
        public long MapType { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
