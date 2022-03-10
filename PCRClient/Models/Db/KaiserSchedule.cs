using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class KaiserSchedule
    {
        public long Id { get; set; }
        public string TeaserTime { get; set; } = null!;
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
        public string CountStartTime { get; set; } = null!;
        public string CloseTime { get; set; } = null!;
        public long StoryId { get; set; }
        public long CloseStoryConditionId { get; set; }
        public long CloseStoryId { get; set; }
        public string TopBgm { get; set; } = null!;
        public string TopBg { get; set; } = null!;
        public string AfterBgm { get; set; } = null!;
        public string AfterBg { get; set; } = null!;
    }
}
