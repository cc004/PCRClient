using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventReminder
    {
        public long ReminderId { get; set; }
        public long EventId { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string TitleText { get; set; } = null!;
        public string DescriptionText { get; set; } = null!;
        public string NoticeText { get; set; } = null!;
        public long ThumbnailId { get; set; }
        public string BtnText { get; set; } = null!;
        public long TargetType { get; set; }
        public long TargetId { get; set; }
    }
}
