using System;
using System.Collections.Generic;

namespace PCRClient.Models.Db
{
    public partial class EventStoryDatum
    {
        public long StoryGroupId { get; set; }
        public long StoryType { get; set; }
        public long Value { get; set; }
        public string Title { get; set; } = null!;
        public long ThumbnailId { get; set; }
        public long DispOrder { get; set; }
        public string StartTime { get; set; } = null!;
        public string EndTime { get; set; } = null!;
    }
}
