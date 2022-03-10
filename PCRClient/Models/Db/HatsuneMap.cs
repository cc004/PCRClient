using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneMap
    {
        public long CourseId { get; set; }
        public long EventId { get; set; }
        public string Name { get; set; } = null!;
        public long MapId { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public long StartAreaId { get; set; }
        public long EndAreaId { get; set; }
    }
}
