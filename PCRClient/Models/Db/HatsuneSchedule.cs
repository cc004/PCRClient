using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class HatsuneSchedule
    {
        public long EventId { get; set; }
        public string TeaserTime { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string CloseTime { get; set; } = null!;
        public long Background { get; set; }
        public string SheetId { get; set; } = null!;
        public string QueId { get; set; } = null!;
        public long BannerUnitId { get; set; }
        public string CountStartTime { get; set; } = null!;
        public long BackgroudSizeX { get; set; }
        public long BackgroudSizeY { get; set; }
        public long BackgroudPosX { get; set; }
        public long BackgroudPosY { get; set; }
        public long OriginalEventId { get; set; }
        public long SeriesEventId { get; set; }
        public long TeaserDialogType { get; set; }
    }
}
